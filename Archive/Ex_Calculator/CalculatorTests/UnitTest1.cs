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
            double results = CalculatorLib.Class1.Addition(a, b);
            Assert.AreEqual(expected, results);
        }

        [TestCase(5, 3, 2)]
        [TestCase(-3, -2, -1)]
        public void SubtractionTest(double a, double b, double expected)
        {
            double results = CalculatorLib.Class1.Subtraction(a, b);
            Assert.AreEqual(expected, results);
        }

        [TestCase(5, 5, 25)]
        [TestCase(12, -3, -36)]
        public void MultiplicationTest(double a, double b, double expected)
        {
            double results = CalculatorLib.Class1.Multiplication(a, b);
            Assert.AreEqual(expected, results);
        }

        [TestCase(6, 2, 3)]
        [TestCase(9, 3, 3)]
        public void divisionTest(double a, double b, double expected)
        {
            double results = CalculatorLib.Class1.Division(a, b);
            Assert.AreEqual(expected, results);
        }
    }
}