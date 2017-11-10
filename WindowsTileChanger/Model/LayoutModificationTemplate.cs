using System.Xml.Serialization;

namespace WindowsTileChanger.Model
{
    [XmlRoot( Namespace = "http://schemas.microsoft.com/Start/2014/LayoutModification" )]
    public class LayoutModificationTemplate
    {
        public LayoutOptions LayoutOptions { get; set; }
        public DefaultLayoutOverride DefaultLayoutOverride { get; set; }
    }
}
