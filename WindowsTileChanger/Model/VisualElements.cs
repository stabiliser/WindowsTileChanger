using System.Xml.Serialization;

namespace WindowsTileChanger.Model
{
    public class VisualElements
    {
        [XmlAttribute]
        public string BackgroundColor { get; set; }

        [XmlAttribute]
        public string ShowNameOnSquare150x150Logo { get; set; }

        [XmlAttribute]
        public string ForegroundText { get; set; }

        [XmlAttribute]
        public string Square150x150Logo { get; set; }

        [XmlAttribute]
        public string Square70x70Logo { get; set; }
    }
}
