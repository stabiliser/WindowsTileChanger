using System.Xml.Serialization;

namespace WindowsTileChanger.Model
{
    public class StartLayoutCollection
    {
        [XmlElement( Namespace = "http://schemas.microsoft.com/Start/2014/FullDefaultLayout" )]
        public StartLayout StartLayout { get; set; }
    }
}
