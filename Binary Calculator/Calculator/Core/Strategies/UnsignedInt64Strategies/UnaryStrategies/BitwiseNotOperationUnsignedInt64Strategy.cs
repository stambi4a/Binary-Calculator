namespace Calculator.Core.Strategies.UnsignedInt64Strategies.UnaryStrategies
{
    using Attributes;

    [Component]
    public class BitwiseNotOperationUnsignedInt64Strategy
    {
        public ulong Calculate(ulong element)
        {
            return ~element;
        }
    }
}
