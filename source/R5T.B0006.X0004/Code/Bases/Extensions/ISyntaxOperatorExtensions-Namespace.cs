using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;

using Instances = R5T.B0006.X0004.Instances;


namespace System
{
    public static partial class ISyntaxOperatorExtensions
    {
        public static NamespaceDeclarationSyntax PostGenerationInitialSimpleDecorator(this ISyntaxOperator _,
            NamespaceDeclarationSyntax @namespace)
        {
            var output = @namespace
                .WithName(
                    @namespace.Name
                        .WithLeadingTrivia(
                            Instances.SpacingGenerator.Space()))
                .ModifyAsBraced(
                    _.PostGenerationInitialSimpleDecorator);

            return output;
        }
    }
}
