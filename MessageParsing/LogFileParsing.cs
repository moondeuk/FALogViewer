using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;

namespace FALogViewer
{
    class LogFileParsing
    {
        public const int maxReadBuffer = 8192;
        private string logFileName;
        private const string timeStampPattern = "^(([0-9]{1,2}[:]){1,2}([0-9]{1,2}))$";
        System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(timeStampPattern);

        // Events
        public event DEL_UpdateProgress EV_updateProgress;
        // Delegates
        public delegate void DEL_UpdateProgress(long totalValue, long currentValue, String currentStatus);

        public LogFileParsing(string logFileName)
        {
            this.logFileName = logFileName;
        }

        public List<string> LoadWholeLogFile()
        {
            long readEndPosition = -1;

            using (FileStream fs = File.Open(logFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                try
                {
                    readEndPosition = fs.Length;
                }
                catch
                {
                    readEndPosition = -1;
                }
            }

            return LoadLogFileByPosition(0, readEndPosition);
        }

        public List<string> LoadLogFileByPosition(long startFilePosition)
        {
            return LoadLogFileByPosition(startFilePosition, startFilePosition + maxReadBuffer);
        }

        public List<string> LoadLogFileByPosition(long readStartPosition, long readEndPosition)
        {
            const int BufferSize = 65536;
            List<string> messages = new List<string>();
            int lineNum = 0;

            using (FileStream fs = File.Open(logFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                Console.WriteLine("Read Text");
                byte[] btDatas = new byte[BufferSize];
                List<byte> readBytes = new List<byte>();
                int readLength;
                int readCount;
                string message;
                long filePosition;

                Byte readByte;

                for (long index = readStartPosition; index <= readEndPosition; )
                {
                    fs.Position = index;
                    readLength = Math.Min(BufferSize, (int)(readEndPosition - index));

                    readCount = fs.Read(btDatas, 0, readLength);

                    if (readCount == 0)
                    {
                        break;
                    }

                    for (int i = 0; i < readCount; i++)
                    {
                        readByte = btDatas[i];
                        if (readByte == (byte)'\n')
                        {
                            message = Encoding.Default.GetString(readBytes.ToArray());

                            filePosition = fs.Position - readCount + i - readBytes.Count;
                            message = filePosition.ToString() + "," + (++lineNum) + " : " + message;
                            messages.Add(message);

                            readBytes.Clear();
                        }
                        else
                        {
                            readBytes.Add(readByte);
                        }
                    }

                    index += readCount;

                    if (EV_updateProgress != null)
                    {
                        EV_updateProgress(readEndPosition - readStartPosition, index - readStartPosition, "Reading Log file");
                    }
                }

                EV_updateProgress(100, 0, "Complete");
            }
            return messages;
        }

        private bool IsIncludeTimeStamp(string message)
        {
            if (message.Length > 20 && regex.IsMatch(message.Substring(0, 8)))
                return true;
            else
                return false;
        }

        private bool IsHeaderMessage(string message)
        {
            bool returnValue;
            string stream;
            string function;

            string[] messages = message.Split(',');
            if (messages.Length < 5)
                returnValue = false;
            else
            {
                stream = messages[0].Trim();
                function = messages[1].Trim();

                if (stream.StartsWith("S") && function.StartsWith("F"))
                {
                    returnValue = true;
                }

                else
                {
                    returnValue = false;
                }
            }

            return returnValue;
        }

        private int GetNextMessageIndex(List<string> messages, int currentIndex)
        {
            int nextIndex = -1;
            string message;

            nextIndex = currentIndex + 1;

            while (true)
            {
                if (nextIndex + 1 <= messages.Count)  // 다음 메시지가 있다면
                {
                    message = messages[nextIndex];
                    message = message.Substring(message.IndexOf(':') + 2);
                    if (message.Trim().Equals(string.Empty) == false)
                    {
                        break;
                    }
                    else
                    {
                        nextIndex++;
                    }
                }
                else // 다음 메시지가 없다면
                {
                    nextIndex = -1;
                    break;
                }
            }

            return nextIndex;
        }

        public List<SecsLog> RetrieveMessageList(List<string> messages)
        {
            string message;
            List<SecsLog> secsLogs = new List<SecsLog>();
            string[] headerSplits;
            string messageID;
            string timeStamp;
            string msgTypeString;
            string msgStatus;

            string positionInfo;
            long filePosition;
            int lineNum;
            string readMessage;
            string nextMessage;
            int nextIndex = -1;

       
            eMessageType msgType = eMessageType.UNKNOWN;

            for (int msgIndex = 0; msgIndex < messages.Count; msgIndex++)
            {
                message = messages[msgIndex];
                positionInfo = message.Substring(0, message.IndexOf(':'));
                filePosition = long.Parse(positionInfo.Substring(0, positionInfo.IndexOf(',')));
                lineNum = int.Parse(positionInfo.Substring(positionInfo.IndexOf(',') + 1));
                readMessage = message.Substring(message.IndexOf(':') + 2);

                if (readMessage.Length > 20)
                {
                    if (IsIncludeTimeStamp(readMessage) == true) // Is the header of each message containing timestamp??
                    {
                        timeStamp = readMessage.Substring(0, 8);
                        msgTypeString = readMessage.Substring(10, (readMessage.IndexOf("]") - 10));
                        msgStatus = readMessage.Substring(readMessage.IndexOf("]") + 1).Trim();

                        switch (msgTypeString)
                        {
                            case "SECS-II:Rcv":
                                msgType = eMessageType.SECS_RCV;
                                break;
                            case "SECS-II:Send":
                                msgType = eMessageType.SECS_SEND;
                                break;
                            case "I/F:Alarm":
                                msgType = eMessageType.IF_ALARM;
                                break;
                            case "Proc:Event":
                                msgType = eMessageType.PROC_ALARM;
                                break;
                            case "Proc:Alarm":
                                msgType = eMessageType.PROC_ALARM;
                                break;
                            case "HSMS:State":
                                msgType = eMessageType.HSMS_STATE;
                                break;
                            case "HSMS:Send":
                                msgType = eMessageType.HSMS_SEND;
                                break;
                            case "HSMS:Rcv":
                                msgType = eMessageType.HSMS_RCV;
                                break;
                            default:
                                msgType = eMessageType.UNKNOWN;
                                break;
                        }

                        SecsLog secsLog = new SecsLog(timeStamp, msgType, msgStatus);
                        StringBuilder messageBody = new StringBuilder();

                        secsLog.FilePosition = filePosition;

                        messageID = "N/A";
                        secsLog.MessageID = messageID;

                        


                        // *----1. MSG Header 가져오기.
                        if (msgType == eMessageType.SECS_RCV || msgType == eMessageType.SECS_SEND)
                        {
                            if ((nextIndex = this.GetNextMessageIndex(messages, msgIndex)) != -1)  // 다음 메시지가 있다면
                            {
                                nextMessage = messages[nextIndex];
                                nextMessage = messages[nextIndex].Substring(message.IndexOf(':') + 2);

                                // 다음 메시지가 시간을 포함하는 다른 시작 메세지가 아니라면 (정상 메시지가 아닌지 확인)
                                if (this.IsHeaderMessage(nextMessage) == true)
                                {
                                    message = messages[nextIndex];
                                    readMessage = message.Substring(message.IndexOf(':') + 2);

                                    readMessage = readMessage.Replace("\t", string.Empty);

                                    headerSplits = readMessage.Split(',');
                                    messageID = headerSplits[0].Trim() + ", " + headerSplits[1].Trim();
                                    secsLog.MessageID = messageID;

                                    secsLog.SystemByte = headerSplits[4].Remove(0, " SystemByte = ".Length);

                                    msgIndex = nextIndex;   // msgIndex를 nextIndex로 확정.
                                }
                            }

                            // *----2. MSG Body 가져오기.
                            

                            while (true)
                            {
                                if ((nextIndex = this.GetNextMessageIndex(messages, msgIndex)) != -1)  // 다음 메시지가 있다면
                                {
                                    nextMessage = messages[nextIndex];
                                    nextMessage = messages[nextIndex].Substring(message.IndexOf(':') + 2);

                                    // 다음 메시지가 시간을 포함하는 다른 시작 메세지가 아니라면 (정상 메시지가 아닌지 확인)
                                    if (IsIncludeTimeStamp(nextMessage) == false)
                                    {
                                        message = messages[nextIndex];
                                        readMessage = message.Substring(message.IndexOf(':') + 2);

                                        readMessage = readMessage.Replace("\t", string.Empty);

                                        messageBody.Append(readMessage);

                                        msgIndex = nextIndex;   // msgIndex를 nextIndex로 확정.
                                    }
                                    else break;
                                }
                                else break;
                            }
                        }

                        // 여기서 Message를 각각 Parsing할 일이 있다면 구현해줘어야 함.
                        switch (secsLog.MessageID)
                        {
                            case "S6, F11":
                                S6F11Parser s6f11Parser = new S6F11Parser();
                                secsLog.SecsMessage = s6f11Parser.GetParsedMessage(messageBody.ToString());
                                break;
                            case "S10, F5":
                                S10F5Parser s10f5Parser = new S10F5Parser();
                                secsLog.SecsMessage = s10f5Parser.GetParsedMessage(messageBody.ToString());
                                break;
                            case "N/A":
                                secsLog.SecsMessage = new NAMessage(secsLog.MsgStatus);
                                break;
                        }


                        secsLogs.Add(secsLog);
                    }
                }

                if (EV_updateProgress != null)
                {
                    EV_updateProgress(messages.Count, msgIndex, "Retrieving SECS Messages");
                }
            }

            EV_updateProgress(100, 0, "Complete");

            return secsLogs;
        }

    }
}
