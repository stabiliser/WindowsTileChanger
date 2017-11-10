using System.Xml.Serialization;

namespace WindowsTileChanger.Model
{
    public class LayoutOptions
    {
        [XmlAttribute]
        public int StartTileGroupCellWidth { get; set; }
    }
}
