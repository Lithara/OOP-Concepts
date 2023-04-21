using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet1
{
    internal class EncapData
    {
        private float radius;
        private float pi = 22/7;

        public void setRadius(float radiusFromUser)
        {
            radius = radiusFromUser;
        }

        public float getArea()
        {
            return pi * radius * radius;
        }

        public float getCircumference()
        {
            return 2 * pi * radius;
        }
    }
}
