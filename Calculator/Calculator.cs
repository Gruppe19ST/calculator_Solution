using System;

namespace Calculator
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

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Divide(double dividend, double devisor)
        {
            if (devisor == 0)
            {
                throw new System.DivideByZeroException();
            }

            else
            {
                return dividend / devisor;
            }
            
        }
    }
}
