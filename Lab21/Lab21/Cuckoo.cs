using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21
{
    class Cuckoo : Bird
    {
        string v = "CUCKOO-CUCKOO";
        protected override string Sing()
        {
            return v;
        }
        public void Nest(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.WriteLine($"{j} egg is Nested");
                Console.WriteLine();

            }
        }

    }
}
