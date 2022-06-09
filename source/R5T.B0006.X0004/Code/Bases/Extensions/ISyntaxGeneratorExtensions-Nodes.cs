using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;

using Instances = R5T.B0006.X0004.Instances;


namespace System
{
    using R5T.N0001.Generation.Initial.Simple;


    public static partial class ISyntaxGeneratorExtensions
    {
        public static InterfaceDeclarationSyntax Interface(this ISyntaxGenerator syntaxGenerator,
            string interfaceTypeName)
        {
            var output = Instances.SyntaxOperator.Decorate(
                syntaxGenerator.Interface_Simple(interfaceTypeName),
                Instances.SyntaxOperator.PostGenerationInitialSimpleDecorator);

            return output;
        }

        public static NamespaceDeclarationSyntax Namespace(this ISyntaxGenerator syntaxGenerator,
            string namespaceName)
        {
            var output = Instances.SyntaxOperator.Decorate(
                syntaxGenerator.Namespace_Simple(namespaceName),
                Instances.SyntaxOperator.PostGenerationInitialSimpleDecorator);

            return output;
        }
    }
}
