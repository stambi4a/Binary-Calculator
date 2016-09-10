namespace Calculator.Core.Strategies.UnsignedInt16Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class NegativeValueOperationUnsignedInt16Strategy 
    {
        public ushort Calculate(ushort element)
        {
            if (element > 0)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return (ushort)-element;
        }
    }
}
