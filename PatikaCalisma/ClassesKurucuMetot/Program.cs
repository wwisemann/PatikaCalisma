using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Erişim Belirleyici / Veri Tipi / ÖzellikAdı;   ---> Property tanımlama
            // Erişim Belirleyici / Geri Dönüş Tipi / MetotAdı(Parametreler)  ---> Metot tanımı
            //{
            // Metot Kodları
            //}

            // Erişim Belirleyiciler
            //* Public: Her yerden erişilir.
            //* Private: Sadece tanımlandıgı sınıf içerisinde erişilebilir.(Propertyler)
            //* Internal: Sadece bulundugu proje dosyası içinde erişilebilir.(Program.cs)
            //* Protected: Sadece tanımlandıgı sınıf ve sınıfın miras aldıgı sınıflarda erişilebilmesi içindir.
            Console.WriteLine("Calisan 1");
            Calisan calisan1 = new Calisan("Arif","Yılmaz",123, "IT");
            calisan1.CalisanBilgileri();

            Console.WriteLine("Calisan 2");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Berke";
            calisan2.Soyad = "Üre";
            calisan2.No = 456;
            calisan2.Departman = "Human Sources";
            calisan2.CalisanBilgileri();

            Console.WriteLine("Calisan 3");
            Calisan calisan3 = new Calisan("Meltem","Albayrak");
            calisan3.CalisanBilgileri();

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public Calisan(string ad, string soyad, int no, string departman) //Kurucu Metot
        {
            Ad = ad;
            Soyad = soyad;
            No = no;
            Departman = departman;
        }
        public Calisan(string ad, string soyad) //Kurucu Metot
        {
            Ad = ad;
            Soyad = soyad;
        }
        public Calisan() { }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calışan Adı: {0}", Ad);
            Console.WriteLine("Calışan Soyadı: {0}", Soyad);
            Console.WriteLine("Calışan Nosu: {0}", No);
            Console.WriteLine("Calışan Departmanı: {0}", Departman);
        }
    }
}
