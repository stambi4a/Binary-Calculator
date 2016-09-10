namespace Calculator.Core.Strategies.SignedByteStrategies.BinaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class SubtractOperationSignedByteStrategy 
    {
        public sbyte Calculate(sbyte first, sbyte second)
        {
            if (first - second < sbyte.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            if (first - second > sbyte.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return (sbyte)(first - second);
        }
    }
}
