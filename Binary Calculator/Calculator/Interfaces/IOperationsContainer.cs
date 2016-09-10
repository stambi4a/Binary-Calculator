namespace Calculator.Interfaces
{
    using System;

    public interface IOperationsContainer
    {
        ICalculationHandler CalculationHandler { get; }

        void Execute(string input);

        void RestoreResultFromMemory();
    }
}