namespace Calculator.Core.Strategies.SignedByteStrategies.BinaryStrategies
{
    using Calculator.Attributes;

    [Component]
    public class BitwiseXorOperationSignedByteStrategy
    {
        public sbyte Calculate(sbyte first, sbyte second)
        {
            return (sbyte)(first ^ second);
        }
    }
}
