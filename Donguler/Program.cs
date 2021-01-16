using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Phyton";
            string kurs5 = "C++";


            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            //array = dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs" , "Java","Phyton","C++"}; 



            for (int i = 0; i<kurslar.Length; i++) // i sayaç anlamına gelir
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine ("for Bitti") ;

                                                 //kurs yerine başka bir şey de yazabilirsin foreach'i dizileri kolay dolaşmak için kullanırız
            foreach (string kurs in kurslar) //string yerine var da yazabiliriz."in kurslar" demek kursları tek tek dolaş demek. foreach dizilere uygulanır.
            {
                Console.WriteLine(kurs); 
            }

            Console.WriteLine("sayfa sonu - footer");        }
    }
}
