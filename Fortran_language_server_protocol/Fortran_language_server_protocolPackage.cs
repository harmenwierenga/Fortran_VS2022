﻿using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;
using Microsoft.VisualStudio.LanguageServer.Client;
using Microsoft.VisualStudio.Threading;
using Microsoft.VisualStudio.Utilities;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.IO;

namespace Fortran_language_server_protocol
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [Guid(Fortran_language_server_protocolPackage.PackageGuidString)]
    [Export(typeof(ILanguageClient))]
    [ContentType("fortran")]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    public sealed class Fortran_language_server_protocolPackage : AsyncPackage, ILanguageClient
    {
        private readonly IEnumerable<string> filesToWatch;
        public Fortran_language_server_protocolPackage()
        {
            filesToWatch = new List<string> {"*.f", "*.F", "*.f77", "*.F77",
                    "*.f90", "*.F90", "*.f95", "*.F95", "*.f03", "*.F03",
                    "*.f08", "*.F08", "*.f18", "*.F18", "*.f23", "*.F23"};
        }

        public const string PackageGuidString = "9ac7db48-d27e-4e3d-84e8-fb93bf93b968";
        public string Name => "Fortran Language Extension";
        public IEnumerable<string> ConfigurationSections => null;
        public bool ShowNotificationOnInitializeFailed => true;
        public object InitializationOptions => null;

        public IEnumerable<string> FilesToWatch
        {
            get
            {
                return filesToWatch;
            }
        }

        public event AsyncEventHandler<EventArgs> StartAsync;
        public event AsyncEventHandler<EventArgs> StopAsync;

        public async Task<Connection> ActivateAsync(CancellationToken token)
        {
            await Task.Yield();

            string programPath = "C:\\Users\\wierenga\\AppData\\Local\\Programs\\Python\\Python311\\Scripts\\fortls.exe";
            ProcessStartInfo info = new ProcessStartInfo
            {
                Arguments = "",
                FileName = programPath,
                WorkingDirectory = Path.GetDirectoryName(programPath),
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process
            {
                StartInfo = info
            };

            if (process.Start())
            {
                return new Connection(process.StandardOutput.BaseStream, process.StandardInput.BaseStream);
            }

            return null;
        }

        public async Task OnLoadedAsync()
        {
            await StartAsync.InvokeAsync(this, EventArgs.Empty);
        }

        public Task<InitializationFailureContext> OnServerInitializeFailedAsync(ILanguageClientInitializationInfo info)
        {
            return Task.FromResult(new InitializationFailureContext
            {
                FailureMessage = info.StatusMessage
            });
        }

        public Task OnServerInitializedAsync()
        {
            return Task.CompletedTask;
        }

        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            await JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
        }
    }
}
