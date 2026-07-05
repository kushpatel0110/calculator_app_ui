namespace CalculatorAppUI;

partial class CalcUI
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        negateButton = new Button();
        zeroButton = new Button();
        periodButton = new Button();
        equateButton = new Button();
        oneButton = new Button();
        twoButton = new Button();
        threeButton = new Button();
        plusButton = new Button();
        fourButton = new Button();
        fiveButton = new Button();
        sixButton = new Button();
        subtractButton = new Button();
        sevenButton = new Button();
        eightButton = new Button();
        nineButton = new Button();
        multiplyButton = new Button();
        percentButton = new Button();
        clearEntryButton = new Button();
        clearAllButton = new Button();
        divideButton = new Button();
        label2 = new Label();
        tableLayoutPanel1 = new TableLayoutPanel();
        menuStrip1 = new MenuStrip();
        viewToolStripMenuItem = new ToolStripMenuItem();
        basicToolStripMenuItem = new ToolStripMenuItem();
        scientificToolStripMenuItem = new ToolStripMenuItem();
        basicPanel = new Panel();
        scientificPanel = new Panel();
        scientificLayoutPanel = new TableLayoutPanel();
        tangentButton = new Button();
        cosineButton = new Button();
        sineButton = new Button();
        layerTwoButton = new Button();
        moduloButton = new Button();
        factorialButton = new Button();
        eulerButton = new Button();
        piButton = new Button();
        exponentButton = new Button();
        naturalLogButton = new Button();
        eulerPowerXButton = new Button();
        logBaseTenButton = new Button();
        tenPowerXButton = new Button();
        nthRootButton = new Button();
        powerButton = new Button();
        squareRootButton = new Button();
        squareButton = new Button();
        reciprocalButton = new Button();
        tableLayoutPanel1.SuspendLayout();
        menuStrip1.SuspendLayout();
        basicPanel.SuspendLayout();
        scientificPanel.SuspendLayout();
        scientificLayoutPanel.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label1.BorderStyle = BorderStyle.Fixed3D;
        label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ForeColor = SystemColors.HotTrack;
        label1.Location = new Point(0, 0);
        label1.Name = "label1";
        label1.Size = new Size(386, 133);
        label1.TabIndex = 0;
        label1.Text = "0";
        label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // negateButton
        // 
        negateButton.BackColor = Color.Black;
        negateButton.Dock = DockStyle.Fill;
        negateButton.Font = new Font("Segoe UI", 24F);
        negateButton.ForeColor = Color.Cyan;
        negateButton.Location = new Point(3, 419);
        negateButton.Name = "negateButton";
        negateButton.Size = new Size(90, 102);
        negateButton.TabIndex = 1;
        negateButton.Text = "+/-";
        negateButton.UseVisualStyleBackColor = false;
        negateButton.Click += NegateButton_Click;
        // 
        // zeroButton
        // 
        zeroButton.BackColor = Color.Black;
        zeroButton.Dock = DockStyle.Fill;
        zeroButton.Font = new Font("Segoe UI", 24F);
        zeroButton.ForeColor = Color.Cyan;
        zeroButton.Location = new Point(99, 419);
        zeroButton.Name = "zeroButton";
        zeroButton.Size = new Size(90, 102);
        zeroButton.TabIndex = 2;
        zeroButton.Text = "0";
        zeroButton.UseVisualStyleBackColor = false;
        zeroButton.Click += ZeroButton_Click;
        // 
        // periodButton
        // 
        periodButton.BackColor = Color.Black;
        periodButton.Dock = DockStyle.Fill;
        periodButton.Font = new Font("Segoe UI", 24F);
        periodButton.ForeColor = Color.Cyan;
        periodButton.Location = new Point(195, 419);
        periodButton.Name = "periodButton";
        periodButton.Size = new Size(90, 102);
        periodButton.TabIndex = 3;
        periodButton.Text = ".";
        periodButton.UseVisualStyleBackColor = false;
        periodButton.Click += PeriodButton_Click;
        // 
        // equateButton
        // 
        equateButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        equateButton.BackColor = Color.Cyan;
        equateButton.Dock = DockStyle.Fill;
        equateButton.Font = new Font("Segoe UI", 24F);
        equateButton.ForeColor = Color.Black;
        equateButton.Location = new Point(291, 419);
        equateButton.Name = "equateButton";
        equateButton.Size = new Size(92, 102);
        equateButton.TabIndex = 4;
        equateButton.Text = "=";
        equateButton.UseVisualStyleBackColor = false;
        equateButton.Click += EquateButton_Click;
        // 
        // oneButton
        // 
        oneButton.BackColor = Color.Black;
        oneButton.Dock = DockStyle.Fill;
        oneButton.Font = new Font("Segoe UI", 24F);
        oneButton.ForeColor = Color.Cyan;
        oneButton.Location = new Point(3, 315);
        oneButton.Name = "oneButton";
        oneButton.Size = new Size(90, 98);
        oneButton.TabIndex = 5;
        oneButton.Text = "1";
        oneButton.UseVisualStyleBackColor = false;
        oneButton.Click += OneButton_Click;
        // 
        // twoButton
        // 
        twoButton.BackColor = Color.Black;
        twoButton.Dock = DockStyle.Fill;
        twoButton.Font = new Font("Segoe UI", 24F);
        twoButton.ForeColor = Color.Cyan;
        twoButton.Location = new Point(99, 315);
        twoButton.Name = "twoButton";
        twoButton.Size = new Size(90, 98);
        twoButton.TabIndex = 6;
        twoButton.Text = "2";
        twoButton.UseVisualStyleBackColor = false;
        twoButton.Click += TwoButton_Click;
        // 
        // threeButton
        // 
        threeButton.BackColor = Color.Black;
        threeButton.Dock = DockStyle.Fill;
        threeButton.Font = new Font("Segoe UI", 24F);
        threeButton.ForeColor = Color.Cyan;
        threeButton.Location = new Point(195, 315);
        threeButton.Name = "threeButton";
        threeButton.Size = new Size(90, 98);
        threeButton.TabIndex = 7;
        threeButton.Text = "3";
        threeButton.UseVisualStyleBackColor = false;
        threeButton.Click += ThreeButton_Click;
        // 
        // plusButton
        // 
        plusButton.BackColor = Color.Black;
        plusButton.Dock = DockStyle.Fill;
        plusButton.Font = new Font("Segoe UI", 24F);
        plusButton.ForeColor = Color.Cyan;
        plusButton.Location = new Point(291, 315);
        plusButton.Name = "plusButton";
        plusButton.Size = new Size(92, 98);
        plusButton.TabIndex = 8;
        plusButton.Text = "+";
        plusButton.UseVisualStyleBackColor = false;
        plusButton.Click += PlusButton_Click;
        // 
        // fourButton
        // 
        fourButton.BackColor = Color.Black;
        fourButton.Dock = DockStyle.Fill;
        fourButton.Font = new Font("Segoe UI", 24F);
        fourButton.ForeColor = Color.Cyan;
        fourButton.Location = new Point(3, 211);
        fourButton.Name = "fourButton";
        fourButton.Size = new Size(90, 98);
        fourButton.TabIndex = 9;
        fourButton.Text = "4";
        fourButton.UseVisualStyleBackColor = false;
        fourButton.Click += FourButton_Click;
        // 
        // fiveButton
        // 
        fiveButton.BackColor = Color.Black;
        fiveButton.Dock = DockStyle.Fill;
        fiveButton.Font = new Font("Segoe UI", 24F);
        fiveButton.ForeColor = Color.Cyan;
        fiveButton.Location = new Point(99, 211);
        fiveButton.Name = "fiveButton";
        fiveButton.Size = new Size(90, 98);
        fiveButton.TabIndex = 10;
        fiveButton.Text = "5";
        fiveButton.UseVisualStyleBackColor = false;
        fiveButton.Click += FiveButton_Click;
        // 
        // sixButton
        // 
        sixButton.BackColor = Color.Black;
        sixButton.Dock = DockStyle.Fill;
        sixButton.Font = new Font("Segoe UI", 24F);
        sixButton.ForeColor = Color.Cyan;
        sixButton.Location = new Point(195, 211);
        sixButton.Name = "sixButton";
        sixButton.Size = new Size(90, 98);
        sixButton.TabIndex = 11;
        sixButton.Text = "6";
        sixButton.UseVisualStyleBackColor = false;
        sixButton.Click += SixButton_Click;
        // 
        // subtractButton
        // 
        subtractButton.BackColor = Color.Black;
        subtractButton.Dock = DockStyle.Fill;
        subtractButton.Font = new Font("Segoe UI", 24F);
        subtractButton.ForeColor = Color.Cyan;
        subtractButton.Location = new Point(291, 211);
        subtractButton.Name = "subtractButton";
        subtractButton.Size = new Size(92, 98);
        subtractButton.TabIndex = 12;
        subtractButton.Text = "-";
        subtractButton.UseVisualStyleBackColor = false;
        subtractButton.Click += SubtractButton_Click;
        // 
        // sevenButton
        // 
        sevenButton.BackColor = Color.Black;
        sevenButton.Dock = DockStyle.Fill;
        sevenButton.Font = new Font("Segoe UI", 24F);
        sevenButton.ForeColor = Color.Cyan;
        sevenButton.Location = new Point(3, 107);
        sevenButton.Name = "sevenButton";
        sevenButton.Size = new Size(90, 98);
        sevenButton.TabIndex = 13;
        sevenButton.Text = "7";
        sevenButton.UseVisualStyleBackColor = false;
        sevenButton.Click += SevenButton_Click;
        // 
        // eightButton
        // 
        eightButton.BackColor = Color.Black;
        eightButton.Dock = DockStyle.Fill;
        eightButton.Font = new Font("Segoe UI", 24F);
        eightButton.ForeColor = Color.Cyan;
        eightButton.Location = new Point(99, 107);
        eightButton.Name = "eightButton";
        eightButton.Size = new Size(90, 98);
        eightButton.TabIndex = 14;
        eightButton.Text = "8";
        eightButton.UseVisualStyleBackColor = false;
        eightButton.Click += EightButton_Click;
        // 
        // nineButton
        // 
        nineButton.BackColor = Color.Black;
        nineButton.Dock = DockStyle.Fill;
        nineButton.Font = new Font("Segoe UI", 24F);
        nineButton.ForeColor = Color.Cyan;
        nineButton.Location = new Point(195, 107);
        nineButton.Name = "nineButton";
        nineButton.Size = new Size(90, 98);
        nineButton.TabIndex = 15;
        nineButton.Text = "9";
        nineButton.UseVisualStyleBackColor = false;
        nineButton.Click += NineButton_Click;
        // 
        // multiplyButton
        // 
        multiplyButton.BackColor = Color.Black;
        multiplyButton.Dock = DockStyle.Fill;
        multiplyButton.Font = new Font("Segoe UI", 24F);
        multiplyButton.ForeColor = Color.Cyan;
        multiplyButton.Location = new Point(291, 107);
        multiplyButton.Name = "multiplyButton";
        multiplyButton.Size = new Size(92, 98);
        multiplyButton.TabIndex = 16;
        multiplyButton.Text = "*";
        multiplyButton.UseVisualStyleBackColor = false;
        multiplyButton.Click += MultiplyButton_Click;
        // 
        // percentButton
        // 
        percentButton.BackColor = Color.Black;
        percentButton.Dock = DockStyle.Fill;
        percentButton.Font = new Font("Segoe UI", 24F);
        percentButton.ForeColor = Color.Cyan;
        percentButton.Location = new Point(3, 3);
        percentButton.Name = "percentButton";
        percentButton.Size = new Size(90, 98);
        percentButton.TabIndex = 17;
        percentButton.Text = "%";
        percentButton.UseVisualStyleBackColor = false;
        percentButton.Click += PercentButton_Click;
        // 
        // clearEntryButton
        // 
        clearEntryButton.BackColor = Color.Black;
        clearEntryButton.Dock = DockStyle.Fill;
        clearEntryButton.Font = new Font("Segoe UI", 24F);
        clearEntryButton.ForeColor = Color.Cyan;
        clearEntryButton.Location = new Point(99, 3);
        clearEntryButton.Name = "clearEntryButton";
        clearEntryButton.Size = new Size(90, 98);
        clearEntryButton.TabIndex = 18;
        clearEntryButton.Text = "CE";
        clearEntryButton.UseVisualStyleBackColor = false;
        clearEntryButton.Click += ClearEntryButton_Click;
        // 
        // clearAllButton
        // 
        clearAllButton.BackColor = Color.Black;
        clearAllButton.Dock = DockStyle.Fill;
        clearAllButton.Font = new Font("Segoe UI", 24F);
        clearAllButton.ForeColor = Color.Cyan;
        clearAllButton.Location = new Point(195, 3);
        clearAllButton.Name = "clearAllButton";
        clearAllButton.Size = new Size(90, 98);
        clearAllButton.TabIndex = 19;
        clearAllButton.Text = "C";
        clearAllButton.UseVisualStyleBackColor = false;
        clearAllButton.Click += ClearAllButton_Click;
        // 
        // divideButton
        // 
        divideButton.BackColor = Color.Black;
        divideButton.Dock = DockStyle.Fill;
        divideButton.Font = new Font("Segoe UI", 24F);
        divideButton.ForeColor = Color.Cyan;
        divideButton.Location = new Point(291, 3);
        divideButton.Name = "divideButton";
        divideButton.Size = new Size(92, 98);
        divideButton.TabIndex = 20;
        divideButton.Text = "/";
        divideButton.UseVisualStyleBackColor = false;
        divideButton.Click += DivideButton_Click;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label2.BorderStyle = BorderStyle.Fixed3D;
        label2.ForeColor = Color.DodgerBlue;
        label2.Location = new Point(0, 0);
        label2.Name = "label2";
        label2.Size = new Size(267, 23);
        label2.TabIndex = 21;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tableLayoutPanel1.ColumnCount = 4;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.Controls.Add(equateButton, 3, 4);
        tableLayoutPanel1.Controls.Add(periodButton, 2, 4);
        tableLayoutPanel1.Controls.Add(plusButton, 3, 3);
        tableLayoutPanel1.Controls.Add(subtractButton, 3, 2);
        tableLayoutPanel1.Controls.Add(threeButton, 2, 3);
        tableLayoutPanel1.Controls.Add(multiplyButton, 3, 1);
        tableLayoutPanel1.Controls.Add(sixButton, 2, 2);
        tableLayoutPanel1.Controls.Add(divideButton, 3, 0);
        tableLayoutPanel1.Controls.Add(nineButton, 2, 1);
        tableLayoutPanel1.Controls.Add(zeroButton, 1, 4);
        tableLayoutPanel1.Controls.Add(clearAllButton, 2, 0);
        tableLayoutPanel1.Controls.Add(negateButton, 0, 4);
        tableLayoutPanel1.Controls.Add(clearEntryButton, 1, 0);
        tableLayoutPanel1.Controls.Add(oneButton, 0, 3);
        tableLayoutPanel1.Controls.Add(percentButton, 0, 0);
        tableLayoutPanel1.Controls.Add(twoButton, 1, 3);
        tableLayoutPanel1.Controls.Add(fourButton, 0, 2);
        tableLayoutPanel1.Controls.Add(fiveButton, 1, 2);
        tableLayoutPanel1.Controls.Add(eightButton, 1, 1);
        tableLayoutPanel1.Controls.Add(sevenButton, 0, 1);
        tableLayoutPanel1.Location = new Point(0, 153);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 5;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new Size(386, 524);
        tableLayoutPanel1.TabIndex = 22;
        // 
        // menuStrip1
        // 
        menuStrip1.BackColor = SystemColors.ActiveCaptionText;
        menuStrip1.ForeColor = Color.Cyan;
        menuStrip1.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem });
        menuStrip1.Location = new Point(300, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(386, 24);
        menuStrip1.TabIndex = 23;
        menuStrip1.Text = "menuStrip1";
        // 
        // viewToolStripMenuItem
        // 
        viewToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
        viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { basicToolStripMenuItem, scientificToolStripMenuItem });
        viewToolStripMenuItem.ForeColor = Color.Cyan;
        viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        viewToolStripMenuItem.Size = new Size(44, 20);
        viewToolStripMenuItem.Text = "View";
        // 
        // basicToolStripMenuItem
        // 
        basicToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
        basicToolStripMenuItem.ForeColor = Color.Cyan;
        basicToolStripMenuItem.Name = "basicToolStripMenuItem";
        basicToolStripMenuItem.Size = new Size(122, 22);
        basicToolStripMenuItem.Text = "Basic";
        basicToolStripMenuItem.Click += BasicToolStripMenuItem_Click;
        // 
        // scientificToolStripMenuItem
        // 
        scientificToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
        scientificToolStripMenuItem.ForeColor = Color.Cyan;
        scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
        scientificToolStripMenuItem.Size = new Size(122, 22);
        scientificToolStripMenuItem.Text = "Scientific";
        scientificToolStripMenuItem.Click += ScientificToolStripMenuItem_Click;
        // 
        // basicPanel
        // 
        basicPanel.Controls.Add(tableLayoutPanel1);
        basicPanel.Controls.Add(label2);
        basicPanel.Controls.Add(label1);
        basicPanel.Dock = DockStyle.Fill;
        basicPanel.Location = new Point(300, 24);
        basicPanel.Name = "basicPanel";
        basicPanel.Size = new Size(386, 677);
        basicPanel.TabIndex = 24;
        // 
        // scientificPanel
        // 
        scientificPanel.Controls.Add(scientificLayoutPanel);
        scientificPanel.Dock = DockStyle.Left;
        scientificPanel.Location = new Point(0, 0);
        scientificPanel.Name = "scientificPanel";
        scientificPanel.Size = new Size(300, 701);
        scientificPanel.TabIndex = 23;
        scientificPanel.Visible = false;
        // 
        // scientificLayoutPanel
        // 
        scientificLayoutPanel.ColumnCount = 3;
        scientificLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
        scientificLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
        scientificLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
        scientificLayoutPanel.Controls.Add(tangentButton, 2, 5);
        scientificLayoutPanel.Controls.Add(cosineButton, 1, 5);
        scientificLayoutPanel.Controls.Add(sineButton, 0, 5);
        scientificLayoutPanel.Controls.Add(layerTwoButton, 2, 4);
        scientificLayoutPanel.Controls.Add(moduloButton, 1, 4);
        scientificLayoutPanel.Controls.Add(factorialButton, 0, 4);
        scientificLayoutPanel.Controls.Add(eulerButton, 2, 3);
        scientificLayoutPanel.Controls.Add(piButton, 1, 3);
        scientificLayoutPanel.Controls.Add(exponentButton, 0, 3);
        scientificLayoutPanel.Controls.Add(naturalLogButton, 2, 2);
        scientificLayoutPanel.Controls.Add(eulerPowerXButton, 1, 2);
        scientificLayoutPanel.Controls.Add(logBaseTenButton, 0, 2);
        scientificLayoutPanel.Controls.Add(tenPowerXButton, 2, 1);
        scientificLayoutPanel.Controls.Add(nthRootButton, 1, 1);
        scientificLayoutPanel.Controls.Add(powerButton, 0, 1);
        scientificLayoutPanel.Controls.Add(squareRootButton, 2, 0);
        scientificLayoutPanel.Controls.Add(squareButton, 1, 0);
        scientificLayoutPanel.Controls.Add(reciprocalButton, 0, 0);
        scientificLayoutPanel.Dock = DockStyle.Fill;
        scientificLayoutPanel.Location = new Point(0, 0);
        scientificLayoutPanel.Name = "scientificLayoutPanel";
        scientificLayoutPanel.RowCount = 6;
        scientificLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
        scientificLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
        scientificLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
        scientificLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
        scientificLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
        scientificLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
        scientificLayoutPanel.Size = new Size(300, 701);
        scientificLayoutPanel.TabIndex = 0;
        // 
        // tangentButton
        // 
        tangentButton.BackColor = Color.Black;
        tangentButton.Dock = DockStyle.Fill;
        tangentButton.Font = new Font("Segoe UI", 24F);
        tangentButton.ForeColor = Color.MediumPurple;
        tangentButton.Location = new Point(202, 583);
        tangentButton.Name = "tangentButton";
        tangentButton.Size = new Size(95, 115);
        tangentButton.TabIndex = 35;
        tangentButton.Text = "tan";
        tangentButton.UseVisualStyleBackColor = false;
        tangentButton.Click += TangentButton_Click;
        // 
        // cosineButton
        // 
        cosineButton.BackColor = Color.Black;
        cosineButton.Dock = DockStyle.Fill;
        cosineButton.Font = new Font("Segoe UI", 24F);
        cosineButton.ForeColor = Color.MediumPurple;
        cosineButton.Location = new Point(102, 583);
        cosineButton.Name = "cosineButton";
        cosineButton.Size = new Size(94, 115);
        cosineButton.TabIndex = 34;
        cosineButton.Text = "cos";
        cosineButton.UseVisualStyleBackColor = false;
        cosineButton.Click += CosineButton_Click;
        // 
        // sineButton
        // 
        sineButton.BackColor = Color.Black;
        sineButton.Dock = DockStyle.Fill;
        sineButton.Font = new Font("Segoe UI", 24F);
        sineButton.ForeColor = Color.MediumPurple;
        sineButton.Location = new Point(3, 583);
        sineButton.Name = "sineButton";
        sineButton.Size = new Size(93, 115);
        sineButton.TabIndex = 33;
        sineButton.Text = "sin";
        sineButton.UseVisualStyleBackColor = false;
        sineButton.Click += SineButton_Click;
        // 
        // layerTwoButton
        // 
        layerTwoButton.BackColor = Color.Black;
        layerTwoButton.Dock = DockStyle.Fill;
        layerTwoButton.Font = new Font("Segoe UI", 24F);
        layerTwoButton.ForeColor = Color.MediumPurple;
        layerTwoButton.Location = new Point(202, 467);
        layerTwoButton.Name = "layerTwoButton";
        layerTwoButton.Size = new Size(95, 110);
        layerTwoButton.TabIndex = 32;
        layerTwoButton.Text = "2nd";
        layerTwoButton.UseVisualStyleBackColor = false;
        layerTwoButton.Click += LayerTwoButton_Click;
        // 
        // moduloButton
        // 
        moduloButton.BackColor = Color.Black;
        moduloButton.Dock = DockStyle.Fill;
        moduloButton.Font = new Font("Segoe UI", 24F);
        moduloButton.ForeColor = Color.MediumPurple;
        moduloButton.Location = new Point(102, 467);
        moduloButton.Name = "moduloButton";
        moduloButton.Size = new Size(94, 110);
        moduloButton.TabIndex = 31;
        moduloButton.Text = "mod";
        moduloButton.UseVisualStyleBackColor = false;
        moduloButton.Click += ModuloButton_Click;
        // 
        // factorialButton
        // 
        factorialButton.BackColor = Color.Black;
        factorialButton.Dock = DockStyle.Fill;
        factorialButton.Font = new Font("Segoe UI", 24F);
        factorialButton.ForeColor = Color.MediumPurple;
        factorialButton.Location = new Point(3, 467);
        factorialButton.Name = "factorialButton";
        factorialButton.Size = new Size(93, 110);
        factorialButton.TabIndex = 30;
        factorialButton.Text = "𝑛!";
        factorialButton.UseVisualStyleBackColor = false;
        factorialButton.Click += FactorialButton_Click;
        // 
        // eulerButton
        // 
        eulerButton.BackColor = Color.Black;
        eulerButton.Dock = DockStyle.Fill;
        eulerButton.Font = new Font("Segoe UI", 24F);
        eulerButton.ForeColor = Color.MediumPurple;
        eulerButton.Location = new Point(202, 351);
        eulerButton.Name = "eulerButton";
        eulerButton.Size = new Size(95, 110);
        eulerButton.TabIndex = 29;
        eulerButton.Text = "e";
        eulerButton.UseVisualStyleBackColor = false;
        eulerButton.Click += EulerButton_Click;
        // 
        // piButton
        // 
        piButton.BackColor = Color.Black;
        piButton.Dock = DockStyle.Fill;
        piButton.Font = new Font("Segoe UI", 24F);
        piButton.ForeColor = Color.MediumPurple;
        piButton.Location = new Point(102, 351);
        piButton.Name = "piButton";
        piButton.Size = new Size(94, 110);
        piButton.TabIndex = 28;
        piButton.Text = "π";
        piButton.UseVisualStyleBackColor = false;
        piButton.Click += PiButton_Click;
        // 
        // exponentButton
        // 
        exponentButton.BackColor = Color.Black;
        exponentButton.Dock = DockStyle.Fill;
        exponentButton.Font = new Font("Segoe UI", 24F);
        exponentButton.ForeColor = Color.MediumPurple;
        exponentButton.Location = new Point(3, 351);
        exponentButton.Name = "exponentButton";
        exponentButton.Size = new Size(93, 110);
        exponentButton.TabIndex = 27;
        exponentButton.Text = "exp";
        exponentButton.UseVisualStyleBackColor = false;
        exponentButton.Click += ExponentButton_Click;
        // 
        // naturalLogButton
        // 
        naturalLogButton.BackColor = Color.Black;
        naturalLogButton.Dock = DockStyle.Fill;
        naturalLogButton.Font = new Font("Segoe UI", 24F);
        naturalLogButton.ForeColor = Color.MediumPurple;
        naturalLogButton.Location = new Point(202, 235);
        naturalLogButton.Name = "naturalLogButton";
        naturalLogButton.Size = new Size(95, 110);
        naturalLogButton.TabIndex = 26;
        naturalLogButton.Text = "ln";
        naturalLogButton.UseVisualStyleBackColor = false;
        naturalLogButton.Click += NaturalLogButton_Click;
        // 
        // eulerPowerXButton
        // 
        eulerPowerXButton.BackColor = Color.Black;
        eulerPowerXButton.Dock = DockStyle.Fill;
        eulerPowerXButton.Font = new Font("Segoe UI", 24F);
        eulerPowerXButton.ForeColor = Color.MediumPurple;
        eulerPowerXButton.Location = new Point(102, 235);
        eulerPowerXButton.Name = "eulerPowerXButton";
        eulerPowerXButton.Size = new Size(94, 110);
        eulerPowerXButton.TabIndex = 25;
        eulerPowerXButton.Text = "eˣ";
        eulerPowerXButton.UseVisualStyleBackColor = false;
        eulerPowerXButton.Click += EulerPowerXButton_Click;
        // 
        // logBaseTenButton
        // 
        logBaseTenButton.BackColor = Color.Black;
        logBaseTenButton.Dock = DockStyle.Fill;
        logBaseTenButton.Font = new Font("Segoe UI", 24F);
        logBaseTenButton.ForeColor = Color.MediumPurple;
        logBaseTenButton.Location = new Point(3, 235);
        logBaseTenButton.Name = "logBaseTenButton";
        logBaseTenButton.Size = new Size(93, 110);
        logBaseTenButton.TabIndex = 24;
        logBaseTenButton.Text = "log";
        logBaseTenButton.UseVisualStyleBackColor = false;
        logBaseTenButton.Click += LogBaseTenButton_Click;
        // 
        // tenPowerXButton
        // 
        tenPowerXButton.BackColor = Color.Black;
        tenPowerXButton.Dock = DockStyle.Fill;
        tenPowerXButton.Font = new Font("Segoe UI", 24F);
        tenPowerXButton.ForeColor = Color.MediumPurple;
        tenPowerXButton.Location = new Point(202, 119);
        tenPowerXButton.Name = "tenPowerXButton";
        tenPowerXButton.Size = new Size(95, 110);
        tenPowerXButton.TabIndex = 23;
        tenPowerXButton.Text = "10ˣ";
        tenPowerXButton.UseVisualStyleBackColor = false;
        tenPowerXButton.Click += TenPowerXButton_Click;
        // 
        // nthRootButton
        // 
        nthRootButton.BackColor = Color.Black;
        nthRootButton.Dock = DockStyle.Fill;
        nthRootButton.Font = new Font("Segoe UI", 24F);
        nthRootButton.ForeColor = Color.MediumPurple;
        nthRootButton.Location = new Point(102, 119);
        nthRootButton.Name = "nthRootButton";
        nthRootButton.Size = new Size(94, 110);
        nthRootButton.TabIndex = 22;
        nthRootButton.Text = "ʸ√𝑥";
        nthRootButton.UseVisualStyleBackColor = false;
        nthRootButton.Click += NthRootButton_Click;
        // 
        // powerButton
        // 
        powerButton.BackColor = Color.Black;
        powerButton.Dock = DockStyle.Fill;
        powerButton.Font = new Font("Segoe UI", 24F);
        powerButton.ForeColor = Color.MediumPurple;
        powerButton.Location = new Point(3, 119);
        powerButton.Name = "powerButton";
        powerButton.Size = new Size(93, 110);
        powerButton.TabIndex = 21;
        powerButton.Text = "𝑥ʸ";
        powerButton.UseVisualStyleBackColor = false;
        powerButton.Click += PowerButton_Click;
        // 
        // squareRootButton
        // 
        squareRootButton.BackColor = Color.Black;
        squareRootButton.Dock = DockStyle.Fill;
        squareRootButton.Font = new Font("Segoe UI", 24F);
        squareRootButton.ForeColor = Color.MediumPurple;
        squareRootButton.Location = new Point(202, 3);
        squareRootButton.Name = "squareRootButton";
        squareRootButton.Size = new Size(95, 110);
        squareRootButton.TabIndex = 20;
        squareRootButton.Text = "²√𝑥";
        squareRootButton.UseVisualStyleBackColor = false;
        squareRootButton.Click += SquareRootButton_Click;
        // 
        // squareButton
        // 
        squareButton.BackColor = Color.Black;
        squareButton.Dock = DockStyle.Fill;
        squareButton.Font = new Font("Segoe UI", 24F);
        squareButton.ForeColor = Color.MediumPurple;
        squareButton.Location = new Point(102, 3);
        squareButton.Name = "squareButton";
        squareButton.Size = new Size(94, 110);
        squareButton.TabIndex = 19;
        squareButton.Text = "𝑥²";
        squareButton.UseVisualStyleBackColor = false;
        squareButton.Click += SquareButton_Click;
        // 
        // reciprocalButton
        // 
        reciprocalButton.BackColor = Color.Black;
        reciprocalButton.Dock = DockStyle.Fill;
        reciprocalButton.Font = new Font("Segoe UI", 24F);
        reciprocalButton.ForeColor = Color.MediumPurple;
        reciprocalButton.Location = new Point(3, 3);
        reciprocalButton.Name = "reciprocalButton";
        reciprocalButton.Size = new Size(93, 110);
        reciprocalButton.TabIndex = 18;
        reciprocalButton.Text = "1/𝑥";
        reciprocalButton.UseVisualStyleBackColor = false;
        reciprocalButton.Click += ReciprocalButton_Click;
        // 
        // CalcUI
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaptionText;
        ClientSize = new Size(686, 701);
        Controls.Add(basicPanel);
        Controls.Add(menuStrip1);
        Controls.Add(scientificPanel);
        ForeColor = SystemColors.ControlText;
        KeyPreview = true;
        MainMenuStrip = menuStrip1;
        Name = "CalcUI";
        Text = "Kush's Calculator Xtreme!!!";
        KeyDown += CalcUI_KeyDown;
        tableLayoutPanel1.ResumeLayout(false);
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        basicPanel.ResumeLayout(false);
        scientificPanel.ResumeLayout(false);
        scientificLayoutPanel.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Button negateButton;
    private Button zeroButton;
    private Button periodButton;
    private Button equateButton;
    private Button oneButton;
    private Button twoButton;
    private Button threeButton;
    private Button plusButton;
    private Button fourButton;
    private Button fiveButton;
    private Button sixButton;
    private Button subtractButton;
    private Button sevenButton;
    private Button eightButton;
    private Button nineButton;
    private Button multiplyButton;
    private Button percentButton;
    private Button clearEntryButton;
    private Button clearAllButton;
    private Button divideButton;
    private Label label2;
    private TableLayoutPanel tableLayoutPanel1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem viewToolStripMenuItem;
    private ToolStripMenuItem basicToolStripMenuItem;
    private ToolStripMenuItem scientificToolStripMenuItem;
    private Panel basicPanel;
    private Panel scientificPanel;
    private TableLayoutPanel scientificLayoutPanel;
    private Button reciprocalButton;
    private Button squareButton;
    private Button squareRootButton;
    private Button powerButton;
    private Button nthRootButton;
    private Button tenPowerXButton;
    private Button logBaseTenButton;
    private Button eulerPowerXButton;
    private Button naturalLogButton;
    private Button exponentButton;
    private Button piButton;
    private Button eulerButton;
    private Button factorialButton;
    private Button moduloButton;
    private Button layerTwoButton;
    private Button sineButton;
    private Button cosineButton;
    private Button tangentButton;
}
