using Microsoft.VisualStudio.LanguageServer.Client;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace Fortran_language_server_protocol
{
    public class FortranContentDefinition
    {
        [Export]
        [Name("fortran")]
        [BaseDefinition(CodeRemoteContentDefinition.CodeRemoteContentTypeName)]
        internal static ContentTypeDefinition FortranContentTypeDefinition;

        [Export]
        [FileExtension(".f")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionF;

        [Export]
        [FileExtension(".f77")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionF77;

        [Export]
        [FileExtension(".f90")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionF90;

        [Export]
        [FileExtension(".f95")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionF95;

        [Export]
        [FileExtension(".f03")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionF03;

        [Export]
        [FileExtension(".f08")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionF08;

        [Export]
        [FileExtension(".f18")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionF18;

        [Export]
        [FileExtension(".f23")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionF23;
    }
}
