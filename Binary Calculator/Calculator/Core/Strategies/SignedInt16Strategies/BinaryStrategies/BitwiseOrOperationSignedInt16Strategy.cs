﻿namespace Calculator.Core.Strategies.SignedInt16Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    [Component]
    public class BitwiseOrOperationSignedInt16Strategy
    {
        public short Calculate(short first, short second)
        {
            return (short)(first | second);
        }
    }
}
