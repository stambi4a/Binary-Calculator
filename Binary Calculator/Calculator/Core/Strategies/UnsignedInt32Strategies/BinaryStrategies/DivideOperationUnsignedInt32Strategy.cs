namespace Calculator.Core.Strategies.UnsignedInt32Strategies.BinaryStrategies
{
    using System;

    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class DivideOperationUnsignedInt32Strategy 
    {
        public uint Calculate(uint first, uint second)
        {
            if (second == 0)
            {
                throw new ZeroDivisionException();
            }

            if ((long)(first / second) > uint.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return first / second;
        }
    }
}
