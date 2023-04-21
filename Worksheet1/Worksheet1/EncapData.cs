using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet1
{
    internal class EncapData
    {
        private double a;
        private double b;

        public void setA(double aFromUser)
        {
            a = aFromUser;
        }

        public void setB(double bFromUser)
        {
            b = bFromUser;
        }

        public double getSum()
        {
            return a + b;
        }

        public double getSub()
        {
            return a - b;
        }

        public double getMul()
        {
            return a * b;
        }

        public double getDiv()
        {
            return a / b;
        }
    }
}
