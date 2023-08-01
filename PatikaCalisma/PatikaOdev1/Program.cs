using System;
using System.Collections.Generic;
using System.Linq;

namespace PatikaOdev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                    //************1.ÖDEV * ***********

            Console.Write("Lütfen bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n + " Adet sayı giriniz ");
            int[] dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + ".Sayı: ");
                dizi[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    Console.WriteLine(dizi[i]);
                }
            }


                                    //************2.ÖDEV * ***********

            Console.Write("Lütfen iki sayı giriniz: ");
            int n2 = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(n2 + " Adet sayı giriniz: ");
            int[] dizi2 = new int[n2];

            for (int i = 0; i < n2; i++)
            {
                Console.Write((i + 1) + ".Sayı: ");
                dizi[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n2; i++)
            {
                if (dizi2[i] % m == 0)
                {
                    Console.WriteLine(dizi2[i]);
                }
                else if (dizi2[i] == m)
                {
                    Console.WriteLine(dizi2[i]);
                }
            }


                                    //************3.ÖDEV * ***********
            Console.Write("Lütfen bir sayı giriniz: ");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine(n3 + " Adet kelime giriniz: ");
            string[] dizi3 = new string[n3];

            for (int i = 0; i < n3; i++)
            {
                Console.Write((i + 1) + ".Kelime: ");
                dizi3[i] = Console.ReadLine();
            }

            Console.WriteLine("Yazdığınız Kelimeler: \n");

            Array.Reverse(dizi3);
            foreach (var kelime in dizi)
            {
                Console.WriteLine(kelime);
            }



                                    //************  4.ÖDEV  ************
            Console.Write("Lütfen bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            int karakterSayisi = cumle.Length;
            char arama = ' ';
            int sayac = 0;    

           
            foreach (char a in cumle) 
            {
                if (a == arama)
                    sayac++;
            }

            Console.Write("Girdiğiniz cümledeki karakter sayısı: " + karakterSayisi+ "\n");
            Console.Write("Girdiğiniz cümledeki kelime sayısı: " + ++sayac);   

        }
    }
}

