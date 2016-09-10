namespace Calculator.Core.Convertors
{
    using System;

    using Calculator.Attributes;

    [ConvertorComponent("Hex")]
    public class HexBaseConvertor : BaseConvertor
    {
        private const int HexBaseOfConversion = 16;
        public object ConvertInputFromHexBase(Type numericType, string baseNumber)
        {
            return base.ConvertInputFromBase(numericType, baseNumber, HexBaseOfConversion);
        }

        public string ConvertResultToHexBase(object number)
        {
            return base.ConvertResultToBase(number, HexBaseOfConversion);
        }
    }
}
