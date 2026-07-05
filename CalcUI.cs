using CalculatorAppUI.Services;
using System.Globalization;

namespace CalculatorAppUI;

//GOH: Claude mentioned a couple things:
// outputUpdater has no test coverage.
//culture crash; double.Parse/toString -> CultureInfo.InvariantCulture
//good idea to figure out how to resize font if currentInput too big for UI.
//need to revisit % button overall...

public partial class CalcUI : Form
{
    private readonly Calculator calc = new Calculator();

    string currentInput = "0";
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

    private void NegateButton_Click(object sender, EventArgs e)
    {
        if (currentInput != "0")
        {
            if (label2.Text.Contains("="))
            {
                PerformSingleOperation("", calc.Negate);
            }
            else
            {
                PerformSingleOperation(label2.Text, calc.Negate);
            }            
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

    private void PerformSingleOperation(string display, Func<double, double> op)
    {
        double input = double.Parse(currentInput, CultureInfo.InvariantCulture);
        double result = op(input);
        if (double.IsNaN(result) || double.IsInfinity(result))
        {
            ClearEverything();
            label1.Text = "Error: Invalid input";
        }
        else
        {
            label2.Text = display;
            currentInput = result.ToString();
            label1.Text = currentInput;
            argumentEntered = true;
        }
    }

    private void PeriodButton_Click(object sender, EventArgs e) //.
    {
        if (label2.Text.Contains('='))
        {
            label2.Text = "";
            currentInput = "0.";
            label1.Text = currentInput;
        }
        else if (!currentInput.Contains('.'))
        {
            currentInput = currentInput + ".";
            label1.Text = currentInput;
        }
        argumentEntered = true;
    }

    private void EquateButton_Click(object sender, EventArgs e) //=
    {
        if (calcOperator != "")
        {
            arg2 = currentInput;
            double result = 0;
            if (GetResultFromOperation(out result))
            {
                currentInput = result.ToString();
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
        double currentInputParsed = double.Parse(currentInput, CultureInfo.InvariantCulture);
        if (calcOperator == "")
        {
            currentInput = calc.Percent(currentInputParsed).ToString();
        }
        else
        {
            double arg1Parsed = double.Parse(arg1, CultureInfo.InvariantCulture);
            switch (calcOperator)
            {
                case "+":
                    currentInput = calc.PercentageOf(arg1Parsed, currentInputParsed).ToString();
                    break;
                case "-":
                    currentInput = calc.PercentageOf(arg1Parsed, currentInputParsed).ToString();
                    break;
                case "*":
                    currentInput = calc.Percent(currentInputParsed).ToString();
                    break;
                case "/":
                    currentInput = calc.Percent(currentInputParsed).ToString();
                    break;
                default: break;
            }
        }
        label1.Text = currentInput;
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
            arg1 = currentInput;
            currentInput = "0";
            label1.Text = currentInput;
        }
        else if (argumentEntered) //user wanted to take whatever the current result would be, do the operation, then use the newOperator to do something else.
        {
            argumentEntered = false;
            arg2 = currentInput;
            double result = 0;
            if (GetResultFromOperation(out result))
            {
                arg1 = result.ToString();
                currentInput = "0";
                arg2 = "";
                label1.Text = currentInput;
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
        PerformSingleOperation("1 / " + currentInput + " = ", calc.Reciprocal);
    }

    private void SquareButton_Click(object sender, EventArgs e)
    {
        PerformSingleOperation(currentInput + " ^ 2 = ", calc.Square);
    }

    private void SquareRootButton_Click(object sender, EventArgs e)
    {
        PerformSingleOperation("²√( " + currentInput + " ) = ", calc.SquareRoot);
    }

    private void TenPowerXButton_Click(object sender, EventArgs e)
    {
        PerformSingleOperation("10 ^ " + currentInput + " = ", calc.TenPowerX);
    }

    private void LogBaseTenButton_Click(object sender, EventArgs e)
    {
        PerformSingleOperation("log ( " + currentInput + " ) = ", calc.LogBaseTen);
    }

    private void EulerPowerXButton_Click(object sender, EventArgs e)
    {
        PerformSingleOperation("e ^ " + currentInput + " = ", calc.EulerPowerX);
    }

    private void NaturalLogButton_Click(object sender, EventArgs e)
    {
        PerformSingleOperation("log_e ( " + currentInput + " ) = ", calc.NaturalLog);
    }

    private void PiButton_Click(object sender, EventArgs e)
    {
        label2.Text = "π = ";
        currentInput = calc.Pi().ToString();
        label1.Text = currentInput;
        argumentEntered = true;
    }

    private void EulerButton_Click(object sender, EventArgs e)
    {
        label2.Text = "e = ";
        currentInput = calc.Euler().ToString();
        label1.Text = currentInput;
        argumentEntered = true;
    }

    private void FactorialButton_Click(object sender, EventArgs e)
    {
        double input = double.Parse(currentInput, CultureInfo.InvariantCulture);
        string displayText = currentInput + "! = ";


        if (input >= 0 && input <= 170 && (input % 1) == 0) //upper bound needs to be set, number too large = stack overflow
        {
            //positive integer
            PerformSingleOperation(displayText, calc.Factorial);
        }
        else if (input <= 170 && input % 1 != 0)
        {
            //positive or negative decimal
            PerformSingleOperation(displayText, calc.FactorialGamma);
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
        double angle = double.Parse(currentInput, CultureInfo.InvariantCulture);
    
        if (layerTwo == false)
        {
            PerformSingleOperation("sin " + currentInput + " = ", calc.Sine);
        }
        else
        {
            if(angle < -1d || angle > 1d)
            {
                ClearEverything();
                label1.Text = "Error: Invalid input";
            }
            else
            {
                PerformSingleOperation("sin⁻¹ " + currentInput + " = ", calc.ArcSine);
            }
        }
    }

    private void CosineButton_Click(object sender, EventArgs e)
    {
        double angle = double.Parse(currentInput, CultureInfo.InvariantCulture);
        if (layerTwo == false)
        {
            PerformSingleOperation("cos " + currentInput + " = ", calc.Cosine);
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
                PerformSingleOperation("cos⁻¹ " + currentInput + " = ", calc.ArcCosine);
            }
        }
    }

    private void TangentButton_Click(object sender, EventArgs e)
    {
        double angle = double.Parse(currentInput, CultureInfo.InvariantCulture);
        if (layerTwo == false)
        {
            if (angle % 180 == 90 || angle % 180 == -90) // tan = sin / cos, cant div/0
            {
                ClearEverything();
                label1.Text = "Error: Invalid input";

            }
            else
            {
                PerformSingleOperation("tan " + currentInput + " = ", calc.Tangent);
            }
        }
        else
        {
            PerformSingleOperation("tan⁻¹ " + currentInput + " = ", calc.ArcTangent);
        }
        
    }
}
