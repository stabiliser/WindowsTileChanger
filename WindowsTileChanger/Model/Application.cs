using System.Xml.Serialization;

namespace WindowsTileChanger.Model
{
    [XmlRoot]
    public class Application
    {
        public VisualElements VisualElements { get; set; }
    }
}
