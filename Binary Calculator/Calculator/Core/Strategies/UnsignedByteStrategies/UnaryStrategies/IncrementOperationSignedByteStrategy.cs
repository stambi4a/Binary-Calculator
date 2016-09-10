namespace Calculator.Core.Strategies.UnsignedByteStrategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class IncrementOperationUnsignedByteStrategy 
    {
        public byte Calculate(byte element)
        {
            if (element + 1 > byte.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return (byte)(element + 1);
        }
    }
}
