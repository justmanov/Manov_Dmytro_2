using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21
{
     abstract class Bird
    {
        public string  v { get; set; }
        public string Song { get => Sing(); }
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
        protected abstract string Sing();
        
    }
}
