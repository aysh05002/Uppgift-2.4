using System;

namespace Uppgift_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in tre olika löner för tre olika anstälda på ett företag \nsen skrivs det ut medellönen \n");
            Console.Write("1:a = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("2:a = ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("3:e = ");
            int z = Convert.ToInt32(Console.ReadLine());
            int medel = (x + y + z) / 3;
            Console.WriteLine("Medellönen är " + medel + " kr i månaden");
        }
    }
}