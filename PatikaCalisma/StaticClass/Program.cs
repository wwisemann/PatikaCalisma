using System;

namespace StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalısan Sayısı: {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Arif","Yılmaz","IT");
            Console.WriteLine("Çalısan Sayısı: {0}", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Berke", "Üre", "Human Sources");
            Console.WriteLine("Çalısan Sayısı: {0}", Calisan.CalisanSayisi);


            Console.WriteLine("Toplama İşlemi: {0}", Islemler.Topla(100, 200));
            Console.WriteLine("Çıkarma İşlemi: {0}", Islemler.Cikar(600, 200));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}


        private string isim;
        private string soyisim;
        private string departman;

        static Calisan() 
        {
            calisanSayisi = 0;
        }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            calisanSayisi++;
        }

    }

    static class Islemler
    {
        public static long Topla(int a, int b)
        {
            return a+b;
        }
        public static long Cikar(int a, int b)
        {
            return a - b;
        }
    }
}
