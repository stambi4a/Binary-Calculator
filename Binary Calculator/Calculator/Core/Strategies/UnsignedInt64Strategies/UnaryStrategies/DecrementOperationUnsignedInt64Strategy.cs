namespace Calculator.Core.Strategies.UnsignedInt64Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class DecrementOperationUnsignedInt64Strategy 
    {
        public ulong Calculate(ulong element)
        {
            if ((decimal)(element - 1) < ulong.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return element - 1;
        }
    }
}
