namespace Calculator.Core.Convertors
{
    using System;

    using Attributes;

    [ConvertorComponent("Oct")]
    public class OctBaseConvertor : BaseConvertor
    {
        private const int OctBaseOfConversion = 8;
        public object ConvertInputFromOctBase(Type numericType, string baseNumber)
        {
            return base.ConvertInputFromBase(numericType, baseNumber, OctBaseOfConversion);
        }

        public string ConvertResultToOctBase(object number)
        {
            return base.ConvertResultToBase(number, OctBaseOfConversion);
        }
    }
}
