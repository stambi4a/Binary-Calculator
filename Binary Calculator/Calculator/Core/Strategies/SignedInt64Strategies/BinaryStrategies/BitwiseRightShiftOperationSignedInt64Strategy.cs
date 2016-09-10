namespace Calculator.Core.Strategies.SignedInt64Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    [Component]
    public class BitwiseRightShiftOperationSignedInt64Strategy
    {
        public long Calculate(long first, long element)
        {
            var second = (int)element;

            return first >> second;
        }
    }
}
