using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Coffee
    {
        public abstract string Name { get; }
        public abstract string Sort { get; set; }
        public abstract int Price { get; set; }
        public abstract int Weight { get; }
        public abstract int Fresh { get; set; }


        public void GetInfo()
        {
            Console.WriteLine("===================");
            Console.WriteLine($"Type: {Name}");
            Console.WriteLine($"Sort: {Sort}");
            Console.WriteLine($"Price: {Price} UAH");
            Console.WriteLine($"Weight:{Weight} kg");
            Console.WriteLine($"Fresh: {Fresh}");
            Console.WriteLine("===================");
        }

    }
}


