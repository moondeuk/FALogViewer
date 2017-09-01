using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FALogViewer
{
    public class NAMessage : ISecsMessage
    {
        private string messageStatus;

        public NAMessage(string messageStatus)
        {
            this.messageStatus = messageStatus;
        }

        public string GetInfo()
        {
            return messageStatus;
        }
    }
}
