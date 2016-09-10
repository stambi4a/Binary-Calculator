namespace Calculator.Core.Strategies.SignedInt32Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class NegativeValueOperationSignedInt32Strategy
    {
        public int Calculate(int element)
        {
            if ((long)-element > int.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return -element;
        }
    }
}
