namespace Calculator.Core.Strategies.UnsignedInt64Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    [Component]
    public class BitwiseLeftShiftOperationUnsignedInt64Strategy
    {
        public ulong Calculate(ulong first, ulong element)
        {
            var second = (int)element;

            return first << second;
        }
    }
}
