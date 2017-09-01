using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FALogViewer.MessageHelper
{
    [Serializable]
    public class MessageHelpInfo
    {
        [XmlAttribute]
        public int Stream { get; set; }

        [XmlAttribute]
        public int Function { get; set; }

        [XmlAttribute]
        public string Description { get; set; }

        [XmlAttribute]
        public string MessageHelp { get; set; }

        [XmlAttribute]
        public int ColorIndex { get; set; }

    }
}
