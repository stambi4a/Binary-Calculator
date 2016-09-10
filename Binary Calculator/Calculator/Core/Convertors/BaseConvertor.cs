namespace Calculator.Core.Convertors
{
    using System;
    using System.ComponentModel;
    using System.Reflection;

    using Calculator.Interfaces;
    using Calculator.Utilities;

    public abstract class BaseConvertor : IBaseConvertor
    {
        public object ConvertInputFromBase(Type numericType, string baseNumber, int baseOfConversion)
        {
            var convertMethod = typeof(Convert).GetMethod(
                "To" + numericType.Name,
                BindingFlags.Static | BindingFlags.Public,
                null,
                new[] { typeof(string), typeof(int) },
                null);

            var number = convertMethod.Invoke(null, new object[] { baseNumber, baseOfConversion });

            return number;
        }

        public string ConvertResultToBase(object number, int baseOfConversion)
        {
            var numberType = number is ulong ? typeof(long) : number.GetType();
            number = number is ulong ? (long)(ulong)number : number;
            var convertMethod = typeof(Convert).GetMethod(
                Constants.ToStringMethodName,
                BindingFlags.Static | BindingFlags.Public,
                null,
                new[] { numberType, typeof(int) },
                null);

            var binaryNumber = convertMethod.Invoke(number, new[] { number, baseOfConversion });
            if ((number is byte || number is sbyte) && binaryNumber.ToString().Length == 2 * Constants.BitsInAByte)
            {
                return binaryNumber.ToString().Substring(Constants.BitsInAByte, Constants.BitsInAByte);
            }

            return binaryNumber.ToString();
        }
    }
}
