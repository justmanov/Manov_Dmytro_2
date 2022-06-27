using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Grain : Coffee
    {
        public override string Name { get { return "Зернове"; } }

        public override int Price { get; set; }
        public override int Weight { get { return 12; } }
        public override string Sort { get; set; }
        public override int Fresh { get; set; }


        public Grain(int fresh, int price, string sort)
        {
            Fresh = fresh;
            Price = price;
            Sort = sort;
        }

    }
}
