using CalculatorAppUI.Services;
using CalculatorAppUI.Utils;

namespace CalculatorAppUI;

//GOH: Claude mentioned a couple things:
// line 219: arg2 parsed twice
// line 205: ref should be out on result
// outputUpdater has no test coverage.
//culture crash; double.Parse/toString -> CultureInfo.InvariantCulture

public partial class CalcUI : Form
{
    private readonly Calculator calc = new Calculator();

    string placeHolder = "0";
    string calcOperator = "";
    string arg1 = "";
    string arg2 = "";
    bool argumentEntered = false;
    public CalcUI()
    {
        InitializeComponent();
        ActiveControl = equateButton;
    }

    private void NegateButton_Click(object sender, EventArgs e) //negate
    {
        placeHolder = calc.Negate(double.Parse(placeHolder)).ToString();
        label1.Text = placeHolder;
        if (label2.Text.Contains("="))
        {
            label2.Text = "";
        }
        argumentEntered = true;
    }

    private void ZeroButton_Click(object sender, EventArgs e) //0
    {
        DigitEntered("0");
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
        argumentEntered = true;
    }

    private void EquateButton_Click(object sender, EventArgs e) //=
    {
        if (calcOperator != "")
        {
            arg2 = placeHolder;
            double result = 0;
            if (GetResultFromOperation(ref result))
            {
                placeHolder = result.ToString();
                label1.Text = result.ToString();
                label2.Text = arg1 + " " + calcOperator + " " + arg2 + " =";
                arg1 = "";
                arg2 = "";
                calcOperator = "";
                argumentEntered = false;
            }
        }

    }

    private void OneButton_Click(object sender, EventArgs e) //1
    {
        DigitEntered("1");
    }

    private void TwoButton_Click(object sender, EventArgs e) //2
    {
        DigitEntered("2");
    }

    private void ThreeButton_Click(object sender, EventArgs e) //3
    {
        DigitEntered("3");
    }

    private void PlusButton_Click(object sender, EventArgs e) //+
    {
        HandleOperatorPress("+");
    }

    private void FourButton_Click(object sender, EventArgs e) //4
    {
        DigitEntered("4");
    }

    private void FiveButton_Click(object sender, EventArgs e) //5
    {
        DigitEntered("5");
    }

    private void SixButton_Click(object sender, EventArgs e) //6
    {
        DigitEntered("6");
    }

    private void SubtractButton_Click(object sender, EventArgs e) //-
    {
        HandleOperatorPress("-");
    }

    private void SevenButton_Click(object sender, EventArgs e) //7
    {
        DigitEntered("7");
    }

    private void EightButton_Click(object sender, EventArgs e) //8
    {
        DigitEntered("8");
    }

    private void NineButton_Click(object sender, EventArgs e) //9
    {
        DigitEntered("9");
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
            placeHolder = calc.Percent(double.Parse(placeHolder)).ToString();
        }
        else
        {
            switch (calcOperator)
            {
                case "+":
                    placeHolder = calc.PercentageOf(double.Parse(arg1), double.Parse(placeHolder)).ToString();
                    break;
                case "-":
                    placeHolder = calc.PercentageOf(double.Parse(arg1), double.Parse(placeHolder)).ToString();
                    break;
                case "*":
                    placeHolder = calc.Percent(double.Parse(placeHolder)).ToString();
                    break;
                case "/":
                    placeHolder = calc.Percent(double.Parse(placeHolder)).ToString();
                    break;
                default: break;
            }
        }
        label1.Text = placeHolder;
    }

    private void ClearEntryButton_Click(object sender, EventArgs e) //CE
    {
        OutputUpdater.ClearEntry(this, ref placeHolder, ref argumentEntered);
    }

    private void ClearAllButton_Click(object sender, EventArgs e) //C
    {
        OutputUpdater.ClearEverything(this, ref placeHolder, ref arg1, ref arg2, ref calcOperator, ref argumentEntered);
    }

    private void DivideButton_Click(object sender, EventArgs e) //'/'
    {
        HandleOperatorPress("/");
    }
    private void HandleOperatorPress(string newOperator)
    {
        if (calcOperator == "")
        {
            argumentEntered = false;
            arg1 = placeHolder;
            placeHolder = "0";
            label1.Text = placeHolder;
        }
        else if (argumentEntered) //user wanted to take whatever the current result would be, do the operation, then use the newOperator to do something else.
        {
            argumentEntered = false;
            arg2 = placeHolder;
            double result = 0;
            if (GetResultFromOperation(ref result))
            {
                arg1 = result.ToString();
                placeHolder = "0";
                arg2 = "";
                label1.Text = placeHolder;
            }
            else
            {
                return;
            }
        }
        calcOperator = newOperator;
        label2.Text = arg1 + " " + calcOperator;

    }
    private bool GetResultFromOperation(ref double result)
    {
        switch (calcOperator)
        {
            case "+":
                result = calc.Add(double.Parse(arg1), double.Parse(arg2));
                break;
            case "-":
                result = calc.Subtract(double.Parse(arg1), double.Parse(arg2));
                break;
            case "*":
                result = calc.Multiply(double.Parse(arg1), double.Parse(arg2));
                break;
            case "/":
                if (double.Parse(arg2) != 0d)
                {
                    result = calc.Divide(double.Parse(arg1), double.Parse(arg2));
                }
                else
                {
                    OutputUpdater.ClearEverything(this, ref placeHolder, ref arg1, ref arg2, ref calcOperator, ref argumentEntered);
                    label1.Text = "Error: DIV/0";
                    return false;
                }
                break;
            default:
                break;
        }
        return true;
    }

    private void DigitEntered(string digit)
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, digit);
        argumentEntered = true;
    }
    private void CalcUI_KeyDown(object sender, KeyEventArgs e)
    {
        e.SuppressKeyPress = true;
        switch (e.KeyCode)
        {
            case Keys.D0:
            case Keys.NumPad0:
                zeroButton.PerformClick();
                break;
            case Keys.D1:
            case Keys.NumPad1:
                oneButton.PerformClick();
                break;
            case Keys.D2:
            case Keys.NumPad2:
                twoButton.PerformClick();
                break;
            case Keys.D3:
            case Keys.NumPad3:
                threeButton.PerformClick();
                break;
            case Keys.D4:
            case Keys.NumPad4:
                fourButton.PerformClick();
                break;
            case Keys.D5:
            case Keys.NumPad5:
                if (e.Shift)
                {
                    percentButton.PerformClick();
                }
                else
                {
                    fiveButton.PerformClick();
                }
                break;
            case Keys.D6:
            case Keys.NumPad6:
                sixButton.PerformClick();
                break;
            case Keys.D7:
            case Keys.NumPad7:
                sevenButton.PerformClick();
                break;
            case Keys.D8:
            case Keys.NumPad8:
                if (e.Shift)
                {
                    multiplyButton.PerformClick();
                }
                else
                {
                    eightButton.PerformClick();
                }
                break;
            case Keys.D9:
            case Keys.NumPad9:
                nineButton.PerformClick();
                break;
            case Keys.OemQuestion:
            case Keys.Divide:
                divideButton.PerformClick();
                break;
            case Keys.Oemplus:
                if (e.Shift)
                {
                    plusButton.PerformClick();
                }
                else
                {
                    equateButton.PerformClick();
                }
                break;
            case Keys.Add:
                plusButton.PerformClick();
                break;
            case Keys.OemMinus:
            case Keys.Subtract:
                subtractButton.PerformClick();
                break;
            case Keys.Multiply:
                multiplyButton.PerformClick();
                break;
            case Keys.OemPeriod:
            case Keys.Decimal:
                periodButton.PerformClick();
                break;
            case Keys.Enter:
                equateButton.PerformClick();
                break;
            case Keys.F9:
                negateButton.PerformClick();
                break;
            case Keys.Delete:
                clearEntryButton.PerformClick();
                break;
            case Keys.Escape:
                clearAllButton.PerformClick();
                break;

        }
    }
}
