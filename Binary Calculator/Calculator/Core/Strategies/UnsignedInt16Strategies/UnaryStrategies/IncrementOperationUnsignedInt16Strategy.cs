namespace Calculator.Core.Strategies.UnsignedInt16Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class IncrementOperationunsignedInt16Strategy 
    {
        public ushort Calculate(ushort element)
        {
            if (element + 1 > ushort.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return (ushort)(element + 1);
        }
    }
}
