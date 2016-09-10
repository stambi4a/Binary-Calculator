namespace Calculator.Core.Strategies.SignedInt64Strategies.BinaryStrategies
{
    using Calculator.Attributes;


    [Component]
    public class ModOperationSignedInt64Strategy 
    {
        public long Calculate(long first, long second)
        {
            return first % second;
        }
    }
}
