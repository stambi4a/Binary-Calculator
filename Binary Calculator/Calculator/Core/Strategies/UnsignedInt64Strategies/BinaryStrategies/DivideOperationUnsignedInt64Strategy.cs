namespace Calculator.Core.Strategies.UnsignedInt64Strategies.BinaryStrategies
{
    using System;

    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class DivideOperationUnsignedInt64Strategy 
    {
        public ulong Calculate(ulong first, ulong second)
        {
            if (second == 0)
            {
                throw new ZeroDivisionException();
            }

            if ((decimal)(first / second) < ulong.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return first / second;
        }
    }
}
