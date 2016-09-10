namespace Calculator.Core.Strategies.SignedInt32Strategies.BinaryStrategies
{

    using Calculator.Exceptions;
    using Attributes;

    [Component]
    public class SubtractOperationSignedInt32Strategy
    {
        public int Calculate(int first, int second)
        {
            if ((long)(first - second) < int.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            if ((long)(first - second) > int.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return first - second;
        }
    }
}
