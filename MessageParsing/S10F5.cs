using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FALogViewer
{
    class S10F5 : ISecsMessage
    {
        private string terminalMessage;

        public string TerminalMessage
        {
            get { return terminalMessage; }
            set { terminalMessage = value; }
        }
        
        public string GetInfo()
        {
            return terminalMessage;
        }
    }
}
