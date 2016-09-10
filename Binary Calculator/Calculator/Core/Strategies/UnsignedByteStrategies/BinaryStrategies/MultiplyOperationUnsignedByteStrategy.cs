namespace Calculator.Core.Strategies.UnsignedByteStrategies.BinaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class MultiplyOperationUnsignedByteStrategy 
    {
        public byte Calculate(byte first, byte second)
        {
            if (first * second < byte.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            if (first * second > byte.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return (byte)(first * second);
        }
    }
}
