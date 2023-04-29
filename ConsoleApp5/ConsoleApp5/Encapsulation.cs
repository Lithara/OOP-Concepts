using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Encapsulation
    {
        private double num1;
        private double num2;

        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public double Sum()
        {
            return num1 + num2;
        }

        public double Sub()
        {
            return num1 - num2;
        }

        public double Mul()
        {
            return num1 * num2;
        }

        public double Div()
        {
            return num1 / num2;
        }
    }
}
