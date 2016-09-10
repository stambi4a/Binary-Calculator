namespace Calculator.Core.Strategies.SignedInt64Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class DecrementOperationSignedInt64Strategy 
    {
        public long Calculate(long element)
        {
            if ((decimal)(element - 1) < long.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return element - 1;
        }
    }
}
