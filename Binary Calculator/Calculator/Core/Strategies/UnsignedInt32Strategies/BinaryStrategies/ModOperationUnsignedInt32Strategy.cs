namespace Calculator.Core.Strategies.UnsignedInt32Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class ModOperationUnsignedInt32Strategy 
    {
        public uint Calculate(uint first, uint second)
        {
            if ((long)(first % second) < uint.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return first % second;
        }
    }
}
