using Microsoft.VisualStudio.Shell;
using System.ComponentModel;

namespace Fortran_language_server_protocol
{
    public class OptionPageGrid : DialogPage
    {
        public const string LanguageServerExecutableDefault = "fortls";
        public const string LanguageServerArgumentsDefault = "--lowercase_intrinsics";

        private string languageServerExecutable = LanguageServerExecutableDefault;
        private string languageServerArguments = LanguageServerArgumentsDefault;

        [Category("Fortran Language Server")]
        [DisplayName("Executable (path)")]
        [Description("Path to language server executable, or name if it is on the Path. Default: " + LanguageServerExecutableDefault)]
        public string LanguageServerExecutable
        {
            get { return languageServerExecutable; }
            set { languageServerExecutable = value; }
        }

        [Category("Fortran Language Server")]
        [DisplayName("Command Line Arguments")]
        [Description("Command line arguments to language server. Default: " + LanguageServerArgumentsDefault)]
        public string LanguageServerArguments
        {
            get { return languageServerArguments; }
            set { languageServerArguments = value; }
        }
    }
}
