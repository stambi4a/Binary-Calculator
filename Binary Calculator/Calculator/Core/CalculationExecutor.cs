﻿namespace Calculator.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    using Calculator.Attributes;
    using Calculator.Exceptions;
    using Calculator.Interfaces;
    using Calculator.Utilities;

    [Core]
    public class CalculationExecutor : ICalculationExecutor
    {
        private const int ReturnDataCount = 3;
        private readonly IDictionary<string, string> binaryOperators = new Dictionary<string, string>
                                                                                  {
            {Constants.AddSign, Constants.AddPrefix },
            {Constants.SubtractSign, Constants.SubtractPrefix },
            {Constants.MultiplySign, Constants.MultiplyPrefix },
            {Constants.DivideSign, Constants.DividePrefix },
            {Constants.ModSign, Constants.ModPrefix },
            {Constants.BitwiseRotationLeftSign, Constants.BitwiseRotationLeftPrefix },
            {Constants.BitwiseRotationRightSign, Constants.BitwiseRotationRightPrefix },
            {Constants.BitwiseRightShiftSign, Constants.BitwiseRightShiftPrefix },
            {Constants.BitwiseLeftShiftSign, Constants.BitwiseLeftShiftPrefix },
            {Constants.BitwiseAndSign, Constants.BitwiseAndPrefix },
            {Constants.BitwiseOrSign, Constants.BitwiseOrPrefix },
            {Constants.BitwiseXorSign, Constants.BitwiseXorPrefix },
                                                                                  };

        private readonly IDictionary<string, string> unarySuffixOperators = new Dictionary<string, string>()
                                                                                       {
            { Constants.IncrementSign, Constants.IncrementPrefix },
            { Constants.DecrementSign, Constants.DecrementPrefix },
            { Constants.ChangeSignSign, Constants.ChangeSignPrefix }
                                                                                       };

        private readonly IDictionary<string, string> unaryPrefixOperators = new Dictionary<string, string>
                                                               {
            {Constants.BitwiseNotSign, Constants.BitwiseNotPrefix },
                                                               };
        private readonly IDictionary<string, int> operatorsPrecedence = new Dictionary<string, int>()
                                                                                   {
            { Constants.IncrementSign, 7 },
            { Constants.DecrementSign, 7 },
            { Constants.ChangeSignSign, 6 },
            { Constants.BitwiseNotSign, 6 },
            { Constants.MultiplySign, 5 },
            { Constants.DivideSign, 5 },
            { Constants.ModSign, 5 },
            { Constants.AddSign, 4 },
            { Constants.SubtractSign, 4 },
            { Constants.BitwiseLeftShiftSign, 3 },
            { Constants.BitwiseRightShiftSign, 3 },
            { Constants.BitwiseRotationLeftSign, 3 },
            { Constants.BitwiseRotationRightSign, 3 },
            { Constants.BitwiseAndSign, 2 },
            { Constants.BitwiseXorSign, 1 },
            { Constants.BitwiseOrSign, 0 },
                                                                                   };

        private readonly ISet<string> digits = new HashSet<string>()
                                                          {
                                                              Constants.DigitZero, 
                                                              Constants.DigitOne,
                                                              Constants.DigitTwo,
                                                              Constants.DigitThree,
                                                              Constants.DigitFour,
                                                              Constants.DigitFive,
                                                              Constants.DigitSix,
                                                              Constants.DigitSeven,
                                                              Constants.DigitEight,
                                                              Constants.DigitNine,
                                                              Constants.DigitTen,
                                                              Constants.DigitEleven,
                                                              Constants.DigitTwelve,
                                                              Constants.DigitThirteen,
                                                              Constants.DigitFourteen,
                                                              Constants.DigitFifteen,
                                                              Constants.DigitZeroZero,
                                                              Constants.DigitZeroOne,
                                                              Constants.DigitOneZero,
                                                              Constants.DigitOneOne
                                                          };
        private readonly ISet<string> specialOperations = new HashSet<string>
                                                              {
                                                                  Constants.ClearPrefix,
                                                                  Constants.ClearLastPrefix,
                                                                  Constants.AddToMemoryPrefix,
                                                                  Constants.SubtractFromMemoryPrefix,
                                                                  Constants.MemoryClearPrefix,
                                                                  Constants.MemoryRestorePrefix
                                                              };
        private readonly StringBuilder currentNumberBuilder;
        private readonly IValueExtractor valueExtractor;
        private readonly IDependencyContainer dependencyContainer;
        private readonly IMethodInvoker methodInvoker;
        private readonly List<List<object>> numbers;
        private readonly List<List<string>> operators;
        private readonly List<object> addedToMemoryResults;
        private readonly List<string> currentIterationInputs;

        private object currentResult;
        private string previousInput;
        private string currentInput;

        public CalculationExecutor(IDependencyContainer dependencyContainer, IValueExtractor valueExtractor, IMethodInvoker methodInvoker)
        {
            this.valueExtractor = valueExtractor;
            this.methodInvoker = methodInvoker;
            this.dependencyContainer = dependencyContainer;
            this.currentNumberBuilder = new StringBuilder();
            this.numbers = new List<List<object>> { new List<object>() };
            this.operators = new List<List<string>> { new List<string>() };
            this.addedToMemoryResults = new List<object>();
            this.currentIterationInputs = new List<string>();
            this.currentResult = null;
            this.previousInput = null;
            this.currentInput = null;
            Application.ThreadException += this.CalculationExecutorThreadExceptionHandlingMethod;
        }

        public int Count => this.numbers.Count;

        public object[] ProcessInput(string input, Type currentNumericType, IBaseConvertor baseConvertor)
        {
            this.currentInput = input;
            var data = new object[ReturnDataCount];
            if (this.specialOperations.Contains(input))
            {
                data = this.PerformSpecialOperation(input, currentNumericType, baseConvertor);

                return data;
            }

            if (this.digits.Contains(input))
            {
                if (this.previousInput != null && this.unarySuffixOperators.ContainsKey(this.previousInput))
                {
                    return null;
                }

                if (this.operators[this.Count - 1].Count == 0 && this.currentResult != null)
                {
                    this.currentResult = null;
                }

                if (this.numbers[this.Count - 1].Count > 0 && this.operators[this.Count - 1].Count == 0)
                {
                    this.numbers.RemoveAt(this.numbers[this.Count - 1].Count - 1);
                    this.currentResult = null;
                }

                if (this.currentNumberBuilder.Length == 0 && this.currentResult != null)
                {
                    this.numbers[this.Count - 1].Add(this.currentResult);
                    this.currentResult = null;
                }

                this.currentNumberBuilder.Append(input);
                this.currentInput = input;
                this.previousInput = input;
                this.currentIterationInputs.Add(input);
                var baseValue = this.currentNumberBuilder.ToString();
                this.currentResult = this.valueExtractor.GetDecimalValueOfNumber(baseValue,  baseConvertor, currentNumericType);
                data[0] = this.currentResult;
               

                return data;
            }

            if (input == Constants.LeftBracket)
            {
                if ((this.numbers[this.Count - 1].Count > 0 || this.currentResult != null)
                    && (this.previousInput == null || !this.binaryOperators.ContainsKey(this.previousInput)))
                {
                    return null;
                }

                this.numbers[this.Count - 1].Add(this.currentResult);
                this.currentResult = null;
                this.numbers.Add(new List<object>());
                this.operators.Add(new List<string>());

                return null;
            }

            if (input == Constants.RightBracket)
            {
                if (this.operators.Count == 1)
                {
                    return null;
                }

                if (this.currentNumberBuilder.Length != 0)
                {
                    this.Clear();
                }

                var operatorGroup = this.operators[this.Count - 1];
                var numbersGroup = this.numbers[this.Count - 1];

                while (operatorGroup.Count > 0)
                {
                    var currentOperator = operatorGroup[operatorGroup.Count - 1];
                    operatorGroup.RemoveAt(operatorGroup.Count - 1);
                    this.currentResult = this.Calculate(currentOperator, currentNumericType, numbersGroup);
                }

                this.operators.RemoveAt(this.Count - 1);
                this.numbers.RemoveAt(this.Count - 1);
                data[1] = this.currentResult;

                return data;
            }

            if (input == Constants.DeleteSign)
            {
                if (this.currentNumberBuilder.Length == 0)
                {
                    return null;
                }

                this.currentNumberBuilder.Length--;
                this.previousInput = this.currentNumberBuilder.Length > 0
                                         ? this.currentNumberBuilder[this.currentNumberBuilder.Length - 1].ToString(
                                             )
                                         : null;
                if (this.previousInput != null)
                {
                    this.currentIterationInputs.RemoveAt(this.currentIterationInputs.Count - 1);
                    var baseValue = this.currentNumberBuilder.ToString();
                    this.currentResult = this.valueExtractor.GetDecimalValueOfNumber(
                        baseValue,
                        baseConvertor,
                        currentNumericType);
                    data[0] = this.currentResult;
                }
                else
                {
                    data[0] = 0;
                    this.currentResult = 0;
                }

                return data;
            }

            if (input == Constants.EqualSign)
            {
                this.Clear();
                while (this.operators.Count > 0)
                {
                    var operatorGroup = this.operators[this.Count - 1];
                    var numbersGroup = this.numbers[this.Count - 1];

                    while (operatorGroup.Count > 0)
                    {
                        var currentOperator = operatorGroup[operatorGroup.Count - 1];
                        operatorGroup.RemoveAt(operatorGroup.Count - 1);
                        this.currentResult = this.Calculate(currentOperator, currentNumericType, numbersGroup);
                    }

                    this.operators.RemoveAt(this.Count - 1);
                    this.numbers.RemoveAt(this.Count - 1);
                }

                this.operators.Add(new List<string>());
                this.numbers.Add(new List<object>());
                this.previousInput = input;
                this.currentIterationInputs.Add(input);

                data[1] = this.currentResult;

                return data;
            }

            if (this.binaryOperators.ContainsKey(input))
            {
                if (this.previousInput == null)
                {
                    return null;
                }

                if (this.binaryOperators.ContainsKey(this.previousInput))
                {
                    this.previousInput = input;
                    this.currentIterationInputs.Add(input);
                    this.operators[this.Count - 1].RemoveAt(this.operators[this.Count - 1].Count - 1);
                    this.operators[this.Count - 1].Add(input);

                    return null;
                }

                if (this.unaryPrefixOperators.ContainsKey(this.previousInput))
                {
                    return null;
                }

                if (this.unarySuffixOperators.ContainsKey(this.previousInput))
                {
                    var previousOperators = new Queue<string>();
                    while (this.operators[this.Count - 1].Count > 0 && this.operatorsPrecedence[input]
                           < this.operatorsPrecedence[this.operators[this.Count - 1].Last()])
                    {
                        previousOperators.Enqueue(this.operators[this.Count - 1].Last());
                        this.operators[this.Count - 1].RemoveAt(this.operators[this.Count - 1].Count - 1);
                    }

                    this.operators[this.Count - 1].Add(input);

                    while (previousOperators.Count > 0)
                    {
                        this.currentResult = this.Calculate(
                            previousOperators.Dequeue(),
                            currentNumericType,
                            this.numbers[this.Count - 1]);
                    }

                    data[1] = this.currentResult;

                    return data;
                }

                if (this.digits.Contains(this.previousInput))
                {
                    this.Clear();
                    while (this.operators[this.Count - 1].Count > 0 && this.operatorsPrecedence[this.operators[this.Count - 1].Last()]
                        >= this.operatorsPrecedence[input])
                    {
                        var currentOperator = this.operators[this.Count - 1].Last();
                        this.operators[this.Count - 1].RemoveAt(this.operators[this.Count - 1].Count - 1);
                        this.currentResult = this.Calculate(currentOperator, currentNumericType, this.numbers[this.Count - 1]);
                        data[1] = this.currentResult;
                    }

                    this.operators[this.Count - 1].Add(input);
                    this.previousInput = input;
                    this.currentIterationInputs.Add(input);

                    return data;
                }

                if (this.previousInput == Constants.EqualSign)
                {
                    this.operators[this.Count - 1].Add(input);
                    this.previousInput = input;
                    this.currentIterationInputs.Add(input);

                    return null;
                }

                return null;
            }

            if (this.unarySuffixOperators.ContainsKey(input))
            {
                if (this.binaryOperators.ContainsKey(this.previousInput)
                    || this.unarySuffixOperators.ContainsKey(this.previousInput))
                {
                    this.previousInput = input;
                    this.currentIterationInputs.Add(input);
                    this.operators[this.Count - 1].RemoveAt(this.operators[this.Count - 1].Count - 1);
                    this.operators[this.Count - 1].Add(input);
                }

                if (this.digits.Contains(this.previousInput))
                {
                    this.Clear();
                    if (this.operators[this.Count - 1].Count > 0 && this.unaryPrefixOperators.ContainsKey(this.operators[this.Count - 1].Last()))
                    {
                        var currentOperator = this.operators[this.Count - 1].Last();
                        this.operators[this.Count - 1].RemoveAt(this.operators[this.Count - 1].Count - 1);
                        this.currentResult = this.Calculate(currentOperator, currentNumericType, this.numbers[this.Count - 1]);
                        data[1] = this.currentResult;
                    }

                    this.operators[this.Count - 1].Add(input);
                    this.previousInput = input;
                    this.currentIterationInputs.Add(input);

                    return data;
                }

                if (this.previousInput == Constants.EqualSign)
                {
                    this.operators[this.Count - 1].Add(input);
                    this.previousInput = input;
                    this.currentIterationInputs.Add(input);
                }

                return null;
            }

            if (this.unaryPrefixOperators.ContainsKey(input))
            {
                if (this.previousInput != null 
                    && (this.digits.Contains(this.previousInput)
                    || this.unarySuffixOperators.ContainsKey(this.previousInput)))
                {
                    return null;
                }

                if (this.operators[this.Count - 1].Count == 0 && this.currentResult != null)
                {
                    this.currentResult = null;
                    this.numbers.Clear();
                    this.numbers.Add(new List<object>());
                }

                this.operators[this.Count - 1].Add(input);
                this.previousInput = input;
                this.currentIterationInputs.Add(input);

                return null;
            }

            throw new InvalidInputException();
        }

        public void Clear()
        {
            this.currentNumberBuilder.Clear();
        }

        public void ClearAll()
        {
            this.Reset();
            this.addedToMemoryResults.Clear();
        }

        public void Reset()
        {
            this.ResetIteration();
            this.currentIterationInputs.Clear();
        }

        public void ResetIteration()
        {
            this.numbers.Clear();
            this.numbers.Add(new List<object>());
            this.operators.Clear();
            this.operators.Add(new List<string>());
            this.currentResult = null;
            this.previousInput = null;
            this.currentInput = null;
            this.Clear();
        }

        public void SwitchNumericType(Type newNumericType)
        {
            if (this.currentResult != null)
            {
                this.currentResult = this.SwitchNumberNumericType(this.currentResult, newNumericType);
            }

            foreach (var numberGroup in this.numbers)
            {
                for (var i = 0; i < numberGroup.Count; i++)
                {
                    numberGroup[i] = this.SwitchNumberNumericType(numberGroup[i], newNumericType);
                }
            }

            for(var i = 0; i < this.addedToMemoryResults.Count; i++)
            {
                this.addedToMemoryResults[i] = this.SwitchNumberNumericType(this.addedToMemoryResults[i], newNumericType);
            }
        }

        public void CalculationExecutorThreadExceptionHandlingMethod(object sender, ThreadExceptionEventArgs args)
        {
            var exception = args.Exception;
            while (exception.InnerException != null)
            {
                exception = exception.InnerException;
            }

            var exceptionType = exception.GetType();

            if (exceptionType == typeof(InvalidInputException))
            {
                this.currentNumberBuilder.Length -= this.currentInput.Length;
            }

            if (exception is OverflowException)
            {
                if (this.currentNumberBuilder != null && this.currentNumberBuilder.Length > 0)
                {
                    this.currentNumberBuilder.Length -= this.currentInput.Length;
                    this.currentIterationInputs.RemoveAt(this.currentIterationInputs.Count - 1);
                }

                this.ClearAll();
            }

            else
            {
                this.Clear();
            }

            if (exceptionType.BaseType == typeof(ArgumentException))
            {
                this.previousInput = null;
                this.currentIterationInputs.RemoveAt(this.currentIterationInputs.Count - 1);
            }
        }

        private object[] PerformSpecialOperation(string operationName, Type currentNumericType, IBaseConvertor baseConverter)
        {
            var data = new object[ReturnDataCount];
            switch (operationName)
            {
                case Constants.ClearPrefix:
                    {
                        this.ClearAll();
                        data[2] = Constants.ClearPrefix;
                    }

                    break;
                case Constants.ClearLastPrefix:
                    {
                        this.ResetIteration();
                        data[2] = Constants.ClearLastPrefix;
                        if (this.currentIterationInputs.Count == 0)
                        {
                            return data;
                        }

                        this.currentIterationInputs.RemoveAt(this.currentIterationInputs.Count - 1);
                        var count = this.currentIterationInputs.Count;
                        if (count > 0)
                        {
                            for (var i = 0; i < count - 1; i++)
                            {
                                var input = this.currentIterationInputs[i];
                                this.ProcessInput(input, currentNumericType, baseConverter);
                                this.currentIterationInputs.RemoveAt(this.currentIterationInputs.Count - 1);
                            }

                            {
                                var input = this.currentIterationInputs[count - 1];
                                data = this.ProcessInput(input, currentNumericType, baseConverter);
                                this.currentIterationInputs.RemoveAt(this.currentIterationInputs.Count - 1);
                            }
                        }
                    }

                    break;

                case Constants.AddToMemoryPrefix:
                    {
                        if (this.currentResult != null)
                        {
                            this.addedToMemoryResults.Add(this.currentResult);
                        }
                    }

                    break;
                case Constants.SubtractFromMemoryPrefix:
                    {
                        if (this.addedToMemoryResults.Count > 0)
                        {
                            this.addedToMemoryResults.RemoveAt(this.addedToMemoryResults.Count - 1);
                            data[0] = 0;
                        }
                    }

                    break;
                case Constants.MemoryClearPrefix:
                    {
                        this.addedToMemoryResults.Clear();
                        return null;
                    }

                case Constants.MemoryRestorePrefix:
                    {
                        var count = this.addedToMemoryResults.Count;
                        this.currentResult = 0;
                        data[0] = 0;
                        data[1] = this.currentResult;
                        if (count > 0)
                        {
                            for (var i = 0; i < count; i++)
                            {
                                var result = this.addedToMemoryResults[i];
                                this.currentResult = this.Calculate(Constants.AddSign, currentNumericType, new List<object> { result });
                            }

                            data[0] = 0;
                            data[1] = this.currentResult;
                        }
                    }

                    break;

                default:
                    throw new UnimplementedOperationException();
            }

            return data;
        }

        private object Calculate(string operatorName, Type numericType, IList<object> numberGroup)
        {
            if (this.binaryOperators.ContainsKey(operatorName))
            {
                var componentPrefix = this.binaryOperators[operatorName];
                var componentName = NameGenerator.GenerateStrategyName(numericType, componentPrefix);
                var component = this.dependencyContainer.GetComponent(componentName, new[] { numericType });
                var method = this.methodInvoker.GetMethodByName(component.GetType(), Constants.CalculateMethodName);
                object operand = null;
                if (numberGroup.Count > 0)
                {
                    operand = numberGroup[numberGroup.Count - 1];
                    numberGroup.RemoveAt(numberGroup.Count - 1);
                }
                else
                {
                    operand = this.currentResult;
                }
                
                var result = method.Invoke(component, new object[] { operand, this.currentResult  });

                return result;
            }

            if (this.unarySuffixOperators.ContainsKey(operatorName))
            {
                var componentPrefix = this.unarySuffixOperators[operatorName];
                var componentName = NameGenerator.GenerateStrategyName(numericType, componentPrefix);
                var component = this.dependencyContainer.GetComponent(componentName, new[] { numericType });
                var method = this.methodInvoker.GetMethodByName(component.GetType(), Constants.CalculateMethodName);
                var result = method.Invoke(component, new[] { this.currentResult});

                return result;
            }

            if (this.unaryPrefixOperators.ContainsKey(operatorName))
            {
                var componentPrefix = this.unaryPrefixOperators[operatorName];
                var componentName = NameGenerator.GenerateStrategyName(numericType, componentPrefix);
                var component = this.dependencyContainer.GetComponent(componentName, new[] { numericType });
                var method = this.methodInvoker.GetMethodByName(component.GetType(), Constants.CalculateMethodName);
                var result = method.Invoke(component, new[] { this.currentResult });

                return result;
            }

            return null;
        }

        private object SwitchNumberNumericType(object number, Type newNumericType)
        {
            number = Convert.ChangeType(number, newNumericType);
            return number;
        }
    }
}
