﻿namespace Calculator.Core.Strategies.UnsignedByteStrategies.BinaryStrategies
{
    using Calculator.Attributes;

    [Component]
    public class BitwiseOrOperationUnsignedByteStrategy
    {
        public byte Calculate(byte first, byte second)
        {
            return (byte)(first | second);
        }
    }
}
