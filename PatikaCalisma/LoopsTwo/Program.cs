using System;

namespace LoopsTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While
            // 1'den başlayarak console'dan girilen sayıya kadar (sayi dahil) ortalama hesaplayıp console yazdıran program.
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            // a'dan z'ye kadar olan tüm harleri console'a yazdır.
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }
            Console.WriteLine("\n*****Foreach*****");
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
