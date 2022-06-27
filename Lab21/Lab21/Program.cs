using System;
using System.Threading.Tasks;


namespace Lab21
{
    class Program
    {

        
        private static void writeNewLine()
        {
            Console.WriteLine();
        }
        private static void write(string v)
        {
            Console.WriteLine(v);
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int d = random.Next(10);
            Sitter sitter = new Sitter();
            sitter.Fly();
            writeNewLine();
            write(sitter.Song);
            sitter.Nest(d);
            sitter.Sit(d);
            Cuckoo cuckoo = new Cuckoo();
            write(cuckoo.Song);
            cuckoo.Nest(d);
        }
    }
}