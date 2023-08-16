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

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Arif";
            calisan1.Soyad = "Yılmaz";
            calisan1.No = 123;
            calisan1.Departman = "IT";
            calisan1.CalisanBilgileri();

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalisanBilgileri()
        {
            Console.WriteLine("Calışan Adı: {0}", Ad);
            Console.WriteLine("Calışan Soyadı: {0}", Soyad);
            Console.WriteLine("Calışan Nosu: {0}", No);
            Console.WriteLine("Calışan Departmanı: {0}", Departman);
        }
    }
}
