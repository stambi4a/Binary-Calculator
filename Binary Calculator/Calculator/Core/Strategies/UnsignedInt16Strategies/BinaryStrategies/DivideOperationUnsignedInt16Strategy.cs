namespace Calculator.Core.Strategies.UnsignedInt16Strategies.BinaryStrategies
{
    using System;

    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class DivideOperationSUnsignedInt16Strategy 
    {
        public ushort Calculate(ushort first, ushort second)
        {
            if (second == 0)
            {
                throw new ZeroDivisionException();
            }

            if (first / second < ushort.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }
            return (ushort)(first / second);
        }
    }
}
