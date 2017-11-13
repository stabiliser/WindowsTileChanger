using CommandLine;
using CommandLine.Text;
using System;

namespace WindowsTileChanger
{
    class Options
    {
        [Option( 'f', "foregroundtext", Required = true, HelpText = "Supported values are light or dark."  )]
        public string ForegroundText { get; set; }

        [Option( 'b', "backgroundcolor", Required = true, HelpText = "red, blue, etc or transparent or RGB code (with #)" )]
        public string BackgroundColor { get; set; }

        [Option( 'g', "group", Required = false, HelpText = "Specifies a start menu group name." )]
        public string Group { get; set; }

        [HelpOption( 'h', "help", HelpText = "Display this help screen." )]
        public string GetUsage()
        {
            return HelpText.AutoBuild( this, ( HelpText aCurrent ) =>
            {
                aCurrent.AdditionalNewLineAfterOption = false;
                HelpText.DefaultParsingErrorsHandler( this, aCurrent );
            } );
        }
    }
}
