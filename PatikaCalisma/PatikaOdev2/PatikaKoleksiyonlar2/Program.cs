using System;
using System.Linq;

namespace PatikaKoleksiyonlar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int[] arrSmall = new int[3];
            int[] arrLarge = new int[3];
            int totalSmall = 0, totalLarge = 0;
            Console.WriteLine("Lütfen 20 adet sayı giriniz: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            Console.WriteLine("En küçük 3 Sayı: ");
            for (int i = 0;i < 3;i++) 
            {
                Console.WriteLine(arr[i]);
                arrSmall[i] = arr[i];
                totalSmall += arr[i];
            }
            Array.Reverse(arr);
            Console.WriteLine("En büyük 3 Sayı: ");
            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine(arr[i]);
                arrLarge[i] = arr[i];
                totalLarge += arr[i];
            }


            Console.WriteLine("Büyük grubun ortalaması: " + totalLarge/3);
            Console.WriteLine("Büyük grubun ortalaması: " + totalSmall/3);
            Console.WriteLine("Ortalamaların toplamı: " + ((totalSmall/3)+(totalLarge/3)));
        }
    }
}



