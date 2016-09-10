namespace Calculator.Core.Strategies.SignedInt32Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class IncrementOperationSignedInt32Strategy
    {
        public int Calculate(int element)
        {
            if ((long)(element + 1) > int.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return element + 1;
        }
    }
}
