using System;

using Microsoft.CodeAnalysis;

using R5T.B0006;

using Instances = R5T.B0006.X0004.Instances;


namespace System
{
    public static partial class ISyntaxOperatorExtensions
    {
        public static TNode Decorate<TNode>(this ISyntaxOperator _,
            TNode node,
            Func<TNode, TNode> decorator)
            where TNode : SyntaxNode
        {
            return Instances.SyntaxOperator_Functionality.Decorate(
                node,
                decorator);
        }
    }
}
