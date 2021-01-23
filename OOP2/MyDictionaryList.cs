using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionaryList<T1, T2, T3>
    {
        T1[] Isımler;
        T2[] Soyısımler;
        T3[] Yaslar;
        public MyDictionaryList()
        {
            Isımler = new T1[0];
            Soyısımler = new T2[0];
            Yaslar = new T3[0];
        }
        public void Add(T1 Isım, T2 Soyısım, T3 Yas)
        {
            T1[] tempArray = Isımler;
            T2[] tempArray2 = Soyısımler;
            T3[] tempArray3 = Yaslar;
            Isımler = new T1[Isımler.Length + 1];
            Soyısımler = new T2[Soyısımler.Length + 1];
            Yaslar = new T3[Yaslar.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                Isımler[i] = tempArray[i];
                Soyısımler[i] = tempArray2[i];
                Yaslar[i] = tempArray3[i];

            }
            Isımler[Isımler.Length - 1] = Isım;
            Soyısımler[Soyısımler.Length - 1] = Soyısım;
            Yaslar[Yaslar.Length - 1] = Yas;


        }

        public int Length()
        {return Yaslar.Length; }
        

        public T1[] ısım
        {
            get { return Isımler; }
        }
        public T2[] Soyısım 
        {
           get { return Soyısımler; }
        }
        public T3[] Yas
        {
            get { return Yaslar; }
        }



    }
}
