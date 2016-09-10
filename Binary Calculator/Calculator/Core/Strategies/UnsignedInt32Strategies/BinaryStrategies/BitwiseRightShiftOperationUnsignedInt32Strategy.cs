namespace Calculator.Core.Strategies.UnsignedInt32Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    [Component]
    public class BitwiseRightShiftOperationUnsignedInt32Strategy
    {
        public uint Calculate(uint first, uint element)
        {
            var second = (int)element;

            return first >> second;
        }
    }
}
