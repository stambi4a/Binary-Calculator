namespace Calculator.Core.Strategies.UnsignedInt64Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    [Component]
    public class BitwiseXorOperationUnsignedInt64Strategy
    {
        public ulong Calculate(ulong first, ulong second)
        {
            return first ^ second;
        }
    }
}
