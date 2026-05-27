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
        SuspendLayout();
        // 
        // label1
        // 
        label1.BorderStyle = BorderStyle.Fixed3D;
        label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ForeColor = SystemColors.HotTrack;
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(495, 113);
        label1.TabIndex = 0;
        label1.Text = "0";
        label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // negateButton
        // 
        negateButton.BackColor = Color.Black;
        negateButton.Font = new Font("Segoe UI", 24F);
        negateButton.ForeColor = Color.Cyan;
        negateButton.Location = new Point(12, 558);
        negateButton.Name = "negateButton";
        negateButton.Size = new Size(120, 100);
        negateButton.TabIndex = 1;
        negateButton.Text = "+/-";
        negateButton.UseVisualStyleBackColor = false;
        negateButton.Click += negateButton_Click;
        // 
        // zeroButton
        // 
        zeroButton.BackColor = Color.Black;
        zeroButton.Font = new Font("Segoe UI", 24F);
        zeroButton.ForeColor = Color.Cyan;
        zeroButton.Location = new Point(138, 558);
        zeroButton.Name = "zeroButton";
        zeroButton.Size = new Size(120, 100);
        zeroButton.TabIndex = 2;
        zeroButton.Text = "0";
        zeroButton.UseVisualStyleBackColor = false;
        zeroButton.Click += zeroButton_Click;
        // 
        // periodButton
        // 
        periodButton.BackColor = Color.Black;
        periodButton.Font = new Font("Segoe UI", 24F);
        periodButton.ForeColor = Color.Cyan;
        periodButton.Location = new Point(264, 558);
        periodButton.Name = "periodButton";
        periodButton.Size = new Size(120, 100);
        periodButton.TabIndex = 3;
        periodButton.Text = ".";
        periodButton.UseVisualStyleBackColor = false;
        periodButton.Click += periodButton_Click;
        // 
        // equateButton
        // 
        equateButton.BackColor = Color.Cyan;
        equateButton.Font = new Font("Segoe UI", 24F);
        equateButton.ForeColor = Color.Black;
        equateButton.Location = new Point(390, 558);
        equateButton.Name = "equateButton";
        equateButton.Size = new Size(120, 100);
        equateButton.TabIndex = 4;
        equateButton.Text = "=";
        equateButton.UseVisualStyleBackColor = false;
        equateButton.Click += equateButton_Click;
        // 
        // oneButton
        // 
        oneButton.BackColor = Color.Black;
        oneButton.Font = new Font("Segoe UI", 24F);
        oneButton.ForeColor = Color.Cyan;
        oneButton.Location = new Point(12, 452);
        oneButton.Name = "oneButton";
        oneButton.Size = new Size(120, 100);
        oneButton.TabIndex = 5;
        oneButton.Text = "1";
        oneButton.UseVisualStyleBackColor = false;
        oneButton.Click += oneButton_Click;
        // 
        // twoButton
        // 
        twoButton.BackColor = Color.Black;
        twoButton.Font = new Font("Segoe UI", 24F);
        twoButton.ForeColor = Color.Cyan;
        twoButton.Location = new Point(138, 452);
        twoButton.Name = "twoButton";
        twoButton.Size = new Size(120, 100);
        twoButton.TabIndex = 6;
        twoButton.Text = "2";
        twoButton.UseVisualStyleBackColor = false;
        twoButton.Click += twoButton_Click;
        // 
        // threeButton
        // 
        threeButton.BackColor = Color.Black;
        threeButton.Font = new Font("Segoe UI", 24F);
        threeButton.ForeColor = Color.Cyan;
        threeButton.Location = new Point(264, 452);
        threeButton.Name = "threeButton";
        threeButton.Size = new Size(120, 100);
        threeButton.TabIndex = 7;
        threeButton.Text = "3";
        threeButton.UseVisualStyleBackColor = false;
        threeButton.Click += threeButton_Click;
        // 
        // plusButton
        // 
        plusButton.BackColor = Color.Black;
        plusButton.Font = new Font("Segoe UI", 24F);
        plusButton.ForeColor = Color.Cyan;
        plusButton.Location = new Point(390, 452);
        plusButton.Name = "plusButton";
        plusButton.Size = new Size(120, 100);
        plusButton.TabIndex = 8;
        plusButton.Text = "+";
        plusButton.UseVisualStyleBackColor = false;
        plusButton.Click += plusButton_Click;
        // 
        // fourButton
        // 
        fourButton.BackColor = Color.Black;
        fourButton.Font = new Font("Segoe UI", 24F);
        fourButton.ForeColor = Color.Cyan;
        fourButton.Location = new Point(12, 346);
        fourButton.Name = "fourButton";
        fourButton.Size = new Size(120, 100);
        fourButton.TabIndex = 9;
        fourButton.Text = "4";
        fourButton.UseVisualStyleBackColor = false;
        fourButton.Click += fourButton_Click;
        // 
        // fiveButton
        // 
        fiveButton.BackColor = Color.Black;
        fiveButton.Font = new Font("Segoe UI", 24F);
        fiveButton.ForeColor = Color.Cyan;
        fiveButton.Location = new Point(138, 346);
        fiveButton.Name = "fiveButton";
        fiveButton.Size = new Size(120, 100);
        fiveButton.TabIndex = 10;
        fiveButton.Text = "5";
        fiveButton.UseVisualStyleBackColor = false;
        fiveButton.Click += fiveButton_Click;
        // 
        // sixButton
        // 
        sixButton.BackColor = Color.Black;
        sixButton.Font = new Font("Segoe UI", 24F);
        sixButton.ForeColor = Color.Cyan;
        sixButton.Location = new Point(264, 346);
        sixButton.Name = "sixButton";
        sixButton.Size = new Size(120, 100);
        sixButton.TabIndex = 11;
        sixButton.Text = "6";
        sixButton.UseVisualStyleBackColor = false;
        sixButton.Click += sixButton_Click;
        // 
        // subtractButton
        // 
        subtractButton.BackColor = Color.Black;
        subtractButton.Font = new Font("Segoe UI", 24F);
        subtractButton.ForeColor = Color.Cyan;
        subtractButton.Location = new Point(390, 346);
        subtractButton.Name = "subtractButton";
        subtractButton.Size = new Size(120, 100);
        subtractButton.TabIndex = 12;
        subtractButton.Text = "-";
        subtractButton.UseVisualStyleBackColor = false;
        subtractButton.Click += subtractButton_Click;
        // 
        // sevenButton
        // 
        sevenButton.BackColor = Color.Black;
        sevenButton.Font = new Font("Segoe UI", 24F);
        sevenButton.ForeColor = Color.Cyan;
        sevenButton.Location = new Point(12, 240);
        sevenButton.Name = "sevenButton";
        sevenButton.Size = new Size(120, 100);
        sevenButton.TabIndex = 13;
        sevenButton.Text = "7";
        sevenButton.UseVisualStyleBackColor = false;
        sevenButton.Click += sevenButton_Click;
        // 
        // eightButton
        // 
        eightButton.BackColor = Color.Black;
        eightButton.Font = new Font("Segoe UI", 24F);
        eightButton.ForeColor = Color.Cyan;
        eightButton.Location = new Point(138, 240);
        eightButton.Name = "eightButton";
        eightButton.Size = new Size(120, 100);
        eightButton.TabIndex = 14;
        eightButton.Text = "8";
        eightButton.UseVisualStyleBackColor = false;
        eightButton.Click += eightButton_Click;
        // 
        // nineButton
        // 
        nineButton.BackColor = Color.Black;
        nineButton.Font = new Font("Segoe UI", 24F);
        nineButton.ForeColor = Color.Cyan;
        nineButton.Location = new Point(264, 240);
        nineButton.Name = "nineButton";
        nineButton.Size = new Size(120, 100);
        nineButton.TabIndex = 15;
        nineButton.Text = "9";
        nineButton.UseVisualStyleBackColor = false;
        nineButton.Click += nineButton_Click;
        // 
        // multiplyButton
        // 
        multiplyButton.BackColor = Color.Black;
        multiplyButton.Font = new Font("Segoe UI", 24F);
        multiplyButton.ForeColor = Color.Cyan;
        multiplyButton.Location = new Point(390, 240);
        multiplyButton.Name = "multiplyButton";
        multiplyButton.Size = new Size(120, 100);
        multiplyButton.TabIndex = 16;
        multiplyButton.Text = "*";
        multiplyButton.UseVisualStyleBackColor = false;
        multiplyButton.Click += multiplyButton_Click;
        // 
        // percentButton
        // 
        percentButton.BackColor = Color.Black;
        percentButton.Font = new Font("Segoe UI", 24F);
        percentButton.ForeColor = Color.Cyan;
        percentButton.Location = new Point(12, 134);
        percentButton.Name = "percentButton";
        percentButton.Size = new Size(120, 100);
        percentButton.TabIndex = 17;
        percentButton.Text = "%";
        percentButton.UseVisualStyleBackColor = false;
        percentButton.Click += percentButton_Click;
        // 
        // clearEntryButton
        // 
        clearEntryButton.BackColor = Color.Black;
        clearEntryButton.Font = new Font("Segoe UI", 24F);
        clearEntryButton.ForeColor = Color.Cyan;
        clearEntryButton.Location = new Point(138, 134);
        clearEntryButton.Name = "clearEntryButton";
        clearEntryButton.Size = new Size(120, 100);
        clearEntryButton.TabIndex = 18;
        clearEntryButton.Text = "CE";
        clearEntryButton.UseVisualStyleBackColor = false;
        clearEntryButton.Click += clearEntryButton_Click;
        // 
        // clearAllButton
        // 
        clearAllButton.BackColor = Color.Black;
        clearAllButton.Font = new Font("Segoe UI", 24F);
        clearAllButton.ForeColor = Color.Cyan;
        clearAllButton.Location = new Point(264, 134);
        clearAllButton.Name = "clearAllButton";
        clearAllButton.Size = new Size(120, 100);
        clearAllButton.TabIndex = 19;
        clearAllButton.Text = "C";
        clearAllButton.UseVisualStyleBackColor = false;
        clearAllButton.Click += clearAllButton_Click;
        // 
        // divideButton
        // 
        divideButton.BackColor = Color.Black;
        divideButton.Font = new Font("Segoe UI", 24F);
        divideButton.ForeColor = Color.Cyan;
        divideButton.Location = new Point(390, 134);
        divideButton.Name = "divideButton";
        divideButton.Size = new Size(120, 100);
        divideButton.TabIndex = 20;
        divideButton.Text = "/";
        divideButton.UseVisualStyleBackColor = false;
        divideButton.Click += divideButton_Click;
        // 
        // label2
        // 
        label2.BorderStyle = BorderStyle.Fixed3D;
        label2.ForeColor = Color.DodgerBlue;
        label2.Location = new Point(12, 9);
        label2.Name = "label2";
        label2.Size = new Size(246, 23);
        label2.TabIndex = 21;
        // 
        // CalcUI
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaptionText;
        ClientSize = new Size(519, 670);
        Controls.Add(label2);
        Controls.Add(divideButton);
        Controls.Add(clearAllButton);
        Controls.Add(clearEntryButton);
        Controls.Add(percentButton);
        Controls.Add(multiplyButton);
        Controls.Add(nineButton);
        Controls.Add(eightButton);
        Controls.Add(sevenButton);
        Controls.Add(subtractButton);
        Controls.Add(sixButton);
        Controls.Add(fiveButton);
        Controls.Add(fourButton);
        Controls.Add(plusButton);
        Controls.Add(threeButton);
        Controls.Add(twoButton);
        Controls.Add(oneButton);
        Controls.Add(equateButton);
        Controls.Add(periodButton);
        Controls.Add(zeroButton);
        Controls.Add(negateButton);
        Controls.Add(label1);
        ForeColor = SystemColors.ControlText;
        Name = "CalcUI";
        Text = "Kush's Calculator Xtreme!!!";
        Load += CalcUI_Load;
        ResumeLayout(false);
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
}
