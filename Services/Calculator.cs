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
            return -a;
        }
        public double Percent(double a)
        {
            return a / 100d;
        }
        public double PercentageOf(double a, double b)
        {
            return ((b / 100d) * a);
        }
        public double Reciprocal(double a)
        {
            return 1 / a;
        }
        public double Square(double a)
        {
            return Math.Pow(a, 2d);
        }
        public double SquareRoot(double a)
        {
            return Math.Sqrt(a);
        }
        public double Power(double a, double b)
        {
            //there are some issues with this regarding negative/decimal/complex numbers
            //not fixing this in this iteration.
            return Math.Pow(a, b);
        }
        public double NthRoot(double a, double b)
        {
            //same here, for the same reasons.
            return Math.Pow(a, 1.0 / b);
        }
        public double TenPowerX(double a)
        {
            return Math.Pow(10, a);
        }
        public double LogBaseTen(double a)
        {
            return Math.Log10(a);
        }
        public double EulerPowerX(double a)
        {
            return Math.Pow(Math.E, a);
        }
        public double NaturalLog(double a)
        {
            return Math.Log(a);
        }
        public double Exponent(double a, double b)
        {
            //this application allows decimals for b, windows calc does not.
            return a * Math.Pow(10, b);
        }
        public double Pi()
        {
            return Math.PI;
        }
        public double Euler()
        {
            return Math.E;
        }
        public double Factorial(double a)
        {
            if (a <= 1)
            {
                return 1;
            }
            return a * Factorial(a - 1);
        }
        private double LanczosSeriesVariant(double z)
        {
            //for this set of constants/precision, we are using n=6, g = 5.5
            //this is not strictly the lanczos approximation, but an algebraic variant
            //of Godfrey's partial fraction form of the equation,
            //which was popularized globally by the definitive
            //scientific textbook
            //Numerical Recipes: The Art of Scientific Computing
            //...Windows uses a library called RatPak to do it instead.
            //i thought this would be more fun.

            List<double> c = [
                1.000001897273944,
                76.18008222264214,
                -86.50509203705486,
                24.01289858192269,
                -1.229602849028582
            ];

            double lanczosSum = c[0];

            for (int k = 1; k < c.Count; k++)
            {
                lanczosSum = lanczosSum + (c[k] / (z + k));
            }

            return lanczosSum;
        }

        private double LanczosApproxFormula(double z)
        {
            
            double g = 5.5; //precision

            return ((Math.Sqrt(2 * Math.PI)) * 
                    (Math.Pow(z + g, (z + 0.5))) * 
                    (Math.Exp(Negate(z + g))) * 
                    LanczosSeriesVariant(z)) / z;
        }

        public double FactorialGamma(double z)
        {
            return LanczosApproxFormula(z + 1.0);
        }

        public double Modulo(double a, double b)
        {
            return a % b;
        }

        //for these trigonomery functions, the inputs are expected
        //to be in degrees, not radians.

        public double Sine(double a)
        {
            return Math.Round(Math.Sin(a * (Math.PI / 180.0)), 10);
        }
        public double Cosine(double a)
        {
            return Math.Round(Math.Cos(a * (Math.PI / 180.0)), 10);
        }
        public double Tangent(double a)
        {
            return Math.Round(Math.Tan(a * (Math.PI / 180.0)), 10);
        }
        public double ArcSine(double a)
        {
            return Math.Round(Math.Asin(a) * (180 / Math.PI), 10);
        }
        public double ArcCosine(double a)
        {
            return Math.Round(Math.Acos(a) * (180 / Math.PI), 10);
        }
        public double ArcTangent(double a)
        {
            return Math.Round(Math.Atan(a) * (180 / Math.PI), 10);
        }

    }
}