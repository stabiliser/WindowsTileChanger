using CommandLine;
using System;
using System.IO;

namespace WindowsTileChanger
{
    class Program
    {
        [STAThread]
        static int Main( string[] aArgs )
        {
            try
            {
                var options = new Options();

                if( Parser.Default.ParseArguments( aArgs, options ) )
                {
                    var template = StartLayout.Get();

                    if( template != null )
                    {
                        foreach( var startGroup in template.DefaultLayoutOverride.StartLayoutCollection.StartLayout.StartGroup )
                        {
                            if( startGroup.Name == "Applications" )
                            {
                                foreach( var desktopApplicationTile in startGroup.DesktopApplicationTile )
                                {
                                    var shortcut = Environment.ExpandEnvironmentVariables( desktopApplicationTile.DesktopApplicationLinkPath );
                                    var target = Shortcut.GetTarget( shortcut );
                                    var manifest = new Manifest( Path.ChangeExtension( target, "VisualElementsManifest.xml" ) );

                                    manifest.ReadOrCreate();

                                    manifest.Application.VisualElements.ForegroundText = options.ForegroundText;
                                    manifest.Application.VisualElements.BackgroundColor = options.BackgroundColor;

                                    manifest.Save();

                                    Shortcut.Touch( shortcut );

                                    return 0;
                                }
                            }
                        }
                    }
                }

                return 1;
            }
            catch( Exception ex )
            {
                Console.WriteLine( $"Error: {ex.Message}" );

                return -1;
            }
        }
    }
}
