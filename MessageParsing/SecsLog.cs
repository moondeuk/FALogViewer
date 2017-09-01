using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FALogViewer
{
    class SecsLog
    {
        private long filePosition = -1;
        private string timeStamp;
        private string msgID;
        private eMessageType msgType;
        private string msgStatus;

        private ISecsMessage secsMessage;

        public long FilePosition
        {
            get { return filePosition; }
            set { filePosition = value; }
        }

        public eMessageType MessageType
        {
            get { return msgType; }
            set { msgType = value; }
        }

        public string TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

        public string MessageID
        {
            get { return msgID; }
            set { msgID = value; }
        }

        public string MsgStatus
        {
            get { return msgStatus; }
            set { msgStatus = value; }
        }

        public ISecsMessage SecsMessage
        {
            get { return secsMessage; }
            set { secsMessage = value; }
        }

        public SecsLog(string timeStamp, eMessageType msgType, string msgStatus)
        {
            this.timeStamp = timeStamp;
            this.msgType = msgType;
            this.msgStatus = msgStatus;
        }

        public string SystemByte {get; set;}
    }
}
