using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater
{
    internal class UICalculate
    {
        Calculate _calculate = new();
        public void Nums(double num1, double num2, string symbol)
        {
            
            switch(symbol)
            {
                case "+":
                    Console.WriteLine(_calculate.Sum(num1, num2));
                    break;
                case "-":
                    Console.WriteLine(_calculate.Sub(num1, num2));
                    break;
                case "*":
                    Console.WriteLine(_calculate.Mul(num1, num2));
                    break;
                case "/":
                    Console.WriteLine(_calculate.Div(num1, num2));
                    break;
                case "pow":
                    Console.WriteLine(_calculate.Pow(num1, num2));
                    break;
            }
        }
        public void Nums(double num1,  string symbol)
        {
            switch(symbol)
            {
                case "abs":
                    Console.WriteLine(_calculate.Abs(num1));
                    break;
                case "sqrt":
                    Console.WriteLine(_calculate.Sqrt(num1));
                    break;
                case "sin":
                    Console.WriteLine(_calculate.Sin(num1));
                    break;
                case "cos":
                    Console.WriteLine(_calculate.Cos(num1));
                    break;
                case "tan":
                    Console.WriteLine(_calculate.Tan(num1));
                    break;
            }

        }
    }
}
