namespace Calculator.Forms
{
    using System.Windows.Forms;

    using Calculator.Utilities;
    using ExtensionMethods;

    partial class BinaryCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>S
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip MenuStrip;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinaryCalculator));
            this.modeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thematicToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.economicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.physicsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unitConversionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.thematicToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.economicsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.astronomyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.electronicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitConversionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.linksToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bitViewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nightToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.thematicsToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.economicsToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.physicsToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.mathematicsToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.astronomicsToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.formulasToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.linksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.InputField = new System.Windows.Forms.RichTextBox();
            this.menuItem = new System.Windows.Forms.MenuItem();
            this.OutputField = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripOutputField = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripOutputFieldMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldBitsInput = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripBitsInput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripBitsInputMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.panelInput = new System.Windows.Forms.Panel();
            this.LabelInput = new System.Windows.Forms.Label();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.labelBitsInput = new System.Windows.Forms.Label();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.ChooseBinModePanel = new System.Windows.Forms.Panel();
            this.DecButton = new System.Windows.Forms.RadioButton();
            this.labelBase = new System.Windows.Forms.Label();
            this.BinButton = new System.Windows.Forms.RadioButton();
            this.OctButton = new System.Windows.Forms.RadioButton();
            this.HexButton = new System.Windows.Forms.RadioButton();
            this.ChooseBinSizePanel = new System.Windows.Forms.Panel();
            this.labelUnsigned = new System.Windows.Forms.Label();
            this.UnsignedByteButton = new System.Windows.Forms.RadioButton();
            this.labelSigned = new System.Windows.Forms.Label();
            this.UnsignedWordButton = new System.Windows.Forms.RadioButton();
            this.ByteButton = new System.Windows.Forms.RadioButton();
            this.UnsignedDwordButton = new System.Windows.Forms.RadioButton();
            this.WordButton = new System.Windows.Forms.RadioButton();
            this.UnsignedQwordButton = new System.Windows.Forms.RadioButton();
            this.DwordButton = new System.Windows.Forms.RadioButton();
            this.QwordButton = new System.Windows.Forms.RadioButton();
            this.panelMemoryOperations = new System.Windows.Forms.Panel();
            this.buttonClearLast = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSubtractFromMemory = new System.Windows.Forms.Button();
            this.buttonAddToMemory = new System.Windows.Forms.Button();
            this.buttonMemoryRestore = new System.Windows.Forms.Button();
            this.buttonMemoryClear = new System.Windows.Forms.Button();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thematicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geometryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algebraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.physicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chemistryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.economicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBitView = new System.Windows.Forms.Panel();
            this.panelBitOperations = new System.Windows.Forms.Panel();
            this.buttonAnd = new System.Windows.Forms.Button();
            this.buttonOr = new System.Windows.Forms.Button();
            this.buttonXor = new System.Windows.Forms.Button();
            this.buttonNot = new System.Windows.Forms.Button();
            this.buttonRotateRight = new System.Windows.Forms.Button();
            this.buttonRightShift = new System.Windows.Forms.Button();
            this.buttonRotateLeft = new System.Windows.Forms.Button();
            this.buttonLeftShift = new System.Windows.Forms.Button();
            this.panelOctDigits = new System.Windows.Forms.Panel();
            this.buttonOctSix6 = new System.Windows.Forms.Button();
            this.buttonOctSeven7 = new System.Windows.Forms.Button();
            this.buttonOctFour4 = new System.Windows.Forms.Button();
            this.buttonOctFive5 = new System.Windows.Forms.Button();
            this.buttonOctTwo2 = new System.Windows.Forms.Button();
            this.buttonOctThree3 = new System.Windows.Forms.Button();
            this.buttonOctZero0 = new System.Windows.Forms.Button();
            this.buttonOctOne1 = new System.Windows.Forms.Button();
            this.panelDigits = new System.Windows.Forms.Panel();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonOneOne = new System.Windows.Forms.Button();
            this.buttonZeroZero = new System.Windows.Forms.Button();
            this.buttonOneZero = new System.Windows.Forms.Button();
            this.buttonZeroOne = new System.Windows.Forms.Button();
            this.panelDecimalDigits = new System.Windows.Forms.Panel();
            this.buttonSix6 = new System.Windows.Forms.Button();
            this.buttonNine9 = new System.Windows.Forms.Button();
            this.buttonFive5 = new System.Windows.Forms.Button();
            this.buttonEight8 = new System.Windows.Forms.Button();
            this.buttonFour4 = new System.Windows.Forms.Button();
            this.buttonZero0 = new System.Windows.Forms.Button();
            this.buttonSeven7 = new System.Windows.Forms.Button();
            this.buttonOne1 = new System.Windows.Forms.Button();
            this.buttonTwo2 = new System.Windows.Forms.Button();
            this.buttonThree3 = new System.Windows.Forms.Button();
            this.panelHexDigits = new System.Windows.Forms.Panel();
            this.buttonHexF = new System.Windows.Forms.Button();
            this.buttonHexE = new System.Windows.Forms.Button();
            this.buttonHexD = new System.Windows.Forms.Button();
            this.buttonHexC = new System.Windows.Forms.Button();
            this.buttonHexB = new System.Windows.Forms.Button();
            this.buttonHexA = new System.Windows.Forms.Button();
            this.buttonHexSeven7 = new System.Windows.Forms.Button();
            this.buttonHexSix6 = new System.Windows.Forms.Button();
            this.buttonHexNine9 = new System.Windows.Forms.Button();
            this.buttonHexEight8 = new System.Windows.Forms.Button();
            this.buttonHexFive5 = new System.Windows.Forms.Button();
            this.buttonHexFour4 = new System.Windows.Forms.Button();
            this.buttonHexThree3 = new System.Windows.Forms.Button();
            this.buttonHexZero0 = new System.Windows.Forms.Button();
            this.buttonHexOne1 = new System.Windows.Forms.Button();
            this.buttonHexTwo2 = new System.Windows.Forms.Button();
            this.panelArithmeticOperations = new System.Windows.Forms.Panel();
            this.buttonRightBracket = new System.Windows.Forms.Button();
            this.buttonLeftBracket = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonIncrement = new System.Windows.Forms.Button();
            this.buttonDecrement = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMulitply = new System.Windows.Forms.Button();
            this.buttonModDivide = new System.Windows.Forms.Button();
            this.buttonNegative = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.bitsOutputField = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripBitsOutput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripBitsOutputMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBitsOutput = new System.Windows.Forms.Label();
            this.panelErrorStatus = new System.Windows.Forms.Panel();
            this.ErrorStatusField = new System.Windows.Forms.RichTextBox();
            this.lableErrorStatus = new System.Windows.Forms.Label();
            this.checkBoxErrorStatusOn = new System.Windows.Forms.CheckBox();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerErrorStatusMoveText = new System.Windows.Forms.Timer(this.components);
            MenuStrip = new System.Windows.Forms.MenuStrip();
            MenuStrip.SuspendLayout();
            this.contextMenuStripOutputField.SuspendLayout();
            this.contextMenuStripBitsInput.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.ChooseBinModePanel.SuspendLayout();
            this.ChooseBinSizePanel.SuspendLayout();
            this.panelMemoryOperations.SuspendLayout();
            this.panelBitView.SuspendLayout();
            this.panelBitOperations.SuspendLayout();
            this.panelOctDigits.SuspendLayout();
            this.panelDigits.SuspendLayout();
            this.panelDecimalDigits.SuspendLayout();
            this.panelHexDigits.SuspendLayout();
            this.panelArithmeticOperations.SuspendLayout();
            this.contextMenuStripBitsOutput.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelErrorStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.AllowDrop = true;
            MenuStrip.BackColor = System.Drawing.Color.LightSkyBlue;
            MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            MenuStrip.ForeColor = System.Drawing.Color.Aquamarine;
            MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem2,
            this.viewToolStripMenuItem2,
            this.helpToolStripMenuItem2});
            MenuStrip.Location = new System.Drawing.Point(5, 6);
            MenuStrip.Margin = new System.Windows.Forms.Padding(4, 4, 0, 0);
            MenuStrip.MinimumSize = new System.Drawing.Size(578, 15);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Padding = new System.Windows.Forms.Padding(6, 2, 0, 0);
            MenuStrip.Size = new System.Drawing.Size(578, 24);
            MenuStrip.TabIndex = 8;
            MenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStripItemClicked);
            // 
            // modeToolStripMenuItem2
            // 
            this.modeToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem2,
            this.programmerToolStripMenuItem1,
            this.scientificToolStripMenuItem1,
            this.thematicToolStripMenuItem1,
            this.unitConversionsToolStripMenuItem});
            this.modeToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeToolStripMenuItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.modeToolStripMenuItem2.Name = "modeToolStripMenuItem2";
            this.modeToolStripMenuItem2.Size = new System.Drawing.Size(51, 22);
            this.modeToolStripMenuItem2.Text = "Mode";
            // 
            // standardToolStripMenuItem2
            // 
            this.standardToolStripMenuItem2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.standardToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.standardToolStripMenuItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.standardToolStripMenuItem2.Name = "standardToolStripMenuItem2";
            this.standardToolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.standardToolStripMenuItem2.Text = "Standard";
            // 
            // programmerToolStripMenuItem1
            // 
            this.programmerToolStripMenuItem1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.programmerToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programmerToolStripMenuItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.programmerToolStripMenuItem1.Name = "programmerToolStripMenuItem1";
            this.programmerToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.programmerToolStripMenuItem1.Text = "Programmer";
            // 
            // scientificToolStripMenuItem1
            // 
            this.scientificToolStripMenuItem1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.scientificToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scientificToolStripMenuItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.scientificToolStripMenuItem1.Name = "scientificToolStripMenuItem1";
            this.scientificToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.scientificToolStripMenuItem1.Text = "Scientific";
            // 
            // thematicToolStripMenuItem1
            // 
            this.thematicToolStripMenuItem1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.thematicToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.economicToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.physicsToolStripMenuItem1});
            this.thematicToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thematicToolStripMenuItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.thematicToolStripMenuItem1.Name = "thematicToolStripMenuItem1";
            this.thematicToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.thematicToolStripMenuItem1.Text = "Thematic";
            // 
            // economicToolStripMenuItem
            // 
            this.economicToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.economicToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.economicToolStripMenuItem.Name = "economicToolStripMenuItem";
            this.economicToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.economicToolStripMenuItem.Text = "Economic";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.statisticsToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // physicsToolStripMenuItem1
            // 
            this.physicsToolStripMenuItem1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.physicsToolStripMenuItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.physicsToolStripMenuItem1.Name = "physicsToolStripMenuItem1";
            this.physicsToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.physicsToolStripMenuItem1.Text = "Physics";
            // 
            // unitConversionsToolStripMenuItem
            // 
            this.unitConversionsToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.unitConversionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitConversionsToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.unitConversionsToolStripMenuItem.Name = "unitConversionsToolStripMenuItem";
            this.unitConversionsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.unitConversionsToolStripMenuItem.Text = "Unit Conversions";
            // 
            // viewToolStripMenuItem2
            // 
            this.viewToolStripMenuItem2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem3,
            this.programmerToolStripMenuItem3,
            this.scientificToolStripMenuItem2,
            this.thematicToolStripMenuItem2,
            this.unitConversionsToolStripMenuItem1});
            this.viewToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewToolStripMenuItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.viewToolStripMenuItem2.Name = "viewToolStripMenuItem2";
            this.viewToolStripMenuItem2.Size = new System.Drawing.Size(47, 22);
            this.viewToolStripMenuItem2.Text = "View";
            // 
            // standardToolStripMenuItem3
            // 
            this.standardToolStripMenuItem3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.standardToolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.standardToolStripMenuItem3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.standardToolStripMenuItem3.Name = "standardToolStripMenuItem3";
            this.standardToolStripMenuItem3.Size = new System.Drawing.Size(168, 22);
            this.standardToolStripMenuItem3.Text = "Standard";
            // 
            // programmerToolStripMenuItem3
            // 
            this.programmerToolStripMenuItem3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.programmerToolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programmerToolStripMenuItem3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.programmerToolStripMenuItem3.Name = "programmerToolStripMenuItem3";
            this.programmerToolStripMenuItem3.Size = new System.Drawing.Size(168, 22);
            this.programmerToolStripMenuItem3.Text = "Programmer";
            // 
            // scientificToolStripMenuItem2
            // 
            this.scientificToolStripMenuItem2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.scientificToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scientificToolStripMenuItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.scientificToolStripMenuItem2.Name = "scientificToolStripMenuItem2";
            this.scientificToolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.scientificToolStripMenuItem2.Text = "Scientific";
            // 
            // thematicToolStripMenuItem2
            // 
            this.thematicToolStripMenuItem2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.thematicToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.economicsToolStripMenuItem1,
            this.statisticsToolStripMenuItem1,
            this.astronomyToolStripMenuItem,
            this.electronicsToolStripMenuItem});
            this.thematicToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thematicToolStripMenuItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.thematicToolStripMenuItem2.Name = "thematicToolStripMenuItem2";
            this.thematicToolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.thematicToolStripMenuItem2.Text = "Thematic";
            // 
            // economicsToolStripMenuItem1
            // 
            this.economicsToolStripMenuItem1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.economicsToolStripMenuItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.economicsToolStripMenuItem1.Name = "economicsToolStripMenuItem1";
            this.economicsToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.economicsToolStripMenuItem1.Text = "Economics";
            // 
            // statisticsToolStripMenuItem1
            // 
            this.statisticsToolStripMenuItem1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.statisticsToolStripMenuItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.statisticsToolStripMenuItem1.Name = "statisticsToolStripMenuItem1";
            this.statisticsToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.statisticsToolStripMenuItem1.Text = "Statistics";
            // 
            // astronomyToolStripMenuItem
            // 
            this.astronomyToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.astronomyToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.astronomyToolStripMenuItem.Name = "astronomyToolStripMenuItem";
            this.astronomyToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.astronomyToolStripMenuItem.Text = "Astronomy";
            // 
            // electronicsToolStripMenuItem
            // 
            this.electronicsToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.electronicsToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.electronicsToolStripMenuItem.Name = "electronicsToolStripMenuItem";
            this.electronicsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.electronicsToolStripMenuItem.Text = "Electronics";
            // 
            // unitConversionsToolStripMenuItem1
            // 
            this.unitConversionsToolStripMenuItem1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.unitConversionsToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitConversionsToolStripMenuItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.unitConversionsToolStripMenuItem1.Name = "unitConversionsToolStripMenuItem1";
            this.unitConversionsToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.unitConversionsToolStripMenuItem1.Text = "Unit Conversions";
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.helpToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialToolStripMenuItem2,
            this.tutorialToolStripMenuItem3,
            this.linksToolStripMenuItem2});
            this.helpToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpToolStripMenuItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(45, 22);
            this.helpToolStripMenuItem2.Text = "Help";
            // 
            // tutorialToolStripMenuItem2
            // 
            this.tutorialToolStripMenuItem2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tutorialToolStripMenuItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tutorialToolStripMenuItem2.Name = "tutorialToolStripMenuItem2";
            this.tutorialToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.tutorialToolStripMenuItem2.Text = "About";
            // 
            // tutorialToolStripMenuItem3
            // 
            this.tutorialToolStripMenuItem3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tutorialToolStripMenuItem3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tutorialToolStripMenuItem3.Name = "tutorialToolStripMenuItem3";
            this.tutorialToolStripMenuItem3.Size = new System.Drawing.Size(116, 22);
            this.tutorialToolStripMenuItem3.Text = "Tutorial";
            // 
            // linksToolStripMenuItem2
            // 
            this.linksToolStripMenuItem2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.linksToolStripMenuItem2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.linksToolStripMenuItem2.Name = "linksToolStripMenuItem2";
            this.linksToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.linksToolStripMenuItem2.Text = "Links";
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // bitViewToolStripMenuItem1
            // 
            this.bitViewToolStripMenuItem1.Name = "bitViewToolStripMenuItem1";
            this.bitViewToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // offToolStripMenuItem1
            // 
            this.offToolStripMenuItem1.Name = "offToolStripMenuItem1";
            this.offToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // onToolStripMenuItem1
            // 
            this.onToolStripMenuItem1.Name = "onToolStripMenuItem1";
            this.onToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // nightToolStripMenuItem2
            // 
            this.nightToolStripMenuItem2.Name = "nightToolStripMenuItem2";
            this.nightToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // modeToolStripMenuItem1
            // 
            this.modeToolStripMenuItem1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.modeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem1,
            this.programmerToolStripMenuItem2,
            this.toolStripMenuItem3,
            this.thematicsToolStripMenuItem4,
            this.formulasToolStripMenuItem9});
            this.modeToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeToolStripMenuItem1.ForeColor = System.Drawing.Color.Navy;
            this.modeToolStripMenuItem1.Name = "modeToolStripMenuItem1";
            this.modeToolStripMenuItem1.Size = new System.Drawing.Size(51, 22);
            this.modeToolStripMenuItem1.Text = "Mode";
            // 
            // standardToolStripMenuItem1
            // 
            this.standardToolStripMenuItem1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.standardToolStripMenuItem1.ForeColor = System.Drawing.Color.Navy;
            this.standardToolStripMenuItem1.Name = "standardToolStripMenuItem1";
            this.standardToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.standardToolStripMenuItem1.Text = "Standard";
            // 
            // programmerToolStripMenuItem2
            // 
            this.programmerToolStripMenuItem2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.programmerToolStripMenuItem2.ForeColor = System.Drawing.Color.Navy;
            this.programmerToolStripMenuItem2.Name = "programmerToolStripMenuItem2";
            this.programmerToolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.programmerToolStripMenuItem2.Text = "Programmer";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.Navy;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem3.Text = "Scientific";
            // 
            // thematicsToolStripMenuItem4
            // 
            this.thematicsToolStripMenuItem4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.thematicsToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.economicsToolStripMenuItem5,
            this.physicsToolStripMenuItem6,
            this.mathematicsToolStripMenuItem7,
            this.astronomicsToolStripMenuItem8});
            this.thematicsToolStripMenuItem4.ForeColor = System.Drawing.Color.Navy;
            this.thematicsToolStripMenuItem4.Name = "thematicsToolStripMenuItem4";
            this.thematicsToolStripMenuItem4.Size = new System.Drawing.Size(145, 22);
            this.thematicsToolStripMenuItem4.Text = "Thematics";
            // 
            // economicsToolStripMenuItem5
            // 
            this.economicsToolStripMenuItem5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.economicsToolStripMenuItem5.ForeColor = System.Drawing.Color.DarkBlue;
            this.economicsToolStripMenuItem5.Name = "economicsToolStripMenuItem5";
            this.economicsToolStripMenuItem5.Size = new System.Drawing.Size(146, 22);
            this.economicsToolStripMenuItem5.Text = "Economics";
            // 
            // physicsToolStripMenuItem6
            // 
            this.physicsToolStripMenuItem6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.physicsToolStripMenuItem6.ForeColor = System.Drawing.Color.DarkBlue;
            this.physicsToolStripMenuItem6.Name = "physicsToolStripMenuItem6";
            this.physicsToolStripMenuItem6.Size = new System.Drawing.Size(146, 22);
            this.physicsToolStripMenuItem6.Text = "Physics";
            // 
            // mathematicsToolStripMenuItem7
            // 
            this.mathematicsToolStripMenuItem7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mathematicsToolStripMenuItem7.ForeColor = System.Drawing.Color.DarkBlue;
            this.mathematicsToolStripMenuItem7.Name = "mathematicsToolStripMenuItem7";
            this.mathematicsToolStripMenuItem7.Size = new System.Drawing.Size(146, 22);
            this.mathematicsToolStripMenuItem7.Text = "Mathematics";
            // 
            // astronomicsToolStripMenuItem8
            // 
            this.astronomicsToolStripMenuItem8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.astronomicsToolStripMenuItem8.ForeColor = System.Drawing.Color.DarkBlue;
            this.astronomicsToolStripMenuItem8.Name = "astronomicsToolStripMenuItem8";
            this.astronomicsToolStripMenuItem8.Size = new System.Drawing.Size(146, 22);
            this.astronomicsToolStripMenuItem8.Text = "Astronomics";
            // 
            // formulasToolStripMenuItem9
            // 
            this.formulasToolStripMenuItem9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.formulasToolStripMenuItem9.ForeColor = System.Drawing.Color.DarkBlue;
            this.formulasToolStripMenuItem9.Name = "formulasToolStripMenuItem9";
            this.formulasToolStripMenuItem9.Size = new System.Drawing.Size(145, 22);
            this.formulasToolStripMenuItem9.Text = "Formulas";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linksToolStripMenuItem1,
            this.tutorialToolStripMenuItem1,
            this.aboutToolStripMenuItem2});
            this.helpToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkBlue;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(45, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // linksToolStripMenuItem1
            // 
            this.linksToolStripMenuItem1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.linksToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkBlue;
            this.linksToolStripMenuItem1.Name = "linksToolStripMenuItem1";
            this.linksToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.linksToolStripMenuItem1.Text = "Links";
            // 
            // tutorialToolStripMenuItem1
            // 
            this.tutorialToolStripMenuItem1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tutorialToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkBlue;
            this.tutorialToolStripMenuItem1.Name = "tutorialToolStripMenuItem1";
            this.tutorialToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.tutorialToolStripMenuItem1.Text = "Tutorial";
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.aboutToolStripMenuItem2.ForeColor = System.Drawing.Color.DarkBlue;
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem2.Text = "About";
            // 
            // InputField
            // 
            this.InputField.BackColor = System.Drawing.Color.MidnightBlue;
            this.InputField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InputField.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputField.ForeColor = System.Drawing.Color.Aqua;
            this.InputField.Location = new System.Drawing.Point(2, 5);
            this.InputField.Multiline = false;
            this.InputField.Name = "InputField";
            this.InputField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InputField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.InputField.Size = new System.Drawing.Size(495, 19);
            this.InputField.TabIndex = 0;
            this.InputField.Text = "0";
            this.InputField.WordWrap = false;
            this.InputField.TextChanged += new System.EventHandler(this.InputFieldTextChanged);
            this.InputField.DoubleClick += new System.EventHandler(this.InputFieldDoubleClick);
            this.InputField.Enter += new System.EventHandler(this.InputFieldEnter);
            // 
            // menuItem
            // 
            this.menuItem.Index = -1;
            this.menuItem.Text = "";
            // 
            // OutputField
            // 
            this.OutputField.BackColor = System.Drawing.Color.MidnightBlue;
            this.OutputField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputField.ContextMenuStrip = this.contextMenuStripOutputField;
            this.OutputField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OutputField.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputField.ForeColor = System.Drawing.Color.Aqua;
            this.OutputField.Location = new System.Drawing.Point(2, 3);
            this.OutputField.Multiline = false;
            this.OutputField.Name = "OutputField";
            this.OutputField.ReadOnly = true;
            this.OutputField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OutputField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.OutputField.Size = new System.Drawing.Size(495, 19);
            this.OutputField.TabIndex = 1;
            this.OutputField.Text = "0";
            this.OutputField.WordWrap = false;
            this.OutputField.TextChanged += new System.EventHandler(this.OutputFieldTextChanged);
            this.OutputField.Enter += new System.EventHandler(this.OutputFieldEnter);
            // 
            // contextMenuStripOutputField
            // 
            this.contextMenuStripOutputField.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripOutputFieldMenuItemCopy});
            this.contextMenuStripOutputField.Name = "contextMenuStrip1";
            this.contextMenuStripOutputField.Size = new System.Drawing.Size(102, 26);
            // 
            // ToolStripOutputFieldMenuItemCopy
            // 
            this.ToolStripOutputFieldMenuItemCopy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ToolStripOutputFieldMenuItemCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripOutputFieldMenuItemCopy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ToolStripOutputFieldMenuItemCopy.Name = "ToolStripOutputFieldMenuItemCopy";
            this.ToolStripOutputFieldMenuItemCopy.Size = new System.Drawing.Size(101, 22);
            this.ToolStripOutputFieldMenuItemCopy.Text = "Copy";
            // 
            // fieldBitsInput
            // 
            this.fieldBitsInput.BackColor = System.Drawing.Color.MidnightBlue;
            this.fieldBitsInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fieldBitsInput.ContextMenuStrip = this.contextMenuStripBitsInput;
            this.fieldBitsInput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fieldBitsInput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldBitsInput.ForeColor = System.Drawing.Color.Aqua;
            this.fieldBitsInput.Location = new System.Drawing.Point(2, 5);
            this.fieldBitsInput.Multiline = false;
            this.fieldBitsInput.Name = "fieldBitsInput";
            this.fieldBitsInput.ReadOnly = true;
            this.fieldBitsInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fieldBitsInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.fieldBitsInput.Size = new System.Drawing.Size(499, 19);
            this.fieldBitsInput.TabIndex = 2;
            this.fieldBitsInput.TabStop = false;
            this.fieldBitsInput.Text = "00000000 00000000 00000000 00000000 00000000 00000000 00000000 00000000";
            this.fieldBitsInput.WordWrap = false;
            this.fieldBitsInput.Enter += new System.EventHandler(this.FieldBitsInputEnter);
            // 
            // contextMenuStripBitsInput
            // 
            this.contextMenuStripBitsInput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripBitsInputMenuItemCopy});
            this.contextMenuStripBitsInput.Name = "contextMenuStrip1";
            this.contextMenuStripBitsInput.Size = new System.Drawing.Size(102, 26);
            // 
            // ToolStripBitsInputMenuItemCopy
            // 
            this.ToolStripBitsInputMenuItemCopy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ToolStripBitsInputMenuItemCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripBitsInputMenuItemCopy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ToolStripBitsInputMenuItemCopy.Name = "ToolStripBitsInputMenuItemCopy";
            this.ToolStripBitsInputMenuItemCopy.Size = new System.Drawing.Size(101, 22);
            this.ToolStripBitsInputMenuItemCopy.Text = "Copy";
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Controls.Add(this.InputField);
            this.panelInput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelInput.ForeColor = System.Drawing.Color.White;
            this.panelInput.Location = new System.Drawing.Point(76, 36);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(5);
            this.panelInput.Size = new System.Drawing.Size(508, 28);
            this.panelInput.TabIndex = 100;
            // 
            // LabelInput
            // 
            this.LabelInput.BackColor = System.Drawing.Color.SteelBlue;
            this.LabelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInput.ForeColor = System.Drawing.Color.Aqua;
            this.LabelInput.Location = new System.Drawing.Point(5, 36);
            this.LabelInput.Name = "LabelInput";
            this.LabelInput.Size = new System.Drawing.Size(68, 28);
            this.LabelInput.TabIndex = 5;
            this.LabelInput.Text = "Input";
            this.LabelInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelOutput
            // 
            this.panelOutput.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOutput.Controls.Add(this.OutputField);
            this.panelOutput.ForeColor = System.Drawing.Color.White;
            this.panelOutput.Location = new System.Drawing.Point(76, 70);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Padding = new System.Windows.Forms.Padding(5);
            this.panelOutput.Size = new System.Drawing.Size(508, 28);
            this.panelOutput.TabIndex = 101;
            this.panelOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.OutputFieldContainerPaint);
            // 
            // labelBitsInput
            // 
            this.labelBitsInput.BackColor = System.Drawing.Color.SteelBlue;
            this.labelBitsInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBitsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBitsInput.ForeColor = System.Drawing.Color.Aqua;
            this.labelBitsInput.Location = new System.Drawing.Point(5, 104);
            this.labelBitsInput.Name = "labelBitsInput";
            this.labelBitsInput.Size = new System.Drawing.Size(68, 28);
            this.labelBitsInput.TabIndex = 7;
            this.labelBitsInput.Text = "BitsInput";
            this.labelBitsInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelOutput
            // 
            this.LabelOutput.BackColor = System.Drawing.Color.SteelBlue;
            this.LabelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOutput.ForeColor = System.Drawing.Color.Aqua;
            this.LabelOutput.Location = new System.Drawing.Point(5, 70);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(68, 28);
            this.LabelOutput.TabIndex = 6;
            this.LabelOutput.Text = "Output";
            this.LabelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseBinModePanel
            // 
            this.ChooseBinModePanel.BackColor = System.Drawing.Color.SteelBlue;
            this.ChooseBinModePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChooseBinModePanel.Controls.Add(this.DecButton);
            this.ChooseBinModePanel.Controls.Add(this.labelBase);
            this.ChooseBinModePanel.Controls.Add(this.BinButton);
            this.ChooseBinModePanel.Controls.Add(this.OctButton);
            this.ChooseBinModePanel.Controls.Add(this.HexButton);
            this.ChooseBinModePanel.Location = new System.Drawing.Point(5, 266);
            this.ChooseBinModePanel.Name = "ChooseBinModePanel";
            this.ChooseBinModePanel.Size = new System.Drawing.Size(68, 88);
            this.ChooseBinModePanel.TabIndex = 2;
            // 
            // DecButton
            // 
            this.DecButton.AutoSize = true;
            this.DecButton.Checked = true;
            this.DecButton.ForeColor = System.Drawing.Color.Aqua;
            this.DecButton.Location = new System.Drawing.Point(3, 20);
            this.DecButton.Name = "DecButton";
            this.DecButton.Size = new System.Drawing.Size(48, 17);
            this.DecButton.TabIndex = 53;
            this.DecButton.TabStop = true;
            this.DecButton.Text = "Dec";
            this.DecButton.UseVisualStyleBackColor = true;
            this.DecButton.CheckedChanged += new System.EventHandler(this.RadioButtonDecCheckedChanged);
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelBase.Location = new System.Drawing.Point(13, 2);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(35, 13);
            this.labelBase.TabIndex = 56;
            this.labelBase.Text = "Base";
            // 
            // BinButton
            // 
            this.BinButton.AutoSize = true;
            this.BinButton.ForeColor = System.Drawing.Color.Aqua;
            this.BinButton.Location = new System.Drawing.Point(3, 52);
            this.BinButton.Name = "BinButton";
            this.BinButton.Size = new System.Drawing.Size(43, 17);
            this.BinButton.TabIndex = 56;
            this.BinButton.TabStop = true;
            this.BinButton.Text = "Bin";
            this.BinButton.UseVisualStyleBackColor = true;
            this.BinButton.CheckedChanged += new System.EventHandler(this.RadioButtonBinCheckedChanged);
            // 
            // OctButton
            // 
            this.OctButton.AutoSize = true;
            this.OctButton.ForeColor = System.Drawing.Color.Aqua;
            this.OctButton.Location = new System.Drawing.Point(3, 36);
            this.OctButton.Name = "OctButton";
            this.OctButton.Size = new System.Drawing.Size(45, 17);
            this.OctButton.TabIndex = 55;
            this.OctButton.Text = "Oct";
            this.OctButton.UseVisualStyleBackColor = true;
            this.OctButton.CheckedChanged += new System.EventHandler(this.RadioButtonOctCheckedChanged);
            // 
            // HexButton
            // 
            this.HexButton.AutoSize = true;
            this.HexButton.ForeColor = System.Drawing.Color.Aqua;
            this.HexButton.Location = new System.Drawing.Point(3, 68);
            this.HexButton.Name = "HexButton";
            this.HexButton.Size = new System.Drawing.Size(47, 17);
            this.HexButton.TabIndex = 54;
            this.HexButton.Text = "Hex";
            this.HexButton.UseVisualStyleBackColor = true;
            this.HexButton.CheckedChanged += new System.EventHandler(this.RadioButtonHexCheckedChanged);
            // 
            // ChooseBinSizePanel
            // 
            this.ChooseBinSizePanel.BackColor = System.Drawing.Color.SteelBlue;
            this.ChooseBinSizePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChooseBinSizePanel.Controls.Add(this.labelUnsigned);
            this.ChooseBinSizePanel.Controls.Add(this.UnsignedByteButton);
            this.ChooseBinSizePanel.Controls.Add(this.labelSigned);
            this.ChooseBinSizePanel.Controls.Add(this.UnsignedWordButton);
            this.ChooseBinSizePanel.Controls.Add(this.ByteButton);
            this.ChooseBinSizePanel.Controls.Add(this.UnsignedDwordButton);
            this.ChooseBinSizePanel.Controls.Add(this.WordButton);
            this.ChooseBinSizePanel.Controls.Add(this.UnsignedQwordButton);
            this.ChooseBinSizePanel.Controls.Add(this.DwordButton);
            this.ChooseBinSizePanel.Controls.Add(this.QwordButton);
            this.ChooseBinSizePanel.Location = new System.Drawing.Point(5, 172);
            this.ChooseBinSizePanel.Name = "ChooseBinSizePanel";
            this.ChooseBinSizePanel.Size = new System.Drawing.Size(136, 88);
            this.ChooseBinSizePanel.TabIndex = 3;
            // 
            // labelUnsigned
            // 
            this.labelUnsigned.AutoSize = true;
            this.labelUnsigned.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelUnsigned.Location = new System.Drawing.Point(71, 2);
            this.labelUnsigned.Name = "labelUnsigned";
            this.labelUnsigned.Size = new System.Drawing.Size(60, 13);
            this.labelUnsigned.TabIndex = 54;
            this.labelUnsigned.Text = "Unsigned";
            // 
            // UnsignedByteButton
            // 
            this.UnsignedByteButton.AutoSize = true;
            this.UnsignedByteButton.ForeColor = System.Drawing.Color.Aqua;
            this.UnsignedByteButton.Location = new System.Drawing.Point(73, 68);
            this.UnsignedByteButton.Name = "UnsignedByteButton";
            this.UnsignedByteButton.Size = new System.Drawing.Size(50, 17);
            this.UnsignedByteButton.TabIndex = 53;
            this.UnsignedByteButton.Text = "Byte";
            this.UnsignedByteButton.UseVisualStyleBackColor = true;
            this.UnsignedByteButton.CheckedChanged += new System.EventHandler(this.RadioButtonUnsignedByteCheckedChanged);
            // 
            // labelSigned
            // 
            this.labelSigned.AutoSize = true;
            this.labelSigned.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelSigned.Location = new System.Drawing.Point(7, 2);
            this.labelSigned.Name = "labelSigned";
            this.labelSigned.Size = new System.Drawing.Size(46, 13);
            this.labelSigned.TabIndex = 55;
            this.labelSigned.Text = "Signed";
            // 
            // UnsignedWordButton
            // 
            this.UnsignedWordButton.AutoSize = true;
            this.UnsignedWordButton.ForeColor = System.Drawing.Color.Aqua;
            this.UnsignedWordButton.Location = new System.Drawing.Point(73, 52);
            this.UnsignedWordButton.Name = "UnsignedWordButton";
            this.UnsignedWordButton.Size = new System.Drawing.Size(55, 17);
            this.UnsignedWordButton.TabIndex = 52;
            this.UnsignedWordButton.Text = "Word";
            this.UnsignedWordButton.UseVisualStyleBackColor = true;
            this.UnsignedWordButton.CheckedChanged += new System.EventHandler(this.RadioButtonUnsignedWordCheckedChanged);
            // 
            // ByteButton
            // 
            this.ByteButton.AutoSize = true;
            this.ByteButton.ForeColor = System.Drawing.Color.Aqua;
            this.ByteButton.Location = new System.Drawing.Point(3, 68);
            this.ByteButton.Name = "ByteButton";
            this.ByteButton.Size = new System.Drawing.Size(50, 17);
            this.ByteButton.TabIndex = 53;
            this.ByteButton.Text = "Byte";
            this.ByteButton.UseVisualStyleBackColor = true;
            this.ByteButton.CheckedChanged += new System.EventHandler(this.RadioButtonByteCheckedChanged);
            // 
            // UnsignedDwordButton
            // 
            this.UnsignedDwordButton.AutoSize = true;
            this.UnsignedDwordButton.ForeColor = System.Drawing.Color.Aqua;
            this.UnsignedDwordButton.Location = new System.Drawing.Point(73, 36);
            this.UnsignedDwordButton.Name = "UnsignedDwordButton";
            this.UnsignedDwordButton.Size = new System.Drawing.Size(61, 17);
            this.UnsignedDwordButton.TabIndex = 51;
            this.UnsignedDwordButton.Text = "Dword";
            this.UnsignedDwordButton.UseVisualStyleBackColor = true;
            this.UnsignedDwordButton.CheckedChanged += new System.EventHandler(this.RadioButtonUnsignedDwordCheckedChanged);
            // 
            // WordButton
            // 
            this.WordButton.AutoSize = true;
            this.WordButton.ForeColor = System.Drawing.Color.Aqua;
            this.WordButton.Location = new System.Drawing.Point(3, 52);
            this.WordButton.Name = "WordButton";
            this.WordButton.Size = new System.Drawing.Size(55, 17);
            this.WordButton.TabIndex = 52;
            this.WordButton.Text = "Word";
            this.WordButton.UseVisualStyleBackColor = true;
            this.WordButton.CheckedChanged += new System.EventHandler(this.RadioButtonWordCheckedChanged);
            // 
            // UnsignedQwordButton
            // 
            this.UnsignedQwordButton.AutoSize = true;
            this.UnsignedQwordButton.ForeColor = System.Drawing.Color.Aqua;
            this.UnsignedQwordButton.Location = new System.Drawing.Point(73, 20);
            this.UnsignedQwordButton.Name = "UnsignedQwordButton";
            this.UnsignedQwordButton.Size = new System.Drawing.Size(61, 17);
            this.UnsignedQwordButton.TabIndex = 50;
            this.UnsignedQwordButton.Text = "Qword";
            this.UnsignedQwordButton.UseVisualStyleBackColor = true;
            this.UnsignedQwordButton.CheckedChanged += new System.EventHandler(this.RadioButtonUnsignedQwordCheckedChanged);
            // 
            // DwordButton
            // 
            this.DwordButton.AutoSize = true;
            this.DwordButton.ForeColor = System.Drawing.Color.Aqua;
            this.DwordButton.Location = new System.Drawing.Point(3, 36);
            this.DwordButton.Name = "DwordButton";
            this.DwordButton.Size = new System.Drawing.Size(61, 17);
            this.DwordButton.TabIndex = 51;
            this.DwordButton.Text = "Dword";
            this.DwordButton.UseVisualStyleBackColor = true;
            this.DwordButton.CheckedChanged += new System.EventHandler(this.RadioButtonDwordCheckedChanged);
            // 
            // QwordButton
            // 
            this.QwordButton.AutoSize = true;
            this.QwordButton.Checked = true;
            this.QwordButton.ForeColor = System.Drawing.Color.Aqua;
            this.QwordButton.Location = new System.Drawing.Point(3, 20);
            this.QwordButton.Name = "QwordButton";
            this.QwordButton.Size = new System.Drawing.Size(61, 17);
            this.QwordButton.TabIndex = 50;
            this.QwordButton.TabStop = true;
            this.QwordButton.Text = "Qword";
            this.QwordButton.UseVisualStyleBackColor = true;
            this.QwordButton.CheckedChanged += new System.EventHandler(this.RadioButtonQwordCheckedChanged);
            // 
            // panelMemoryOperations
            // 
            this.panelMemoryOperations.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMemoryOperations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMemoryOperations.Controls.Add(this.buttonClearLast);
            this.panelMemoryOperations.Controls.Add(this.buttonClear);
            this.panelMemoryOperations.Controls.Add(this.buttonSubtractFromMemory);
            this.panelMemoryOperations.Controls.Add(this.buttonAddToMemory);
            this.panelMemoryOperations.Controls.Add(this.buttonMemoryRestore);
            this.panelMemoryOperations.Controls.Add(this.buttonMemoryClear);
            this.panelMemoryOperations.Location = new System.Drawing.Point(147, 172);
            this.panelMemoryOperations.Name = "panelMemoryOperations";
            this.panelMemoryOperations.Size = new System.Drawing.Size(125, 88);
            this.panelMemoryOperations.TabIndex = 22;
            // 
            // buttonClearLast
            // 
            this.buttonClearLast.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonClearLast.ForeColor = System.Drawing.Color.Red;
            this.buttonClearLast.Location = new System.Drawing.Point(82, 44);
            this.buttonClearLast.Name = "buttonClearLast";
            this.buttonClearLast.Size = new System.Drawing.Size(38, 40);
            this.buttonClearLast.TabIndex = 35;
            this.buttonClearLast.Text = "CE";
            this.buttonClearLast.UseVisualStyleBackColor = false;
            this.buttonClearLast.Click += new System.EventHandler(this.ButtonClearLastClick);
            this.buttonClearLast.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonClearLastMouseDown);
            this.buttonClearLast.MouseLeave += new System.EventHandler(this.ButtonClearLastMouseLeave);
            this.buttonClearLast.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonClearLastMouseMove);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonClear.ForeColor = System.Drawing.Color.Red;
            this.buttonClear.Location = new System.Drawing.Point(82, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(38, 40);
            this.buttonClear.TabIndex = 34;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
            this.buttonClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonClearMouseDown);
            this.buttonClear.MouseLeave += new System.EventHandler(this.ButtonClearMouseLeave);
            this.buttonClear.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonClearMouseMove);
            // 
            // buttonSubtractFromMemory
            // 
            this.buttonSubtractFromMemory.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSubtractFromMemory.ForeColor = System.Drawing.Color.Lime;
            this.buttonSubtractFromMemory.Location = new System.Drawing.Point(42, 44);
            this.buttonSubtractFromMemory.Name = "buttonSubtractFromMemory";
            this.buttonSubtractFromMemory.Size = new System.Drawing.Size(38, 40);
            this.buttonSubtractFromMemory.TabIndex = 33;
            this.buttonSubtractFromMemory.Text = "M-";
            this.buttonSubtractFromMemory.UseVisualStyleBackColor = false;
            this.buttonSubtractFromMemory.Click += new System.EventHandler(this.ButtonSubtractFromMemoryClick);
            this.buttonSubtractFromMemory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonSubtractFromMemoryMouseDown);
            this.buttonSubtractFromMemory.MouseLeave += new System.EventHandler(this.ButtonSubtractFromMemoryMouseLeave);
            this.buttonSubtractFromMemory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonSubtractFromMemoryMouseMove);
            // 
            // buttonAddToMemory
            // 
            this.buttonAddToMemory.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAddToMemory.ForeColor = System.Drawing.Color.Lime;
            this.buttonAddToMemory.Location = new System.Drawing.Point(42, 3);
            this.buttonAddToMemory.Name = "buttonAddToMemory";
            this.buttonAddToMemory.Size = new System.Drawing.Size(38, 40);
            this.buttonAddToMemory.TabIndex = 32;
            this.buttonAddToMemory.Text = "M+";
            this.buttonAddToMemory.UseVisualStyleBackColor = false;
            this.buttonAddToMemory.Click += new System.EventHandler(this.ButtonAddToMemoryClick);
            this.buttonAddToMemory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonAddToMemoryMouseDown);
            this.buttonAddToMemory.MouseLeave += new System.EventHandler(this.ButtonAddToMemoryMouseLeave);
            this.buttonAddToMemory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonAddToMemoryMouseMove);
            // 
            // buttonMemoryRestore
            // 
            this.buttonMemoryRestore.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonMemoryRestore.ForeColor = System.Drawing.Color.Lime;
            this.buttonMemoryRestore.Location = new System.Drawing.Point(2, 44);
            this.buttonMemoryRestore.Name = "buttonMemoryRestore";
            this.buttonMemoryRestore.Size = new System.Drawing.Size(38, 40);
            this.buttonMemoryRestore.TabIndex = 31;
            this.buttonMemoryRestore.Text = "MR";
            this.buttonMemoryRestore.UseVisualStyleBackColor = false;
            this.buttonMemoryRestore.Click += new System.EventHandler(this.ButtonMemoryRestoreClick);
            this.buttonMemoryRestore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMemoryRestoreDown);
            this.buttonMemoryRestore.MouseLeave += new System.EventHandler(this.ButtonMemoryRestoreLeave);
            this.buttonMemoryRestore.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonMemoryRestoreMove);
            // 
            // buttonMemoryClear
            // 
            this.buttonMemoryClear.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonMemoryClear.ForeColor = System.Drawing.Color.Lime;
            this.buttonMemoryClear.Location = new System.Drawing.Point(2, 3);
            this.buttonMemoryClear.Name = "buttonMemoryClear";
            this.buttonMemoryClear.Size = new System.Drawing.Size(38, 40);
            this.buttonMemoryClear.TabIndex = 30;
            this.buttonMemoryClear.Text = "MC";
            this.buttonMemoryClear.UseVisualStyleBackColor = false;
            this.buttonMemoryClear.Click += new System.EventHandler(this.ButtonMemoryClearClick);
            this.buttonMemoryClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMemoryClearMouseDown);
            this.buttonMemoryClear.MouseLeave += new System.EventHandler(this.ButtonMemoryClearMouseLeave);
            this.buttonMemoryClear.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonMemoryClearMouseMove);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmerToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.conversionsToolStripMenuItem,
            this.formulasToolStripMenuItem,
            this.thematicToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // programmerToolStripMenuItem
            // 
            this.programmerToolStripMenuItem.Name = "programmerToolStripMenuItem";
            this.programmerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.programmerToolStripMenuItem.Text = "Programmer";
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.scientificToolStripMenuItem.Text = "Scientific";
            // 
            // conversionsToolStripMenuItem
            // 
            this.conversionsToolStripMenuItem.Name = "conversionsToolStripMenuItem";
            this.conversionsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.conversionsToolStripMenuItem.Text = "Conversions";
            // 
            // formulasToolStripMenuItem
            // 
            this.formulasToolStripMenuItem.Name = "formulasToolStripMenuItem";
            this.formulasToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.formulasToolStripMenuItem.Text = "Formulas";
            // 
            // thematicToolStripMenuItem
            // 
            this.thematicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geometryToolStripMenuItem,
            this.algebraToolStripMenuItem,
            this.physicsToolStripMenuItem,
            this.chemistryToolStripMenuItem,
            this.economicsToolStripMenuItem});
            this.thematicToolStripMenuItem.Name = "thematicToolStripMenuItem";
            this.thematicToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.thematicToolStripMenuItem.Text = "Thematic";
            // 
            // geometryToolStripMenuItem
            // 
            this.geometryToolStripMenuItem.Name = "geometryToolStripMenuItem";
            this.geometryToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.geometryToolStripMenuItem.Text = "Geometry";
            // 
            // algebraToolStripMenuItem
            // 
            this.algebraToolStripMenuItem.Name = "algebraToolStripMenuItem";
            this.algebraToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.algebraToolStripMenuItem.Text = "Algebra";
            // 
            // physicsToolStripMenuItem
            // 
            this.physicsToolStripMenuItem.Name = "physicsToolStripMenuItem";
            this.physicsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.physicsToolStripMenuItem.Text = "Physics";
            // 
            // chemistryToolStripMenuItem
            // 
            this.chemistryToolStripMenuItem.Name = "chemistryToolStripMenuItem";
            this.chemistryToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.chemistryToolStripMenuItem.Text = "Chemistry";
            // 
            // economicsToolStripMenuItem
            // 
            this.economicsToolStripMenuItem.Name = "economicsToolStripMenuItem";
            this.economicsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.economicsToolStripMenuItem.Text = "Economics";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitViewToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // bitViewToolStripMenuItem
            // 
            this.bitViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.offToolStripMenuItem,
            this.onToolStripMenuItem});
            this.bitViewToolStripMenuItem.Name = "bitViewToolStripMenuItem";
            this.bitViewToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.bitViewToolStripMenuItem.Text = "BitView";
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.offToolStripMenuItem.Text = "Off";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.onToolStripMenuItem.Text = "On";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialToolStripMenuItem,
            this.linksToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.tutorialToolStripMenuItem.Text = "Tutorial";
            // 
            // linksToolStripMenuItem
            // 
            this.linksToolStripMenuItem.Name = "linksToolStripMenuItem";
            this.linksToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.linksToolStripMenuItem.Text = "Links";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panelBitView
            // 
            this.panelBitView.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBitView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBitView.Controls.Add(this.fieldBitsInput);
            this.panelBitView.ForeColor = System.Drawing.Color.White;
            this.panelBitView.Location = new System.Drawing.Point(76, 104);
            this.panelBitView.Name = "panelBitView";
            this.panelBitView.Padding = new System.Windows.Forms.Padding(5);
            this.panelBitView.Size = new System.Drawing.Size(508, 28);
            this.panelBitView.TabIndex = 102;
            // 
            // panelBitOperations
            // 
            this.panelBitOperations.BackColor = System.Drawing.Color.SteelBlue;
            this.panelBitOperations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBitOperations.Controls.Add(this.buttonAnd);
            this.panelBitOperations.Controls.Add(this.buttonOr);
            this.panelBitOperations.Controls.Add(this.buttonXor);
            this.panelBitOperations.Controls.Add(this.buttonNot);
            this.panelBitOperations.Controls.Add(this.buttonRotateRight);
            this.panelBitOperations.Controls.Add(this.buttonRightShift);
            this.panelBitOperations.Controls.Add(this.buttonRotateLeft);
            this.panelBitOperations.Controls.Add(this.buttonLeftShift);
            this.panelBitOperations.Location = new System.Drawing.Point(78, 266);
            this.panelBitOperations.Name = "panelBitOperations";
            this.panelBitOperations.Size = new System.Drawing.Size(194, 88);
            this.panelBitOperations.TabIndex = 20;
            this.panelBitOperations.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBitOperationsPaint);
            // 
            // buttonAnd
            // 
            this.buttonAnd.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAnd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonAnd.Location = new System.Drawing.Point(3, 3);
            this.buttonAnd.Name = "buttonAnd";
            this.buttonAnd.Size = new System.Drawing.Size(45, 39);
            this.buttonAnd.TabIndex = 3;
            this.buttonAnd.Text = "&&";
            this.buttonAnd.UseVisualStyleBackColor = false;
            this.buttonAnd.Click += new System.EventHandler(this.ButtonAndClick);
            this.buttonAnd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonAndMouseDown);
            this.buttonAnd.MouseLeave += new System.EventHandler(this.ButtonAndMouseLeave);
            this.buttonAnd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonAndMouseMove);
            // 
            // buttonOr
            // 
            this.buttonOr.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOr.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonOr.Location = new System.Drawing.Point(3, 44);
            this.buttonOr.Name = "buttonOr";
            this.buttonOr.Size = new System.Drawing.Size(45, 39);
            this.buttonOr.TabIndex = 4;
            this.buttonOr.Text = " &|";
            this.buttonOr.UseVisualStyleBackColor = false;
            this.buttonOr.Click += new System.EventHandler(this.ButtonOrClick);
            this.buttonOr.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonOrMouseDown);
            this.buttonOr.MouseLeave += new System.EventHandler(this.ButtonOrMouseLeave);
            this.buttonOr.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonOrMouseMove);
            // 
            // buttonXor
            // 
            this.buttonXor.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonXor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonXor.Location = new System.Drawing.Point(50, 44);
            this.buttonXor.Name = "buttonXor";
            this.buttonXor.Size = new System.Drawing.Size(45, 39);
            this.buttonXor.TabIndex = 5;
            this.buttonXor.Text = "^";
            this.buttonXor.UseVisualStyleBackColor = false;
            this.buttonXor.Click += new System.EventHandler(this.ButtonXorClick);
            this.buttonXor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonXorMouseDown);
            this.buttonXor.MouseLeave += new System.EventHandler(this.ButtonXorMouseLeave);
            this.buttonXor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonXorMouseMove);
            // 
            // buttonNot
            // 
            this.buttonNot.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonNot.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonNot.Location = new System.Drawing.Point(50, 3);
            this.buttonNot.Name = "buttonNot";
            this.buttonNot.Size = new System.Drawing.Size(45, 39);
            this.buttonNot.TabIndex = 6;
            this.buttonNot.Text = "~";
            this.buttonNot.UseVisualStyleBackColor = false;
            this.buttonNot.Click += new System.EventHandler(this.ButtonNotClick);
            this.buttonNot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonNotMouseDown);
            this.buttonNot.MouseLeave += new System.EventHandler(this.ButtonNotMouseLeave);
            this.buttonNot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonNotMouseMove);
            // 
            // buttonRotateRight
            // 
            this.buttonRotateRight.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonRotateRight.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonRotateRight.Location = new System.Drawing.Point(144, 44);
            this.buttonRotateRight.Name = "buttonRotateRight";
            this.buttonRotateRight.Size = new System.Drawing.Size(45, 39);
            this.buttonRotateRight.TabIndex = 12;
            this.buttonRotateRight.Text = "RoR";
            this.buttonRotateRight.UseVisualStyleBackColor = false;
            this.buttonRotateRight.Click += new System.EventHandler(this.ButtonRotateRightClick);
            this.buttonRotateRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonRotateRightMouseDown);
            this.buttonRotateRight.MouseLeave += new System.EventHandler(this.ButtonRotateRightMouseLeave);
            this.buttonRotateRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonRotateRightMouseMove);
            // 
            // buttonRightShift
            // 
            this.buttonRightShift.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonRightShift.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonRightShift.Location = new System.Drawing.Point(97, 44);
            this.buttonRightShift.Name = "buttonRightShift";
            this.buttonRightShift.Size = new System.Drawing.Size(45, 39);
            this.buttonRightShift.TabIndex = 10;
            this.buttonRightShift.Text = ">>";
            this.buttonRightShift.UseVisualStyleBackColor = false;
            this.buttonRightShift.Click += new System.EventHandler(this.ButtonRightShiftClick);
            this.buttonRightShift.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonRightShiftMouseDown);
            this.buttonRightShift.MouseLeave += new System.EventHandler(this.ButtonRightShiftMouseLeave);
            this.buttonRightShift.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonRightShiftMove);
            // 
            // buttonRotateLeft
            // 
            this.buttonRotateLeft.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonRotateLeft.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonRotateLeft.Location = new System.Drawing.Point(144, 3);
            this.buttonRotateLeft.Name = "buttonRotateLeft";
            this.buttonRotateLeft.Size = new System.Drawing.Size(45, 39);
            this.buttonRotateLeft.TabIndex = 11;
            this.buttonRotateLeft.Text = "RoL";
            this.buttonRotateLeft.UseVisualStyleBackColor = false;
            this.buttonRotateLeft.Click += new System.EventHandler(this.ButtonRotateLeftClick);
            this.buttonRotateLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonRotateLeftMouseDown);
            this.buttonRotateLeft.MouseLeave += new System.EventHandler(this.ButtonRotateLeftMouseLeave);
            this.buttonRotateLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonRotateLeftMouseMove);
            // 
            // buttonLeftShift
            // 
            this.buttonLeftShift.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLeftShift.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonLeftShift.Location = new System.Drawing.Point(97, 3);
            this.buttonLeftShift.Name = "buttonLeftShift";
            this.buttonLeftShift.Size = new System.Drawing.Size(45, 39);
            this.buttonLeftShift.TabIndex = 9;
            this.buttonLeftShift.Text = "<<";
            this.buttonLeftShift.UseVisualStyleBackColor = false;
            this.buttonLeftShift.Click += new System.EventHandler(this.ButtonLeftShiftClick);
            this.buttonLeftShift.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonLeftShiftMouseDown);
            this.buttonLeftShift.MouseLeave += new System.EventHandler(this.ButtonLeftShiftMouseLeave);
            this.buttonLeftShift.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonLeftShiftMouseMove);
            // 
            // panelOctDigits
            // 
            this.panelOctDigits.BackColor = System.Drawing.Color.SteelBlue;
            this.panelOctDigits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOctDigits.Controls.Add(this.buttonOctSix6);
            this.panelOctDigits.Controls.Add(this.buttonOctSeven7);
            this.panelOctDigits.Controls.Add(this.buttonOctFour4);
            this.panelOctDigits.Controls.Add(this.buttonOctFive5);
            this.panelOctDigits.Controls.Add(this.buttonOctTwo2);
            this.panelOctDigits.Controls.Add(this.buttonOctThree3);
            this.panelOctDigits.Controls.Add(this.buttonOctZero0);
            this.panelOctDigits.Controls.Add(this.buttonOctOne1);
            this.panelOctDigits.Location = new System.Drawing.Point(278, 172);
            this.panelOctDigits.Name = "panelOctDigits";
            this.panelOctDigits.Size = new System.Drawing.Size(161, 182);
            this.panelOctDigits.TabIndex = 120;
            this.panelOctDigits.Visible = false;
            this.panelOctDigits.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelOctDigitsPaint);
            // 
            // buttonOctSix6
            // 
            this.buttonOctSix6.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOctSix6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonOctSix6.Location = new System.Drawing.Point(3, 135);
            this.buttonOctSix6.Name = "buttonOctSix6";
            this.buttonOctSix6.Size = new System.Drawing.Size(76, 42);
            this.buttonOctSix6.TabIndex = 20;
            this.buttonOctSix6.Text = "6";
            this.buttonOctSix6.UseVisualStyleBackColor = false;
            this.buttonOctSix6.Click += new System.EventHandler(this.ButtonSix6Click);
            this.buttonOctSix6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonOctSix6MouseDown);
            this.buttonOctSix6.MouseLeave += new System.EventHandler(this.ButtonOctSix6MouseLeave);
            this.buttonOctSix6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonOctSix6MouseMove);
            // 
            // buttonOctSeven7
            // 
            this.buttonOctSeven7.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOctSeven7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonOctSeven7.Location = new System.Drawing.Point(80, 135);
            this.buttonOctSeven7.Name = "buttonOctSeven7";
            this.buttonOctSeven7.Size = new System.Drawing.Size(76, 42);
            this.buttonOctSeven7.TabIndex = 22;
            this.buttonOctSeven7.Text = "7";
            this.buttonOctSeven7.UseVisualStyleBackColor = false;
            this.buttonOctSeven7.Click += new System.EventHandler(this.ButtonSeven7Click);
            this.buttonOctSeven7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonOctSeven7MouseDown);
            this.buttonOctSeven7.MouseLeave += new System.EventHandler(this.ButtonOctSeven7MouseLeave);
            this.buttonOctSeven7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonOctSeven7MouseMove);
            // 
            // buttonOctFour4
            // 
            this.buttonOctFour4.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOctFour4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonOctFour4.Location = new System.Drawing.Point(3, 91);
            this.buttonOctFour4.Name = "buttonOctFour4";
            this.buttonOctFour4.Size = new System.Drawing.Size(76, 42);
            this.buttonOctFour4.TabIndex = 17;
            this.buttonOctFour4.Text = "4";
            this.buttonOctFour4.UseVisualStyleBackColor = false;
            this.buttonOctFour4.Click += new System.EventHandler(this.ButtonFour4Click);
            this.buttonOctFour4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonOctFour4MouseDown);
            this.buttonOctFour4.MouseLeave += new System.EventHandler(this.ButtonOctFour4MouseLeave);
            this.buttonOctFour4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonOctFour4MouseMove);
            // 
            // buttonOctFive5
            // 
            this.buttonOctFive5.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOctFive5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonOctFive5.Location = new System.Drawing.Point(80, 91);
            this.buttonOctFive5.Name = "buttonOctFive5";
            this.buttonOctFive5.Size = new System.Drawing.Size(76, 42);
            this.buttonOctFive5.TabIndex = 19;
            this.buttonOctFive5.Text = "5";
            this.buttonOctFive5.UseVisualStyleBackColor = false;
            this.buttonOctFive5.Click += new System.EventHandler(this.ButtonFive5Click);
            this.buttonOctFive5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonOctFive5MouseDown);
            this.buttonOctFive5.MouseLeave += new System.EventHandler(this.ButtonOctFive5MouseLeave);
            this.buttonOctFive5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonOctFive5MouseMove);
            // 
            // buttonOctTwo2
            // 
            this.buttonOctTwo2.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOctTwo2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonOctTwo2.Location = new System.Drawing.Point(3, 47);
            this.buttonOctTwo2.Name = "buttonOctTwo2";
            this.buttonOctTwo2.Size = new System.Drawing.Size(76, 42);
            this.buttonOctTwo2.TabIndex = 14;
            this.buttonOctTwo2.Text = "2";
            this.buttonOctTwo2.UseVisualStyleBackColor = false;
            this.buttonOctTwo2.Click += new System.EventHandler(this.ButtonTwo2Click);
            this.buttonOctTwo2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonOctTwo2MouseDown);
            this.buttonOctTwo2.MouseLeave += new System.EventHandler(this.ButtonOctTwo2MouseLeave);
            this.buttonOctTwo2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonOctTwo2MouseMove);
            // 
            // buttonOctThree3
            // 
            this.buttonOctThree3.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOctThree3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonOctThree3.Location = new System.Drawing.Point(80, 47);
            this.buttonOctThree3.Name = "buttonOctThree3";
            this.buttonOctThree3.Size = new System.Drawing.Size(76, 42);
            this.buttonOctThree3.TabIndex = 16;
            this.buttonOctThree3.Text = "3";
            this.buttonOctThree3.UseVisualStyleBackColor = false;
            this.buttonOctThree3.Click += new System.EventHandler(this.ButtonThree3Click);
            this.buttonOctThree3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonOctThree3MouseDown);
            this.buttonOctThree3.MouseLeave += new System.EventHandler(this.ButtonOctThree3MouseLeave);
            this.buttonOctThree3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonOctThree3MouseMove);
            // 
            // buttonOctZero0
            // 
            this.buttonOctZero0.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOctZero0.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonOctZero0.Location = new System.Drawing.Point(3, 3);
            this.buttonOctZero0.Name = "buttonOctZero0";
            this.buttonOctZero0.Size = new System.Drawing.Size(76, 42);
            this.buttonOctZero0.TabIndex = 3;
            this.buttonOctZero0.Text = "0";
            this.buttonOctZero0.UseVisualStyleBackColor = false;
            this.buttonOctZero0.Click += new System.EventHandler(this.ButtonZero0Click);
            this.buttonOctZero0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonOctZero0MouseDown);
            this.buttonOctZero0.MouseLeave += new System.EventHandler(this.ButtonOctZero0MouseLeave);
            this.buttonOctZero0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonOctZero0MouseMove);
            // 
            // buttonOctOne1
            // 
            this.buttonOctOne1.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOctOne1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonOctOne1.Location = new System.Drawing.Point(80, 3);
            this.buttonOctOne1.Name = "buttonOctOne1";
            this.buttonOctOne1.Size = new System.Drawing.Size(76, 42);
            this.buttonOctOne1.TabIndex = 4;
            this.buttonOctOne1.Text = "1";
            this.buttonOctOne1.UseVisualStyleBackColor = false;
            this.buttonOctOne1.Click += new System.EventHandler(this.ButtonOne1Click);
            this.buttonOctOne1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonOctOne1MouseDown);
            this.buttonOctOne1.MouseLeave += new System.EventHandler(this.ButtonOctOne1MouseLeave);
            this.buttonOctOne1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonOctOne1MouseMove);
            // 
            // panelDigits
            // 
            this.panelDigits.BackColor = System.Drawing.Color.SteelBlue;
            this.panelDigits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDigits.Controls.Add(this.buttonZero);
            this.panelDigits.Controls.Add(this.buttonOne);
            this.panelDigits.Controls.Add(this.buttonOneOne);
            this.panelDigits.Controls.Add(this.buttonZeroZero);
            this.panelDigits.Controls.Add(this.buttonOneZero);
            this.panelDigits.Controls.Add(this.buttonZeroOne);
            this.panelDigits.Location = new System.Drawing.Point(278, 172);
            this.panelDigits.Name = "panelDigits";
            this.panelDigits.Size = new System.Drawing.Size(161, 182);
            this.panelDigits.TabIndex = 21;
            this.panelDigits.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDigitsPaint);
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonZero.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonZero.Location = new System.Drawing.Point(3, 3);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(76, 57);
            this.buttonZero.TabIndex = 40;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.ButtonZero0Click);
            this.buttonZero.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonZeroMouseDown);
            this.buttonZero.MouseLeave += new System.EventHandler(this.ButtonZeroMouseLeave);
            this.buttonZero.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonZeroMouseMove);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOne.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonOne.Location = new System.Drawing.Point(80, 3);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(76, 57);
            this.buttonOne.TabIndex = 41;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.ButtonOne1Click);
            this.buttonOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonOneMouseDown);
            this.buttonOne.MouseLeave += new System.EventHandler(this.ButtonOneMouseLeave);
            this.buttonOne.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonOneMouseMove);
            // 
            // buttonOneOne
            // 
            this.buttonOneOne.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOneOne.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonOneOne.Location = new System.Drawing.Point(80, 121);
            this.buttonOneOne.Name = "buttonOneOne";
            this.buttonOneOne.Size = new System.Drawing.Size(76, 57);
            this.buttonOneOne.TabIndex = 45;
            this.buttonOneOne.Text = "11";
            this.buttonOneOne.UseVisualStyleBackColor = false;
            this.buttonOneOne.Click += new System.EventHandler(this.ButtonOneOneClick);
            this.buttonOneOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonOneOneMouseDown);
            this.buttonOneOne.MouseLeave += new System.EventHandler(this.ButtonOneOneMouseLeave);
            this.buttonOneOne.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonOneOneMouseMove);
            // 
            // buttonZeroZero
            // 
            this.buttonZeroZero.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonZeroZero.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonZeroZero.Location = new System.Drawing.Point(3, 62);
            this.buttonZeroZero.Name = "buttonZeroZero";
            this.buttonZeroZero.Size = new System.Drawing.Size(76, 57);
            this.buttonZeroZero.TabIndex = 42;
            this.buttonZeroZero.Text = "00";
            this.buttonZeroZero.UseVisualStyleBackColor = false;
            this.buttonZeroZero.Click += new System.EventHandler(this.ButtonZeroZeroClick);
            this.buttonZeroZero.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonZeroZeroMouseDown);
            this.buttonZeroZero.MouseLeave += new System.EventHandler(this.ButtonZeroZeroMouseLeave);
            this.buttonZeroZero.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonZeroZeroMouseMove);
            // 
            // buttonOneZero
            // 
            this.buttonOneZero.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOneZero.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonOneZero.Location = new System.Drawing.Point(3, 121);
            this.buttonOneZero.Name = "buttonOneZero";
            this.buttonOneZero.Size = new System.Drawing.Size(76, 57);
            this.buttonOneZero.TabIndex = 44;
            this.buttonOneZero.Text = "10";
            this.buttonOneZero.UseVisualStyleBackColor = false;
            this.buttonOneZero.Click += new System.EventHandler(this.ButtonOneZeroClick);
            this.buttonOneZero.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonOneZeroMouseDown);
            this.buttonOneZero.MouseLeave += new System.EventHandler(this.ButtonOneZeroMouseLeave);
            this.buttonOneZero.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonOneZeroMouseMove);
            // 
            // buttonZeroOne
            // 
            this.buttonZeroOne.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonZeroOne.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonZeroOne.Location = new System.Drawing.Point(80, 62);
            this.buttonZeroOne.Name = "buttonZeroOne";
            this.buttonZeroOne.Size = new System.Drawing.Size(76, 57);
            this.buttonZeroOne.TabIndex = 43;
            this.buttonZeroOne.Text = "01";
            this.buttonZeroOne.UseVisualStyleBackColor = false;
            this.buttonZeroOne.Click += new System.EventHandler(this.ButtonZeroOneClick);
            this.buttonZeroOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonZeroOneMouseDown);
            this.buttonZeroOne.MouseLeave += new System.EventHandler(this.ButtonZeroOneMouseLeave);
            this.buttonZeroOne.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonZeroOneMouseMove);
            // 
            // panelDecimalDigits
            // 
            this.panelDecimalDigits.BackColor = System.Drawing.Color.SteelBlue;
            this.panelDecimalDigits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDecimalDigits.Controls.Add(this.buttonSix6);
            this.panelDecimalDigits.Controls.Add(this.buttonNine9);
            this.panelDecimalDigits.Controls.Add(this.buttonFive5);
            this.panelDecimalDigits.Controls.Add(this.buttonEight8);
            this.panelDecimalDigits.Controls.Add(this.buttonFour4);
            this.panelDecimalDigits.Controls.Add(this.buttonZero0);
            this.panelDecimalDigits.Controls.Add(this.buttonSeven7);
            this.panelDecimalDigits.Controls.Add(this.buttonOne1);
            this.panelDecimalDigits.Controls.Add(this.buttonTwo2);
            this.panelDecimalDigits.Controls.Add(this.buttonThree3);
            this.panelDecimalDigits.Location = new System.Drawing.Point(278, 172);
            this.panelDecimalDigits.Name = "panelDecimalDigits";
            this.panelDecimalDigits.Size = new System.Drawing.Size(161, 182);
            this.panelDecimalDigits.TabIndex = 20;
            this.panelDecimalDigits.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDecimalDigitsPaint);
            // 
            // buttonSix6
            // 
            this.buttonSix6.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSix6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonSix6.Location = new System.Drawing.Point(106, 47);
            this.buttonSix6.Name = "buttonSix6";
            this.buttonSix6.Size = new System.Drawing.Size(50, 42);
            this.buttonSix6.TabIndex = 20;
            this.buttonSix6.Text = "6";
            this.buttonSix6.UseVisualStyleBackColor = false;
            this.buttonSix6.Click += new System.EventHandler(this.ButtonSix6Click);
            this.buttonSix6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonSix6MouseDown);
            this.buttonSix6.MouseLeave += new System.EventHandler(this.ButtonSix6MouseLeave);
            this.buttonSix6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonSix6MouseMove);
            // 
            // buttonNine9
            // 
            this.buttonNine9.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonNine9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonNine9.Location = new System.Drawing.Point(106, 91);
            this.buttonNine9.Name = "buttonNine9";
            this.buttonNine9.Size = new System.Drawing.Size(50, 42);
            this.buttonNine9.TabIndex = 22;
            this.buttonNine9.Text = "9";
            this.buttonNine9.UseVisualStyleBackColor = false;
            this.buttonNine9.Click += new System.EventHandler(this.ButtonNine9Click);
            this.buttonNine9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonNine9MouseDown);
            this.buttonNine9.MouseLeave += new System.EventHandler(this.ButtonNine9MouseLeave);
            this.buttonNine9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonNine9MouseMove);
            // 
            // buttonFive5
            // 
            this.buttonFive5.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonFive5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonFive5.Location = new System.Drawing.Point(54, 47);
            this.buttonFive5.Name = "buttonFive5";
            this.buttonFive5.Size = new System.Drawing.Size(51, 42);
            this.buttonFive5.TabIndex = 17;
            this.buttonFive5.Text = "5";
            this.buttonFive5.UseVisualStyleBackColor = false;
            this.buttonFive5.Click += new System.EventHandler(this.ButtonFive5Click);
            this.buttonFive5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonFive5MouseDown);
            this.buttonFive5.MouseLeave += new System.EventHandler(this.ButtonFive5MouseLeave);
            this.buttonFive5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonFive5MouseMove);
            // 
            // buttonEight8
            // 
            this.buttonEight8.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEight8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonEight8.Location = new System.Drawing.Point(54, 91);
            this.buttonEight8.Name = "buttonEight8";
            this.buttonEight8.Size = new System.Drawing.Size(51, 42);
            this.buttonEight8.TabIndex = 19;
            this.buttonEight8.Text = "8";
            this.buttonEight8.UseVisualStyleBackColor = false;
            this.buttonEight8.Click += new System.EventHandler(this.ButtonEight8Click);
            this.buttonEight8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonEight8MouseDown);
            this.buttonEight8.MouseLeave += new System.EventHandler(this.ButtonEight8MouseLeave);
            this.buttonEight8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonEight8MouseMove);
            // 
            // buttonFour4
            // 
            this.buttonFour4.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonFour4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonFour4.Location = new System.Drawing.Point(3, 47);
            this.buttonFour4.Name = "buttonFour4";
            this.buttonFour4.Size = new System.Drawing.Size(50, 42);
            this.buttonFour4.TabIndex = 14;
            this.buttonFour4.Text = "4";
            this.buttonFour4.UseVisualStyleBackColor = false;
            this.buttonFour4.Click += new System.EventHandler(this.ButtonFour4Click);
            this.buttonFour4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonFour4MouseDown);
            this.buttonFour4.MouseLeave += new System.EventHandler(this.ButtonFour4MouseLeave);
            this.buttonFour4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonFour4MouseMove);
            // 
            // buttonZero0
            // 
            this.buttonZero0.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonZero0.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonZero0.Location = new System.Drawing.Point(3, 135);
            this.buttonZero0.Name = "buttonZero0";
            this.buttonZero0.Size = new System.Drawing.Size(154, 42);
            this.buttonZero0.TabIndex = 15;
            this.buttonZero0.Text = "0";
            this.buttonZero0.UseVisualStyleBackColor = false;
            this.buttonZero0.Click += new System.EventHandler(this.ButtonZero0Click);
            this.buttonZero0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonZero0MouseDown);
            this.buttonZero0.MouseLeave += new System.EventHandler(this.ButtonZero0MouseLeave);
            this.buttonZero0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonZero0MouseMove);
            // 
            // buttonSeven7
            // 
            this.buttonSeven7.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSeven7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonSeven7.Location = new System.Drawing.Point(3, 91);
            this.buttonSeven7.Name = "buttonSeven7";
            this.buttonSeven7.Size = new System.Drawing.Size(50, 42);
            this.buttonSeven7.TabIndex = 16;
            this.buttonSeven7.Text = "7";
            this.buttonSeven7.UseVisualStyleBackColor = false;
            this.buttonSeven7.Click += new System.EventHandler(this.ButtonSeven7Click);
            this.buttonSeven7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonSeven7MouseDown);
            this.buttonSeven7.MouseLeave += new System.EventHandler(this.ButtonSeven7MouseLeave);
            this.buttonSeven7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonSeven7MouseMove);
            // 
            // buttonOne1
            // 
            this.buttonOne1.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOne1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonOne1.Location = new System.Drawing.Point(3, 3);
            this.buttonOne1.Name = "buttonOne1";
            this.buttonOne1.Size = new System.Drawing.Size(50, 42);
            this.buttonOne1.TabIndex = 3;
            this.buttonOne1.Text = "1";
            this.buttonOne1.UseVisualStyleBackColor = false;
            this.buttonOne1.Click += new System.EventHandler(this.ButtonOne1Click);
            this.buttonOne1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonOne1MouseDown);
            this.buttonOne1.MouseLeave += new System.EventHandler(this.ButtonOne1MouseLeave);
            this.buttonOne1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonOne1MouseMove);
            // 
            // buttonTwo2
            // 
            this.buttonTwo2.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonTwo2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonTwo2.Location = new System.Drawing.Point(54, 3);
            this.buttonTwo2.Name = "buttonTwo2";
            this.buttonTwo2.Size = new System.Drawing.Size(51, 42);
            this.buttonTwo2.TabIndex = 4;
            this.buttonTwo2.Text = "2";
            this.buttonTwo2.UseVisualStyleBackColor = false;
            this.buttonTwo2.Click += new System.EventHandler(this.ButtonTwo2Click);
            this.buttonTwo2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonTwo2MouseDown);
            this.buttonTwo2.MouseLeave += new System.EventHandler(this.ButtonTwo2MouseLeave);
            this.buttonTwo2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonTwo2MouseMove);
            // 
            // buttonThree3
            // 
            this.buttonThree3.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonThree3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonThree3.Location = new System.Drawing.Point(106, 3);
            this.buttonThree3.Name = "buttonThree3";
            this.buttonThree3.Size = new System.Drawing.Size(50, 42);
            this.buttonThree3.TabIndex = 13;
            this.buttonThree3.Text = "3";
            this.buttonThree3.UseVisualStyleBackColor = false;
            this.buttonThree3.Click += new System.EventHandler(this.ButtonThree3Click);
            this.buttonThree3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonThree3MouseDown);
            this.buttonThree3.MouseLeave += new System.EventHandler(this.ButtonThree3MouseLeave);
            this.buttonThree3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonThree3MouseMove);
            // 
            // panelHexDigits
            // 
            this.panelHexDigits.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHexDigits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHexDigits.Controls.Add(this.buttonHexF);
            this.panelHexDigits.Controls.Add(this.buttonHexE);
            this.panelHexDigits.Controls.Add(this.buttonHexD);
            this.panelHexDigits.Controls.Add(this.buttonHexC);
            this.panelHexDigits.Controls.Add(this.buttonHexB);
            this.panelHexDigits.Controls.Add(this.buttonHexA);
            this.panelHexDigits.Controls.Add(this.buttonHexSeven7);
            this.panelHexDigits.Controls.Add(this.buttonHexSix6);
            this.panelHexDigits.Controls.Add(this.buttonHexNine9);
            this.panelHexDigits.Controls.Add(this.buttonHexEight8);
            this.panelHexDigits.Controls.Add(this.buttonHexFive5);
            this.panelHexDigits.Controls.Add(this.buttonHexFour4);
            this.panelHexDigits.Controls.Add(this.buttonHexThree3);
            this.panelHexDigits.Controls.Add(this.buttonHexZero0);
            this.panelHexDigits.Controls.Add(this.buttonHexOne1);
            this.panelHexDigits.Controls.Add(this.buttonHexTwo2);
            this.panelHexDigits.Location = new System.Drawing.Point(278, 172);
            this.panelHexDigits.Name = "panelHexDigits";
            this.panelHexDigits.Size = new System.Drawing.Size(161, 182);
            this.panelHexDigits.TabIndex = 111;
            this.panelHexDigits.Visible = false;
            this.panelHexDigits.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelHexDigitsPaint);
            // 
            // buttonHexF
            // 
            this.buttonHexF.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHexF.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHexF.Location = new System.Drawing.Point(118, 135);
            this.buttonHexF.Name = "buttonHexF";
            this.buttonHexF.Size = new System.Drawing.Size(38, 43);
            this.buttonHexF.TabIndex = 30;
            this.buttonHexF.Text = "F";
            this.buttonHexF.UseVisualStyleBackColor = false;
            this.buttonHexF.Click += new System.EventHandler(this.ButtonHexFClick);
            this.buttonHexF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHexFMouseDown);
            this.buttonHexF.MouseLeave += new System.EventHandler(this.ButtonHexFMouseLeave);
            this.buttonHexF.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonHexFMouseMove);
            // 
            // buttonHexE
            // 
            this.buttonHexE.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHexE.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHexE.Location = new System.Drawing.Point(80, 135);
            this.buttonHexE.Name = "buttonHexE";
            this.buttonHexE.Size = new System.Drawing.Size(38, 43);
            this.buttonHexE.TabIndex = 29;
            this.buttonHexE.Text = "E";
            this.buttonHexE.UseVisualStyleBackColor = false;
            this.buttonHexE.Click += new System.EventHandler(this.ButtonHexEClick);
            this.buttonHexE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHexEMouseDown);
            this.buttonHexE.MouseLeave += new System.EventHandler(this.ButtonHexEMouseLeave);
            this.buttonHexE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonHexEMouseMove);
            // 
            // buttonHexD
            // 
            this.buttonHexD.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHexD.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHexD.Location = new System.Drawing.Point(41, 135);
            this.buttonHexD.Name = "buttonHexD";
            this.buttonHexD.Size = new System.Drawing.Size(39, 43);
            this.buttonHexD.TabIndex = 28;
            this.buttonHexD.Text = "D";
            this.buttonHexD.UseVisualStyleBackColor = false;
            this.buttonHexD.Click += new System.EventHandler(this.ButtonHexDClick);
            this.buttonHexD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHexDMouseDown);
            this.buttonHexD.MouseLeave += new System.EventHandler(this.ButtonHexDMouseLeave);
            this.buttonHexD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonHexDMouseMove);
            // 
            // buttonHexC
            // 
            this.buttonHexC.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHexC.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHexC.Location = new System.Drawing.Point(3, 135);
            this.buttonHexC.Name = "buttonHexC";
            this.buttonHexC.Size = new System.Drawing.Size(38, 43);
            this.buttonHexC.TabIndex = 27;
            this.buttonHexC.Text = "C";
            this.buttonHexC.UseVisualStyleBackColor = false;
            this.buttonHexC.Click += new System.EventHandler(this.ButtonHexCClick);
            this.buttonHexC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHexCMouseDown);
            this.buttonHexC.MouseLeave += new System.EventHandler(this.ButtonHexCMouseLeave);
            this.buttonHexC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonHexCMouseMove);
            // 
            // buttonHexB
            // 
            this.buttonHexB.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHexB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHexB.Location = new System.Drawing.Point(118, 91);
            this.buttonHexB.Name = "buttonHexB";
            this.buttonHexB.Size = new System.Drawing.Size(38, 43);
            this.buttonHexB.TabIndex = 26;
            this.buttonHexB.Text = "B";
            this.buttonHexB.UseVisualStyleBackColor = false;
            this.buttonHexB.Click += new System.EventHandler(this.ButtonHexBClick);
            this.buttonHexB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHexBMouseDown);
            this.buttonHexB.MouseLeave += new System.EventHandler(this.ButtonHexBMouseLeave);
            this.buttonHexB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonHexBMouseMove);
            // 
            // buttonHexA
            // 
            this.buttonHexA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHexA.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHexA.Location = new System.Drawing.Point(80, 91);
            this.buttonHexA.Name = "buttonHexA";
            this.buttonHexA.Size = new System.Drawing.Size(39, 43);
            this.buttonHexA.TabIndex = 25;
            this.buttonHexA.Text = "A";
            this.buttonHexA.UseVisualStyleBackColor = false;
            this.buttonHexA.Click += new System.EventHandler(this.ButtonHexAClick);
            this.buttonHexA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHexAMouseDown);
            this.buttonHexA.MouseLeave += new System.EventHandler(this.ButtonHexAMouseLeave);
            this.buttonHexA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonHexAMouseMove);
            // 
            // buttonHexSeven7
            // 
            this.buttonHexSeven7.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHexSeven7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHexSeven7.Location = new System.Drawing.Point(118, 47);
            this.buttonHexSeven7.Name = "buttonHexSeven7";
            this.buttonHexSeven7.Size = new System.Drawing.Size(38, 43);
            this.buttonHexSeven7.TabIndex = 24;
            this.buttonHexSeven7.Text = "7";
            this.buttonHexSeven7.UseVisualStyleBackColor = false;
            this.buttonHexSeven7.Click += new System.EventHandler(this.ButtonSeven7Click);
            this.buttonHexSeven7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHexSeven7MouseDown);
            this.buttonHexSeven7.MouseLeave += new System.EventHandler(this.ButtonHexSeven7MouseLeave);
            this.buttonHexSeven7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonHexSeven7MouseMove);
            // 
            // buttonHexSix6
            // 
            this.buttonHexSix6.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHexSix6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHexSix6.Location = new System.Drawing.Point(80, 47);
            this.buttonHexSix6.Name = "buttonHexSix6";
            this.buttonHexSix6.Size = new System.Drawing.Size(38, 43);
            this.buttonHexSix6.TabIndex = 23;
            this.buttonHexSix6.Text = "6";
            this.buttonHexSix6.UseVisualStyleBackColor = false;
            this.buttonHexSix6.Click += new System.EventHandler(this.ButtonSix6Click);
            this.buttonHexSix6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHexSix6MouseDown);
            this.buttonHexSix6.MouseLeave += new System.EventHandler(this.ButtonHexSix6MouseLeave);
            this.buttonHexSix6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonHexSix6MouseMove);
            // 
            // buttonHexNine9
            // 
            this.buttonHexNine9.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHexNine9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHexNine9.Location = new System.Drawing.Point(41, 91);
            this.buttonHexNine9.Name = "buttonHexNine9";
            this.buttonHexNine9.Size = new System.Drawing.Size(39, 43);
            this.buttonHexNine9.TabIndex = 22;
            this.buttonHexNine9.Text = "9";
            this.buttonHexNine9.UseVisualStyleBackColor = false;
            this.buttonHexNine9.Click += new System.EventHandler(this.ButtonNine9Click);
            this.buttonHexNine9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHexNine9MouseDown);
            this.buttonHexNine9.MouseLeave += new System.EventHandler(this.ButtonHexNine9MouseLeave);
            this.buttonHexNine9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonHexNine9MouseMove);
            // 
            // buttonHexEight8
            // 
            this.buttonHexEight8.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHexEight8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHexEight8.Location = new System.Drawing.Point(3, 91);
            this.buttonHexEight8.Name = "buttonHexEight8";
            this.buttonHexEight8.Size = new System.Drawing.Size(38, 43);
            this.buttonHexEight8.TabIndex = 17;
            this.buttonHexEight8.Text = "8";
            this.buttonHexEight8.UseVisualStyleBackColor = false;
            this.buttonHexEight8.Click += new System.EventHandler(this.ButtonEight8Click);
            this.buttonHexEight8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHexEight8MouseDown);
            this.buttonHexEight8.MouseLeave += new System.EventHandler(this.ButtonHexEight8MouseLeave);
            this.buttonHexEight8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonHexEight8MouseMove);
            // 
            // buttonHexFive5
            // 
            this.buttonHexFive5.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHexFive5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHexFive5.Location = new System.Drawing.Point(41, 47);
            this.buttonHexFive5.Name = "buttonHexFive5";
            this.buttonHexFive5.Size = new System.Drawing.Size(39, 43);
            this.buttonHexFive5.TabIndex = 19;
            this.buttonHexFive5.Text = "5";
            this.buttonHexFive5.UseVisualStyleBackColor = false;
            this.buttonHexFive5.Click += new System.EventHandler(this.ButtonFive5Click);
            this.buttonHexFive5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHexFive5MouseDown);
            this.buttonHexFive5.MouseLeave += new System.EventHandler(this.ButtonHexFive5MouseLeave);
            this.buttonHexFive5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonHexFive5MouseMove);
            // 
            // buttonHexFour4
            // 
            this.buttonHexFour4.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHexFour4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHexFour4.Location = new System.Drawing.Point(3, 47);
            this.buttonHexFour4.Name = "buttonHexFour4";
            this.buttonHexFour4.Size = new System.Drawing.Size(38, 43);
            this.buttonHexFour4.TabIndex = 14;
            this.buttonHexFour4.Text = "4";
            this.buttonHexFour4.UseVisualStyleBackColor = false;
            this.buttonHexFour4.Click += new System.EventHandler(this.ButtonFour4Click);
            this.buttonHexFour4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHexFour4MouseDown);
            this.buttonHexFour4.MouseLeave += new System.EventHandler(this.ButtonHexFour4MouseLeave);
            this.buttonHexFour4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonHexFour4MouseMove);
            // 
            // buttonHexThree3
            // 
            this.buttonHexThree3.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHexThree3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHexThree3.Location = new System.Drawing.Point(118, 3);
            this.buttonHexThree3.Name = "buttonHexThree3";
            this.buttonHexThree3.Size = new System.Drawing.Size(38, 43);
            this.buttonHexThree3.TabIndex = 16;
            this.buttonHexThree3.Text = "3";
            this.buttonHexThree3.UseVisualStyleBackColor = false;
            this.buttonHexThree3.Click += new System.EventHandler(this.ButtonThree3Click);
            this.buttonHexThree3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHexThree3MouseDown);
            this.buttonHexThree3.MouseLeave += new System.EventHandler(this.ButtonHexThree3MouseLeave);
            this.buttonHexThree3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonHexThree3MouseMove);
            // 
            // buttonHexZero0
            // 
            this.buttonHexZero0.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHexZero0.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHexZero0.Location = new System.Drawing.Point(3, 3);
            this.buttonHexZero0.Name = "buttonHexZero0";
            this.buttonHexZero0.Size = new System.Drawing.Size(38, 43);
            this.buttonHexZero0.TabIndex = 3;
            this.buttonHexZero0.Text = "0";
            this.buttonHexZero0.UseVisualStyleBackColor = false;
            this.buttonHexZero0.Click += new System.EventHandler(this.ButtonZero0Click);
            this.buttonHexZero0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHexZero0MouseDown);
            this.buttonHexZero0.MouseLeave += new System.EventHandler(this.ButtonHexZero0MouseLeave);
            this.buttonHexZero0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonHexZero0MouseMove);
            // 
            // buttonHexOne1
            // 
            this.buttonHexOne1.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHexOne1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHexOne1.Location = new System.Drawing.Point(41, 3);
            this.buttonHexOne1.Name = "buttonHexOne1";
            this.buttonHexOne1.Size = new System.Drawing.Size(39, 43);
            this.buttonHexOne1.TabIndex = 4;
            this.buttonHexOne1.Text = "1";
            this.buttonHexOne1.UseVisualStyleBackColor = false;
            this.buttonHexOne1.Click += new System.EventHandler(this.ButtonOne1Click);
            this.buttonHexOne1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHexOne1MouseDown);
            this.buttonHexOne1.MouseLeave += new System.EventHandler(this.ButtonHexOne1MouseLeave);
            this.buttonHexOne1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonHexOne1MouseMove);
            // 
            // buttonHexTwo2
            // 
            this.buttonHexTwo2.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHexTwo2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHexTwo2.Location = new System.Drawing.Point(80, 3);
            this.buttonHexTwo2.Name = "buttonHexTwo2";
            this.buttonHexTwo2.Size = new System.Drawing.Size(38, 43);
            this.buttonHexTwo2.TabIndex = 13;
            this.buttonHexTwo2.Text = "2";
            this.buttonHexTwo2.UseVisualStyleBackColor = false;
            this.buttonHexTwo2.Click += new System.EventHandler(this.ButtonTwo2Click);
            this.buttonHexTwo2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHexTwo2MouseDown);
            this.buttonHexTwo2.MouseLeave += new System.EventHandler(this.ButtonHexTwo2MouseLeave);
            this.buttonHexTwo2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonHexTwo2MouseMove);
            // 
            // panelArithmeticOperations
            // 
            this.panelArithmeticOperations.BackColor = System.Drawing.Color.SteelBlue;
            this.panelArithmeticOperations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelArithmeticOperations.Controls.Add(this.buttonRightBracket);
            this.panelArithmeticOperations.Controls.Add(this.buttonLeftBracket);
            this.panelArithmeticOperations.Controls.Add(this.buttonBackspace);
            this.panelArithmeticOperations.Controls.Add(this.buttonIncrement);
            this.panelArithmeticOperations.Controls.Add(this.buttonDecrement);
            this.panelArithmeticOperations.Controls.Add(this.buttonDivide);
            this.panelArithmeticOperations.Controls.Add(this.buttonMulitply);
            this.panelArithmeticOperations.Controls.Add(this.buttonModDivide);
            this.panelArithmeticOperations.Controls.Add(this.buttonNegative);
            this.panelArithmeticOperations.Controls.Add(this.buttonMinus);
            this.panelArithmeticOperations.Controls.Add(this.buttonEqual);
            this.panelArithmeticOperations.Controls.Add(this.buttonPlus);
            this.panelArithmeticOperations.Location = new System.Drawing.Point(445, 172);
            this.panelArithmeticOperations.Name = "panelArithmeticOperations";
            this.panelArithmeticOperations.Size = new System.Drawing.Size(139, 182);
            this.panelArithmeticOperations.TabIndex = 23;
            // 
            // buttonRightBracket
            // 
            this.buttonRightBracket.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonRightBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRightBracket.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonRightBracket.Location = new System.Drawing.Point(91, 47);
            this.buttonRightBracket.Name = "buttonRightBracket";
            this.buttonRightBracket.Size = new System.Drawing.Size(43, 43);
            this.buttonRightBracket.TabIndex = 31;
            this.buttonRightBracket.Text = ")";
            this.buttonRightBracket.UseVisualStyleBackColor = false;
            this.buttonRightBracket.Click += new System.EventHandler(this.ButtonRightBracketClick);
            this.buttonRightBracket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonRightBracketMouseDown);
            this.buttonRightBracket.MouseLeave += new System.EventHandler(this.ButtonRightBracketMouseLeave);
            this.buttonRightBracket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonRightBracketMouseMove);
            // 
            // buttonLeftBracket
            // 
            this.buttonLeftBracket.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLeftBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeftBracket.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonLeftBracket.Location = new System.Drawing.Point(91, 3);
            this.buttonLeftBracket.Name = "buttonLeftBracket";
            this.buttonLeftBracket.Size = new System.Drawing.Size(43, 43);
            this.buttonLeftBracket.TabIndex = 30;
            this.buttonLeftBracket.Text = "(";
            this.buttonLeftBracket.UseVisualStyleBackColor = false;
            this.buttonLeftBracket.Click += new System.EventHandler(this.ButtonLeftBracketClick);
            this.buttonLeftBracket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonLeftBracketMouseDown);
            this.buttonLeftBracket.MouseLeave += new System.EventHandler(this.ButtonLeftBracketMouseLeave);
            this.buttonLeftBracket.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonLeftBracketMouseMove);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackspace.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonBackspace.Location = new System.Drawing.Point(91, 91);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(42, 43);
            this.buttonBackspace.TabIndex = 28;
            this.buttonBackspace.Text = "←";
            this.buttonBackspace.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonBackspace.UseVisualStyleBackColor = false;
            this.buttonBackspace.Click += new System.EventHandler(this.ButtonBackspaceClick);
            this.buttonBackspace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonBackspaceMouseDown);
            this.buttonBackspace.MouseLeave += new System.EventHandler(this.ButtonBackspaceMouseLeave);
            this.buttonBackspace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonBackspaceMouseMove);
            // 
            // buttonIncrement
            // 
            this.buttonIncrement.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIncrement.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonIncrement.Location = new System.Drawing.Point(47, 135);
            this.buttonIncrement.Name = "buttonIncrement";
            this.buttonIncrement.Size = new System.Drawing.Size(43, 43);
            this.buttonIncrement.TabIndex = 27;
            this.buttonIncrement.Text = "++";
            this.buttonIncrement.UseVisualStyleBackColor = false;
            this.buttonIncrement.Click += new System.EventHandler(this.ButtonIncrementClick);
            this.buttonIncrement.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonIncrementMouseDown);
            this.buttonIncrement.MouseLeave += new System.EventHandler(this.ButtonIncrementMouseLeave);
            this.buttonIncrement.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonIncrementMouseMove);
            // 
            // buttonDecrement
            // 
            this.buttonDecrement.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDecrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecrement.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonDecrement.Location = new System.Drawing.Point(47, 91);
            this.buttonDecrement.Name = "buttonDecrement";
            this.buttonDecrement.Size = new System.Drawing.Size(43, 43);
            this.buttonDecrement.TabIndex = 26;
            this.buttonDecrement.Text = "--";
            this.buttonDecrement.UseVisualStyleBackColor = false;
            this.buttonDecrement.Click += new System.EventHandler(this.ButtonDecrementClick);
            this.buttonDecrement.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonDecrementMouseDown);
            this.buttonDecrement.MouseLeave += new System.EventHandler(this.ButtonDecrementMouseLeave);
            this.buttonDecrement.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonDecrementMouseMove);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivide.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonDivide.Location = new System.Drawing.Point(47, 47);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(43, 43);
            this.buttonDivide.TabIndex = 23;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.ButtonDivideClick);
            this.buttonDivide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonDivideMouseDown);
            this.buttonDivide.MouseLeave += new System.EventHandler(this.ButtonDivideMouseLeave);
            this.buttonDivide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonDivideMouseMove);
            // 
            // buttonMulitply
            // 
            this.buttonMulitply.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonMulitply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMulitply.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonMulitply.Location = new System.Drawing.Point(47, 3);
            this.buttonMulitply.Name = "buttonMulitply";
            this.buttonMulitply.Size = new System.Drawing.Size(43, 43);
            this.buttonMulitply.TabIndex = 22;
            this.buttonMulitply.Text = "*";
            this.buttonMulitply.UseVisualStyleBackColor = false;
            this.buttonMulitply.Click += new System.EventHandler(this.ButtonMultiplyClick);
            this.buttonMulitply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMultiplyMouseDown);
            this.buttonMulitply.MouseLeave += new System.EventHandler(this.ButtonMultiplyMouseLeave);
            this.buttonMulitply.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonMultiplyMouseMove);
            // 
            // buttonModDivide
            // 
            this.buttonModDivide.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonModDivide.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonModDivide.Location = new System.Drawing.Point(3, 135);
            this.buttonModDivide.Name = "buttonModDivide";
            this.buttonModDivide.Size = new System.Drawing.Size(43, 43);
            this.buttonModDivide.TabIndex = 25;
            this.buttonModDivide.Text = "%";
            this.buttonModDivide.UseVisualStyleBackColor = false;
            this.buttonModDivide.Click += new System.EventHandler(this.ButtonModClick);
            this.buttonModDivide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonModMouseDown);
            this.buttonModDivide.MouseLeave += new System.EventHandler(this.ButtonModMouseLeave);
            this.buttonModDivide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonModMouseMove);
            // 
            // buttonNegative
            // 
            this.buttonNegative.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNegative.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonNegative.Location = new System.Drawing.Point(3, 91);
            this.buttonNegative.Name = "buttonNegative";
            this.buttonNegative.Size = new System.Drawing.Size(43, 43);
            this.buttonNegative.TabIndex = 24;
            this.buttonNegative.Text = "±";
            this.buttonNegative.UseVisualStyleBackColor = false;
            this.buttonNegative.Click += new System.EventHandler(this.ButtonNegativeClick);
            this.buttonNegative.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonNegativeMouseDown);
            this.buttonNegative.MouseLeave += new System.EventHandler(this.ButtonNegativeMouseLeave);
            this.buttonNegative.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonNegativeMouseMove);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonMinus.Location = new System.Drawing.Point(3, 47);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(43, 43);
            this.buttonMinus.TabIndex = 21;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.ButtonMinusClick);
            this.buttonMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMinusMouseDown);
            this.buttonMinus.MouseLeave += new System.EventHandler(this.ButtonMinusMouseLeave);
            this.buttonMinus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonMinusMouseMove);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEqual.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonEqual.Location = new System.Drawing.Point(91, 135);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(43, 43);
            this.buttonEqual.TabIndex = 29;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.ButtonEqualClick);
            this.buttonEqual.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonEqualMouseDown);
            this.buttonEqual.MouseLeave += new System.EventHandler(this.ButtonEqualMouseLeave);
            this.buttonEqual.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonEqualMouseMove);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonPlus.Location = new System.Drawing.Point(3, 3);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(43, 43);
            this.buttonPlus.TabIndex = 20;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.ButtonPlusClick);
            this.buttonPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPlusMouseDown);
            this.buttonPlus.MouseLeave += new System.EventHandler(this.ButtonPlusMouseLeave);
            this.buttonPlus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonPlusMouseMove);
            // 
            // bitsOutputField
            // 
            this.bitsOutputField.BackColor = System.Drawing.Color.MidnightBlue;
            this.bitsOutputField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bitsOutputField.ContextMenuStrip = this.contextMenuStripBitsOutput;
            this.bitsOutputField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bitsOutputField.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bitsOutputField.ForeColor = System.Drawing.Color.Aqua;
            this.bitsOutputField.Location = new System.Drawing.Point(2, 5);
            this.bitsOutputField.Name = "bitsOutputField";
            this.bitsOutputField.ReadOnly = true;
            this.bitsOutputField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bitsOutputField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.bitsOutputField.Size = new System.Drawing.Size(501, 19);
            this.bitsOutputField.TabIndex = 2;
            this.bitsOutputField.TabStop = false;
            this.bitsOutputField.Text = "00000000 00000000 00000000 00000000 00000000 00000000 00000000 00000000";
            this.bitsOutputField.WordWrap = false;
            this.bitsOutputField.Enter += new System.EventHandler(this.FieldBitsOutputEnter);
            // 
            // contextMenuStripBitsOutput
            // 
            this.contextMenuStripBitsOutput.BackColor = System.Drawing.Color.White;
            this.contextMenuStripBitsOutput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripBitsOutputMenuItemCopy});
            this.contextMenuStripBitsOutput.Name = "contextMenuStrip1";
            this.contextMenuStripBitsOutput.Size = new System.Drawing.Size(153, 48);
            // 
            // ToolStripBitsOutputMenuItemCopy
            // 
            this.ToolStripBitsOutputMenuItemCopy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ToolStripBitsOutputMenuItemCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripBitsOutputMenuItemCopy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ToolStripBitsOutputMenuItemCopy.Name = "ToolStripBitsOutputMenuItemCopy";
            this.ToolStripBitsOutputMenuItemCopy.Size = new System.Drawing.Size(152, 22);
            this.ToolStripBitsOutputMenuItemCopy.Text = "Copy";
            this.ToolStripBitsOutputMenuItemCopy.Click += this.bitsOutputField.CopyAction;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bitsOutputField);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(76, 138);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(508, 28);
            this.panel1.TabIndex = 122;
            // 
            // labelBitsOutput
            // 
            this.labelBitsOutput.BackColor = System.Drawing.Color.SteelBlue;
            this.labelBitsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBitsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBitsOutput.ForeColor = System.Drawing.Color.Aqua;
            this.labelBitsOutput.Location = new System.Drawing.Point(5, 138);
            this.labelBitsOutput.Name = "labelBitsOutput";
            this.labelBitsOutput.Size = new System.Drawing.Size(68, 28);
            this.labelBitsOutput.TabIndex = 121;
            this.labelBitsOutput.Text = "BitsOutput";
            this.labelBitsOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelErrorStatus
            // 
            this.panelErrorStatus.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelErrorStatus.Controls.Add(this.ErrorStatusField);
            this.panelErrorStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelErrorStatus.ForeColor = System.Drawing.Color.White;
            this.panelErrorStatus.Location = new System.Drawing.Point(147, 360);
            this.panelErrorStatus.Name = "panelErrorStatus";
            this.panelErrorStatus.Padding = new System.Windows.Forms.Padding(5);
            this.panelErrorStatus.Size = new System.Drawing.Size(437, 20);
            this.panelErrorStatus.TabIndex = 124;
            // 
            // ErrorStatusField
            // 
            this.ErrorStatusField.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ErrorStatusField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorStatusField.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ErrorStatusField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorStatusField.ForeColor = System.Drawing.Color.Red;
            this.ErrorStatusField.Location = new System.Drawing.Point(0, 2);
            this.ErrorStatusField.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ErrorStatusField.Multiline = false;
            this.ErrorStatusField.Name = "ErrorStatusField";
            this.ErrorStatusField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ErrorStatusField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.ErrorStatusField.Size = new System.Drawing.Size(437, 18);
            this.ErrorStatusField.TabIndex = 0;
            this.ErrorStatusField.Text = "No errors";
            this.ErrorStatusField.WordWrap = false;
            // 
            // lableErrorStatus
            // 
            this.lableErrorStatus.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lableErrorStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableErrorStatus.ForeColor = System.Drawing.Color.Red;
            this.lableErrorStatus.Location = new System.Drawing.Point(49, 360);
            this.lableErrorStatus.Name = "lableErrorStatus";
            this.lableErrorStatus.Size = new System.Drawing.Size(102, 20);
            this.lableErrorStatus.TabIndex = 123;
            this.lableErrorStatus.Text = "Error Status";
            this.lableErrorStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxErrorStatusOn
            // 
            this.checkBoxErrorStatusOn.AutoSize = true;
            this.checkBoxErrorStatusOn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.checkBoxErrorStatusOn.Checked = true;
            this.checkBoxErrorStatusOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxErrorStatusOn.Location = new System.Drawing.Point(6, 360);
            this.checkBoxErrorStatusOn.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.checkBoxErrorStatusOn.MinimumSize = new System.Drawing.Size(0, 20);
            this.checkBoxErrorStatusOn.Name = "checkBoxErrorStatusOn";
            this.checkBoxErrorStatusOn.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.checkBoxErrorStatusOn.Size = new System.Drawing.Size(44, 20);
            this.checkBoxErrorStatusOn.TabIndex = 125;
            this.checkBoxErrorStatusOn.Text = "On";
            this.checkBoxErrorStatusOn.UseVisualStyleBackColor = false;
            this.checkBoxErrorStatusOn.CheckStateChanged += new System.EventHandler(this.ErrorStatusCheckedStateChanged);
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.standardToolStripMenuItem.Text = "Mode";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // timerErrorStatusMoveText
            // 
            this.timerErrorStatusMoveText.Enabled = true;
            this.timerErrorStatusMoveText.Tick += ErrorStatusMoveTick;
            // 
            // BinaryCalculator
            // 
            this.AcceptButton = this.buttonEqual;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(589, 386);
            this.Controls.Add(this.panelHexDigits);
            this.Controls.Add(this.panelDecimalDigits);
            this.Controls.Add(this.panelOctDigits);
            this.Controls.Add(this.panelDigits);
            this.Controls.Add(this.checkBoxErrorStatusOn);
            this.Controls.Add(this.panelErrorStatus);
            this.Controls.Add(this.lableErrorStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelBitsOutput);
            this.Controls.Add(this.ChooseBinModePanel);
            this.Controls.Add(this.panelBitOperations);
            this.Controls.Add(this.panelArithmeticOperations);
            this.Controls.Add(this.panelMemoryOperations);
            this.Controls.Add(this.panelBitView);
            this.Controls.Add(this.labelBitsInput);
            this.Controls.Add(this.LabelInput);
            this.Controls.Add(this.ChooseBinSizePanel);
            this.Controls.Add(this.LabelOutput);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(MenuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(100, 100);
            this.MainMenuStrip = MenuStrip;
            this.MaximizeBox = false;
            this.Name = "BinaryCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binary Calculator";
            this.Load += new System.EventHandler(this.CalculatorLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDetectKeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormDetectKeyPress);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FormPreviewKeyDown);
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            this.contextMenuStripOutputField.ResumeLayout(false);
            this.contextMenuStripBitsInput.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelOutput.ResumeLayout(false);
            this.ChooseBinModePanel.ResumeLayout(false);
            this.ChooseBinModePanel.PerformLayout();
            this.ChooseBinSizePanel.ResumeLayout(false);
            this.ChooseBinSizePanel.PerformLayout();
            this.panelMemoryOperations.ResumeLayout(false);
            this.panelBitView.ResumeLayout(false);
            this.panelBitOperations.ResumeLayout(false);
            this.panelOctDigits.ResumeLayout(false);
            this.panelDigits.ResumeLayout(false);
            this.panelDecimalDigits.ResumeLayout(false);
            this.panelHexDigits.ResumeLayout(false);
            this.panelArithmeticOperations.ResumeLayout(false);
            this.contextMenuStripBitsOutput.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelErrorStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Tab || keyData == Keys.Enter)
            {
                return true;
            }
            else
            {
                return base.IsInputKey(keyData);
            }
        }

        protected override bool ProcessCmdKey(ref Message message, Keys keyData)
        {
            var mess = message.Result;
            if (keyData == Keys.Enter || keyData == Keys.Space)
            {
                this.ActiveControl = this.buttonEqual;
                return false;
            }
            if (keyData == Keys.Left || keyData == Keys.Right)
            {
                return true;
            }

            return base.ProcessCmdKey(ref message, keyData);
        }

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.Panel ChooseBinModePanel;
        private System.Windows.Forms.RadioButton HexButton;
        private System.Windows.Forms.Panel ChooseBinSizePanel;
        private System.Windows.Forms.RadioButton OctButton;
        private System.Windows.Forms.RadioButton DecButton;
        private System.Windows.Forms.RadioButton BinButton;
        private System.Windows.Forms.RadioButton ByteButton;
        private System.Windows.Forms.RadioButton WordButton;
        private System.Windows.Forms.RadioButton DwordButton;
        private System.Windows.Forms.RadioButton QwordButton;
        private System.Windows.Forms.Label LabelInput;
        private System.Windows.Forms.Label labelBitsInput;
        private System.Windows.Forms.Label LabelOutput;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thematicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geometryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algebraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem physicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chemistryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem economicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panelBitView;
        private System.Windows.Forms.RichTextBox fieldBitsInput;
        private System.Windows.Forms.Panel panelMemoryOperations;
        private System.Windows.Forms.Button buttonClearLast;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSubtractFromMemory;
        private System.Windows.Forms.Button buttonAddToMemory;
        private System.Windows.Forms.Button buttonMemoryRestore;
        private System.Windows.Forms.Button buttonMemoryClear;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bitViewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem programmerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem linksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem1;
        private System.Windows.Forms.RichTextBox InputField;
        private System.Windows.Forms.RichTextBox OutputField;
        private System.Windows.Forms.ToolStripMenuItem nightToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem thematicsToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem economicsToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem physicsToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem mathematicsToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem astronomicsToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem formulasToolStripMenuItem9;

        private MenuItem menuItem;
        private RadioButton UnsignedByteButton;
        private RadioButton UnsignedWordButton;
        private RadioButton UnsignedDwordButton;
        private RadioButton UnsignedQwordButton;
        private Panel panelBitOperations;
        private Button buttonAnd;
        private Button buttonOr;
        private Button buttonXor;
        private Button buttonNot;
        private Button buttonRotateRight;
        private Button buttonRightShift;
        private Button buttonRotateLeft;
        private Button buttonLeftShift;
        private Panel panelDigits;
        private Panel panelDecimalDigits;
        private Button buttonSix6;
        private Button buttonNine9;
        private Button buttonFive5;
        private Button buttonEight8;
        private Button buttonFour4;
        private Button buttonZero0;
        private Button buttonSeven7;
        private Button buttonOne1;
        private Button buttonTwo2;
        private Button buttonThree3;
        private Button buttonZero;
        private Button buttonOne;
        private Button buttonOneOne;
        private Button buttonZeroZero;
        private Button buttonOneZero;
        private Button buttonZeroOne;
        private Panel panelArithmeticOperations;
        private Button buttonRightBracket;
        private Button buttonLeftBracket;
        private Button buttonBackspace;
        private Button buttonIncrement;
        private Button buttonDecrement;
        private Button buttonDivide;
        private Button buttonMulitply;
        private Button buttonModDivide;
        private Button buttonNegative;
        private Button buttonMinus;
        private Button buttonEqual;
        private Button buttonPlus;
        private Panel panelOctDigits;
        private Button buttonOctSix6;
        private Button buttonOctSeven7;
        private Button buttonOctFour4;
        private Button buttonOctFive5;
        private Button buttonOctTwo2;
        private Button buttonOctThree3;
        private Button buttonOctZero0;
        private Button buttonOctOne1;
        private Panel panelHexDigits;
        private Button buttonHexF;
        private Button buttonHexE;
        private Button buttonHexD;
        private Button buttonHexC;
        private Button buttonHexB;
        private Button buttonHexSeven7;
        private Button buttonHexSix6;
        private Button buttonHexNine9;
        private Button buttonHexEight8;
        private Button buttonHexFive5;
        private Button buttonHexFour4;
        private Button buttonHexThree3;
        private Button buttonHexZero0;
        private Button buttonHexOne1;
        private Button buttonHexTwo2;
        private Label labelSigned;
        private Label labelUnsigned;
        private Label labelBase;
        private RichTextBox bitsOutputField;
        private Panel panel1;
        private Label labelBitsOutput;
        private Button buttonHexA;
        private Panel panelErrorStatus;
        private RichTextBox ErrorStatusField;
        private Label lableErrorStatus;
        private CheckBox checkBoxErrorStatusOn;
        private ToolStripMenuItem modeToolStripMenuItem2;
        private ToolStripMenuItem standardToolStripMenuItem2;
        private ToolStripMenuItem programmerToolStripMenuItem1;
        private ToolStripMenuItem scientificToolStripMenuItem1;
        private ToolStripMenuItem thematicToolStripMenuItem1;
        private ToolStripMenuItem economicToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem physicsToolStripMenuItem1;
        private ToolStripMenuItem unitConversionsToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem2;
        private ToolStripMenuItem helpToolStripMenuItem2;
        private ContextMenuStrip contextMenuStripOutputField;
        private ToolStripMenuItem ToolStripOutputFieldMenuItemCopy;
        private ToolStripMenuItem standardToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem tutorialToolStripMenuItem2;
        private ToolStripMenuItem tutorialToolStripMenuItem3;
        private ToolStripMenuItem linksToolStripMenuItem2;
        private ToolStripMenuItem standardToolStripMenuItem3;
        private ToolStripMenuItem programmerToolStripMenuItem3;
        private ToolStripMenuItem scientificToolStripMenuItem2;
        private ToolStripMenuItem thematicToolStripMenuItem2;
        private ToolStripMenuItem economicsToolStripMenuItem1;
        private ToolStripMenuItem statisticsToolStripMenuItem1;
        private ToolStripMenuItem astronomyToolStripMenuItem;
        private ToolStripMenuItem electronicsToolStripMenuItem;
        private ToolStripMenuItem unitConversionsToolStripMenuItem1;
        private ContextMenuStrip contextMenuStripBitsInput;
        private ToolStripMenuItem ToolStripBitsInputMenuItemCopy;
        private ContextMenuStrip contextMenuStripBitsOutput;
        private ToolStripMenuItem ToolStripBitsOutputMenuItemCopy;
        private Timer timerErrorStatusMoveText;
    }
}