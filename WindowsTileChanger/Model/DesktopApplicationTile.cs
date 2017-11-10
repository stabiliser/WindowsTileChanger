using System.Xml.Serialization;

namespace WindowsTileChanger.Model
{
    public class DesktopApplicationTile
    {
        [XmlAttribute]
        public string Size { get; set; }

        [XmlAttribute]
        public int Column { get; set; }

        [XmlAttribute]
        public int Row { get; set; }

        [XmlAttribute]
        public string DesktopApplicationLinkPath { get; set; }
    }
}
