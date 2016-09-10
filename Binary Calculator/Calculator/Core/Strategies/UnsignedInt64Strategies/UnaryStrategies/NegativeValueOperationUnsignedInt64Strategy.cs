namespace Calculator.Core.Strategies.UnsignedInt64Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class NegativeValueOperationUnsignedInt64Strategy 
    {
        public ulong Calculate(ulong element)
        {
            if (element > 0)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return 0 - element;
        }
    }
}
