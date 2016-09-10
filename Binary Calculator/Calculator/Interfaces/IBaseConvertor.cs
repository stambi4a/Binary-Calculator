namespace Calculator.Interfaces
{
    using System;

    public interface IBaseConvertor
    {
        object ConvertInputFromBase(Type numericType, string baseNumber, int baseOfConversion);

        string ConvertResultToBase(object number, int baseOfConversion);
    }
}
