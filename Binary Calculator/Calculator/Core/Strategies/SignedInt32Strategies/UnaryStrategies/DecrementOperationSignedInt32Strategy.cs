namespace Calculator.Core.Strategies.SignedInt32Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class DecrementOperationSignedInt32Strategy
    {
        public int Calculate(int element)
        {
            if ((long)(element - 1) < int.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return element - 1;
        }
    }
}
