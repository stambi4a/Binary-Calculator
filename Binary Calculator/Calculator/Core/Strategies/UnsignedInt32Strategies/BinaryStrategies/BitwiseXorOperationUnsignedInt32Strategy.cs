namespace Calculator.Core.Strategies.UnsignedInt32Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    [Component]
    public class BitwiseXorOperationUnsignedInt32Strategy
    {
        public uint Calculate(uint first, uint second)
        {
            return first ^ second;
        }
    }
}
