namespace Calculator.Core.Strategies.SignedByteStrategies.BinaryStrategies
{
    using System;

    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class DivideOperationSignedByteStrategy 
    {

        public sbyte Calculate(sbyte first, sbyte second)
        {
            if (second == 0)
            {
                throw new ZeroDivisionException();
            }

            if (first / second > sbyte.MaxValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return (sbyte)(first / second);
        }
    }
}
