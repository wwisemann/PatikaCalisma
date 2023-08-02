using System;

namespace StringMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz Csharp, Hoş geldiniz!";
            string degisken2 = "Csharp";

            //Length
            Console.WriteLine(degisken.Length); //Uzunluğu alır.

            //ToUpper,ToLower
            Console.WriteLine(degisken.ToLower()); //Küçük harf
            Console.WriteLine(degisken.ToUpper()); //Büyük harf
            
            //Concat
            Console.WriteLine(String.Concat(degisken," Merhaba!")); //Sona Ekler

            //Compare,CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1 karşılaştırır.
            Console.WriteLine(String.Compare(degisken,degisken2,true)); // Karşılaştırır true oldugu için büyük harf duyarlıdır
            Console.WriteLine(String.Compare(degisken, degisken2, false));

            //Contains
            Console.WriteLine(degisken.Contains(" " + degisken2)); // İçinde varsa true döner.
            Console.WriteLine(degisken.EndsWith("Hoş geldiniz!")); //Onla bitiyorsa true döner.
            Console.WriteLine(degisken.StartsWith("Merhaba selamlar")); //Onla başlıyorsa true döner.

            //IndexOf
            Console.WriteLine(degisken.IndexOf("Cs")); //bulamazsa -1 döner.
            Console.WriteLine(degisken.LastIndexOf("i")); //Son i'nin indexini döner.

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba ")); //Indexe göre ekler.

            //PadLeft,Padright
            Console.WriteLine(degisken + degisken2.PadLeft(30)); //gereksiz.

            //Remove
            Console.WriteLine(degisken.Remove(10)); //10.Indexten sonrasını uçurur.
            Console.WriteLine(degisken.Remove(5,3)); //5.Indexten sonra 3 tane uçurur.

            //Replace
            Console.WriteLine(degisken.Replace("Csharp", "C#")); //Bir kelimeyi başka bir şeyle değiştirebiliriz.

            //Split
            Console.WriteLine(degisken.Split(' ')[3]); //Belirtece göre öncesi ve sonrasını diziye atar.

            //Substring
            Console.WriteLine(degisken.Substring(4)); //4.indexten başlar sona kadar gider.
            Console.WriteLine(degisken.Substring(4,6)); //4.indexten başlar 6 karakter ilerler.
        }
    }
}
