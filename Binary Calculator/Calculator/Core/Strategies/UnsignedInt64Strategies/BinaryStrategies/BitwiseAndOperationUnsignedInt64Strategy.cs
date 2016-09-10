namespace Calculator.Core.Strategies.UnsignedInt64Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    [Component]
    public class BitwiseAndOperationUnsignedInt64Strategy
    {
        public ulong Calculate(ulong first, ulong second)
        {
            return first & second;
        }
    }
}
