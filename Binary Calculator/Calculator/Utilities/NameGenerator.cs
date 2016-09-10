namespace Calculator.Utilities
{
    using System;

    public class NameGenerator
    {
        public static string GenerateStrategyName(Type type, string nameParameter)
        {
            var isSigned = type.Name == "SByte" || type.Name.StartsWith("Int");
            var signedTitle = isSigned ? "Signed" : "Unsigned";
            var isByte = type.Name.EndsWith("Byte");
            var typeTitle = isByte ? "Byte" : type.Name.Replace("U", string.Empty);
            var strategyName = nameParameter + "Operation" + signedTitle + typeTitle + "Strategy";

            return strategyName;
        }

        public static string GenerateConvertorName(string nameParameter)
        {
            var convertorName = nameParameter + Constants.ConvertorSuffix;

            return convertorName;
        }

        public static string GenerateMethodName(string prefix, string modifier, string suffix)
        {
            return prefix + modifier + suffix;
        }
    }
}
