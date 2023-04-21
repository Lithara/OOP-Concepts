using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet1
{
    public class Program
    {
        static void Main(string[] args)
        {
            EncapData objEncapData = new EncapData();

            float radius;

            Console.Write("Enter the radius value : ");
            radius = float.Parse(Console.ReadLine());

            objEncapData.setRadius(radius);

            Console.WriteLine("Area : " + objEncapData.getArea());
            Console.WriteLine("Circumference : " + objEncapData.getCircumference());

            Console.ReadLine();
        }
    }
}
