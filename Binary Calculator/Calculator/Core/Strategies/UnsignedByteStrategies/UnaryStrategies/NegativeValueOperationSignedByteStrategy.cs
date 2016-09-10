namespace Calculator.Core.Strategies.UnsignedByteStrategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class NegativeValueOperationUnsignedByteStrategy 
    {
        public byte Calculate(byte element)
        {
            if (element > 0)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return (byte)-element;
        }
    }
}
