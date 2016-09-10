namespace Calculator.Core.Strategies.UnsignedInt32Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class SubtractOperationUnsignedInt32Strategy 
    {
        public uint Calculate(uint first, uint second)
        {
            if ((long)(first - second) < uint.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            if ((long)(first - second) > uint.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return first - second;
        }
    }
}
