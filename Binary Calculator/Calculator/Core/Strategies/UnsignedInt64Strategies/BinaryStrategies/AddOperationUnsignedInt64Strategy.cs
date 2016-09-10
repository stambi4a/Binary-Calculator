namespace Calculator.Core.Strategies.UnsignedInt64Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class AddOperationUnsignedInt64Strategy 
    {
        public ulong Calculate(ulong first, ulong second)
        {
            if ((decimal)(first + second) < ulong.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            if ((decimal)(first + second) > ulong.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return first + second;
        }
    }
}
