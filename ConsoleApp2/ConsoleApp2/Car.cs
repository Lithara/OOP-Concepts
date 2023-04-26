using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Car : Tyre
    {
        public void CarType()
        {
            Console.WriteLine("Car type : Ferrari");
            TyreType();
            Console.WriteLine(NoOfTyres);
        }
    }
}
