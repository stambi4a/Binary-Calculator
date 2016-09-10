namespace Calculator.Core.Strategies.SignedByteStrategies.BinaryStrategies
{
    using Calculator.Attributes;

    [Component]
    public class BitwiseAndOperationSignedByteStrategy
    {
        public sbyte Calculate(sbyte first, sbyte second)
        {
            return (sbyte)(first & second);
        }
    }
}
