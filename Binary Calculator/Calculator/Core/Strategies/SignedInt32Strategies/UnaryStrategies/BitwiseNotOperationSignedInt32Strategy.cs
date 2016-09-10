namespace Calculator.Core.Strategies.SignedInt32Strategies.UnaryStrategies
{
    using Attributes;

    [Component]
    public class BitwiseNotOperationSignedInt32Strategy
    {
        public int Calculate(int element)
        {
            return ~element;
        }
    }
}
