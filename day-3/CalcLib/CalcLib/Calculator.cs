using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
{
    public class Calculator
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        public double Diff(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        public double Avg(double num1, double num2)
        {
            double result = (num1 + num2)/2;
            return result;
        }
        public double Multi(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        public double Div(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
    }
}
