using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet1
{
    internal class EncapData
    {
        private double radius;
        private double pi = 3.14;

        public void setRadius(double radiusFromUser)
        {
            radius = radiusFromUser;
        }

        public double getArea()
        {
            return pi * radius * radius;
        }

        public double getCircumference()
        {
            return 2 * pi * radius;
        }
    }
}
