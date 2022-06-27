using System;

namespace ConsoleApp1
{
    class Van
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================== Наповніть фургон ===================");
            Grain grain1 = new Grain(1,20, "Arabica");
            Console.WriteLine("Choose first coffee:");
            Console.WriteLine();
            Console.WriteLine("Number 1:");
            Console.WriteLine();
            grain1.GetInfo();
            Console.WriteLine();
            Grain grain2 = new Grain( 3,30, "Coffea canephora");
            Console.WriteLine("Number 2:");
            Console.WriteLine();
            grain2.GetInfo();
            Console.WriteLine();

            Console.WriteLine("Enter 1 or 2 to choose coffee");
            Console.WriteLine();

            Coffee[] van = new Coffee[3];


            int status1 = 1;
            while (status1 != 0)
            {
                char choose1 = Console.ReadKey(true).KeyChar;
                switch (choose1)
                {
                    case '1': van[0] = grain1; Console.WriteLine("You have choosen first coffee with Number 1"); status1 = 0; break;
                    case '2': van[0] = grain2; Console.WriteLine("You have choosen first coffee with Number 2"); status1 = 0; break;
                    default: Console.WriteLine("You haven`t chosen correctly, try again"); break;
                }
            };

            Console.WriteLine();

            Console.WriteLine("Choose second coffee:");
            Console.WriteLine();
            Console.WriteLine("Number 1:");
            Ground ground1 = new Ground(3,23, "Arabica");
            Console.WriteLine();
            ground1.GetInfo();
            Console.WriteLine();
            Console.WriteLine("Number 2:");
            Ground ground2 = new Ground(4,43, "Excelsa");
            Console.WriteLine();
            ground2.GetInfo();
            Console.WriteLine();

            Console.WriteLine("Enter 1 or 2 to choose second coffee");



            int status2 = 1;
            while (status2 != 0)
            {
                char choose2 = Console.ReadKey(true).KeyChar;
                switch (choose2)
                {
                    case '1': van[1] = ground1; Console.WriteLine("You have choosen second coffee with Number 1"); status2 = 0; break;
                    case '2': van[1] = ground2; Console.WriteLine("You have choosen second coffee with Number 2"); status2 = 0; break;
                    default: Console.WriteLine("You haven`t chosen correctly, try again"); break;
                }
            }

            Console.WriteLine();


            Console.WriteLine("Choose third coffee:");
            Console.WriteLine();
            Console.WriteLine("Number 1:");
            SolubeBags solubebags1 = new SolubeBags(5,32, "Coffea liberica");
            Console.WriteLine();
            solubebags1.GetInfo();
            Console.WriteLine();
            Console.WriteLine("Number 2:");
            SolubeBags solubebags2 = new SolubeBags(1,43, "Excelsa");
            Console.WriteLine();
            solubebags2.GetInfo();
            Console.WriteLine();

            Console.WriteLine("Enter 1 or 2 to choose third coffee");



            int status3 = 1;
            while (status3 != 0)
            {
                char choose3 = Console.ReadKey(true).KeyChar;
                switch (choose3)
                {
                    case '1': van[2] = solubebags1; Console.WriteLine("You have choosen third coffee with Number 1"); status3 = 0; break;
                    case '2': van[2] = solubebags2; Console.WriteLine("You have choosen third coffee with Number 2"); status3 = 0; break;
                    default: Console.WriteLine("You haven`t chosen correctly, try again"); break;
                }
            }
            Console.WriteLine();


            Console.WriteLine("Choose fourth coffee:");
            Console.WriteLine();
            Console.WriteLine("Number 1:");
            SolubeJars solubejars1 = new SolubeJars(5, 24, "Coffea canephora");
            Console.WriteLine();
            solubebags1.GetInfo();
            Console.WriteLine();
            Console.WriteLine("Number 2:");
            SolubeBags solubejars2 = new SolubeBags(1, 13, "Coffea liberica");
            Console.WriteLine();
            solubebags2.GetInfo();
            Console.WriteLine();

            Console.WriteLine("Enter 1 or 2 to choose fourth coffee");



            int status4 = 1;
            while (status4 != 0)
            {
                char choose4 = Console.ReadKey(true).KeyChar;
                switch (choose4)
                {
                    case '1': van[2] = solubebags1; Console.WriteLine("You have choosen fourth coffee with Number 1"); status4 = 0; break;
                    case '2': van[2] = solubebags2; Console.WriteLine("You have choosen fourth coffee with Number 2"); status4 = 0; break;
                    default: Console.WriteLine("You haven`t chosen correctly, try again"); break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Price of your coffe:");

            int price = 0;
            for (int i = 0; i < van.Length; i++)
            {
                price += van[i].Price;
            }
            Console.WriteLine($"{price} UAH");
            Console.WriteLine("========================================================");

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Weight of van:");

            int weight = 0;
            for (int i = 0; i < van.Length; i++)
            {
                weight += van[i].Weight;
            }
            Console.WriteLine($"{weight} kg");
            Console.WriteLine("========================================================");
            Console.WriteLine();
            Console.WriteLine("Sorting coffee with a level of fresh");
            Console.WriteLine();

            Console.WriteLine("========================================================");
            Console.WriteLine("Cheap: ");
            for (int i = 0; i < van.Length; i++)
            {

                if (van[i].Price / van[i].Weight < 1)
                {
                    Console.WriteLine(van[i].Name);
                    Console.WriteLine(van[i].Sort);
                }
            }
            
            Console.WriteLine("========================================================");

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Medium: ");

            for (int i = 0; i < van.Length; i++)
            {

                if (van[i].Price / van[i].Weight >= 1 && van[i].Price / van[i].Weight <= 2) 
                {
                    Console.WriteLine(van[i].Name);
                    Console.WriteLine(van[i].Sort);
                }
            }
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Expensive: ");

            for (int i = 0; i < van.Length; i++)
            {

                if (van[i].Price / van[i].Weight > 2)
                {
                    Console.WriteLine(van[i].Name);
                    Console.WriteLine(van[i].Sort);
                }
            }
            Console.WriteLine("========================================================");
            Console.WriteLine();
            Console.WriteLine("Set range of fresh to show coffee:");
            Console.Write("First number: "); int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: "); int numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("========================================================");

            for (int i = 0; i < van.Length; i++)
            {
                if (van[i].Fresh >= numb1 && van[i].Fresh <= numb2)
                {
                    Console.WriteLine(van[i].Name);
                    Console.WriteLine(van[i].Sort);
                }
            }
            Console.WriteLine("========================================================");
        }
    }
}
