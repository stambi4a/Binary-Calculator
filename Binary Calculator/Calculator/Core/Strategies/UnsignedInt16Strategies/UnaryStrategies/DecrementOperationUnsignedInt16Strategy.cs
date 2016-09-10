namespace Calculator.Core.Strategies.UnsignedInt16Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class DecrementOperationUnsignedInt16Strategy 
    {
        public ushort Calculate(ushort element)
        {
            if (element - 1 < ushort.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return (ushort)(element - 1);
        }
    }
}
