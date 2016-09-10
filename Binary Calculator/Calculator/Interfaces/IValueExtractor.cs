namespace Calculator.Interfaces
{
    using System;

    public interface IValueExtractor
    {
        string GetStringValueOfNumber(object number, IBaseConvertor baseConvertor);

        object GetDecimalValueOfNumber(string baseValue, IBaseConvertor baseConvertor, Type numericType);
    }
}
