using System.Xml.Serialization;

namespace WindowsTileChanger.Model
{
    public class StartGroup
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlElement]
        public DesktopApplicationTile[] DesktopApplicationTile { get; set; }
    }
}
