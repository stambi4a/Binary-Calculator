namespace Calculator.Core.Strategies.SignedByteStrategies.UnaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class DecrementOperationSignedByteStrategy 
    {
        public sbyte Calculate(sbyte first)
        {
            if (first - 1 < sbyte.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return (sbyte)(first - 1);
        }
    }
}
