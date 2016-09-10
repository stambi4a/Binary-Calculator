namespace Calculator.Forms
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    using System.Windows.Input;

    using Calculator.Events;
    using Calculator.Exceptions;
    using Calculator.Interfaces;
    using Calculator.Utilities;

    using Properties;

    using KeyEventArgs = System.Windows.Forms.KeyEventArgs;
    using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

    public partial class BinaryCalculator : Form
    {
        private readonly IOperationsContainer operationsContainer;
        public BinaryCalculator(IOperationsContainer operationsContainer)
        {
            this.InitializeComponent();
            this.operationsContainer = operationsContainer;
            this.operationsContainer.CalculationHandler.InputChanged += this.InputFieldTextChanged;
            this.operationsContainer.CalculationHandler.OutputChanged += this.OutputFieldTextChanged;
            this.operationsContainer.CalculationHandler.InputBitViewChanged += this.InputBitViewFieldTextChanged;
            this.operationsContainer.CalculationHandler.OutputBitViewChanged += this.OutputBitViewFieldTextChanged;
            this.operationsContainer.CalculationHandler.ReceiveNonEmptyResult += this.ReceivedNewResult;
            Application.ThreadException += this.BinaryCalculatorThreadExceptionHandlingMethod;

        }

        private void CalculatorLoad(object sender, EventArgs e)
        {
            this.InputFieldDoubleClick(sender, e);
        }

        #region Changed Events

        private void InputFieldTextChanged(object sender, EventArgs e)
        {

        }

        private void OutputFieldTextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Clicked Events

        private void MenuStripItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        #endregion

        #region Checked Events

        private void RadioButtonHexCheckedChanged(object sender, EventArgs e)
        {
            if (this.HexButton.Checked == false)
            {
                return;
            }

            this.panelDigits.Visible = false;
            this.panelHexDigits.Visible = true;
            this.panelOctDigits.Visible = false;
            this.panelDecimalDigits.Visible = false;
            this.operationsContainer.CalculationHandler.SwitchBase("Hex");
        }

        private void RadioButtonOctCheckedChanged(object sender, EventArgs e)
        {
            if (this.OctButton.Checked == false)
            {
                return;
            }

            this.panelDigits.Visible = false;
            this.panelHexDigits.Visible = false;
            this.panelOctDigits.Visible = true;
            this.panelDecimalDigits.Visible = false;
            this.operationsContainer.CalculationHandler.SwitchBase("Oct");
        }

        private void RadioButtonBinCheckedChanged(object sender, EventArgs e)
        {
            if (this.BinButton.Checked == false)
            {
                return;
            }

            this.panelDigits.Visible = true;
            this.panelHexDigits.Visible = false;
            this.panelOctDigits.Visible = false;
            this.panelDecimalDigits.Visible = false;
            this.operationsContainer.CalculationHandler.SwitchBase("Bin");
        }

        private void RadioButtonDecCheckedChanged(object sender, EventArgs e)
        {
            if (this.DecButton.Checked == false)
            {
                return;
            }

            this.panelDigits.Visible = false;
            this.panelHexDigits.Visible = false;
            this.panelOctDigits.Visible = false;
            this.panelDecimalDigits.Visible = true;
            this.operationsContainer.CalculationHandler.SwitchBase("Decimal");
        }

        private void RadioButtonQwordCheckedChanged(object sender, EventArgs e)
        {
            if (this.QwordButton.Checked)
            {
                this.operationsContainer.CalculationHandler.SwitchNumericType(Constants.SignedInt64Name);
            }
        }

        private void RadioButtonUnsignedQwordCheckedChanged(object sender, EventArgs e)
        {
            if (this.UnsignedQwordButton.Checked)
            {
                this.operationsContainer.CalculationHandler.SwitchNumericType(Constants.UnsignedInt64Name);
            }
        }

        private void RadioButtonDwordCheckedChanged(object sender, EventArgs e)
        {
            if (this.DwordButton.Checked)
            {
                this.operationsContainer.CalculationHandler.SwitchNumericType(Constants.SignedInt32Name);
            }
        }

        private void RadioButtonUnsignedDwordCheckedChanged(object sender, EventArgs e)
        {
            if (this.UnsignedDwordButton.Checked)
            {
                this.operationsContainer.CalculationHandler.SwitchNumericType(Constants.UnsignedInt32Name);
            }
        }

        private void RadioButtonWordCheckedChanged(object sender, EventArgs e)
        {
            if (this.WordButton.Checked)
            {
                this.operationsContainer.CalculationHandler.SwitchNumericType(Constants.SignedInt16Name);
            }
        }

        private void RadioButtonUnsignedWordCheckedChanged(object sender, EventArgs e)
        {
            if (this.UnsignedWordButton.Checked)
            {
                this.operationsContainer.CalculationHandler.SwitchNumericType(Constants.UnsignedInt16Name);
            }
        }

        private void RadioButtonByteCheckedChanged(object sender, EventArgs e)
        {
            if (this.ByteButton.Checked)
            {
                this.operationsContainer.CalculationHandler.SwitchNumericType(Constants.SignedByteName);
            }
        }

        private void RadioButtonUnsignedByteCheckedChanged(object sender, EventArgs e)
        {
            if (this.UnsignedByteButton.Checked)
            {
                this.operationsContainer.CalculationHandler.SwitchNumericType(Constants.UnsignedByteName);
            }
        }

        #endregion

        #region Enter Events

        private void InputFieldEnter(object sender, EventArgs e)
        {
            this.InputField.Enabled = false;
            this.InputField.Enabled = true;
        }

        private void OutputFieldEnter(object sender, EventArgs e)
        {
            this.OutputField.Enabled = false;
            this.OutputField.Enabled = true;
        }

        private void FieldBitsInputEnter(object sender, EventArgs e)
        {
            this.InputField.Focus();
        }

        private void FieldBitsOutputEnter(object sender, EventArgs e)
        {
            this.InputField.Focus();
        }

        #endregion

        #region Paint Events

        private void PanelDecimalDigitsPaint(object sender, PaintEventArgs e)
        {

        }

        private void PanelOctDigitsPaint(object sender, PaintEventArgs e)
        {

        }

        private void PanelHexDigitsPaint(object sender, PaintEventArgs e)
        {

        }

        private void PanelBitOperationsPaint(object sendre, PaintEventArgs e)
        {

        }

        private void PanelDigitsPaint(object sendre, PaintEventArgs e)
        {

        }

        private void OutputFieldContainerPaint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        #region Click events

        private void ButtonAndClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.BitwiseAndSign);
        }

        private void ButtonOrClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.BitwiseOrSign);
        }

        private void ButtonXorClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.BitwiseXorSign);
        }

        private void ButtonNotClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.BitwiseNotSign);
        }


        private void ButtonLeftShiftClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.BitwiseLeftShiftSign);
        }

        private void ButtonRightShiftClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.BitwiseRightShiftSign);
        }

        private void ButtonRotateLeftClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.BitwiseRotationLeftSign);
        }

        private void ButtonRotateRightClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.BitwiseRotationRightSign);
        }

        private void ButtonPlusClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.AddSign);
        }

        private void ButtonMinusClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.SubtractSign);
        }

        private void ButtonMultiplyClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.MultiplySign);
        }

        private void ButtonDivideClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DivideSign);
        }

        private void ButtonNegativeClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.ChangeSignSign);
        }

        private void ButtonModClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.ModSign);
        }

        private void ButtonDecrementClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DecrementSign);
        }

        private void ButtonIncrementClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.IncrementSign);
        }

        private void ButtonBackspaceClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DeleteSign);
        }

        private void ButtonEqualClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.EqualSign);
        }

        private void ButtonMemoryClearClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.MemoryClearPrefix);
        }

        private void ButtonMemoryRestoreClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.MemoryRestorePrefix);
        }

        private void ButtonAddToMemoryClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.AddToMemoryPrefix);
        }

        private void ButtonSubtractFromMemoryClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.SubtractFromMemoryPrefix);
        }

        private void ButtonClearClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.ClearPrefix);
        }

        private void ButtonClearLastClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.ClearLastPrefix);
        }

        private void ButtonZeroZeroClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitZeroZero);
        }

        private void ButtonZeroOneClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitZeroOne);
        }

        private void ButtonOneZeroClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitOneZero);
        }

        private void ButtonOneOneClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitOneOne);
        }

        private void ButtonZero0Click(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitZero);
        }

        private void ButtonTwo2Click(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitTwo);
        }

        private void ButtonLeftBracketClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.LeftBracket);
        }

        private void ButtonRightBracketClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.RightBracket);
        }

        private void ButtonHexAClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitTen);
        }

        private void ButtonHexBClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitEleven);
        }

        private void ButtonHexDClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitThirteen);
        }

        private void ButtonHexEClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitFourteen);
        }

        private void ButtonHexFClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitFifteen);
        }

        private void ButtonHexCClick(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitTwelve);
        }

        private void ButtonOne1Click(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitOne);
        }

        private void ButtonThree3Click(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitThree);
        }

        private void ButtonFour4Click(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitFour);
        }

        private void ButtonFive5Click(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitFive);
        }

        private void ButtonSix6Click(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitSix);
        }

        private void ButtonSeven7Click(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitSeven);
        }

        private void ButtonEight8Click(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitEight);
        }

        private void ButtonNine9Click(object sender, EventArgs e)
        {
            this.operationsContainer.Execute(Constants.DigitNine);
        }

        #endregion

        #region MouseMove, MouseLeave And MouseDown Events

        private void ButtonPlusMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonPlus.BackColor = Color.DodgerBlue;
        }

        private void ButtonPlusMouseLeave(object sender, EventArgs e)
        {
            this.buttonPlus.BackColor = Color.RoyalBlue;
        }

        private void ButtonPlusMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonPlus.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonMinusMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonMinus.BackColor = Color.DodgerBlue;
        }

        private void ButtonMinusMouseLeave(object sender, EventArgs e)
        {
            this.buttonMinus.BackColor = Color.RoyalBlue;
        }

        private void ButtonMinusMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonMinus.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonLeftBracketMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonLeftBracket.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonLeftBracketMouseLeave(object sender, EventArgs e)
        {
            this.buttonLeftBracket.BackColor = Color.RoyalBlue;
        }

        private void ButtonLeftBracketMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonLeftBracket.BackColor = Color.DodgerBlue;
        }

        private void ButtonMultiplyMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonMulitply.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonMultiplyMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonMulitply.BackColor = Color.DodgerBlue;
        }

        private void ButtonMultiplyMouseLeave(object sender, EventArgs e)
        {
            this.buttonMulitply.BackColor = Color.RoyalBlue;
        }

        private void ButtonDivideMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonDivide.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonDivideMouseLeave(object sender, EventArgs e)
        {
            this.buttonDivide.BackColor = Color.RoyalBlue;
        }

        private void ButtonDivideMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonDivide.BackColor = Color.DodgerBlue;
        }

        private void ButtonRightBracketMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonRightBracket.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonRightBracketMouseLeave(object sender, EventArgs e)
        {
            this.buttonRightBracket.BackColor = Color.RoyalBlue;
        }

        private void ButtonRightBracketMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonRightBracket.BackColor = Color.DodgerBlue;
        }

        private void ButtonNegativeMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonNegative.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonNegativeMouseLeave(object sender, EventArgs e)
        {
            this.buttonNegative.BackColor = Color.RoyalBlue;
        }

        private void ButtonNegativeMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonNegative.BackColor = Color.DodgerBlue;
        }

        private void ButtonModMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonModDivide.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonModMouseLeave(object sender, EventArgs e)
        {
            this.buttonModDivide.BackColor = Color.RoyalBlue;
        }

        private void ButtonModMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonModDivide.BackColor = Color.DodgerBlue;
        }

        private void ButtonBackspaceMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonBackspace.BackColor = Color.DeepSkyBlue;
        }


        private void ButtonBackspaceMouseLeave(object sender, EventArgs e)
        {
            this.buttonBackspace.BackColor = Color.RoyalBlue;
        }

        private void ButtonBackspaceMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonBackspace.BackColor = Color.DodgerBlue;
        }

        private void ButtonDecrementMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonDecrement.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonDecrementMouseLeave(object sender, EventArgs e)
        {
            this.buttonDecrement.BackColor = Color.RoyalBlue;
        }

        private void ButtonDecrementMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonDecrement.BackColor = Color.DodgerBlue;
        }

        private void ButtonIncrementMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonIncrement.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonIncrementMouseLeave(object sender, EventArgs e)
        {
            this.buttonIncrement.BackColor = Color.RoyalBlue;
        }

        private void ButtonIncrementMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonIncrement.BackColor = Color.DodgerBlue;
        }

        private void ButtonEqualMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonEqual.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonEqualMouseLeave(object sender, EventArgs e)
        {
            this.buttonEqual.BackColor = Color.RoyalBlue;
        }

        private void ButtonEqualMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonEqual.BackColor = Color.DodgerBlue;
        }

        private void ButtonMemoryClearMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonMemoryClear.BackColor = Color.ForestGreen;
        }

        private void ButtonMemoryClearMouseLeave(object sender, EventArgs e)
        {
            this.buttonMemoryClear.BackColor = Color.RoyalBlue;
        }

        private void ButtonMemoryClearMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonMemoryClear.BackColor = Color.Green;
        }

        private void ButtonMemoryRestoreDown(object sender, MouseEventArgs e)
        {
            this.buttonMemoryRestore.BackColor = Color.Green;
        }

        private void ButtonMemoryRestoreLeave(object sender, EventArgs e)
        {
            this.buttonMemoryRestore.BackColor = Color.RoyalBlue;
        }

        private void ButtonMemoryRestoreMove(object sender, MouseEventArgs e)
        {
            this.buttonMemoryRestore.BackColor = Color.ForestGreen;
        }

        private void ButtonAddToMemoryMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonAddToMemory.BackColor = Color.Green;
        }

        private void ButtonAddToMemoryMouseLeave(object sender, EventArgs e)
        {
            this.buttonAddToMemory.BackColor = Color.RoyalBlue;
        }

        private void ButtonAddToMemoryMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonAddToMemory.BackColor = Color.ForestGreen;
        }

        private void ButtonSubtractFromMemoryMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonSubtractFromMemory.BackColor = Color.Green;
        }

        private void ButtonSubtractFromMemoryMouseLeave(object sender, EventArgs e)
        {
            this.buttonSubtractFromMemory.BackColor = Color.RoyalBlue;
        }

        private void ButtonSubtractFromMemoryMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonSubtractFromMemory.BackColor = Color.ForestGreen;
        }

        private void ButtonClearMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonClear.BackColor = Color.Salmon;
        }

        private void ButtonClearMouseLeave(object sender, EventArgs e)
        {
            this.buttonClear.BackColor = Color.RoyalBlue;
        }

        private void ButtonClearMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonClear.BackColor = Color.Coral;
        }

        private void ButtonClearLastMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonClearLast.BackColor = Color.Salmon;

        }

        private void ButtonClearLastMouseLeave(object sender, EventArgs e)
        {
            this.buttonClearLast.BackColor = Color.RoyalBlue;
        }

        private void ButtonClearLastMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonClearLast.BackColor = Color.Coral;
        }

        private void ButtonOctZero0MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonOctZero0.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonOctZero0MouseLeave(object sender, EventArgs e)
        {
            this.buttonOctZero0.BackColor = Color.RoyalBlue;
        }

        private void ButtonOctZero0MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonOctZero0.BackColor = Color.DodgerBlue;
        }

        private void ButtonOctOne1MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonOctOne1.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonOctOne1MouseLeave(object sender, EventArgs e)
        {
            this.buttonOctOne1.BackColor = Color.RoyalBlue;
        }

        private void ButtonOctOne1MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonOctOne1.BackColor = Color.DodgerBlue;
        }

        private void ButtonOctTwo2MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonOctTwo2.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonOctTwo2MouseLeave(object sender, EventArgs e)
        {
            this.buttonOctTwo2.BackColor = Color.RoyalBlue;
        }

        private void ButtonOctTwo2MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonOctTwo2.BackColor = Color.DodgerBlue;
        }

        private void ButtonOctThree3MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonOctThree3.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonOctThree3MouseLeave(object sender, EventArgs e)
        {
            this.buttonOctThree3.BackColor = Color.RoyalBlue;
        }

        private void ButtonOctThree3MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonOctThree3.BackColor = Color.DodgerBlue;
        }

        private void ButtonOctFour4MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonOctFour4.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonOctFour4MouseLeave(object sender, EventArgs e)
        {
            this.buttonOctFour4.BackColor = Color.RoyalBlue;
        }

        private void ButtonOctFour4MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonOctFour4.BackColor = Color.DodgerBlue;
        }

        private void ButtonOctFive5MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonOctFive5.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonOctFive5MouseLeave(object sender, EventArgs e)
        {
            this.buttonOctFive5.BackColor = Color.RoyalBlue;
        }

        private void ButtonOctFive5MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonOctFive5.BackColor = Color.DodgerBlue;
        }

        private void ButtonOctSix6MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonOctSix6.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonOctSix6MouseLeave(object sender, EventArgs e)
        {
            this.buttonOctSix6.BackColor = Color.RoyalBlue;
        }

        private void ButtonOctSix6MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonOctSix6.BackColor = Color.DodgerBlue;
        }

        private void ButtonOctSeven7MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonOctSeven7.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonOctSeven7MouseLeave(object sender, EventArgs e)
        {
            this.buttonOctSeven7.BackColor = Color.RoyalBlue;
        }

        private void ButtonOctSeven7MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonOctSeven7.BackColor = Color.DodgerBlue;
        }

        private void ButtonAndMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonAnd.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonAndMouseLeave(object sender, EventArgs e)
        {
            this.buttonAnd.BackColor = Color.RoyalBlue;
        }

        private void ButtonAndMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonAnd.BackColor = Color.DodgerBlue;
        }

        private void ButtonOrMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonOr.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonOrMouseLeave(object sender, EventArgs e)
        {
            this.buttonOr.BackColor = Color.RoyalBlue;
        }

        private void ButtonOrMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonOr.BackColor = Color.DodgerBlue;
        }

        private void ButtonNotMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonNot.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonNotMouseLeave(object sender, EventArgs e)
        {
            this.buttonNot.BackColor = Color.RoyalBlue;
        }

        private void ButtonNotMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonNot.BackColor = Color.DodgerBlue;
        }

        private void ButtonXorMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonXor.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonXorMouseLeave(object sender, EventArgs e)
        {
            this.buttonXor.BackColor = Color.RoyalBlue;
        }

        private void ButtonXorMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonXor.BackColor = Color.DodgerBlue;
        }

        private void ButtonLeftShiftMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonLeftShift.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonLeftShiftMouseLeave(object sender, EventArgs e)
        {
            this.buttonLeftShift.BackColor = Color.RoyalBlue;
        }

        private void ButtonLeftShiftMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonLeftShift.BackColor = Color.DodgerBlue;
        }

        private void ButtonRightShiftMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonRightShift.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonRightShiftMouseLeave(object sender, EventArgs e)
        {
            this.buttonRightShift.BackColor = Color.RoyalBlue;
        }

        private void ButtonRightShiftMove(object sender, MouseEventArgs e)
        {
            this.buttonRightShift.BackColor = Color.DodgerBlue;
        }

        private void ButtonRotateLeftMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonRotateLeft.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonRotateLeftMouseLeave(object sender, EventArgs e)
        {
            this.buttonRotateLeft.BackColor = Color.RoyalBlue;
        }

        private void ButtonRotateLeftMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonRotateLeft.BackColor = Color.DodgerBlue;
        }

        private void ButtonRotateRightMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonRotateRight.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonRotateRightMouseLeave(object sender, EventArgs e)
        {
            this.buttonRotateRight.BackColor = Color.RoyalBlue;
        }

        private void ButtonRotateRightMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonRotateRight.BackColor = Color.DodgerBlue;
        }

        private void ButtonZeroMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonZero.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonZeroMouseLeave(object sender, EventArgs e)
        {
            this.buttonZero.BackColor = Color.RoyalBlue;
        }

        private void ButtonZeroMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonZero.BackColor = Color.DodgerBlue;
        }

        private void ButtonOneMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonOne.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonOneMouseLeave(object sender, EventArgs e)
        {
            this.buttonOne.BackColor = Color.RoyalBlue;
        }

        private void ButtonOneMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonOne.BackColor = Color.DodgerBlue;
        }

        private void ButtonZeroZeroMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonZeroZero.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonZeroZeroMouseLeave(object sender, EventArgs e)
        {
            this.buttonZeroZero.BackColor = Color.RoyalBlue;
        }

        private void ButtonZeroZeroMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonZeroZero.BackColor = Color.DodgerBlue;
        }

        private void ButtonZeroOneMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonZeroOne.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonZeroOneMouseLeave(object sender, EventArgs e)
        {
            this.buttonZeroOne.BackColor = Color.RoyalBlue;
        }

        private void ButtonZeroOneMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonZeroOne.BackColor = Color.DodgerBlue;
        }

        private void ButtonOneZeroMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonOneZero.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonOneZeroMouseLeave(object sender, EventArgs e)
        {
            this.buttonOneZero.BackColor = Color.RoyalBlue;
        }

        private void ButtonOneZeroMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonOneZero.BackColor = Color.DodgerBlue;
        }

        private void ButtonOneOneMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonOneOne.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonOneOneMouseLeave(object sender, EventArgs e)
        {
            this.buttonOneOne.BackColor = Color.RoyalBlue;
        }

        private void ButtonOneOneMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonOneOne.BackColor = Color.DodgerBlue;
        }

        private void ButtonHexZero0MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonHexZero0.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonHexZero0MouseLeave(object sender, EventArgs e)
        {
            this.buttonHexZero0.BackColor = Color.RoyalBlue;
        }

        private void ButtonHexZero0MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonHexZero0.BackColor = Color.DodgerBlue;
        }

        private void ButtonHexOne1MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonHexOne1.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonHexOne1MouseLeave(object sender, EventArgs e)
        {
            this.buttonHexOne1.BackColor = Color.RoyalBlue;
        }

        private void ButtonHexOne1MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonHexOne1.BackColor = Color.DodgerBlue;
        }

        private void ButtonHexTwo2MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonHexTwo2.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonHexTwo2MouseLeave(object sender, EventArgs e)
        {
            this.buttonHexTwo2.BackColor = Color.RoyalBlue;
        }

        private void ButtonHexTwo2MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonHexTwo2.BackColor = Color.DodgerBlue;
        }

        private void ButtonHexThree3MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonHexThree3.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonHexThree3MouseLeave(object sender, EventArgs e)
        {
            this.buttonHexThree3.BackColor = Color.RoyalBlue;
        }

        private void ButtonHexThree3MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonHexThree3.BackColor = Color.DodgerBlue;
        }

        private void ButtonHexFour4MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonHexFour4.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonHexFour4MouseLeave(object sender, EventArgs e)
        {
            this.buttonHexFour4.BackColor = Color.RoyalBlue;
        }

        private void ButtonHexFour4MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonHexFour4.BackColor = Color.DodgerBlue;
        }

        private void ButtonHexFive5MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonHexFive5.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonHexFive5MouseLeave(object sender, EventArgs e)
        {
            this.buttonHexFive5.BackColor = Color.RoyalBlue;
        }

        private void ButtonHexFive5MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonHexFive5.BackColor = Color.DodgerBlue;
        }

        private void ButtonHexSix6MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonHexSix6.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonHexSix6MouseLeave(object sender, EventArgs e)
        {
            this.buttonHexSix6.BackColor = Color.RoyalBlue;
        }

        private void ButtonHexSix6MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonHexSix6.BackColor = Color.DodgerBlue;
        }

        private void ButtonHexSeven7MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonHexSeven7.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonHexSeven7MouseLeave(object sender, EventArgs e)
        {
            this.buttonHexSeven7.BackColor = Color.RoyalBlue;
        }

        private void ButtonHexSeven7MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonHexSeven7.BackColor = Color.DodgerBlue;
        }

        private void ButtonHexEight8MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonHexEight8.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonHexEight8MouseLeave(object sender, EventArgs e)
        {
            this.buttonHexEight8.BackColor = Color.RoyalBlue;
        }

        private void ButtonHexEight8MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonHexEight8.BackColor = Color.DodgerBlue;
        }

        private void ButtonHexNine9MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonHexNine9.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonHexNine9MouseLeave(object sender, EventArgs e)
        {
            this.buttonHexNine9.BackColor = Color.RoyalBlue;
        }

        private void ButtonHexNine9MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonHexNine9.BackColor = Color.DodgerBlue;
        }

        private void ButtonHexAMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonHexA.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonHexAMouseLeave(object sender, EventArgs e)
        {
            this.buttonHexA.BackColor = Color.RoyalBlue;
        }

        private void ButtonHexAMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonHexA.BackColor = Color.DodgerBlue;
        }

        private void ButtonHexBMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonHexB.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonHexBMouseLeave(object sender, EventArgs e)
        {
            this.buttonHexB.BackColor = Color.RoyalBlue;
        }

        private void ButtonHexBMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonHexB.BackColor = Color.DodgerBlue;
        }

        private void ButtonHexCMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonHexC.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonHexCMouseLeave(object sender, EventArgs e)
        {
            this.buttonHexC.BackColor = Color.RoyalBlue;
        }

        private void ButtonHexCMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonHexC.BackColor = Color.DodgerBlue;
        }

        private void ButtonHexDMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonHexD.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonHexDMouseLeave(object sender, EventArgs e)
        {
            this.buttonHexD.BackColor = Color.RoyalBlue;
        }

        private void ButtonHexDMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonHexD.BackColor = Color.DodgerBlue;
        }

        private void ButtonHexEMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonHexE.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonHexEMouseLeave(object sender, EventArgs e)
        {
            this.buttonHexE.BackColor = Color.RoyalBlue;
        }

        private void ButtonHexEMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonHexE.BackColor = Color.DodgerBlue;
        }

        private void ButtonHexFMouseDown(object sender, MouseEventArgs e)
        {
            this.buttonHexF.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonHexFMouseLeave(object sender, EventArgs e)
        {
            this.buttonHexF.BackColor = Color.RoyalBlue;
        }

        private void ButtonHexFMouseMove(object sender, MouseEventArgs e)
        {
            this.buttonHexF.BackColor = Color.DodgerBlue;
        }

        private void ButtonOne1MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonOne1.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonOne1MouseLeave(object sender, EventArgs e)
        {
            this.buttonOne1.BackColor = Color.RoyalBlue;
        }

        private void ButtonOne1MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonOne1.BackColor = Color.DodgerBlue;
        }

        private void ButtonTwo2MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonTwo2.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonTwo2MouseLeave(object sender, EventArgs e)
        {
            this.buttonTwo2.BackColor = Color.RoyalBlue;
        }

        private void ButtonTwo2MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonTwo2.BackColor = Color.DodgerBlue;
        }

        private void ButtonThree3MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonThree3.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonThree3MouseLeave(object sender, EventArgs e)
        {
            this.buttonThree3.BackColor = Color.RoyalBlue;
        }

        private void ButtonThree3MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonThree3.BackColor = Color.DodgerBlue;
        }

        private void ButtonFour4MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonFour4.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonFour4MouseLeave(object sender, EventArgs e)
        {
            this.buttonFour4.BackColor = Color.RoyalBlue;
        }

        private void ButtonFour4MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonFour4.BackColor = Color.DodgerBlue;
        }

        private void ButtonFive5MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonFive5.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonFive5MouseLeave(object sender, EventArgs e)
        {
            this.buttonFive5.BackColor = Color.RoyalBlue;
        }

        private void ButtonFive5MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonFive5.BackColor = Color.DodgerBlue;
        }

        private void ButtonSix6MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonSix6.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonSix6MouseLeave(object sender, EventArgs e)
        {
            this.buttonSix6.BackColor = Color.RoyalBlue;
        }

        private void ButtonSix6MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonSix6.BackColor = Color.DodgerBlue;
        }

        private void ButtonSeven7MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonSeven7.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonSeven7MouseLeave(object sender, EventArgs e)
        {
            this.buttonSeven7.BackColor = Color.RoyalBlue;
        }

        private void ButtonSeven7MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonSeven7.BackColor = Color.DodgerBlue;
        }

        private void ButtonEight8MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonEight8.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonEight8MouseLeave(object sender, EventArgs e)
        {
            this.buttonEight8.BackColor = Color.RoyalBlue;
        }

        private void ButtonEight8MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonEight8.BackColor = Color.DodgerBlue;
        }

        private void ButtonNine9MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonNine9.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonNine9MouseLeave(object sender, EventArgs e)
        {
            this.buttonNine9.BackColor = Color.RoyalBlue;
        }

        private void ButtonNine9MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonNine9.BackColor = Color.DodgerBlue;
        }

        private void ButtonZero0MouseDown(object sender, MouseEventArgs e)
        {
            this.buttonZero0.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonZero0MouseLeave(object sender, EventArgs e)
        {
            this.buttonZero0.BackColor = Color.RoyalBlue;
        }

        private void ButtonZero0MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonZero0.BackColor = Color.DodgerBlue;
        }
        #endregion

        #region CustomEvents

        private void InputBitViewFieldTextChanged(object sender, ChangeTextEventArgs args)
        {
            this.fieldBitsInput.Text = args.FieldValue;
        }

        private void OutputBitViewFieldTextChanged(object sender, ChangeTextEventArgs args)
        {
            this.bitsOutputField.Text = args.FieldValue;
        }

        private void InputFieldTextChanged(object sender, ChangeTextEventArgs args)
        {
            this.InputField.Text = args.FieldValue;
        }

        private void OutputFieldTextChanged(object sender, ChangeTextEventArgs args)
        {
            this.OutputField.Text = args.FieldValue;
        }

        private void ReceivedNewResult(object sender, EventArgs args)
        {
            if (this.checkBoxErrorStatusOn.CheckState == CheckState.Unchecked)
            {
                this.ErrorStatusField.Text = string.Empty;
                return;
            }

            this.ErrorStatusField.Text = FormConstants.ErrorStatusDefaultMessage;
        }

        #endregion

        #region DoubleClickEvents
        private void InputFieldDoubleClick(object sender, EventArgs e)
        {
            this.InputField.Text = string.Empty;
            this.operationsContainer.CalculationHandler.Clear();
        }

        #endregion

        #region CheckStateEvents
        private void ErrorStatusCheckedStateChanged(object sender, EventArgs e)
        {
           this.ReceivedNewResult(sender, e);
        }
        #endregion

        #region TimerEvents
        private void ErrorStatusMoveTick(object sender, EventArgs e)
        {
            if (this.ErrorStatusField.Text == string.Empty)
            {
                return;
            }

            var firstLetter = this.ErrorStatusField.Text.First(ch => ch != ' ');
            var indexOfFirstLetter = this.ErrorStatusField.Text.IndexOf(firstLetter);

            if (indexOfFirstLetter == FormConstants.ErrorTextRotationLength)
            {
                this.ErrorStatusField.Text = this.ErrorStatusField.Text.TrimStart();
            }

            this.ErrorStatusField.Text = " " + this.ErrorStatusField.Text;
        }
        #endregion

        #region KeyboardEvents

        private void FormDetectKeyDown(object sender, KeyEventArgs e)
        {
            var pressedKeyValue = e.KeyValue;

            if ((Keys)pressedKeyValue == Keys.Delete)
            {
                this.ButtonBackspaceClick(sender, null);
            }
        }

        private void FormDetectKeyPress(object sender, KeyPressEventArgs e)
        {
            var pressedKeyValue = e.KeyChar;
            switch (pressedKeyValue)
            {
                case '0':
                    {
                        this.ButtonZero0Click(sender, null);
                    }

                    break;
                case '1':
                    {
                        this.ButtonOne1Click(sender, null);
                    }

                    break;
                case '2':
                    {
                        this.ButtonTwo2Click(sender, null);
                    }

                    break;
                case '3':
                    {
                        this.ButtonThree3Click(sender, null);
                    }

                    break;
                case '4':
                    {
                        this.ButtonFour4Click(sender, null);
                    }

                    break;
                case '5':
                    {
                        this.ButtonFive5Click(sender, null);
                    }

                    break;
                case '6':
                    {
                        this.ButtonSix6Click(sender, null);
                    }

                    break;
                case '7':
                    {
                        this.ButtonSeven7Click(sender, null);
                    }

                    break;
                case '8':
                    {
                        this.ButtonEight8Click(sender, null);
                    }

                    break;
                case '9':
                    {
                        this.ButtonNine9Click(sender, null);
                    }

                    break;
                case 'a':
                    {
                        this.ButtonHexAClick(sender, null);
                    }

                    break;
                case 'b':
                    {
                        this.ButtonHexBClick(sender, null);
                    }

                    break;
                case 'c':
                    {
                        this.ButtonHexCClick(sender, null);
                    }

                    break;
                case 'd':
                    {
                        this.ButtonHexDClick(sender, null);
                    }

                    break;
                case 'e':
                    {
                        this.ButtonHexEClick(sender, null);
                    }

                    break;
                case 'f':
                    {
                        this.ButtonHexFClick(sender, null);
                    }

                    break;
                case '+':
                    {
                        this.ButtonPlusClick(sender, null);
                    }

                    break;
                case '-':
                    {
                        this.ButtonMinusClick(sender, null);
                    }

                    break;
                case '/':
                    {
                        this.ButtonDivideClick(sender, null);
                    }

                    break;
                case '*':
                    {
                        this.ButtonMultiplyClick(sender, null);
                    }

                    break;
                case '^':
                    {
                        this.ButtonXorClick(sender, null);
                    }

                    break;
                case '|':
                    {
                        this.ButtonOrClick(sender, null);
                    }

                    break;
                case '&':
                    {
                        this.ButtonAndClick(sender, null);
                    }

                    break;
                case '~':
                    {
                        this.ButtonNegativeClick(sender, null);
                    }

                    break;
                case '=':
                    {
                        this.ButtonEqualClick(sender, null);
                    }

                    break;
                case '(':
                    {
                        this.ButtonLeftBracketClick(sender, null);
                    }

                    break;
                case ')':
                    {
                        this.ButtonRightBracketClick(sender, null);
                    }

                    break;
                case '\b':
                    {
                        this.ButtonBackspaceClick(sender, null);
                    }

                    break;

                case '\r':
                    {
                        //this.ButtonEqualClick(sender, null);
                    }

                    break;
                case ' ':
                    {
                        this.ButtonEqualClick(sender, null);
                    }

                    break;

                default:
                    throw new InvalidKeyPressedException();
            }
        }

        #endregion

        private void BinaryCalculatorThreadExceptionHandlingMethod(object sender, ThreadExceptionEventArgs args)
        {
            var exception = args.Exception;
            while (exception.InnerException != null)
            {
                exception = exception.InnerException;
            }

            if (this.checkBoxErrorStatusOn.CheckState == CheckState.Checked)
            {
                this.ErrorStatusCheckedStateChanged(sender, null);
                this.ErrorStatusField.Text = exception.Message;
            }
           
            this.operationsContainer.CalculationHandler.CalculationHandlerThreadExceptionHandlingMethod(sender, args);
        }

        private void FormPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    {
                        e.IsInputKey = true;
                    }

                    break;
            }
        }
    }
}