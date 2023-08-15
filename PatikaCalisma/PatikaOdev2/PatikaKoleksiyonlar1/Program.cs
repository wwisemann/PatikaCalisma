using System;
using System.Collections;

namespace PatikaKoleksiyonlar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 Adet Sayı Giriniz: ");
            int bolen = 2;
            int check = 0;
            double primeTotal = 0;
            double normalTotal = 0;
            ArrayList primeList = new ArrayList();
            ArrayList normalList = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                int sayi;
                sayi = int.Parse(Console.ReadLine());
                
                while (bolen < sayi)
                {
                    if (sayi % bolen == 0)
                    {
                        check++;
                    }
                    bolen++;
                }
                bolen = 2;
                if (check != 0)
                {
                    normalList.Add(sayi);
                }
                else
                {
                    primeList.Add(sayi);
                }
                check = 0;
            }

            primeList.Sort();
            normalList.Sort();
            primeList.Reverse();
            normalList.Reverse();
            Console.WriteLine("**** Asal Sayılar ****");
            foreach (int i in primeList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("**** Normal Sayılar ****");
            foreach (int i in normalList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Asal Sayıların eleman sayısı: " + primeList.Count);
            Console.WriteLine("Normal Sayıların eleman sayısı: " + normalList.Count);

            for (int i = 0; i < primeList.Count; i++)
            {
                primeTotal += Convert.ToDouble(primeList[i]);
            }

            for (int i = 0; i < normalList.Count; i++)
            {
                normalTotal += Convert.ToDouble(normalList[i]);
            }

            Console.WriteLine("Asal Sayıların Ortalaması: " + primeTotal/primeList.Count);
            Console.WriteLine("Asal Sayıların Ortalaması: " + normalTotal/normalList.Count);
        }
    }
}





//Negatif ve numeric olmayan girişleri engelleyin.
