namespace Calculator.Core.Strategies.SignedInt16Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class NegativeValueOperationSignedInt16Strategy 
    {
        public short Calculate(short first)
        {
            if (-first > short.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return (short)-first;
        }
    }
}
