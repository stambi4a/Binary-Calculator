namespace Calculator.Core.Strategies.UnsignedInt32Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class NegativeValueOperationUnsignedInt32Strategy 
    {
        public uint Calculate(uint element)
        {
            if (element > 0)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return (uint)-element;
        }
    }
}
