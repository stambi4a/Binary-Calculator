namespace Calculator.Core.Strategies.SignedInt64Strategies.UnaryStrategies
{
    using Attributes;

    [Component]
    public class BitwiseNotOperationSignedInt64Strategy
    {
        public long Calculate(long element)
        {
            return ~element;
        }
    }
}
