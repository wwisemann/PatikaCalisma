using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaCalisma
{
    internal class TypeConversion
    {
        static void Main(string[] args)
        {
            //Implict Conversion (Bilinçsiz Dönüşüm)
            byte a = 5;
            sbyte b = 30;
            short c = 50;

            int d = a + b + c;
            long h = d + 50;
            float i = h + d; //Daha büyük değişken oldugu için sorun çıkmıyor.


            string arif = "Arif";
            char yılmaz = 'D';
            object o1 = arif + yılmaz + a;
            Console.WriteLine(o1);

            //Explicit Conversion (Bilinçli Dönüşüm)
            int x = 5;
            byte y = (byte)x;
            Console.WriteLine(y);

            float z = 5.9F;
            byte g = (byte)z;
            Console.WriteLine(g);

            //ToString Methodu= int'e çevirdik
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine(yy);

            string zz = 17.9F.ToString();
            Console.WriteLine(zz);

            //System.Convert Methodu
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Console.WriteLine(sayi1 + sayi2);

            //Parse Methodu
            string metin1 = "10";
            string metin2 = "10,700";
            int sayi3;
            Double sayi4;
            
            sayi3 = Int32.Parse(metin1);
            sayi4 = Double.Parse(metin2);
            Console.WriteLine(sayi4);
            Console.WriteLine(sayi3);
        }
    }
}
