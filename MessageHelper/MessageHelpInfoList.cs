using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using FALogViewer.MessageHelper;

namespace FALogViewer
{
    [XmlRoot("MessageHelpInfoList")]
    public class MessageHelpInfoList
    {
        [XmlIgnore]
        public bool IsChangeSaved { get; set; }

        public MessageHelpInfoList() { Items = new List<MessageHelpInfo>(); }

        [XmlElement("MessageHelpInfo")]
        public List<MessageHelpInfo> Items { get; set; }

        public MessageHelpInfo GetMessageHelp(string messageID)
        {
            try
            {
                string[] messages = messageID.Split(',');

                if (messages.Length != 2)
                {
                    return null;
                }
                else
                {
                    int stream = int.Parse(messages[0].Trim().Substring(1));
                    int function = int.Parse(messages[1].Trim().Substring(1));
                    foreach (MessageHelpInfo messageHelpInfo in Items)
                    {
                        if (messageHelpInfo.Stream == stream && messageHelpInfo.Function == function)
                        {
                            return messageHelpInfo;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }

            return null;
        }
    }
}
