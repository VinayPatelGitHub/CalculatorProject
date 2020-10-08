using System;

namespace CalculatorLib
{
    public class Operations
    {        
        public static double Addition(double a, double b)
        {
            double c = a + b;
            return c;
        }

        public static double Subtraction(double a, double b)
        {
            double c = a - b;
            return c;
        }

        public static double Multiplication(double a, double b)
        {
            double c = a * b;
            return c;
        }

        public static double Division(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception("Math Error");//???
            }

            double c = a / b;
            return c;
        }

        public static double Indices(double a, double b)
        {
            // what if b is a fraction or negative...
            double c = 1;
            for (int i = 0; i < b; i++)
            {
                c += c * a;
            }
            
            return c;
        }

    }
}
