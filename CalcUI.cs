using CalculatorAppUI.Services;
using CalculatorAppUI.Utils;

namespace CalculatorAppUI;

public partial class CalcUI : Form
{

    private readonly Calculator calc = new Calculator();

    string placeHolder = "0"; 
    string calcOperator = "";
    string arg1 = "";
    string arg2 = "";
    public CalcUI()
    {
        InitializeComponent();
    }


    private void NegateButton_Click(object sender, EventArgs e) //negate
    {
        placeHolder = calc.Negate(float.Parse(placeHolder)).ToString();
        label1.Text = placeHolder;
        if (label2.Text.Contains("="))
        {
            label2.Text = "";
        }
    }

    private void ZeroButton_Click(object sender, EventArgs e) //0
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "0");
    }

    private void PeriodButton_Click(object sender, EventArgs e) //.
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

    private void EquateButton_Click(object sender, EventArgs e) //=
    {
        if (calcOperator != "")
        {
            arg2 = placeHolder;
            float result = 0;
            if (GetResultFromOperation(ref result))
            {
                placeHolder = result.ToString();
                label1.Text = result.ToString();
                label2.Text = arg1 + " " + calcOperator + " " + arg2 + " =";
                arg1 = "";
                arg2 = "";
                calcOperator = "";
            }
        }

    }

    private void OneButton_Click(object sender, EventArgs e) //1
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "1");
    }

    private void TwoButton_Click(object sender, EventArgs e) //2
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "2");
    }

    private void ThreeButton_Click(object sender, EventArgs e) //3
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "3");
    }

    private void PlusButton_Click(object sender, EventArgs e) //+
    {
        HandleOperatorPress("+");
    }

    private void FourButton_Click(object sender, EventArgs e) //4
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "4");
    }

    private void FiveButton_Click(object sender, EventArgs e) //5
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "5");
    }

    private void SixButton_Click(object sender, EventArgs e) //6
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "6");
    }

    private void SubtractButton_Click(object sender, EventArgs e) //-
    {
        HandleOperatorPress("-");
    }

    private void SevenButton_Click(object sender, EventArgs e) //7
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "7");
    }

    private void EightButton_Click(object sender, EventArgs e) //8
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "8");
    }

    private void NineButton_Click(object sender, EventArgs e) //9
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "9");
    }

    private void MultiplyButton_Click(object sender, EventArgs e) //*
    {
        HandleOperatorPress("*");
    }

    private void PercentButton_Click(object sender, EventArgs e) //%
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

    private void ClearEntryButton_Click(object sender, EventArgs e) //CE
    {
        OutputUpdater.ClearEntry(this, ref placeHolder);
    }

    private void ClearAllButton_Click(object sender, EventArgs e) //C
    {
        OutputUpdater.ClearEverything(this, ref placeHolder, ref arg1, ref arg2, ref calcOperator);
    }

    private void DivideButton_Click(object sender, EventArgs e) //'/'
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
            if (GetResultFromOperation(ref result))
            {
                arg1 = result.ToString();
                placeHolder = "0";
                arg2 = "";
                label1.Text = placeHolder;
            }
        }
        calcOperator = newOperator;
        label2.Text = arg1 + " " + calcOperator;

    }
    private bool GetResultFromOperation(ref float result)
    { 
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
                if (float.Parse(arg2) != 0f)
                {
                    result = calc.Divide(float.Parse(arg1), float.Parse(arg2));
                }
                else
                {
                    OutputUpdater.ClearEverything(this, ref placeHolder, ref arg1, ref arg2, ref calcOperator);
                    label1.Text = "Error: DIV/0";
                    return false;
                }
                break;
            default:
                break;
        }
        return true;
    }
}
