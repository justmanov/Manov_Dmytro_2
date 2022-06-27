using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21
{
     class Sitter : Chicken
    {
        public void Sit(int i)
        {
            Console.WriteLine($"{i} EGGS IS SITTING");
        }
        string v = "kokokokkokoko.";
        protected override string Sing()
        {
            return v;
        }
    }
}
