using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Deneme1", "Deneme2", "Deneme3","Python" };

            for (int i = 0; i <kurslar.Length; i++) 
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("1");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
            Console.WriteLine("Sayfa sonu");
        }
    }
}