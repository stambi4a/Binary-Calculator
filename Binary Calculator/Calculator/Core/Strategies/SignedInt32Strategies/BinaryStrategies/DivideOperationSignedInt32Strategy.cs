namespace Calculator.Core.Strategies.SignedInt32Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class DivideOperationSignedInt32Strategy
    {
        public int Calculate(int first, int second)
        {
            if (second == 0)
            {
                throw new ZeroDivisionException();
            }

            if ((long)(first / second) > int.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return first / second;
        }
    }
}
