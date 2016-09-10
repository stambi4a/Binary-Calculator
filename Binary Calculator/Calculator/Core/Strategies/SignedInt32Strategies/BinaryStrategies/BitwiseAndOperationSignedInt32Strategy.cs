namespace Calculator.Core.Strategies.SignedInt32Strategies.BinaryStrategies
{
    using Calculator.Attributes;

    using Calculator.Exceptions;

    [Component]
    public class BitwiseAndOperationSignedInt32Strategy
    {
        public int Calculate(int first, int second)
        {
            return first & second;
        }
    }
}
