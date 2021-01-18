using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.MusteriAdi = "Nisa Nur";
            musteri1.MusteriSoyadi = "Güven";
            musteri1.MusteriTelefon = 0123456789;
            musteri1.MusteriMail = "abcd@gmail.com";
            musteri1.MusteriSifre = 1456;

            Musteri musteri2 = new Musteri();

            musteri2.MusteriAdi = "Ayşe";
            musteri2.MusteriSoyadi = "Güngör";
            musteri2.MusteriTelefon = 1234560789;
            musteri2.MusteriMail = "asdf@gmail.com";
            musteri2.MusteriSifre = 2354;

            Musteri musteri3 = new Musteri();

            musteri3.MusteriAdi = "Merve ";
            musteri3.MusteriSoyadi = "Yılmaz";
            musteri3.MusteriTelefon = 789456123;
            musteri3.MusteriMail = "qwer@gmail.com";
            musteri3.MusteriSifre = 4561;

            Musteri musteri4 = new Musteri();

            musteri4.MusteriAdi = "Ömer";
            musteri4.MusteriSoyadi = "Görkem";
            musteri4.MusteriTelefon = 235664643;
            musteri4.MusteriMail = "kfldg@gmail.com";
            musteri4.MusteriSifre = 7895;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };


            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyadi);
                Console.WriteLine(musteri.MusteriTelefon);
                Console.WriteLine(musteri.MusteriMail);
                Console.WriteLine(musteri.MusteriSifre);
                Console.WriteLine("---------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);
            musteriManager.MusteriSil(musteri4);
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriListele(musteri3);
            musteriManager.MusteriListele(musteri4);






        }
    }
}
