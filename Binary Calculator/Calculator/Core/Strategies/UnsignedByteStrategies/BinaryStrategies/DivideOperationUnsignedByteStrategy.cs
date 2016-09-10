namespace Calculator.Core.Strategies.UnsignedByteStrategies.BinaryStrategies
{
    using System;

    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class DivideOperationUnsignedByteStrategy 
    {
        public byte Calculate(byte first, byte second)
        {
            if (second == 0)
            {
                throw new ZeroDivisionException();
            }

            if (first / second < byte.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return (byte)(first / second);
        }
    }
}
