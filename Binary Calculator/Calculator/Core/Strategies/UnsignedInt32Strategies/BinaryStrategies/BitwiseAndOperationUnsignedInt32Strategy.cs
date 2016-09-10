namespace Calculator.Core.Strategies.UnsignedInt32Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    [Component]
    public class BitwiseAndOperationUnsignedInt32Strategy
    {
        public uint Calculate(uint first, uint second)
        {
            return first & second;
        }
    }
}
