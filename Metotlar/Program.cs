using Metotlar;
using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunadi = "Elma";
            double fiyati = 15;
            string aciklama= "Amasya Elması";
            string[] meyveler = new string[] { "Elma","Karpuz" };
            
            Urun urun1 = new Urun ();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 10;

            Urun urun2 = new Urun ();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 10;

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun x in urunler)
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine(x.Aciklama);
                Console.WriteLine("-----------------");

            }

            Console.WriteLine("------------Metotlar------------");
            
            // instance - örnek
            SepetManager SepetManager = new SepetManager();
            SepetManager.Ekle(urun1);
            SepetManager.Ekle(urun2);
            
            
            //encapsulation
            //niye illa clas yapiyoruz
            SepetManager.Ekle2("Armut","Yeşil Armut",12,10);
            SepetManager.Ekle2("Elma","Yeşil Elma",12,9);
            SepetManager.Ekle2("Karpuz","Diyarbakır Karpuzu",12,8);

        }
    }
}

// Metotlar kendini bir daha tekrar etmemeni sağlar.