namespace Calculator.Interfaces
{
    using System;
    using System.Threading;

    using Events;

    public interface ICalculationHandler
    {
        event ChangeTextEventHandler InputChanged;
        event ChangeTextEventHandler OutputChanged;
        event ChangeTextEventHandler InputBitViewChanged;
        event ChangeTextEventHandler OutputBitViewChanged;

        event EventHandler ReceiveNonEmptyResult;

        void Execute(string input);

        void SwitchNumericType(string numericType);

        void SwitchBase(string newBaseName);

        void Clear();

        void CalculationHandlerThreadExceptionHandlingMethod(object sender, ThreadExceptionEventArgs args);
    }
}
