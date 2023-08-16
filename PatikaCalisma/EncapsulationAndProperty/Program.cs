using System;

namespace EncapsulationAndProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci("Arif","Yılmaz",651,5);
            ogrenci1.OgrenciBilgileri();
            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileri();

            Ogrenci ogrenci2 = new Ogrenci("Berke", "Üre", 139, 2);
            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileri();
        }
    }

    class Ogrenci
    { //Private propertyler kucuk harfle baslar.
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo1 { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en kücük 1 olabilir.");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
            }
        }


        public Ogrenci(string ısim, string soyisim, int ogrenciNo1, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo1 = ogrenciNo1;
            Sinif = sinif;
        }
        public Ogrenci() { }
        
        public void OgrenciBilgileri()
        {
            Console.WriteLine("Öğrenci Adı: {0}" , this.Isim);
            Console.WriteLine("Öğrenci Soyadı: {0}" , this.Soyisim);
            Console.WriteLine("Öğrenci Numarası: {0}" , this.ogrenciNo);
            Console.WriteLine("Öğrenci Sınıfı: {0}" , this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif += 1;
        }
        public void SinifDusur()
        {
            this.Sinif -= 1;
        }
    }
}
