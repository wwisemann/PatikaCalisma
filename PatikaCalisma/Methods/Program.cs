using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Erişim belirteci  -- geri dönüş tipi  --  metot adı(parametre listesi)
            //{
            //  Komutlar;
            //}

            int a = 2;
            int b = 3;

            Console.WriteLine(a + b);
            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc)); //5

            int sonuc2 = ornek.ArttirVeTopla(ref a,ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));
        }

        static int Topla(int deger1,int deger2)
        {
            return deger1 + deger2;
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string metin)
        {
            Console.WriteLine(metin);
        }

        public int ArttirVeTopla(ref int deger1,ref int deger2)
        {
            deger1++;
            deger2++;
            return deger1+deger2;
        }
    }
}
