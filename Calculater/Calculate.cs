using Calculater.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater
{
    internal class Calculate : ICalc1, ICalc2
    {
        private const float PI = 3.14f;
        private const double EPS = 1e-9;
        public double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Div(double num1, double num2)
        {
            return num1 / num2;
        }

        public double Mul(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Sub(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Pow(double num1, double num2)
        {
            double j = num1;
            if (num2 == 0) return 1;
            else if (num2 == 1) return num1;
            for (int i = 1; i < num2; i++)
            {
                j *= num1;
            }
            return j;
        }
        public double Sqrt(double num1)
        {
            double x = 1;
            while (Abs(x * x - num1) > EPS)
                x = (x + num1 / x) / 2;
            return x;
        }
        public double Sin(double num1)
        {
            return num1 * PI / 180;
        }
        public double Cos(double num1)
        {
            return num1 * PI / 90;
        }
        public double Tan(double num1)
        {
            return num1 * PI / 170;
        }
        public double Abs(double num1)
        {
            if (num1 < 0)
            {
                num1 = (double)-num1;
            }
            return num1;
        }
    }
}
