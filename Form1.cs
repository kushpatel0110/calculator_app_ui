using CalculatorApp.Services;
using CalculatorApp.Utils;

namespace CalculatorAppUI;

public partial class Form1 : Form
{

    Calculator calc = new Calculator(); 

    string placeHolder = "0"; //THERE IS AN ANNOYING BUG WHERE IF YOU DO 1 - 1 =, YOU WILL GET A RESULT OF 0. PUSHING A 9 WILL UPDATE TEXT, BUT NOT CLEAR LABEL2, MEANING THE NEXT NUMBER INPUTTED WILL REPLACE THE 9. AAAAAAAAAA
    string calcOperator = "";
    string arg1, arg2;
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) 
    {

    }

    private void button1_Click(object sender, EventArgs e) //negate
    {
        placeHolder = calc.Negate(float.Parse(placeHolder)).ToString();
        label1.Text = placeHolder;
    }

    private void button2_Click(object sender, EventArgs e) //0
    {
        //for number buttons i have a couple things i need to work on here
        //first i need some sort of string buffer or int buffer that i can later turn into a complete number via tryparse 
        //then also, when this button is clicked, i need to figure out a way to display this on the label.
        //i need to figure out what to do with the arguments with this function and figure out how to explain what is happening there.
        //SHOULD I HANDLE KEYBOARD INPUT?
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

    private void button3_Click(object sender, EventArgs e) //.
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

    private void button4_Click(object sender, EventArgs e) //=
    {
        //if (calcOperator != "")
        //{
        //    arg2 = placeHolder;
        //    float result = calc.Add(float.Parse(arg1), float.Parse(arg2));
        //    placeHolder = result.ToString();
        //    label1.Text = result.ToString();
        //    label2.Text = arg1 + " " + calcOperator + " " + arg2 + " " + "=";
        //    arg1 = "";
        //    arg2 = "";
        //    calcOperator = "";
        //}
        if (calcOperator != "")
        {
            float result;
            switch (calcOperator)
            {
                case "+":
                    arg2 = placeHolder;
                    result = calc.Add(float.Parse(arg1), float.Parse(arg2));
                    placeHolder = result.ToString();
                    label1.Text = result.ToString();
                    break;
                case "-":
                    arg2 = placeHolder;
                    result = calc.Subtract(float.Parse(arg1), float.Parse(arg2));
                    placeHolder = result.ToString();
                    label1.Text = result.ToString();
                    break;
                case "*":
                    arg2 = placeHolder;
                    result = calc.Multiply(float.Parse(arg1), float.Parse(arg2));
                    placeHolder = result.ToString();
                    label1.Text = result.ToString();
                    break;
                case "/":
                    arg2 = placeHolder;
                    result = calc.Divide(float.Parse(arg1), float.Parse(arg2));
                    placeHolder = result.ToString();
                    label1.Text = result.ToString();
                    break;
                default:
                    break;
            }
            label2.Text = arg1 + " " + calcOperator + " " + arg2 + " " + "=";
            arg1 = "";
            arg2 = "";
            calcOperator = "";
        }

    }

    private void button5_Click(object sender, EventArgs e) //1
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "1");
    }

    private void button6_Click(object sender, EventArgs e) //2
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "2");
    }

    private void button7_Click(object sender, EventArgs e) //3
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "3");
    }

    private void button8_Click(object sender, EventArgs e) //+
    {
        //need to get the calculator class set up and running here
        //when i press this button, i need to be able to save the input that is currently present and clear the label text
        //maybe i make an operator variable and set that variable here, maybe make another function to handle it too
        //just to be sure that if use presses + by mistake and wanted -, they can switch to it seemlessly.

        switch (calcOperator)
        {
            case "":
                calcOperator = "+";
                arg1 = placeHolder;
                placeHolder = "0";
                label1.Text = placeHolder;
                label2.Text = arg1 + " " + calcOperator;
                
                break;
            case "+":
                calcOperator = "+";
                if (placeHolder == "0")
                {
                    //if placeholder is empty, then the user just wanted to switch the operator. if thats the case, update the variable, update the text on screen.
                    label2.Text = arg1 + " " + calcOperator;
                }
                else //user wanted to take whatever the current result would be, do the operation, then add something else.
                {
                    arg2 = placeHolder;
                    float result = calc.Add(float.Parse(arg1), float.Parse(arg2));
                    arg1 = result.ToString();
                    placeHolder = "0";
                    arg2 = "";
                    label1.Text = placeHolder;
                    label2.Text = arg1 + " " + calcOperator;
                }
                break;
            case "-":
                calcOperator = "+";
                if (placeHolder == "0")
                {
                    label2.Text = arg1 + " " + calcOperator;
                }
                else
                {
                    arg2 = placeHolder;
                    float result = calc.Subtract(float.Parse(arg1), float.Parse(arg2));
                    arg1 = result.ToString();
                    placeHolder = "0";
                    arg2 = "";
                    label1.Text = placeHolder;
                    label2.Text = arg1 + " " + calcOperator;
                }
                break;
            case "*":
                calcOperator = "+";
                if (placeHolder == "0")
                {
                    label2.Text = arg1 + " " + calcOperator;
                }
                else
                {
                    arg2 = placeHolder;
                    float result = calc.Multiply(float.Parse(arg1), float.Parse(arg2));
                    arg1 = result.ToString();
                    placeHolder = "0";
                    arg2 = "";
                    label1.Text = placeHolder;
                    label2.Text = arg1 + " " + calcOperator;
                }
                break;
            case "/":
                calcOperator = "+";
                if (placeHolder == "0")
                {
                    label2.Text = arg1 + " " + calcOperator;
                }
                else
                {
                    arg2 = placeHolder;
                    float result = calc.Divide(float.Parse(arg1), float.Parse(arg2));
                    arg1 = result.ToString();
                    placeHolder = "0";
                    arg2 = "";
                    label1.Text = placeHolder;
                    label2.Text = arg1 + " " + calcOperator;
                }
                break;
            default:
                break;
        }
    }

    private void button9_Click(object sender, EventArgs e) //4
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "4");
    }

    private void button10_Click(object sender, EventArgs e) //5
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "5");
    }

    private void button11_Click(object sender, EventArgs e) //6
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "6");
    }

    private void button12_Click(object sender, EventArgs e) //-
    {
        switch (calcOperator)
        {
            case "":
                calcOperator = "-";
                arg1 = placeHolder;
                placeHolder = "0";
                label1.Text = placeHolder;
                label2.Text = arg1 + " " + calcOperator;

                break;
            case "+":
                calcOperator = "-";
                if (placeHolder == "0")
                {
                    //if placeholder is empty, then the user just wanted to switch the operator. if thats the case, update the variable, update the text on screen.
                    label2.Text = arg1 + " " + calcOperator;
                }
                else //user wanted to take whatever the current result would be, do the operation, then add something else.
                {
                    arg2 = placeHolder;
                    float result = calc.Add(float.Parse(arg1), float.Parse(arg2));
                    arg1 = result.ToString();
                    placeHolder = "0";
                    arg2 = "";
                    label1.Text = placeHolder;
                    label2.Text = arg1 + " " + calcOperator;
                }
                break;
            case "-":
                calcOperator = "-";
                if (placeHolder == "0")
                {
                    label2.Text = arg1 + " " + calcOperator;
                }
                else
                {
                    arg2 = placeHolder;
                    float result = calc.Subtract(float.Parse(arg1), float.Parse(arg2));
                    arg1 = result.ToString();
                    placeHolder = "0";
                    arg2 = "";
                    label1.Text = placeHolder;
                    label2.Text = arg1 + " " + calcOperator;
                }
                break;
            case "*":
                calcOperator = "-";
                if (placeHolder == "0")
                {
                    label2.Text = arg1 + " " + calcOperator;
                }
                else
                {
                    arg2 = placeHolder;
                    float result = calc.Multiply(float.Parse(arg1), float.Parse(arg2));
                    arg1 = result.ToString();
                    placeHolder = "0";
                    arg2 = "";
                    label1.Text = placeHolder;
                    label2.Text = arg1 + " " + calcOperator;
                }
                break;
            case "/":
                calcOperator = "-";
                if (placeHolder == "0")
                {
                    label2.Text = arg1 + " " + calcOperator;
                }
                else
                {
                    arg2 = placeHolder;
                    float result = calc.Divide(float.Parse(arg1), float.Parse(arg2));
                    arg1 = result.ToString();
                    placeHolder = "0";
                    arg2 = "";
                    label1.Text = placeHolder;
                    label2.Text = arg1 + " " + calcOperator;
                }
                break;
            default:
                break;
        }
    }

    private void button13_Click(object sender, EventArgs e) //7
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "7");
    }

    private void button14_Click(object sender, EventArgs e) //8
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "8");
    }

    private void button15_Click(object sender, EventArgs e) //9
    {
        OutputUpdater.UpdateCalcText(this, ref placeHolder, "9");
    }

    private void button16_Click(object sender, EventArgs e) //*
    {
        switch (calcOperator)
        {
            case "":
                calcOperator = "*";
                arg1 = placeHolder;
                placeHolder = "0";
                label1.Text = placeHolder;
                label2.Text = arg1 + " " + calcOperator;

                break;
            case "+":
                calcOperator = "*";
                if (placeHolder == "0")
                {
                    //if placeholder is empty, then the user just wanted to switch the operator. if thats the case, update the variable, update the text on screen.
                    label2.Text = arg1 + " " + calcOperator;
                }
                else //user wanted to take whatever the current result would be, do the operation, then add something else.
                {
                    arg2 = placeHolder;
                    float result = calc.Add(float.Parse(arg1), float.Parse(arg2));
                    arg1 = result.ToString();
                    placeHolder = "0";
                    arg2 = "";
                    label1.Text = placeHolder;
                    label2.Text = arg1 + " " + calcOperator;
                }
                break;
            case "-":
                calcOperator = "*";
                if (placeHolder == "0")
                {
                    label2.Text = arg1 + " " + calcOperator;
                }
                else
                {
                    arg2 = placeHolder;
                    float result = calc.Subtract(float.Parse(arg1), float.Parse(arg2));
                    arg1 = result.ToString();
                    placeHolder = "0";
                    arg2 = "";
                    label1.Text = placeHolder;
                    label2.Text = arg1 + " " + calcOperator;
                }
                break;
            case "*":
                calcOperator = "*";
                if (placeHolder == "0")
                {
                    label2.Text = arg1 + " " + calcOperator;
                }
                else
                {
                    arg2 = placeHolder;
                    float result = calc.Multiply(float.Parse(arg1), float.Parse(arg2));
                    arg1 = result.ToString();
                    placeHolder = "0";
                    arg2 = "";
                    label1.Text = placeHolder;
                    label2.Text = arg1 + " " + calcOperator;
                }
                break;
            case "/":
                calcOperator = "*";
                if (placeHolder == "0")
                {
                    label2.Text = arg1 + " " + calcOperator;
                }
                else
                {
                    arg2 = placeHolder;
                    float result = calc.Divide(float.Parse(arg1), float.Parse(arg2));
                    arg1 = result.ToString();
                    placeHolder = "0";
                    arg2 = "";
                    label1.Text = placeHolder;
                    label2.Text = arg1 + " " + calcOperator;
                }
                break;
            default:
                break;
        }
    }

    private void button17_Click(object sender, EventArgs e) //%
    {
        //this thing is NOT a simple divide by 100 man.
        if (calcOperator == "")
        {
            placeHolder = calc.Percent(float.Parse(placeHolder)).ToString();
            label1.Text = placeHolder;
        }
        else
        {
            switch (calcOperator)
            {
                case "+":
                    placeHolder = calc.PercentageOf(float.Parse(arg1), float.Parse(placeHolder)).ToString();
                    label1.Text = placeHolder;
                    break;
                case "-":
                    placeHolder = calc.PercentageOf(float.Parse(arg1), float.Parse(placeHolder)).ToString();
                    label1.Text = placeHolder;
                    break;
                case "*":
                    placeHolder = calc.Percent(float.Parse(placeHolder)).ToString();
                    label1.Text = placeHolder;
                    break;
                case "/":
                    placeHolder = calc.Percent(float.Parse(placeHolder)).ToString();
                    label1.Text = placeHolder;
                    break;
                default: break;
            }
        }
    }

    private void button18_Click(object sender, EventArgs e) //CE
    {
        OutputUpdater.ClearEntry(this, ref placeHolder);
    }

    private void button19_Click(object sender, EventArgs e) //C
    {
        OutputUpdater.ClearEverything(this, ref placeHolder, ref arg1, ref arg2, ref calcOperator);
    }

    private void button20_Click(object sender, EventArgs e) //'/'
    {
        switch (calcOperator)
        {
            case "":
                calcOperator = "/";
                arg1 = placeHolder;
                placeHolder = "0";
                label1.Text = placeHolder;
                label2.Text = arg1 + " " + calcOperator;

                break;
            case "+":
                calcOperator = "/";
                if (placeHolder == "0")
                {
                    //if placeholder is empty, then the user just wanted to switch the operator. if thats the case, update the variable, update the text on screen.
                    label2.Text = arg1 + " " + calcOperator;
                }
                else //user wanted to take whatever the current result would be, do the operation, then add something else.
                {
                    arg2 = placeHolder;
                    float result = calc.Add(float.Parse(arg1), float.Parse(arg2));
                    arg1 = result.ToString();
                    placeHolder = "0";
                    arg2 = "";
                    label1.Text = placeHolder;
                    label2.Text = arg1 + " " + calcOperator;
                }
                break;
            case "-":
                calcOperator = "/";
                if (placeHolder == "0")
                {
                    label2.Text = arg1 + " " + calcOperator;
                }
                else
                {
                    arg2 = placeHolder;
                    float result = calc.Subtract(float.Parse(arg1), float.Parse(arg2));
                    arg1 = result.ToString();
                    placeHolder = "0";
                    arg2 = "";
                    label1.Text = placeHolder;
                    label2.Text = arg1 + " " + calcOperator;
                }
                break;
            case "*":
                calcOperator = "/";
                if (placeHolder == "0")
                {
                    label2.Text = arg1 + " " + calcOperator;
                }
                else
                {
                    arg2 = placeHolder;
                    float result = calc.Multiply(float.Parse(arg1), float.Parse(arg2));
                    arg1 = result.ToString();
                    placeHolder = "0";
                    arg2 = "";
                    label1.Text = placeHolder;
                    label2.Text = arg1 + " " + calcOperator;
                }
                break;
            case "/":
                calcOperator = "/";
                if (placeHolder == "0")
                {
                    label2.Text = arg1 + " " + calcOperator;
                }
                else
                {
                    arg2 = placeHolder;
                    float result = calc.Divide(float.Parse(arg1), float.Parse(arg2));
                    arg1 = result.ToString();
                    placeHolder = "0";
                    arg2 = "";
                    label1.Text = placeHolder;
                    label2.Text = arg1 + " " + calcOperator;
                }
                break;
            default:
                break;
        }
    }
}
