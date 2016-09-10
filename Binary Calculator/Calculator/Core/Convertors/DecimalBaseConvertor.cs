namespace Calculator.Core.Convertors
{
    using System;

    using Calculator.Attributes;

    [ConvertorComponent("Decimal")]
    public class DecimalBaseConvertor : BaseConvertor
    {
        private const int DecimalBaseOfConversion = 10;
        public object ConvertInputFromDecimalBase(Type numericType, string baseNumber)
        {
            return base.ConvertInputFromBase(numericType, baseNumber, DecimalBaseOfConversion);
        }

        public string ConvertResultToDecimalBase(object number)
        {
            return number.ToString();
        }
    }
}
