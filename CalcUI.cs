using CalculatorAppUI.Services;
using System.Globalization;

namespace CalculatorAppUI;

//GOH: Claude mentioned a couple things:
// outputUpdater has no test coverage.
//good idea to figure out how to resize font if currentInput too big for UI.

public partial class CalcUI : Form
{
    private readonly Calculator calc = new Calculator();

    string currentInput = "0";
    string calcOperator = "";
    string arg1 = "";
    string arg2 = "";
    bool argumentEntered = false;
    bool layerTwo = false;
    readonly Dictionary<Keys, Button> keyboardMapper;
    readonly Dictionary<Keys, Button> keyboardMapperShifted;


    public CalcUI()
    {
        InitializeComponent();
        ActiveControl = equateButton;

        keyboardMapper = new Dictionary<Keys, Button>
        {
            { Keys.D0, zeroButton },
            { Keys.NumPad0, zeroButton },
            { Keys.D1, oneButton },
            { Keys.NumPad1, oneButton },
            { Keys.D2, twoButton },
            { Keys.NumPad2, twoButton },
            { Keys.D3, threeButton },
            { Keys.NumPad3, threeButton },
            { Keys.D4, fourButton },
            { Keys.NumPad4, fourButton },
            { Keys.D5, fiveButton },
            { Keys.NumPad5, fiveButton },
            { Keys.D6, sixButton },
            { Keys.NumPad6, sixButton },
            { Keys.D7, sevenButton },
            { Keys.NumPad7, sevenButton },
            { Keys.D8, eightButton },
            { Keys.NumPad8, eightButton },
            { Keys.D9, nineButton },
            { Keys.NumPad9, nineButton },
            { Keys.Oemplus, equateButton },
            { Keys.Add, plusButton },
            { Keys.OemMinus, subtractButton },
            { Keys.Subtract, subtractButton },
            { Keys.Multiply, multiplyButton },
            { Keys.OemQuestion, divideButton },
            { Keys.Divide, divideButton },
            { Keys.OemPeriod, periodButton },
            { Keys.Decimal, periodButton },
            { Keys.Enter, equateButton },
            { Keys.F9, negateButton },
            { Keys.Delete, clearEntryButton },
            { Keys.Escape, clearAllButton }
        };
        keyboardMapperShifted = new Dictionary<Keys, Button>
        {
            { Keys.D5, percentButton },
            { Keys.NumPad5, percentButton },
            { Keys.D8, multiplyButton },
            { Keys.NumPad8, multiplyButton },
            { Keys.Oemplus, plusButton }
        };
    }

    private void CalcUI_KeyDown(object sender, KeyEventArgs e)
    {
        e.SuppressKeyPress = true;

        if (keyboardMapper.ContainsKey(e.KeyCode))
        {
            if (e.Shift && keyboardMapperShifted.ContainsKey(e.KeyCode))
            {
                keyboardMapperShifted[e.KeyCode].PerformClick();
            }
            else
            {
                keyboardMapper[e.KeyCode].PerformClick();
            }
        }

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
        double currentInputParsed = double.Parse(currentInput, CultureInfo.InvariantCulture);
        string displayText = arg1 + " " + calcOperator + " " + currentInput + "%";
        label2.Text = displayText;
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
                    //ex: 80 + 10% = 88
                case "-":
                    //ex: 80 - 10% = 72
                    currentInput = calc.PercentageOf(arg1Parsed, currentInputParsed).ToString();
                    break;
                case "*":
                    //ex: 100 * 5% = 5
                case "/":
                    //ex: 100 / 5% = 2000
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
                if (double.IsNaN(result) || double.IsInfinity(result))
                {
                    ClearEverything();
                    label1.Text = "Invalid Input";
                    return false;
                }
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
