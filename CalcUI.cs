using CalculatorAppUI.Services;
using CalculatorAppUI.Utils;

namespace CalculatorAppUI;

public partial class CalcUI : Form
{

    Calculator calc = new Calculator(); 

    string placeHolder = "0"; 
    string calcOperator = "";
    string arg1, arg2 = "";
    public CalcUI()
    {
        InitializeComponent();
    }

    private void CalcUI_Load(object sender, EventArgs e) 
    {

    }

    private void negateButton_Click(object sender, EventArgs e) //negate
    {
        placeHolder = calc.Negate(float.Parse(placeHolder)).ToString();
        label1.Text = placeHolder;
    }

    private void zeroButton_Click(object sender, EventArgs e) //0
    {
        if (placeHolder != "0")
        {
            if (label2.Text.Contains("="))
            {
                label2.Text = "";
                placeHolder = "0";
                label1.Text = placeHolder;
            }
            else
            {
                placeHolder = placeHolder + "0";
                label1.Text = placeHolder;
            }   
        }
    }

    private void periodButton_Click(object sender, EventArgs e) //.
    {
        if (label2.Text.Contains('='))
        {
            label2.Text = "";
            placeHolder = "0.";
            label1.Text = placeHolder;
        }
        else if (!placeHolder.Contains('.'))
        {
            placeHolder = placeHolder + ".";
            label1.Text = placeHolder;
        }
    }

    private void equateButton_Click(object sender, EventArgs e) //=
    {
        if (calcOperator != "")
        {
            float result = 0;
            arg2 = placeHolder;
            switch (calcOperator)
            {
                case "+":
                    result = calc.Add(float.Parse(arg1), float.Parse(arg2));
                    break;
                case "-":
                    result = calc.Subtract(float.Parse(arg1), float.Parse(arg2));
                    break;
                case "*":
                    result = calc.Multiply(float.Parse(arg1), float.Parse(arg2));
                    break;
                case "/":
                    result = calc.Divide(float.Parse(arg1), float.Parse(arg2));
                    break;
                default:
                    break;
            }
            placeHolder = result.ToString();
            label1.Text = result.ToString();
            label2.Text = arg1 + " " + calcOperator + " " + arg2 + " " + "=";
            arg1 = "";
            arg2 = "";
            calcOperator = "";
        }

    }

    private void oneButton_Click(object sender, EventArgs e) //1
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "1");
    }

    private void twoButton_Click(object sender, EventArgs e) //2
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "2");
    }

    private void threeButton_Click(object sender, EventArgs e) //3
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "3");
    }

    private void plusButton_Click(object sender, EventArgs e) //+
    {
        HandleOperatorPress("+");
    }

    private void fourButton_Click(object sender, EventArgs e) //4
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "4");
    }

    private void fiveButton_Click(object sender, EventArgs e) //5
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "5");
    }

    private void sixButton_Click(object sender, EventArgs e) //6
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "6");
    }

    private void subtractButton_Click(object sender, EventArgs e) //-
    {
        HandleOperatorPress("-");
    }

    private void sevenButton_Click(object sender, EventArgs e) //7
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "7");
    }

    private void eightButton_Click(object sender, EventArgs e) //8
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "8");
    }

    private void nineButton_Click(object sender, EventArgs e) //9
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "9");
    }

    private void multiplyButton_Click(object sender, EventArgs e) //*
    {
        HandleOperatorPress("*");
    }

    private void percentButton_Click(object sender, EventArgs e) //%
    {
        //this thing is NOT a simple divide by 100.
        if (calcOperator == "")
        {
            placeHolder = calc.Percent(float.Parse(placeHolder)).ToString();
        }
        else
        {
            switch (calcOperator)
            {
                case "+":
                    placeHolder = calc.PercentageOf(float.Parse(arg1), float.Parse(placeHolder)).ToString();
                    break;
                case "-":
                    placeHolder = calc.PercentageOf(float.Parse(arg1), float.Parse(placeHolder)).ToString();
                    break;
                case "*":
                    placeHolder = calc.Percent(float.Parse(placeHolder)).ToString();
                    break;
                case "/":
                    placeHolder = calc.Percent(float.Parse(placeHolder)).ToString();
                    break;
                default: break;
            }
        }
        label1.Text = placeHolder;
    }

    private void clearEntryButton_Click(object sender, EventArgs e) //CE
    {
        OutputUpdater.ClearEntry(this, ref placeHolder);
    }

    private void clearAllButton_Click(object sender, EventArgs e) //C
    {
        OutputUpdater.ClearEverything(this, ref placeHolder, ref arg1, ref arg2, ref calcOperator);
    }

    private void divideButton_Click(object sender, EventArgs e) //'/'
    {
        HandleOperatorPress("/");
    }
    private void HandleOperatorPress(string newOperator)
    {
        if (calcOperator == "")
        {
            arg1 = placeHolder;
            placeHolder = "0";
            label1.Text = placeHolder;
        }
        else if (placeHolder != "0") //user wanted to take whatever the current result would be, do the operation, then use the newOperator to do something else.
        {
            arg2 = placeHolder;
            float result = 0;
            switch (calcOperator)
            {
                case "+":
                    result = calc.Add(float.Parse(arg1), float.Parse(arg2));
                    break;
                case "-":
                    result = calc.Subtract(float.Parse(arg1), float.Parse(arg2));
                    break;
                case "*":
                    result = calc.Multiply(float.Parse(arg1), float.Parse(arg2));
                    break;
                case "/":
                    result = calc.Divide(float.Parse(arg1), float.Parse(arg2));
                    break;
                default:
                    break;
            }
            arg1 = result.ToString();
            placeHolder = "0";
            arg2 = "";
            label1.Text = placeHolder;
        }
        calcOperator = newOperator;
        label2.Text = arg1 + " " + calcOperator;

    }

    //GOH: need to solve divide by zero with tryparse stuff
}
