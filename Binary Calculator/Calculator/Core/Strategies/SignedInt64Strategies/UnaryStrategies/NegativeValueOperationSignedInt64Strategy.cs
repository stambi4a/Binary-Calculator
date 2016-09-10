namespace Calculator.Core.Strategies.SignedInt64Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class NegativeValueOperationSignedInt64Strategy 
    {
        public long Calculate(long element)
        {
            if ((decimal)-element > long.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return -element;
        }
    }
}
