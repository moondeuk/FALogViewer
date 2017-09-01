using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FALogViewer
{
    public enum FindLookAt
    {
        ID,
        DATETIME,
        INFO,
        DESCRIPTION,
        SYSTEMBYTE
    }

    public class MessageFind
    {

        private bool isDownDirection = true;

        public bool IsDownDirection
        {
            get { return isDownDirection; }
            set { isDownDirection = value; }
        }

        public string FindText {get; set;}

        public bool IsLookAt_ID {get; set;}
        public bool IsLookAt_DateTime { get; set; }
        public bool IsLookAt_Info { get; set; }
        public bool IsLookAt_Description { get; set; }
        public bool IsLookAt_SystemByte { get; set; } 
    }
}
