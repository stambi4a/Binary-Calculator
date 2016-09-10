namespace Calculator.Core.Strategies.SignedInt16Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class AddOperationSignedInt16Strategy 
    {
        public short Calculate(short first, short second)
        {
            if (first + second < short.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            if (first + second > short.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return (short)(first + second);
        }
    }
}
