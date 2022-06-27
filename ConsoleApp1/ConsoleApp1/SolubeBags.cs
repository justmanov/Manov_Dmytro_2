using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SolubeBags : Coffee
    {
        public override string Name { get { return "В пакетиках"; } }
        public override string Sort { get; set; }
        public override int Price { get; set; }
         public override int Weight { get { return 4; } }
        public override int Fresh { get; set; }

        public SolubeBags(int fresh, int price, string sort)
         {
            Fresh = fresh;
            Price = price;
            Sort = sort;
         }
    }
}

