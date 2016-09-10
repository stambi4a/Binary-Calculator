namespace Calculator.Core.Strategies.UnsignedInt32Strategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class IncrementOperationUnsignedInt32Strategy 
    {
        public uint Calculate(uint element)
        {
            if ((long)(element + 1) > uint.MaxValue)
            {
                throw new NumericTypeUpperBoundOverflowException();
            }

            return element + 1;
        }
    }
}
