using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooklistRazor.Models
{
    public class Calculator
    {
        public static double Add(double first,double second)
        {
            return first + second;
        }

        public static double Substract(double first, double second)
        {
            return first - second;
        }

        public static double Multiply(double first, double second)
        {
            return first * second;
        }

        public static double Divide(double first, double second)
        {
            return first / second;
        }
    }
}
