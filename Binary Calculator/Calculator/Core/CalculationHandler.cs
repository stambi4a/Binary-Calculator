namespace Calculator.Core
{
    using System;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    using Calculator.Attributes;
    using Calculator.Core.Convertors;
    using Calculator.Events;
    using Calculator.Exceptions;
    using Calculator.Utilities;

    using Interfaces;

    [Core]
    public class CalculationHandler : ICalculationHandler
    {
        [Inject]
        private readonly ICalculationExecutor calculationExecutor;

        private IBaseConvertor currentBaseConvertor;

        private readonly IBaseConvertor binConvertor;
        private readonly IRepositoryHandler repositoryHandler;
        private readonly IDependencyContainer dependencyContainer;
        private readonly IMethodInvoker methodInvoker;
        private readonly IValueExtractor valueExtractor;

        private string currentOutput;
        private string currentInput;
        private string currentInputBitView;
        private string currentOutputBitView;

        private Type currentNumericType;

        public event ChangeTextEventHandler InputChanged;
        public event ChangeTextEventHandler OutputChanged;
        public event ChangeTextEventHandler InputBitViewChanged;
        public event ChangeTextEventHandler OutputBitViewChanged;

        public event EventHandler ReceiveNonEmptyResult;

        public CalculationHandler(
            IRepositoryHandler repositoryHandler, 
            IDependencyContainer dependencyContainer,
            IMethodInvoker methodInvoker,
            IValueExtractor valueExtractor)
        {
            this.repositoryHandler = repositoryHandler;
            this.dependencyContainer = dependencyContainer;
            this.binConvertor = new BinBaseConvertor();
            this.methodInvoker = methodInvoker;
            this.valueExtractor = valueExtractor;
            this.SetDefaults();
            Application.ThreadException += this.CalculationHandlerThreadExceptionHandlingMethod;
        }

        public string CurrentInput
        {
            get
            {
                return this.currentInput;
            }

            private set
            {
                this.OnInputChanged(this, new ChangeTextEventArgs(value));
                this.currentInput = value;
            }
        }
        public string CurrentOutput
        {
            get
            {
                return this.currentOutput;
            }

            private set
            {
                this.OnOutputChanged(this, new ChangeTextEventArgs(value));
                this.currentOutput = value;
            }
        }

        public string CurrentInputBitView
        {
            get
            {
                return this.currentInputBitView;
            }

            private set
            {
                this.OnBitViewInputChanged(this, new ChangeTextEventArgs(value));
                this.currentInputBitView = value;
            }
        }

        public string CurrentOutputBitView
        {
            get
            {
                return this.currentOutputBitView;
            }

            private set
            {
                this.OnBitViewOutputChanged(this, new ChangeTextEventArgs(value));
                this.currentOutputBitView = value;
            }
        }

        public void Execute(string input)
        {
            var result = this.calculationExecutor.ProcessInput(input, this.currentNumericType, this.currentBaseConvertor);
            if (result == null)
            {
                return;
            }

            if (result[2] != null)
            {
                this.SetInput(0);
                this.SetOutput(0);
                
            }
 
            if (result[0] != null)
            {
                this.CurrentInput = this.valueExtractor.GetStringValueOfNumber(result[0], this.currentBaseConvertor);
                this.CurrentInputBitView = this.SetBitsValue(result[0]);
            }

            if (result[1] == null)
            {
                return;
            }

            this.OnReceiveResult(this, null);
            this.SetOutput(result[1]);
        }

        public void OnInputChanged(object sender, ChangeTextEventArgs args)
        {
            this.InputChanged?.Invoke(sender, args);
        }

        public void OnOutputChanged(object sender, ChangeTextEventArgs args)
        {
            this.OutputChanged?.Invoke(sender, args);
        }

        public void OnBitViewInputChanged(object sender, ChangeTextEventArgs args)
        {
            this.InputBitViewChanged?.Invoke(sender, args);
        }

        public void OnBitViewOutputChanged(object sender, ChangeTextEventArgs args)
        {
            this.OutputBitViewChanged?.Invoke(sender, args);
        }

        public void SwitchNumericType(string numericTypeName)
        {
            if (this.currentNumericType == null)
            {
                this.currentNumericType = Type.GetType(Constants.NumericNamespace + numericTypeName);
                return;
            }

            this.SetInput(0);
            this.SetOutput(0);
            this.currentNumericType = Type.GetType(Constants.NumericNamespace + numericTypeName);
            var currentInputValue = this.valueExtractor.GetDecimalValueOfNumber(this.currentInput, this.currentBaseConvertor, this.currentNumericType);
            var currentOutputValue = this.valueExtractor.GetDecimalValueOfNumber(this.currentOutput, this.currentBaseConvertor, this.currentNumericType);
            this.SetInput(currentInputValue);
            this.SetOutput(currentOutputValue);
            this.calculationExecutor.SwitchNumericType(this.currentNumericType);
        }

        public void SwitchBase(string newBaseName)
        {
            var decimalValue = this.valueExtractor.GetDecimalValueOfNumber(this.CurrentOutput, this.currentBaseConvertor, this.currentNumericType);
            var convertorName = NameGenerator.GenerateConvertorName(newBaseName);
            this.SwitchBaseConvertor(convertorName);           
            this.CurrentOutput = this.valueExtractor.GetStringValueOfNumber(decimalValue, this.currentBaseConvertor);
            this.Clear();
        }

        public void Clear()
        {
            this.calculationExecutor.Clear();
        }

        private void SetInput(object inputField)
        {
            this.CurrentInput = this.valueExtractor.GetStringValueOfNumber(inputField, this.currentBaseConvertor);
            this.CurrentInputBitView = this.SetBitsValue(inputField);
        }

        private void SetOutput(object outputField)
        {
            this.CurrentOutput = this.valueExtractor.GetStringValueOfNumber(outputField, this.currentBaseConvertor);
            this.CurrentOutputBitView = this.SetBitsValue(outputField);
        }

        private void SwitchBaseConvertor(string convertorName)
        {
            this.currentBaseConvertor = (IBaseConvertor)this.dependencyContainer.GetComponent(convertorName, new[] { this.currentNumericType });
        }

        private void SetDefaults()
        {
            var convertorDefaultName = NameGenerator.GenerateConvertorName(Constants.DecimalBaseName);
            this.SwitchBaseConvertor(convertorDefaultName);
            this.SwitchNumericType(Constants.SignedInt64Name);
            this.SetInput(0);
            this.SetOutput(0);
        }

        private string SetBitsValue(object fieldValue)
        {
            var binaryNumber = this.valueExtractor.GetStringValueOfNumber(fieldValue, this.binConvertor);
            var bitSetCapacity = Marshal.SizeOf(this.currentNumericType) * Constants.BitsInAByte;
            try
            {
                binaryNumber = new string('0', bitSetCapacity - binaryNumber.Length) + binaryNumber;
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException(null, null, ExceptionConstants.UntrimmableBitValueExceptionMessage);
            }
            

            var builder = new StringBuilder();
            for (var i = 0; i < bitSetCapacity; i++)
            {
                builder.Append(binaryNumber[i]);
                if ((i + 1) % 8 == 0)
                {
                    builder.Append(FormConstants.ErrorStatusPrefix);
                }
            }

            builder.Length -= 1;
            var bitsValue = builder.ToString();

            return bitsValue;
        }
        public void CalculationHandlerThreadExceptionHandlingMethod(object sender, ThreadExceptionEventArgs args)
        {
            var exception = args.Exception;
            while (exception.InnerException != null)
            {
                exception = exception.InnerException;
            }

            if (!(exception is OverflowException || exception is InvalidKeyPressedException))
            {
                this.SetInput(0);
            }

            if (args.Exception is TargetInvocationException)
            {
                this.SetOutput(0);
            }
            
            if (args.Exception is InvalidKeyPressedException)
            {
                this.SetOutput(0);
            }


            this.calculationExecutor.CalculationExecutorThreadExceptionHandlingMethod(sender, args);
        }

        public void OnReceiveResult(object sender, EventArgs args)
        {
            this.ReceiveNonEmptyResult?.Invoke(sender, args);
        }
    }
}