namespace Calculator.Core.Strategies.SignedByteStrategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class IncrementOperationSignedByteStrategy 
    {
        public sbyte Calculate(sbyte first)
        {
            if (first + 1 > sbyte.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return (sbyte)(first + 1);
        }
    }
}
