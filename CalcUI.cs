using CalculatorAppUI.Services;
using System.Globalization;

namespace CalculatorAppUI;

//GOH: Claude mentioned a couple things:
// line 205: ref should be out on result
// outputUpdater has no test coverage.
//culture crash; double.Parse/toString -> CultureInfo.InvariantCulture
//good idea to figure out how to resize font if placeHolder too big for UI.

public partial class CalcUI : Form
{
    private readonly Calculator calc = new Calculator();

    string placeHolder = "0";
    string calcOperator = "";
    string arg1 = "";
    string arg2 = "";
    bool argumentEntered = false;
    bool layerTwo = false;
    public CalcUI()
    {
        InitializeComponent();
        ActiveControl = equateButton;
    }

    private void NegateButton_Click(object sender, EventArgs e) //negate
    {
        if (placeHolder != "0")
        {
            placeHolder = calc.Negate(double.Parse(placeHolder, CultureInfo.InvariantCulture)).ToString();
            label1.Text = placeHolder;
            if (label2.Text.Contains("="))
            {
                label2.Text = "";
            }
            argumentEntered = true;
        }
        
    }

    private void Digit_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        string? tag = (string?)btn.Tag;
        if (tag != null)
        {
            DigitEntered(tag);
        }
    }

    private void DigitEntered(string digit)
    {
        UpdateCalcText(digit);
        argumentEntered = true;
    }

    private void Operator_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        string? tag = (string?)btn.Tag;
        if (tag != null)
        {
            HandleOperatorPress(tag);
        }
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
            if (GetResultFromOperation(out result))
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

    private void PercentButton_Click(object sender, EventArgs e) //%
    {
        //this thing is NOT a simple divide by 100.
        //GOH: revisit this and add label2 to each case. additionally can collapse the switch statement.
        double placeHolderParsed = double.Parse(placeHolder, CultureInfo.InvariantCulture);
        if (calcOperator == "")
        {
            placeHolder = calc.Percent(placeHolderParsed).ToString();
        }
        else
        {
            double arg1Parsed = double.Parse(arg1, CultureInfo.InvariantCulture);
            switch (calcOperator)
            {
                case "+":
                    placeHolder = calc.PercentageOf(arg1Parsed, placeHolderParsed).ToString();
                    break;
                case "-":
                    placeHolder = calc.PercentageOf(arg1Parsed, placeHolderParsed).ToString();
                    break;
                case "*":
                    placeHolder = calc.Percent(placeHolderParsed).ToString();
                    break;
                case "/":
                    placeHolder = calc.Percent(placeHolderParsed).ToString();
                    break;
                default: break;
            }
        }
        label1.Text = placeHolder;
    }

    private void ClearEntryButton_Click(object sender, EventArgs e) //CE
    {
        ClearEntry();
    }

    private void ClearAllButton_Click(object sender, EventArgs e) //C
    {
        ClearEverything();
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
            if (GetResultFromOperation(out result))
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
    private bool GetResultFromOperation(out double result)
    {
        double arg1Parsed = double.Parse(arg1, CultureInfo.InvariantCulture);
        double arg2Parsed = double.Parse(arg2, CultureInfo.InvariantCulture);
        switch (calcOperator)
        {
            case "+":
                result = calc.Add(arg1Parsed, arg2Parsed);
                break;
            case "-":
                result = calc.Subtract(arg1Parsed, arg2Parsed);
                break;
            case "*":
                result = calc.Multiply(arg1Parsed, arg2Parsed);
                break;
            case "/":
                if (arg2Parsed != 0d)
                {
                    result = calc.Divide(arg1Parsed, arg2Parsed);
                }
                else
                {
                    result = 0;
                    ClearEverything();
                    label1.Text = "Error: DIV/0";
                    return false;
                }
                break;
            case "^":
                result = calc.Power(arg1Parsed, arg2Parsed);
                break;
            case "yroot":
                if (arg2Parsed != 0d)
                {
                    result = calc.NthRoot(arg1Parsed, arg2Parsed);
                    if (double.IsNaN(result) || double.IsInfinity(result))
                    {
                        ClearEverything();
                        label1.Text = "Invalid Input";
                        return false;
                    }
                } 
                else
                {
                    result = 0;
                    ClearEverything();
                    label1.Text = "Error: DIV/0";
                    return false;
                }
                break;
            case "exp":
                result = calc.Exponent(arg1Parsed, arg2Parsed);
                break;
            case "mod":
                result = calc.Modulo(arg1Parsed, arg2Parsed);
                break;
            default:
                result = 0;
                return false;
        }
        return true;
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

    private void BasicToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (scientificPanel.Visible == true)
        {
            scientificPanel.Visible = false;
            this.Width = this.Width - scientificPanel.Width;
        }
    }

    private void ScientificToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (scientificPanel.Visible == false)
        {
            scientificPanel.Visible = true;
            this.Width = this.Width + scientificPanel.Width;
        }
    }

    private void CalcUI_Load(object sender, EventArgs e)
    {

    }

    private void ReciprocalButton_Click(object sender, EventArgs e)
    {
        double arg1Parsed = double.Parse(placeHolder, CultureInfo.InvariantCulture);
        if (arg1Parsed != 0)
        {
            label2.Text = "1 / " + placeHolder + " = ";
            placeHolder = calc.Reciprocal(arg1Parsed).ToString();
            label1.Text = placeHolder;
            argumentEntered = true;
        }
        else
        {
            ClearEverything();
            label1.Text = "Error: DIV/0";
        }

    }

    private void SquareButton_Click(object sender, EventArgs e)
    {
        label2.Text = placeHolder + " ^ 2 = ";
        placeHolder = calc.Square(double.Parse(placeHolder, CultureInfo.InvariantCulture)).ToString();
        label1.Text = placeHolder;
        argumentEntered = true;
    }

    private void SquareRootButton_Click(object sender, EventArgs e)
    {
        double result = calc.SquareRoot(double.Parse(placeHolder, CultureInfo.InvariantCulture));
        if (double.IsNaN(result) || double.IsInfinity(result))
        {
            ClearEverything();
            label1.Text = "Error: Invalid input";
        }
        else
        {
            label2.Text = "²√( " + placeHolder + " ) = ";
            placeHolder = result.ToString();
            label1.Text = placeHolder;
            argumentEntered = true;
        }
        
    }

    private void TenPowerXButton_Click(object sender, EventArgs e)
    {
        label2.Text = "10 ^ " + placeHolder + " = ";
        placeHolder = calc.TenPowerX(double.Parse(placeHolder, CultureInfo.InvariantCulture)).ToString();
        label1.Text = placeHolder;
        argumentEntered = true;
    }

    private void LogBaseTenButton_Click(object sender, EventArgs e)
    {
        double input = double.Parse(placeHolder, CultureInfo.InvariantCulture);
        if (input <= 0)
        {
            ClearEverything();
            label1.Text = "Error: Invalid input";
        }
        else
        {
            label2.Text = "log ( " + placeHolder + " ) = ";
            placeHolder = calc.LogBaseTen(input).ToString();
            label1.Text = placeHolder;
            argumentEntered = true;
        }
    }

    private void EulerPowerXButton_Click(object sender, EventArgs e)
    {
        label2.Text = "e ^ " + placeHolder + " = ";
        placeHolder = calc.EulerPowerX(double.Parse(placeHolder, CultureInfo.InvariantCulture)).ToString();
        label1.Text = placeHolder;
        argumentEntered = true;
    }

    private void NaturalLogButton_Click(object sender, EventArgs e)
    {
        double input = double.Parse(placeHolder, CultureInfo.InvariantCulture);
        if (input <= 0)
        {
            ClearEverything();
            label1.Text = "Error: Invalid input";
        }
        else
        {
            label2.Text = "log_e ( " + placeHolder + " ) = ";
            placeHolder = calc.NaturalLog(input).ToString();
            label1.Text = placeHolder;
            argumentEntered = true;
        }
    }

    private void PiButton_Click(object sender, EventArgs e)
    {
        label2.Text = "π = ";
        placeHolder = calc.Pi().ToString();
        label1.Text = placeHolder;
        argumentEntered = true;
    }

    private void EulerButton_Click(object sender, EventArgs e)
    {
        label2.Text = "e = ";
        placeHolder = calc.Euler().ToString();
        label1.Text = placeHolder;
        argumentEntered = true;
    }

    private void FactorialButton_Click(object sender, EventArgs e)
    {
        double arg1Parsed = double.Parse(placeHolder, CultureInfo.InvariantCulture);
        
        if (arg1Parsed >= 0 && arg1Parsed < 170 && (arg1Parsed % 1) == 0) //upper bound needs to be set, number too large = stack overflow
        {
            //positive integer
            label2.Text = placeHolder + "! = ";
            placeHolder = calc.Factorial(arg1Parsed).ToString();
            label1.Text = placeHolder;
            argumentEntered = true;
        }
        else if (arg1Parsed < 170 && arg1Parsed % 1 != 0)
        {
            //positive or negative decimal
            label2.Text = placeHolder + "! = ";
            placeHolder = calc.FactorialGamma(arg1Parsed).ToString();
            label1.Text = placeHolder;
            argumentEntered = true;
        }
        else
        {
            //invalid input
            ClearEverything();
            label1.Text = "Error: Invalid input";
        }
        
    }

    private void LayerTwoButton_Click(object sender, EventArgs e)
    {
        UpdateLayer();
    }

    private void SineButton_Click(object sender, EventArgs e)
    {
        double angle = double.Parse(placeHolder, CultureInfo.InvariantCulture);
    
        if (layerTwo == false)
        {
            label2.Text = "sin " + placeHolder + " = ";
            placeHolder = calc.Sine(angle).ToString();
            label1.Text = placeHolder;
            argumentEntered = true;
        }
        else
        {
            if(angle < -1d || angle > 1d)
            {
                ClearEverything();
                label1.Text = "Error: Invalid input";
                label1.Text = placeHolder;
                argumentEntered = true;
            }
            else
            {
                label2.Text = "sin⁻¹ " + placeHolder + " = ";
                placeHolder = calc.ArcSine(angle).ToString();
            }
        }
    }

    private void CosineButton_Click(object sender, EventArgs e)
    {
        double angle = double.Parse(placeHolder, CultureInfo.InvariantCulture);
        if (layerTwo == false)
        {
            label2.Text = "cos " + placeHolder + " = ";
            placeHolder = calc.Cosine(angle).ToString();
            label1.Text = placeHolder;
            argumentEntered = true;
        }
        else
        {
            if (angle < -1d || angle > 1d)
            {
                ClearEverything();
                label1.Text = "Error: Invalid input";
            }
            else
            {
                label2.Text = "cos⁻¹ " + placeHolder + " = ";
                placeHolder = calc.ArcCosine(angle).ToString();
                label1.Text = placeHolder;
                argumentEntered = true;
            }
        }
    }

    private void TangentButton_Click(object sender, EventArgs e)
    {
        double angle = double.Parse(placeHolder, CultureInfo.InvariantCulture);
        if (layerTwo == false)
        {
            if (angle % 180 == 90 || angle % 180 == -90) // tan = sin / cos, cant div/0
            {
                ClearEverything();
                label1.Text = "Error: Invalid input";

            }
            else
            {
                label2.Text = "tan " + placeHolder + " = ";
                placeHolder = calc.Tangent(angle).ToString();
                label1.Text = placeHolder;
                argumentEntered = true;
            }
        }
        else
        {
            label2.Text = "tan⁻¹ " + placeHolder + " = ";
            placeHolder = calc.ArcTangent(angle).ToString();
            label1.Text = placeHolder;
            argumentEntered = true;
        }
        
    }
}
