﻿using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type.safe -- tip güvenli
            foreach (Urun urun in urunler) // urun yerine x de yazabilirsin Urun yerine var da yazabililrsin
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("---------Metotlar---------");

            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,5);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,6);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,11);
            sepetManager.Ekle2("Çilek", "Köprübaşı Çileği", 45, 30);
        }
    }
}



//do not repeat yourself - DRY - Clean Code - Best Practice