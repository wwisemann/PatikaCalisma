using System;

namespace PatikaKoleksiyonlar3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle giriniz: ");
            string sentence = Console.ReadLine();
            string vowel = "aeıioöuü";
            char[] chars = sentence.ToCharArray();
            Array.Sort(chars);

            for (int i = 0; i < chars.Length; i++) 
            {
                if (vowel.Contains(chars[i]))
                {
                    Console.Write(chars[i]);
                }
            }
        }
    }
}



