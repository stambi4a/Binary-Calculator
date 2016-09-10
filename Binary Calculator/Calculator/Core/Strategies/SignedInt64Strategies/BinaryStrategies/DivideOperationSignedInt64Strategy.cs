namespace Calculator.Core.Strategies.SignedInt64Strategies.BinaryStrategies
{
    using System;

    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class DivideOperationSignedInt64Strategy 
    {
        public long Calculate(long first, long second)
        {
            if (second == 0)
            {
                throw new ZeroDivisionException();
            }

            if ((decimal)(first / second) > long.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return first / second;
        }
    }
}
