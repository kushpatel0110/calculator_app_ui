namespace CalculatorAppUI.Services
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b; 
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            return a / b;
        }
        public double Negate(double a)
        {
            return a * -1d;
        }
        public double Percent(double a)
        {
            return a / 100d;
        }
        public double PercentageOf(double a, double b)
        {
            return ((b / 100) * a);
        }
    }
    
}