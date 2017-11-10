using System.IO;
using System.Xml.Serialization;
using WindowsTileChanger.Model;

namespace WindowsTileChanger
{
    class Manifest
    {
        public Manifest( string aPath )
        {
            iPath = aPath;
        }

        public void ReadOrCreate()
        {
            if( File.Exists( iPath ) )
            {
                var serializer = new XmlSerializer( typeof( Application ) );

                using( var xmlStream = new StreamReader( iPath ) )
                {
                    Application = ( Application )serializer.Deserialize( xmlStream );
                }
            }
            else
            {
                Application = new Application
                {
                    VisualElements = new VisualElements
                    {
                        BackgroundColor = "#000000",
                        ForegroundText = "light",
                        ShowNameOnSquare150x150Logo = "on"
                    }
                };
            }
        }

        public void Save()
        {
            var serializer = new XmlSerializer( typeof( Application ) );

            using( var xmlStream = new StreamWriter( iPath ) )
            {
                var ns = new XmlSerializerNamespaces();

                ns.Add( "xsi", "http://www.w3.org/2001/XMLSchema-instance" );

                serializer.Serialize( xmlStream, Application, ns );
            }
        }

        public Application Application { get; private set; }

        readonly string iPath;
    }
}
