namespace Calculator.Core.Strategies.UnsignedInt64Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class IncrementOperationUnsignedInt64Strategy 
    {
        public ulong Calculate(ulong element)
        {
            if ((decimal)(element + 1) > ulong.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return element + 1;
        }
    }
}
