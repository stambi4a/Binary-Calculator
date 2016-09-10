namespace Calculator.Core.Strategies.UnsignedByteStrategies.UnaryStrategies
{
    using Attributes;

    [Component]
    public class BitwiseNotOperationUnsignedByteStrategy
    {
        public byte Calculate(byte element)
        {
            return (byte)(~element);
        }
    }
}
