using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator : ICalculator
    {
        double A { get; set; }
        double B { get; set; }

        public double Sum(double a, double b)
        {
            return (a + b);
        }

        public double MSum(double a, double b)
        {
            return (a - b);
        }

        public double Mult(double a, double b)
        {
            return (a * b);
        }

        public double Fract(double a, double b)
        {
            return (a / b);
        }
    }
}
