using System;
namespace Uppgift5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            int tal = int.Parse(Console.ReadLine());
            int[] allaTal = { tal, 24, 2 };
            Console.WriteLine(allaTal[0]+" " + allaTal[1]+" " + allaTal[2]);
            Console.ReadKey();
        }
    }
}