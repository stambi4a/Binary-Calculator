namespace Calculator.Interfaces
{
    using System;
    using System.Threading;

    public interface ICalculationExecutor
    {
        object[] ProcessInput(string input, Type currentNumericType, IBaseConvertor baseConvertor);

        void Clear();

        void ClearAll();

        void CalculationExecutorThreadExceptionHandlingMethod(object sender, ThreadExceptionEventArgs args);

        void SwitchNumericType(Type newNumericType);
    }
}
