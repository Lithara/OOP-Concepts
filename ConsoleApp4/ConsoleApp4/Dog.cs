using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Dog : Animal
    {
        public void DogType()
        {
            AnimalType();
            Console.Write("I have four legs");
        }
    }
}
