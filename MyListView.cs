﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FALogViewer
{
    class MyListView : ListView
    {
        public MyListView()
        {
            DoubleBuffered = true;
        }
    }
}
