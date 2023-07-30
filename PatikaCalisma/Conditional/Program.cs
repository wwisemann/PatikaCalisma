using System;

namespace Conditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time <= 18) 
            {
                Console.WriteLine("Gündüz vakti.");
            }else if (time >=4 && time <= 5)
            {
                Console.WriteLine("Namaz vakti");
            }
            else
            {
                Console.WriteLine("Gece vakti.");
            }
        }
    }
}
