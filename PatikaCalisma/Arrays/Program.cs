using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] dizi = new int[diziUzunlugu];
            int toplam = 0;

            for (int i = 0; i< diziUzunlugu; i++)
            {
                Console.Write(i+1 +".Sayı: ");
                dizi[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0;i< dizi.Length; i++)
            {
                toplam = toplam + dizi[i];
            }

            

            Console.WriteLine("Girdiğiniz sayıların toplamı: " +toplam);

            Console.Write("Girdiğiniz sayılar: ");
            foreach (int sayi in dizi)
            {
                Console.Write(sayi + ",");
               
            }
            Console.WriteLine("Girdiğiniz sayıların ortalaması: " + toplam/diziUzunlugu);
        }
    }
}
