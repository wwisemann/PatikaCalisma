using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Ayşe");
            list.Add(2);
            list.Add(true);
            list.Add('A');

            //Verilere erişim
            Console.WriteLine(list[1]);
            foreach (var item in list) 
            {
                Console.WriteLine(item);            
            }

            //AddRange
            Console.WriteLine("**** Add Range ****");
            string[] renkler = { "kırmızı", "sarı", "yesil" };
            List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
            list.AddRange(renkler);
            list.AddRange(sayilar);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("**** Sort ****");
            //list.Sort(); //içinde tek tip veri olması gerekir.Int ve string aynı anda olamaz.

            //Binary Search
            Console.WriteLine("**** Binary Search ****");
            //Console.WriteLine(list.BinarySearch(9)); //Yine tek tür veri olması gerekir. Index döndürür.

            //Reverse List
            list.Reverse(); //ters çevirir.
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Clear
            list.Clear();//her seyi temizler.
        }
    }
}
