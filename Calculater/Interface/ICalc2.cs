using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater.Interface
{
    internal interface ICalc2
    {
        public double Pow(double num1, double num2);
        public double Sqrt(double num1);
        public double Sin(double num1);
        public double Cos(double num1);
        public double Tan(double num1);
        public double Abs(double num1);
    }
}
