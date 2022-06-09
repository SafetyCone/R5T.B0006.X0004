using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;

using Instances = R5T.B0006.X0004.Instances;


namespace System
{
    public static partial class ISyntaxOperatorExtensions
    {
        public static TBaseType PostGenerationInitialSimpleDecorator<TBaseType>(this ISyntaxOperator _,
            TBaseType baseType)
            where TBaseType : BaseTypeDeclarationSyntax 
        {
            return Instances.SyntaxOperator_Functionality.PostGenerationInitialSimpleDecorator(baseType);
        }
    }
}
