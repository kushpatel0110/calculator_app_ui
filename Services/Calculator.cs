using System.Runtime.CompilerServices;

namespace CalculatorApp.Services
{
    public class Calculator
    {
        public float Add(float a, float b)
        {
            return a + b;
        }
        public float Subtract(float a, float b)
        {
            return a - b; 
        }
        public float Multiply(float a, float b)
        {
            return a * b;
        }
        public float Divide(float a, float b)
        {
            return a / b;
        }
        public float Negate(float a)
        {
            return a * -1f;
        }
        public float Percent(float a)
        {
            return a / 100f;
        }
        public float PercentageOf(float a, float b)
        {
            return ((b / 100) * a);
        }
    }
    
}