using CalculatorAppUI.Services;

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
    }
}
