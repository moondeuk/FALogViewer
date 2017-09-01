using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FALogViewer
{
    class S6F11Parser : IMessageParser
    {
        public ISecsMessage GetParsedMessage(string messageBody)
        {
            S6F11 s6f11 = new S6F11();
            string ce_id;


            string[] messages = messageBody.Split('\r');

            if (messages.Length < 3)
                return null;

            string temp = messages[2];
            ce_id = temp.Split(',')[2].Replace(">", string.Empty).Replace("<", string.Empty).Trim();
           
            s6f11.Ce_Id = ce_id;

            return s6f11;
        }
    }
}
