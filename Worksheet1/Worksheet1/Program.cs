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

            double a;
            double b;

            Console.Write("Enter the first value : ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Enter the second value : ");
            b = double.Parse(Console.ReadLine());

            objEncapData.setA(a);
            objEncapData.setB(b);

            Console.WriteLine("Summation : " + objEncapData.getSum());
            Console.WriteLine("Substraction : " + objEncapData.getSub());
            Console.WriteLine("Multiplication : " + objEncapData.getMul());
            Console.WriteLine("Division : " + objEncapData.getDiv());

            Console.ReadLine();
        }
    }
}
