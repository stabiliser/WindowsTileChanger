using System.IO;
using System.Management.Automation;
using System.Xml.Serialization;
using WindowsTileChanger.Model;

namespace WindowsTileChanger
{
    static class StartLayout
    {
        public static LayoutModificationTemplate Get()
        {
            using( var powershell = PowerShell.Create() )
            {
                var path = Path.Combine( Path.GetTempPath(), Path.GetTempFileName() );

                powershell.AddCommand( "Export-StartLayout" );
                powershell.AddParameter( "-Path", path );

                powershell.Invoke();

                if( File.Exists( path ) )
                {
                    try
                    {
                        var serializer = new XmlSerializer( typeof( LayoutModificationTemplate ) );

                        using( var xmlStream = new StreamReader( path ) )
                        {
                            return ( LayoutModificationTemplate )serializer.Deserialize( xmlStream );
                        }
                    }
                    finally
                    {
                        File.Delete( path );
                    }
                }

                return null;
            }
        }
    }
}
