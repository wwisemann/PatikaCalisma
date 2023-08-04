using System;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<T> class t-> object türündedir.

            List<int> sayiListesi = new List<int>();
            
            sayiListesi.Add(20);
            sayiListesi.Add(10);
            sayiListesi.Add(30);
            sayiListesi.Add(40);

            List<String> renkListesi = new List<String>();
            renkListesi.Add("Mavi");
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Beyaz");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Listeden Eleman çıkarma & Remove ve RemoveAt farkı
            sayiListesi.Remove(40);
            sayiListesi.RemoveAt(2); //3.indexteki sayıyı çıkarır.
            renkListesi.Remove("Beyaz");

            //Yazdırma işlemi & Foreach ve ForEach
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde Arama
            if(sayiListesi.Contains(20)) 
            {
                Console.WriteLine("20 Liste içinde var.");
            }

            //Eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("Mavi"));


            //Diziyi List'e çevirme
            string[] hayvanlar = {"kedi","köpek","at"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz.
            hayvanListesi.Clear();

            //Liste içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Arif";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.Yas = 21;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Özcan";
            kullanıcı2.Soyisim = "Çalışkan";
            kullanıcı2.Yas = 26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });
            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı :" + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yas:" + kullanıcı.Yas);
            }
        }
    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
