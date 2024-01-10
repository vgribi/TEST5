using NUnit.Framework;

namespace SimpleCalculator.UnitTests
{
    [TestFixture]
    public class CalculatorFormTests
    {
        [Test]
        public void EvaluateExpression_Addition_ReturnsCorrectResult()
        {
            // Arrange
            CalculatorForm calculatorForm = new CalculatorForm();
            string expression = "5+3";

            // Act
            double result = calculatorForm.EvaluateExpression(expression);

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void EvaluateExpression_DivisionByZero_ThrowsArgumentException()
        {
            // Arrange
            CalculatorForm calculatorForm = new CalculatorForm();
            string expression = "5/0";

            // Act and Assert
            Assert.Throws<ArgumentException>(() => calculatorForm.EvaluateExpression(expression));
        }

        // Другие тесты для остальных операций и сценариев
    }
}