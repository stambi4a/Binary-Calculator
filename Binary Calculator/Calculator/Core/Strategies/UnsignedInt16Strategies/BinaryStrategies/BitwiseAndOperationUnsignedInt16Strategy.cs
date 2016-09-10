﻿namespace Calculator.Core.Strategies.UnsignedInt16Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    [Component]
    public class BitwiseAndOperationUnsignedInt16Strategy
    {
        public ushort Calculate(ushort first, ushort second)
        {
            return (ushort)(first & second);
        }
    }
}
