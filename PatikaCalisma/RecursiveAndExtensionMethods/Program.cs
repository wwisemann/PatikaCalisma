using System;
using System.Linq.Expressions;

namespace RecursiveAndExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recursive Fonksiyon
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);
            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));


            //Extension Metotlar
            string ifade = "Arifcan Yılmaz";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());


            int[] dizi = {3,5,4,1,2,9};
            dizi.SortArray();
            dizi.EkranYazdir();
        }
    }

    public class Islemler
    {
        public int Expo(int sayi,int üs)
        {
            if (üs < 2)
            {
                return sayi;
            }

            return Expo(sayi, üs - 1)*sayi;
        }
    }

    public static class Extension{
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");

        }

        public static string RemoveWhiteSpaces(this string param) 
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);  
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;   
        }
        
        public static void EkranYazdir(this int[] param)
        {
            foreach(int item in param)
            {
                Console.WriteLine(item);
            }
        }
    }
}
