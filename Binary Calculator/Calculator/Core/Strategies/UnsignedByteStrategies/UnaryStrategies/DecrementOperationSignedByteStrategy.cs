namespace Calculator.Core.Strategies.UnsignedByteStrategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class DecrementOperationUnsignedByteStrategy 
    {
        public byte Calculate(byte element)
        {
            if (element - 1 < byte.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return (byte)(element- 1);
        }
    }
}
