namespace Calculator.Core.Strategies.UnsignedInt32Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class DecrementOperationUnsignedInt32Strategy 
    {
        public uint Calculate(uint element)
        {
            if ((long)(element - 1) < uint.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return element - 1;
        }
    }
}
