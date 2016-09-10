namespace Calculator.Core.Strategies.UnsignedByteStrategies.BinaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class ModOperationUnsignedByteStrategy 
    {
        public byte Calculate(byte first, byte second)
        {
            if (first % second < byte.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return (byte)(first % second);
        }
    }
}
