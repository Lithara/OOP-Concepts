using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scooter sc = new Scooter();
            sc.ScooterType();

            Car c = new Car();
            c.CarType();

            Scooter objScooter = new Scooter();
            objScooter.ScooterType();

            Car objCar = new Car();
            objCar.CarType();

            Console.ReadKey();
        }
    }
}
