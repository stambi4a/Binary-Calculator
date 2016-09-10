namespace Calculator.Core
{
    using System;
    using System.Reflection;

    using Calculator.Attributes;
    using Calculator.Interfaces;
    using Calculator.Utilities;

    [Core]
    public sealed class ValueExtractor : IValueExtractor
    {
        private readonly IMethodInvoker methodInvoker;

        public ValueExtractor(IMethodInvoker methodInvoker)
        {
            this.methodInvoker = methodInvoker;
        }

        public string GetStringValueOfNumber(object number, IBaseConvertor baseConvertor)
        {
            var attr =
                (ConvertorComponentAttribute)
                baseConvertor.GetType().GetCustomAttribute(typeof(ConvertorComponentAttribute));
            var modifier = attr.Name;
            var convertorMethodName = NameGenerator.GenerateMethodName(
                Constants.ConvertToBasePrefix,
                modifier,
                Constants.BaseSuffix);
            var convertMethod = this.methodInvoker.GetMethodByName(baseConvertor.GetType(), convertorMethodName);

            var fieldValue = convertMethod.Invoke(baseConvertor, new[] { number }).ToString().ToUpper();

            return fieldValue;
        }

        public object GetDecimalValueOfNumber(string baseValue, IBaseConvertor baseConvertor, Type numericType)
        {
            var attr =
                (ConvertorComponentAttribute)
                baseConvertor.GetType().GetCustomAttribute(typeof(ConvertorComponentAttribute));
            var modifier = attr.Name;
            var convertorMethodName = NameGenerator.GenerateMethodName(
                Constants.ConvertFromBasePrefix,
                modifier,
                Constants.BaseSuffix);
            var convertMethod = this.methodInvoker.GetMethodByName(baseConvertor.GetType(), convertorMethodName);

            var fieldValue = convertMethod.Invoke(baseConvertor, new object[] { numericType, baseValue });

            return fieldValue;
        }
    }
}
