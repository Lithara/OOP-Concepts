using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encapsulation objEncapsulation = new Encapsulation();

            Console.Write("Enter the first value : ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the second value : ");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Summation : " + objEncapsulation.Sum());
            Console.WriteLine("Subtraction : " + objEncapsulation.Sub());
            Console.WriteLine("Multiplication : " + objEncapsulation.Mul());
            Console.WriteLine("Division : " + objEncapsulation.Div());

            Console.ReadKey();
        }
    }
}
