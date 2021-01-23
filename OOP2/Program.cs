using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionaryList<string, string, double> ıscı = new MyDictionaryList<string, string, double>();
            ıscı.Add("Ahmet", "Güven", 43);
            ıscı.Add("Ömer", "Yılmaz", 25);
            ıscı.Add("Ertuğrul", "Pehlivan", 20);
            ıscı.Add("Mustafa", "Sürmen", 65);


            Console.WriteLine("----İşçilerin Adları----");
            foreach (var ısım in ıscı.ısım) 
            {
                Console.WriteLine(ısım);
            }
            Console.WriteLine("-----İşçilerin Soyadları ----");
            foreach ( var soyısım in ıscı.Soyısım) 
            {
                Console.WriteLine(soyısım);
            }
            Console.WriteLine("-----İşçileri Yaşları----");
            foreach ( var yas in ıscı.Yas) 
            {
                Console.WriteLine(yas);
            }
            
            











        }
    }
}
