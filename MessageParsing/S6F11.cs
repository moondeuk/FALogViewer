using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FALogViewer
{
    class S6F11 : ISecsMessage
    {
        private string data_Id;
        private string ce_Id;

        public string Data_Id
        {
            get { return data_Id; }
            set { data_Id = value; }
        }

        public string Ce_Id
        {
            get { return ce_Id; }
            set { ce_Id = value; }
        }

        public string GetInfo()
        {
            return ce_Id + " <" + CEIDInfo.Instance.GetCeName(ce_Id) +">";
        }
    }
}
