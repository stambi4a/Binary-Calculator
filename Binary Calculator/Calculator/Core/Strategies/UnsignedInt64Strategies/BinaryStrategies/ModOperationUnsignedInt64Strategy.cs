namespace Calculator.Core.Strategies.UnsignedInt64Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class ModOperationUnsignedInt64Strategy 
    {
        public ulong Calculate(ulong first, ulong second)
        {
            if ((decimal)(first % second) < ulong.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }

            return first % second;
        }
    }
}
