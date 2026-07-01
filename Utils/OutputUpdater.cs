using CalculatorAppUI;

namespace CalculatorAppUI.Utils
{
    public static class OutputUpdater
    {
        public static void UpdateCalcText(CalcUI form, ref string placeHolder, string digit)
        {
            if (placeHolder == "0")
            {
                if (form.label2.Text.Contains("="))
                {
                    form.label2.Text = "";

                }
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
        public static void ClearEverything(CalcUI form, ref string placeHolder, ref string arg1, ref string arg2, ref string calcOperator, ref bool argumentEntered)
        {
            placeHolder = "0";
            form.label1.Text = "0";
            form.label2.Text = "";
            arg1 = "";
            arg2 = "";
            calcOperator = "";
            argumentEntered = false;
        }
        public static void ClearEntry(CalcUI form, ref string placeHolder, ref bool argumentEntered)
        {
            placeHolder = "0";
            form.label1.Text = "0";
            argumentEntered = false;
        }

        public static void UpdateLayer(CalcUI form, ref bool layerTwo)
        {
            if (layerTwo == false)
            {
                //we want to enable layer 2
                form.sineButton.Text = "sin⁻¹";
                form.cosineButton.Text = "cos⁻¹";
                form.tangentButton.Text = "tan⁻¹";
                layerTwo = true;
            }
            else
            {
                form.sineButton.Text = "sin";
                form.cosineButton.Text = "cos";
                form.tangentButton.Text = "tan";
                layerTwo = false;
            }
        }
    }
}
