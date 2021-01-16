﻿using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Nisa";
            int yas = 20;

            Kurs kurs1 = new Kurs ();
            kurs1.KursAdi = "C#";
            kurs1.Egıtmen = "Emgin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egıtmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egıtmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egıtmen);

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egıtmen);
            }

            Console.WriteLine("Hello World!");
        }
    }
        class Kurs
    {
        public string KursAdi  { get; set; }
        public string Egıtmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}