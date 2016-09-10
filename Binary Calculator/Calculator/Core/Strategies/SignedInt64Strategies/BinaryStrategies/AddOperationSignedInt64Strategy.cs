namespace Calculator.Core.Strategies.SignedInt64Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class AddOperationSignedInt64Strategy 
    {
        public long Calculate(long first, long second)
        {
            if ((decimal)(first + second) < long.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            if ((decimal)(first + second) > long.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return (long)(first + second);
        }
    }
}
