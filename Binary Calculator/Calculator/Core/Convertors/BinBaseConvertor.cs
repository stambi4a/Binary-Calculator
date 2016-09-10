namespace Calculator.Core.Convertors
{
    using System;

    using Calculator.Attributes;

    [ConvertorComponent("Bin")]
    public class BinBaseConvertor : BaseConvertor
    {
        private const int BinBaseOfConversion = 2;
        public object ConvertInputFromBinBase(Type numericType, string baseNumber)
        {
            return base.ConvertInputFromBase(numericType, baseNumber, BinBaseOfConversion);
        }

        public string ConvertResultToBinBase(object number)
        {
            return base.ConvertResultToBase(number, BinBaseOfConversion);
        }
    }
}
