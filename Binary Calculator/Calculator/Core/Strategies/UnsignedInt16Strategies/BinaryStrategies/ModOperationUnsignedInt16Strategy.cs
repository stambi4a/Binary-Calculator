namespace Calculator.Core.Strategies.UnsignedInt16Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class ModOperationUnsignedInt16Strategy 
    {
        public ushort Calculate(ushort first, ushort second)
        {
            if (first % second < ushort.MinValue)
            {
                throw new NumericTypeLowerBoundOverflowException();
            }
             
            return (ushort)(first % second);
        }
    }
}
