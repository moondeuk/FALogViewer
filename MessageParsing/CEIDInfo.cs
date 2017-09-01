using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace FALogViewer
{
    class CEIDInfo
    {
        private static CEIDInfo _instance = null;
        private static object _syncRoot = new object();
        private DataTable ceidTable;

        private CEIDInfo()
        {
            try
            {
                string fileName = Application.StartupPath + "\\CEID_LIST.txt";
                ceidTable = CSVReader.ReadCSVFile(fileName, true);
            }
            catch
            {
            }
        }

        public string GetCeName(string ceid)
        {
            if (ceidTable != null)
            {
                for (int i = 1; i <= 11; i++)
                {
                    string columnName = String.Format("CEID{0}", i);
                    string stmtExecute = columnName + " = " + ceid;

                    DataRow[] drEQID = ceidTable.Select(stmtExecute); // Find all rows matching the filter.

                    if (drEQID.Length > 0)
                    {


                        string ceName = (string)drEQID[0]["ce_name"];
                        return ceName;

                    }
                }
            } return string.Empty;
        }

        public static CEIDInfo Instance
        {
            get
            {
                lock (_syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new CEIDInfo();
                    }
                    return _instance;
                }
            }
        }
    }
}
