# Fortran Language Server Protocol Extension
This is a Visual Studio 2022 extension that makes use of [fortls](https://fortls.fortran-lang.org/index.html) as a Fortran Language Server.

## How to use
- Build the project in Visual Studio in Release. Install the resulting VSIX file. I intend to publish the extension on the Visual Studio Marketplace.
- Install an implementation of the Language Server Protocol for Fortran, currently [fortls](https://fortls.fortran-lang.org/index.html); for example "python -m pip install fortls".
- By default, fortls will be searched on the Path. This can be changed in Visual Studio by going to Tools->Options->Fortran Language Server->Options->Executable (path) option.
It is possible to specify the full path to an executable, or another Fortran language server protocol implementation than fortls if one is available.
- There are some default command line arguments passed to the language server protocol implementation. These can be changed in Tools->Options->Fortran Language Server->Options->Command Line Arguments.
- In Visual Studio, go to Tools->Options->Text Editor->Fortran->Advanced and turn off the Intel Fortran Browsing/Navigation options (optional).
- Parsing the files may take some time, depending on the project size. Happy coding!

## Resources for development
This project mostly follows the [adding-an-lsp-extension](https://learn.microsoft.com/en-us/visualstudio/extensibility/adding-an-lsp-extension?view=vs-2022) page for creating the code.
The options page was added by following [creating-an-options-page](https://learn.microsoft.com/en-us/visualstudio/extensibility/creating-an-options-page?view=vs-2022),
and the accessing of options uses [getting-service-information-from-the-settings-store](https://learn.microsoft.com/en-us/visualstudio/extensibility/getting-service-information-from-the-settings-store?view=vs-2022).

The logo was taken from [Fortran-lang](https://github.com/fortran-lang/fortran-lang.org/blob/master/assets/img/fortran-logo.svg) (MIT License).
For syntax highlighting, the TextMate grammars were taken from the [Visual Studio Code extension](https://github.com/fortran-lang/vscode-fortran-support/tree/main/syntaxes) (MIT License).
I have used the [TextMate Languages VSCode extension](https://marketplace.visualstudio.com/items?itemName=Togusa09.tmlanguage) to convert the json grammar files to xml.
Only the fortran_free-form.tmLanguage file is used, because I was not able to turn on syntax highlighting when more than one grammar file was included.

## Prior art
[Fortran IntelliSense](https://github.com/michaelkonecny/vs-fortran-ls-client/): Another extension for Visual Studio 2017 that is very similar, probably because it was based on the same tutorial pages.
