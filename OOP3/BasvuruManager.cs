using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager

        //Method injection
    {
        public void BasvuruYap(IKrediManager krediManager, List<iLoggerService> loggers) 
        {
            //Başvuran bilgilerini değerlendirme
            //
            
           krediManager.Hesapla();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) 

        {
            foreach (var kredi in krediler) 
            {
                kredi.Hesapla();
            }
        }



    }
}
