using System;

using R5T.T0136;

using ISyntaxOperator = R5T.B0006.ISyntaxOperator;

using Instances = R5T.B0006.X0004.Instances;


namespace System
{
    public static partial class ISyntaxOperatorExtensions
    {
        public static void PostGenerationInitialSimpleDecorator(this ISyntaxOperator _,
            IBraced braced)
        {
            Instances.SyntaxOperator_Functionality.PostGenerationInitialSimpleDecorator(
                braced);
        }
    }
}
