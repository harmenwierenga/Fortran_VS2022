using Microsoft.VisualStudio.Shell;
using System.ComponentModel;

namespace Fortran_language_server_protocol
{
    public class OptionPageGrid : DialogPage
    {
        private string languageServerExecutable = "fortls";
        private string languageServerArguments = "--nthreads 10";

        [Category("Fortran Language Server")]
        [DisplayName("Executable (path)")]
        [Description("Path to language server executable, or name if it is on the Path")]
        public string LanguageServerExecutable
        {
            get { return languageServerExecutable; }
            set { languageServerExecutable = value; }
        }

        [Category("Fortran Language Server")]
        [DisplayName("Command Line Arguments")]
        [Description("Command line arguments to language server")]
        public string LanguageServerArguments
        {
            get { return languageServerArguments; }
            set { languageServerArguments = value; }
        }
    }
}
