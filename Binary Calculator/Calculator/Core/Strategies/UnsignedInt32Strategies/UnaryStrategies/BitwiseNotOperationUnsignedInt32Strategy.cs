namespace Calculator.Core.Strategies.UnsignedInt32Strategies.UnaryStrategies
{
    using Attributes;

    [Component]
    public class BitwiseNotOperationUnsignedInt32Strategy
    {
        public uint Calculate(uint element)
        {
            return ~element;
        }
    }
}
