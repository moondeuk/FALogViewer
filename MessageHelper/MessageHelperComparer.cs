using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FALogViewer.MessageHelper
{
    class MessageHelperComparer : IComparer<MessageHelpInfo>
    {
        public int Compare(MessageHelpInfo messageHelpInfoX, MessageHelpInfo messageHelpInfoY)
        {

            if (messageHelpInfoX.Stream > messageHelpInfoY.Stream)
                return 1;
            else if (messageHelpInfoX.Stream < messageHelpInfoY.Stream)
                return -1;
            else
            {
                if (messageHelpInfoX.Function > messageHelpInfoY.Function)
                    return 1;
                else if (messageHelpInfoX.Function < messageHelpInfoY.Function)
                    return -1;
                else
                    return 0;
            }
        }
    }
}
