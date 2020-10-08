using NUnit.Framework;
using CalculatorLib;

namespace CalculatorTests
{
    public class Tests
    {
        //[SetUp]
        //public void StaticCalculatorTest()
        //{
        //}

        [TestCase (1, 5, 6)]
        [TestCase(99, -3, 96)]
        public void AdditionTest(double a, double b, double expected)
        {
            double results = CalculatorLib.Operations.Addition(a, b);
            Assert.AreEqual(expected, results);
        }

        [TestCase(5, 3, 2)]
        [TestCase(-3, -2, -1)]
        public void SubtractionTest(double a, double b, double expected)
        {
            double results = CalculatorLib.Operations.Subtraction(a, b);
            Assert.AreEqual(expected, results);
        }

        [TestCase(5, 5, 25)]
        [TestCase(12, -3, -36)]
        public void MultiplicationTest(double a, double b, double expected)
        {
            double results = CalculatorLib.Operations.Multiplication(a, b);
            Assert.AreEqual(expected, results);
        }

        [TestCase(6, 2, 3)]
        [TestCase(9, 3, 3)]
        public void divisionTest(double a, double b, double expected)
        {
            double results = CalculatorLib.Operations.Division(a, b);
            Assert.AreEqual(expected, results);
        }
    }
}