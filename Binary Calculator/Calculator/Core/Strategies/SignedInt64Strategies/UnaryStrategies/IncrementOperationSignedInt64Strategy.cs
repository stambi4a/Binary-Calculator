namespace Calculator.Core.Strategies.SignedInt64Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class IncrementOperationSignedInt64Strategy 
    {
        public long Calculate(long element)
        {
            if ((decimal)(element + 1) > long.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return element + 1;
        }
    }
}
