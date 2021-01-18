using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusteriEkle (Musteri musteri) 
        {
            Console.WriteLine(musteri.MusteriAdi + "Müşterinin Adı Onaylandı : " + musteri.MusteriSoyadi + 
                "Müşterinin Soyadı Onaylandı : " + musteri.MusteriTelefon + "Müşterinin Telefonu Onaylandı : " 
                + musteri.MusteriMail + "Müşterini Maili Onaylandı : " + musteri.MusteriSifre+ "Müsterinin Şifresi Onaylandı :"  );
        }

        public void MusteriSil (Musteri musteri) 
        {
            Console.WriteLine(musteri.MusteriAdi + "Müşterinin Adı Silindi : " + musteri.MusteriSoyadi +
                "Müşterinin Soyadı Silindi : " + musteri.MusteriTelefon + "Müşterinin Telefonu Silindi : "
                + musteri.MusteriMail + "Müşteri Maili Silindi : " + musteri.MusteriSifre + "Müşteri Şifresi Silindi : ");

        }


        public void MusteriListele (Musteri musteri) 
        {
            Console.WriteLine(musteri.MusteriAdi + "Müşterinin Adı Listelendi: " + musteri.MusteriSoyadi +
                "Müşterinin Soyadı Listelendi: " + musteri.MusteriTelefon + "Müşterinin Telefonu Listelendi : "
                + musteri.MusteriMail + "Müşteri Maili Listelendi : " + musteri.MusteriSifre + "Müşteri Şifresi Listelendi : ");
        }
    }
}
