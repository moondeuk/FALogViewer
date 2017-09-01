using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FALogViewer
{
    public class MessageFilter
    {
        private List<string> includeMessages = new List<string>();       
        private List<string> excludeMessages = new List<string>();
        
        private bool isIncludeEnable;
        private bool isExcludeEnable;

        public List<string> IncludeMessages
        {
            get { return includeMessages; }
            set { includeMessages = value; }
        }

        public List<string> ExcludeMessages
        {
            get { return excludeMessages; }
            set { excludeMessages = value; }
        }

        public bool IsIncludeEnable
        {
            get { return isIncludeEnable; }
            set { isIncludeEnable = value; }
        }

        public bool IsExcludeEnable
        {
            get { return isExcludeEnable; }
            set { isExcludeEnable = value; }
        }

        public bool IsFiltered
        {
            get 
            {
                if (this.isIncludeEnable == true && includeMessages.Count > 0)
                {
                    return true;
                }
                else if (this.isExcludeEnable == true && excludeMessages.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
