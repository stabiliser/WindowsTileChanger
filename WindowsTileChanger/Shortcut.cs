using Shell32;
using System;
using System.IO;

namespace WindowsTileChanger
{
    static class Shortcut
    {
        public static string GetTarget( string aPath )
        {
            var shell = new Shell();

            var path = Path.GetFullPath( aPath );
            var dir = shell.NameSpace( Path.GetDirectoryName( path ) );
            var item = dir.Items().Item( Path.GetFileName( path ) );
            var lnk = ( Shell32.ShellLinkObject )item.GetLink;

            return lnk.Target.Path;
        }

        public static void Touch( string aPath )
        {
            if( File.Exists( aPath ) )
            {
                File.SetLastWriteTime( aPath, DateTime.Now );
            }
            else
            {
                // throw
            }
        }
    }
}
