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
        internal static FileExtensionToContentTypeDefinition ExtensionLowerF;

        [Export]
        [FileExtension(".F")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionUpperF;

        [Export]
        [FileExtension(".f77")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionLowerF77;

        [Export]
        [FileExtension(".F77")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionUpperF77;

        [Export]
        [FileExtension(".f90")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionLowerF90;

        [Export]
        [FileExtension(".F90")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionUpperF90;

        [Export]
        [FileExtension(".f95")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionLowerF95;

        [Export]
        [FileExtension(".F95")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionUpperF95;

        [Export]
        [FileExtension(".f03")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionLowerF03;

        [Export]
        [FileExtension(".F03")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionUpperF03;

        [Export]
        [FileExtension(".f08")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionLowerF08;

        [Export]
        [FileExtension(".F08")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionUpperF08;

        [Export]
        [FileExtension(".f18")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionLowerF18;

        [Export]
        [FileExtension(".F18")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionUpperF18;

        [Export]
        [FileExtension(".f23")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionLowerF23;

        [Export]
        [FileExtension(".F23")]
        [ContentType("fortran")]
        internal static FileExtensionToContentTypeDefinition ExtensionUpperF23;
    }
}
