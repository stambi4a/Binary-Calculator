namespace Calculator.Core.Strategies.SignedInt16Strategies.UnaryStrategies
{
    using Attributes;

    [Component]
    public class BitwiseNotOperationSignedInt16Strategy
    {
        public short Calculate(short element)
        {
            return (short)~element;
        }
    }
}
