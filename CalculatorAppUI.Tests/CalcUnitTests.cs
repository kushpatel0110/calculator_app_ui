using CalculatorAppUI.Services;
using System.Transactions;

namespace CalculatorAppUI.Tests

{
    public class CalcUnitTests
    {

        private readonly Calculator _calc;

        public CalcUnitTests()
        {
            _calc = new Calculator();
        }

        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, 1, 0)]
        [InlineData(1.11, 2.22, 3.33)]
        public void Add_Inputs_ReturnsCorrectResult(double a, double b, double expected)
        {
            double result = _calc.Add(a, b);
            Assert.Equal(expected, result, precision: 10);
        }

        [Theory]
        [InlineData(5, 5, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, 1, -2)]
        [InlineData(1.1, 2.2, -1.1)]
        public void Subtract_Inputs_ReturnsCorrectResult(double a, double b, double expected)
        {
            double result = _calc.Subtract(a, b);
            Assert.Equal(expected, result, precision: 10);
        }
        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, 1, -1)]
        [InlineData(10.2, 3.2, 32.64)]
        public void Multiply_Inputs_ReturnsCorrectResult(double a, double b, double expected)
        {
            double result = _calc.Multiply(a, b);
            Assert.Equal(expected, result, precision: 10);
        }
        [Theory]
        [InlineData(5, 5, 1)]
        [InlineData(1, 1, 1)]
        [InlineData(-1, 1, -1)]
        [InlineData(1.1, 2.2, 0.5)]
        [InlineData(99, 0, double.PositiveInfinity)]
        public void Divide_Inputs_ReturnsCorrectResult(double a, double b, double expected)
        {
            double result = _calc.Divide(a, b);
            Assert.Equal(expected, result, precision: 10);
        }
        [Theory]
        [InlineData(5, -5)]
        [InlineData(0, 0)]
        [InlineData(-1, 1)]
        [InlineData(1.1, -1.1)]
        public void Negate_Input_ReturnsCorrectResult(double a, double expected)
        {
            double result = _calc.Negate(a);
            Assert.Equal(expected, result, precision: 10);
        }
        [Theory]
        [InlineData(5, 0.05)]
        [InlineData(0, 0)]
        [InlineData(-1, -0.01)]
        [InlineData(0.11, 0.0011)]
        public void Percent_Input_ReturnsCorrectResult(double a, double expected)
        {
            double result = _calc.Percent(a);
            Assert.Equal(expected, result, precision: 10);
        }
        [Theory]
        [InlineData(100, 90, 90)]
        [InlineData(0, 0, 0)]
        [InlineData(5, 50, 2.5)]
        [InlineData(-10, 70, -7)]
        public void PercentageOf_Inputs_ReturnsCorrectResult(double a, double b, double expected)
        {
            double result = _calc.PercentageOf(a, b);
            Assert.Equal(expected, result, precision: 10);
        }

        [Theory]
        [InlineData(0, double.PositiveInfinity)]
        [InlineData(5, 0.2)]
        [InlineData(-0.125, -8)]
        public void Reciprocal_Input_ReturnsCorrectResult(double a, double expected)
        {
            double result = _calc.Reciprocal(a);
            Assert.Equal(expected, result, precision: 10);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(2.2, 4.84)]
        [InlineData(-3, 9)]
        public void Square_Input_ReturnsCorrectResult(double a, double expected)
        {
            double result = _calc.Square(a);
            Assert.Equal(expected, result, precision: 10);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(16, 4)]
        [InlineData(3.33, 1.82482875908)]
        [InlineData(-5, double.NaN)]
        public void SquareRoot_Input_ReturnsCorrectResult(double a, double expected)
        {
            double result = _calc.SquareRoot(a);
            Assert.Equal(expected, result, precision: 10);
        }

        [Theory]
        [InlineData(0, 0, 1)]
        [InlineData(3, 5, 243)]
        [InlineData(-3, -2, 0.11111111111111111111)]
        [InlineData(0, -1, double.PositiveInfinity)]
        public void Power_Inputs_ReturnsCorrectResult(double a, double b, double expected)
        {
            double result = _calc.Power(a, b);
            Assert.Equal(expected, result, precision: 10);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(3, 5, 1.24573093961551)]
        public void NthRoot_Input_ReturnsCorrectResult(double a, double b, double expected)
        {
            double result = _calc.NthRoot(a, b);
            Assert.Equal(expected, result, precision: 10);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(5, 100000)]
        [InlineData(-2.2, 0.0063095734448019)]
        public void TenPowerX_Input_ReturnsCorrectResult(double a, double expected)
        {
            double result = _calc.TenPowerX(a);
            Assert.Equal(expected, result, precision: 10);
        }

        [Theory]
        [InlineData(0, double.NegativeInfinity)]
        [InlineData(5, 0.69897000433601)]
        [InlineData(-2.2, double.NaN)]
        [InlineData(32.65, 1.513883185611092)]
        public void LogBaseTen_Input_ReturnsCorrectResult(double a, double expected)
        {
            double result = _calc.LogBaseTen(a);
            Assert.Equal(expected, result, precision: 10);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(5, 148.413159102576)]
        [InlineData(-2.2, 0.11080315836233388)]
        public void EulerPowerX_Input_ReturnsCorrectResult(double a, double expected)
        {
            double result = _calc.EulerPowerX(a);
            Assert.Equal(expected, result, precision: 10);
        }

        [Theory]
        [InlineData(0, double.NegativeInfinity)]
        [InlineData(1, 0)]
        [InlineData(5, 1.6094379124341003)]
        [InlineData(-2.2, double.NaN)]
        public void NaturalLog_Input_ReturnsCorrectResult(double a, double expected)
        {
            double result = _calc.NaturalLog(a);
            Assert.Equal(expected, result, precision: 10);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(2, 0, 2)]
        [InlineData(5, 6.2, 7924465.96230556742601)]
        [InlineData(5, -2, 0.05)]
        public void Exponent_Inputs_ReturnsCorrectResult(double a, double b, double expected)
        {
            double result = _calc.Exponent(a, b);
            Assert.Equal(expected, result, precision: 5); //lowered precision due to rounding errors
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(4, 24)]
        public void Factorial_Input_ReturnsCorrectResult(double a, double expected)
        {
            double result = _calc.Factorial(a);
            Assert.Equal(expected, result, precision: 10); 
        }

        [Theory]
        [InlineData(0.7, 0.9086387328532904)]
        [InlineData(6.3, 1271.4236336639)]
        [InlineData(-2.2, 4.8509571405220973)]
        public void FactorialGamma_Input_ReturnsCorrectResult(double a, double expected)
        {
            double result = _calc.FactorialGamma(a);
            Assert.Equal(expected, result, precision: 3); //significantly lowered precision due to method difference
        }

        [Theory]
        [InlineData(0, 0, double.NaN)]
        [InlineData(5, 6, 5)]
        [InlineData(-2.2, 1, -0.2)] //windows calculator shows 0.8; not fixing yet since I don't understand it yet
        public void Modulo_Inputs_ReturnsCorrectResult(double a, double b, double expected)
        {
            double result = _calc.Modulo(a, b);
            Assert.Equal(expected, result, precision: 10);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0.01745240643728351)]
        [InlineData(90, 1)]
        public void Sine_Input_ReturnsCorrectResult(double a, double expected)
        {
            double result = _calc.Sine(a);
            Assert.Equal(expected, result, precision: 10);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 0.99984769515639123915)]
        [InlineData(90, 0)]
        public void Cosine_Input_ReturnsCorrectResult(double a, double expected)
        {
            double result = _calc.Cosine(a);
            Assert.Equal(expected, result, precision: 10);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0.01745506492821758576)]
        [InlineData(0.5, 0.0087268677907587)]
        public void Tangent_Input_ReturnsCorrectResult(double a, double expected)
        {
            double result = _calc.Tangent(a);
            Assert.Equal(expected, result, precision: 10);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0.5, 30)]
        [InlineData(1, 90)]
        public void ArcSine_Input_ReturnsCorrectResult(double a, double expected)
        {
            double result = _calc.ArcSine(a);
            Assert.Equal(expected, result, precision: 10);
        }

        [Theory]
        [InlineData(0, 90)]
        [InlineData(0.5, 60)]
        [InlineData(1, 0)]
        public void ArcCosine_Input_ReturnsCorrectResult(double a, double expected)
        {
            double result = _calc.ArcCosine(a);
            Assert.Equal(expected, result, precision: 10);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0.5, 26.5650511770779893)]
        [InlineData(1, 45)]
        public void ArcTangent_Input_ReturnsCorrectResult(double a, double expected)
        {
            double result = _calc.ArcTangent(a);
            Assert.Equal(expected, result, precision: 10);
        }


    }
}
