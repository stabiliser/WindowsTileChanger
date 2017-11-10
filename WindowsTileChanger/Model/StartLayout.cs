using System.Xml.Serialization;

namespace WindowsTileChanger.Model
{
    public class StartLayout
    {
        [XmlAttribute]
        public int GroupCellWidth { get; set; }

        [XmlElement( ElementName = "Group", Namespace = "http://schemas.microsoft.com/Start/2014/StartLayout" )]
        public StartGroup[] StartGroup { get; set; }
    }
}
