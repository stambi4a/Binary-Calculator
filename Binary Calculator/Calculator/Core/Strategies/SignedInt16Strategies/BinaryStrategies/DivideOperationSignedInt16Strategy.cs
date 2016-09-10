namespace Calculator.Core.Strategies.SignedInt16Strategies.BinaryStrategies
{
    using System;

    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class DivideOperationSignedInt16Strategy 
    {
        public short Calculate(short first, short second)
        {
            if (second == 0)
            {
                throw new ZeroDivisionException();
            }

            if (first / second > short.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return (short)(first / second);
        }
    }
}
