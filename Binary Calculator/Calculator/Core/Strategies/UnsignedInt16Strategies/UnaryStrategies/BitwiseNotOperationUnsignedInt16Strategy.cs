namespace Calculator.Core.Strategies.UnsignedInt16Strategies.UnaryStrategies
{
    using Attributes;

    [Component]
    public class BitwiseNotOperationUnsignedInt16Strategy
    {
        public ushort Calculate(ushort element)
        {
            return (ushort)~element;
        }
    }
}
