namespace Calculator.Core.Strategies.SignedInt16Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class DecrementOperationSignedInt16Strategy 
    {
        public short Calculate(short first)
        {
            if (first - 1 < short.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return (short)(first - 1);
        }
    }
}
