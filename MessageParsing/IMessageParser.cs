using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FALogViewer
{
    interface IMessageParser
    {
        ISecsMessage GetParsedMessage(string rawMessage);
    }
}
