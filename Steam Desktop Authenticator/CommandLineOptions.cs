using CommandLine;
using CommandLine.Text;

namespace Steam_Desktop_Authenticator
{
    class CommandLineOptions
    {
        [Option('k', "encryption-key", Required = false,
          HelpText = "清单的加密密钥")]
        public string EncryptionKey { get; set; }

        [Option('s', "silent", Required = false,
          HelpText = "最小化启动")]
        public bool Silent { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
              (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
