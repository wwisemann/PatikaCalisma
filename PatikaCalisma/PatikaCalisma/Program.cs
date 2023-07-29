using System;

namespace PatikaCalisma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi girin:");
            string name = Console.ReadLine();
            Console.WriteLine("Soy isminizi girin:");
            string lastname = Console.ReadLine();

            Console.WriteLine("Adınız: " +  name + " " + lastname); 
        }
    }
}
