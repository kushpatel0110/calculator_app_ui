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
        tableLayoutPanel1.SuspendLayout();
        menuStrip1.SuspendLayout();
        basicPanel.SuspendLayout();
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
        label1.Size = new Size(319, 133);
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
        negateButton.Size = new Size(73, 102);
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
        zeroButton.Location = new Point(82, 419);
        zeroButton.Name = "zeroButton";
        zeroButton.Size = new Size(73, 102);
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
        periodButton.Location = new Point(161, 419);
        periodButton.Name = "periodButton";
        periodButton.Size = new Size(73, 102);
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
        equateButton.Location = new Point(240, 419);
        equateButton.Name = "equateButton";
        equateButton.Size = new Size(76, 102);
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
        oneButton.Size = new Size(73, 98);
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
        twoButton.Location = new Point(82, 315);
        twoButton.Name = "twoButton";
        twoButton.Size = new Size(73, 98);
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
        threeButton.Location = new Point(161, 315);
        threeButton.Name = "threeButton";
        threeButton.Size = new Size(73, 98);
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
        plusButton.Location = new Point(240, 315);
        plusButton.Name = "plusButton";
        plusButton.Size = new Size(76, 98);
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
        fourButton.Size = new Size(73, 98);
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
        fiveButton.Location = new Point(82, 211);
        fiveButton.Name = "fiveButton";
        fiveButton.Size = new Size(73, 98);
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
        sixButton.Location = new Point(161, 211);
        sixButton.Name = "sixButton";
        sixButton.Size = new Size(73, 98);
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
        subtractButton.Location = new Point(240, 211);
        subtractButton.Name = "subtractButton";
        subtractButton.Size = new Size(76, 98);
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
        sevenButton.Size = new Size(73, 98);
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
        eightButton.Location = new Point(82, 107);
        eightButton.Name = "eightButton";
        eightButton.Size = new Size(73, 98);
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
        nineButton.Location = new Point(161, 107);
        nineButton.Name = "nineButton";
        nineButton.Size = new Size(73, 98);
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
        multiplyButton.Location = new Point(240, 107);
        multiplyButton.Name = "multiplyButton";
        multiplyButton.Size = new Size(76, 98);
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
        percentButton.Size = new Size(73, 98);
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
        clearEntryButton.Location = new Point(82, 3);
        clearEntryButton.Name = "clearEntryButton";
        clearEntryButton.Size = new Size(73, 98);
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
        clearAllButton.Location = new Point(161, 3);
        clearAllButton.Name = "clearAllButton";
        clearAllButton.Size = new Size(73, 98);
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
        divideButton.Location = new Point(240, 3);
        divideButton.Name = "divideButton";
        divideButton.Size = new Size(76, 98);
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
        label2.Size = new Size(62, 23);
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
        tableLayoutPanel1.Size = new Size(319, 524);
        tableLayoutPanel1.TabIndex = 22;
        // 
        // menuStrip1
        // 
        menuStrip1.BackColor = SystemColors.ActiveCaptionText;
        menuStrip1.ForeColor = Color.Cyan;
        menuStrip1.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem });
        menuStrip1.Location = new Point(200, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(319, 24);
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
        basicToolStripMenuItem.Size = new Size(180, 22);
        basicToolStripMenuItem.Text = "Basic";
        basicToolStripMenuItem.Click += BasicToolStripMenuItem_Click;
        // 
        // scientificToolStripMenuItem
        // 
        scientificToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText;
        scientificToolStripMenuItem.ForeColor = Color.Cyan;
        scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
        scientificToolStripMenuItem.Size = new Size(180, 22);
        scientificToolStripMenuItem.Text = "Scientific";
        scientificToolStripMenuItem.Click += ScientificToolStripMenuItem_Click;
        // 
        // basicPanel
        // 
        basicPanel.Controls.Add(tableLayoutPanel1);
        basicPanel.Controls.Add(label2);
        basicPanel.Controls.Add(label1);
        basicPanel.Dock = DockStyle.Fill;
        basicPanel.Location = new Point(200, 24);
        basicPanel.Name = "basicPanel";
        basicPanel.Size = new Size(319, 677);
        basicPanel.TabIndex = 24;
        // 
        // scientificPanel
        // 
        scientificPanel.Dock = DockStyle.Left;
        scientificPanel.Location = new Point(0, 0);
        scientificPanel.Name = "scientificPanel";
        scientificPanel.Size = new Size(200, 701);
        scientificPanel.TabIndex = 23;
        scientificPanel.Visible = false;
        // 
        // CalcUI
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaptionText;
        ClientSize = new Size(519, 701);
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
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    public Label label1;
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
    public Label label2;
    private TableLayoutPanel tableLayoutPanel1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem viewToolStripMenuItem;
    private ToolStripMenuItem basicToolStripMenuItem;
    private ToolStripMenuItem scientificToolStripMenuItem;
    private Panel basicPanel;
    private Panel scientificPanel;
}
