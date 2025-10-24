using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater.Interface
{
    internal interface ICalc1
    {
        public double Sum(double num1, double num2);
        public double Div(double num1, double num2);
        public double Mul(double num1, double num2);
        public double Sub(double num1, double num2);
    }
}
