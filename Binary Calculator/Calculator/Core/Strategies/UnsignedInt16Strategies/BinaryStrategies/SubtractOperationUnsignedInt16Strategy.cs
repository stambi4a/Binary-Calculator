namespace Calculator.Core.Strategies.UnsignedInt16Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class SubtractOperationUnsignedInt1Strategy 
    {
        public ushort Calculate(ushort first, ushort second)
        {
            if (first - second < short.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            if (first - second > ushort.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return (ushort)(first - second);
        }
    }
}
