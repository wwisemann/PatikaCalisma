using System;

namespace DateDimeAndMathClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Hour);

            Console.WriteLine(DateTime.Now.DayOfWeek); //içinde bulundugumuz haftanın günü
            Console.WriteLine(DateTime.Now.DayOfYear); //içine bulundugumuz yılın kaçıncı günüyse o

            Console.WriteLine(DateTime.Now.ToLongDateString()); //3 Ağustos 2023 Perşembe
            Console.WriteLine(DateTime.Now.ToShortDateString()); //3.08.2023
            Console.WriteLine(DateTime.Now.ToShortTimeString()); //18:05
            Console.WriteLine(DateTime.Now.ToLongTimeString());  //18:05:42

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddYears(3));

            //Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //3
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Per         --- Günler için
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Perşembe  

            Console.WriteLine(DateTime.Now.ToString("MM")); //8
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Ağu         --- Aylar için
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //Ağustos  

            Console.WriteLine(DateTime.Now.ToString("yy")); //23
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2023         --- Yıllar için
           

            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));
            Console.WriteLine(Math.Sin(10));

            Console.WriteLine(Math.Ceiling(22.3)); //23 - Her zaman üste yuvarlar.
            Console.WriteLine(Math.Round(22.3)); //22 - Her zaman yakın yere yuvarlar.
            Console.WriteLine(Math.Floor(22.3)); //22 - Her zaman aşağı yuvarlar.

            Console.WriteLine(Math.Min(2,6));
            Console.WriteLine(Math.Max(2,6));

            Console.WriteLine(Math.Pow(10,2)); //Üs alma
            Console.WriteLine(Math.Sqrt(9)); //Kare kök alma
            Console.WriteLine(Math.Log(9)); //Log alma e tabanından
            Console.WriteLine(Math.Log10(10)); //Log alma 10 tabanından
        }
    }
}
