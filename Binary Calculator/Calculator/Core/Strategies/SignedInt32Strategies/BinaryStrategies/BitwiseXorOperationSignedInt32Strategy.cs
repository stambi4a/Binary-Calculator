﻿namespace Calculator.Core.Strategies.SignedInt32Strategies.BinaryStrategies
{
    using Calculator.Attributes;


    [Component]
    public class BitwiseXorOperationSignedInt32Strategy
    {
        public int Calculate(int first, int second)
        {
            return first ^ second;
        }
    }
}
