using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FALogViewer
{
    class S10F5Parser : IMessageParser
    {
        public ISecsMessage GetParsedMessage(string messageBody)
        {
            S10F5 s10f5 = new S10F5();

            string[] messages = messageBody.Split('\r');

            if (messages.Length < 4)
                return null;

            string temp = messages[3];
            string terminalMessage = temp.Split(',')[2].Replace(">", string.Empty).Replace("<", string.Empty).Trim();

            s10f5.TerminalMessage = terminalMessage;

            return s10f5;
        }
    }
}
