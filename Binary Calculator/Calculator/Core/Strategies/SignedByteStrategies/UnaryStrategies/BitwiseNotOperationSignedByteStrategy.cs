namespace Calculator.Core.Strategies.SignedByteStrategies.UnaryStrategies
{
    using Attributes;

    [Component]
    public class BitwiseNotOperationSignedByteStrategy
    {
        public sbyte Calculate(sbyte element)
        {
            return (sbyte)(~element);
        }
    }
}
