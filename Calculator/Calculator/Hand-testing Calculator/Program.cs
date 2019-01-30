using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hand_testing_Calculator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var calc = new Calculator();

            const double x = 12.85;
            const double y = -2.97;
            Console.WriteLine(calc.Add(x, y));
            Console.WriteLine(calc.Subtract(x, y));
            Console.WriteLine(calc.Multiply(x, y));
            Console.WriteLine(calc.Power(x, y));

            const double x0 = -12.85;
            const double y0 = -2.97;
            Console.WriteLine(calc.Add(x0, y0));
            Console.WriteLine(calc.Subtract(x0, y0));
            Console.WriteLine(calc.Multiply(x0, y0));
            Console.WriteLine(calc.Power(x0, y0));

            const double x1 = 12.85;
            const double y1 = 2.97;
            Console.WriteLine(calc.Add(x1, y1));
            Console.WriteLine(calc.Subtract(x1, y1));
            Console.WriteLine(calc.Multiply(x1,y1));
            Console.WriteLine(calc.Power(x1, y1));

            const double x2 = -12.85;
            const double y2 = 2.97;
            Console.WriteLine(calc.Add(x2, y2));
            Console.WriteLine(calc.Subtract(x2, y2));
            Console.WriteLine(calc.Multiply(x2, y2));
            Console.WriteLine(calc.Power(x2, y2));
        }

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

            public double Power(double x, double exp)
            {
                return Math.Pow(x, exp);
            }
        }

    
    }
}
