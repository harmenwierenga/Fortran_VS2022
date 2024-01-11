using Microsoft.VisualStudio.Shell;
using System;
using System.ComponentModel;

namespace Fortran_language_server_protocol
{
    public class OptionPageGrid : DialogPage
    {
        private const string languageServerExecutableDefault = "fortls";
        private const string languageServerArgumentsDefault = "--lowercase_intrinsics --incremental_sync";

        public static string LanguageServerExecutableDefault
        {
            get
            {
                return languageServerExecutableDefault;
            }
        }

        public static string LanguageServerArgumentsDefault
        {
            get
            {
                int numberOfThreads = Math.Max(Environment.ProcessorCount - 2, 1);
                return languageServerArgumentsDefault + String.Format(" --nthreads {0}", numberOfThreads);
            }
        }

        private string languageServerExecutable = LanguageServerExecutableDefault;
        private string languageServerArguments = LanguageServerArgumentsDefault;

        [Category("Fortran Language Server")]
        [DisplayName("Executable (path)")]
        [Description("Path to language server executable, or name if it is on the Path. Default: " + languageServerExecutableDefault)]
        public string LanguageServerExecutable
        {
            get { return languageServerExecutable; }
            set { languageServerExecutable = value; }
        }

        [Category("Fortran Language Server")]
        [DisplayName("Command Line Arguments")]
        [Description("Command line arguments to language server. Default: " + languageServerArgumentsDefault)]
        public string LanguageServerArguments
        {
            get { return languageServerArguments; }
            set { languageServerArguments = value; }
        }
    }
}
