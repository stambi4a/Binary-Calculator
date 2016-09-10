namespace Calculator.Core.Strategies.SignedByteStrategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class NegativeValueOperationSignedByteStrategy 
    {
        public sbyte Calculate(sbyte first)
        {
            if (-first > sbyte.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return (sbyte)-first;
        }
    }
}
