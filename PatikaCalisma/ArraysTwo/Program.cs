using System;

namespace ArraysTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine("*** Sırasız Liste ***");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            //Sort (sıralar)
            Array.Sort(sayiDizisi);
            Console.WriteLine("*** Sıralı Liste ***");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            //Clear(elemanları 0lar)
            Console.WriteLine("*** Array Clear ***");
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            //Reverse(ters çevirir)
            Console.WriteLine("*** Array Reverse ***");
            Array.Reverse(sayiDizisi,4,2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            //Index Of
            Console.WriteLine("*** Index Of ***");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));


            //Resize(index değiştirme)
            Console.WriteLine("*** Resize ***");
            Array.Resize<int>(ref sayiDizisi,25);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
