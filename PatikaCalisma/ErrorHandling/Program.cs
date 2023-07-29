using System;

namespace ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            {

                Console.WriteLine("İşlem tamam bro.");
            }

            try
            {
                //int a = int.Parse(null);
                int a = int.Parse("test");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz! ");
                Console.WriteLine(ex.Message);  
            }
            catch (FormatException ex) 
            {
                Console.WriteLine("Format uyumsuzluğu!");
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
