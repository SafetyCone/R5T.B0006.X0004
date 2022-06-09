using System;

using ISyntaxOperator_Functionality = R5T.F0007.ISyntaxOperator;


namespace R5T.B0006.X0004
{
    public static class Instances
    {
        public static B0007.ISpacingGenerator SpacingGenerator { get; } = B0007.SpacingGenerator.Instance;
        public static ISyntaxOperator SyntaxOperator { get; } = B0006.SyntaxOperator.Instance;
        public static ISyntaxOperator_Functionality SyntaxOperator_Functionality { get; } = F0007.SyntaxOperator.Instance;
    }
}
