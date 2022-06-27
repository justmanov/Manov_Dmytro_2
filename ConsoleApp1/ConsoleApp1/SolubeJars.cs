using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SolubeJars : Coffee
    {
        public override string Name { get { return "В банці"; } }
        public override string Sort { get; set; }
        public override int Price { get; set; }
        public override int Weight { get { return 15; } }
        public override int Fresh { get; set; }

        public SolubeJars( int fresh, int price, string sort)
        {
            Fresh = fresh;
            Price = price;
            Sort = sort;
        }

    }
}
