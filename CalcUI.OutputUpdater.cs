using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorAppUI
{
    public partial class CalcUI
    {
        private void UpdateCalcText(string digit)
        {
            if (placeHolder == "0")
            {
                if (label2.Text.Contains("="))
                {
                    label2.Text = "";

                }
                placeHolder = digit;
            }
            else if (label2.Text.Contains("=")) //previous result has not been cleared as yet
            {
                label2.Text = "";
                placeHolder = digit;
                label1.Text = placeHolder;
            }
            else
            {
                placeHolder = placeHolder + digit;
            }
            label1.Text = placeHolder;
        }
        private void ClearEverything()
        {
            placeHolder = "0";
            label1.Text = "0";
            label2.Text = "";
            arg1 = "";
            arg2 = "";
            calcOperator = "";
            argumentEntered = false;
        }
        private void ClearEntry()
        {
            placeHolder = "0";
            label1.Text = "0";
            argumentEntered = false;
        }

        private void UpdateLayer()
        {
            if (layerTwo == false)
            {
                //we want to enable layer 2
                layerTwoButton.Text = "1st";
                sineButton.Text = "sin⁻¹";
                cosineButton.Text = "cos⁻¹";
                tangentButton.Text = "tan⁻¹";
                layerTwo = true;
            }
            else
            {
                layerTwoButton.Text = "2nd";
                sineButton.Text = "sin";
                cosineButton.Text = "cos";
                tangentButton.Text = "tan";
                layerTwo = false;
            }
        }
    }
}
