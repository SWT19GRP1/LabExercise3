using System;

namespace Calculator
{
    public class Calculator
    {
        public var _accumulator;

        public double Add(double a, double b)
        {
            _accumulator = a + b;
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            _accumulator = a - b;
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            _accumulator = a * b;
            return a * b;
        }

        public double Power(double a, double b)
        {
            _accumulater = Math.Pow(a, b);
            return Math.Pow(a, b);
        }

        public void clear()
        {
            _accumulator = 0;
        }


    }
}
