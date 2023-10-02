namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Kursadi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeYuzdesi = 90;

            Kurs kurs2 = new Kurs();
            kurs2.Kursadi = "Java";
            kurs2.Egitmen = "Aykut Baykurt";
            kurs2.IzlenmeYuzdesi = 99;

            Kurs kurs3 = new Kurs();
            kurs3.Kursadi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeYuzdesi = 30;

            Kurs kurs4 = new Kurs();
            kurs4.Kursadi = "C++";
            kurs4.Egitmen = "Steve Steve";
            kurs4.IzlenmeYuzdesi = 66;

            Console.WriteLine(kurs1.Kursadi + " : " + kurs1.Egitmen);
            Console.WriteLine("2.deneme");

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar )
            {
                Console.WriteLine( kurs.Kursadi + ":" + kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string Kursadi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeYuzdesi { get; set; }
    }
}