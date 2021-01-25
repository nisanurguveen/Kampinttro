using System;

namespace Ooop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Nisa";
            musteri1.Soyadi = "Güven";
            musteri1.TcNo = "1654654654";

            //Kodlama.İo
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "165465";
            musteri2.SirketAdi = "Kodlama İo";
            musteri2.VergiNo = "2222";
            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Ekle(musteri1);
            costumerManager.Ekle(musteri2);
           
        























        }
    }
}
