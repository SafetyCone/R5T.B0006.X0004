using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;

using Instances = R5T.B0006.X0004.Instances;


namespace R5T.N0001.Generation.Initial.Simple
{
    public static partial class ISyntaxGeneratorExtensions
    {
        public static InterfaceDeclarationSyntax Interface_Simple(this ISyntaxGenerator syntaxGenerator,
            string interfaceTypeName)
        {
            var output = syntaxGenerator.Interface(interfaceTypeName);
            return output;
        }

        public static NamespaceDeclarationSyntax Namespace_Simple(this ISyntaxGenerator syntaxGenerator,
            string namespaceName)
        {
            var output = syntaxGenerator.Namespace(namespaceName);
            return output;
        }
    }
}
