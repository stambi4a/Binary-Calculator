namespace Calculator.Core.Strategies.SignedInt16Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class IncrementOperationSignedInt16Strategy 
    {
        public short Calculate(short first)
        {
            if (first + 1 > sbyte.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return (short)(first + 1);
        }
    }
}
