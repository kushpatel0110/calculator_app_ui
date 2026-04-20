using CalculatorAppUI;

namespace CalculatorApp.Utils
{
    public static class OutputUpdater
    {
        public static void UpdateCalcText(Form1 form, ref string placeHolder, string digit)
        {
            if (placeHolder == "0")
            {
                placeHolder = digit;
            }
            else if (form.label2.Text.Contains("=")) //previous result has not been cleared as yet
            {
                form.label2.Text = "";
                placeHolder = digit;
                form.label1.Text = placeHolder;
            }
            else
            {
                placeHolder = placeHolder + digit;
            }
            form.label1.Text = placeHolder;
        }
        public static void ClearEverything(Form1 form, ref string placeHolder, ref string arg1, ref string arg2, ref string calcOperator)
        {
            placeHolder = "0";
            form.label1.Text = "0";
            form.label2.Text = "";
            arg1 = "";
            arg2 = "";
            calcOperator = "";
        }
        public static void ClearEntry(Form1 form, ref string placeHolder)
        {
            placeHolder = "0";
            form.label1.Text = "0";
        }
    }
}
