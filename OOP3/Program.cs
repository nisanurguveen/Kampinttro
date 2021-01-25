using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        private static readonly IKrediManager tasitKrediManager;

        public static IKrediManager İhtiyacKrediManager { get; private set; }

        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyaçKrediManager();
            IKrediManager taşitKrediManager = new TaşıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatebaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService>loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap ( new EsnafKredisiManager(),loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() { İhtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            
        }
    }

    
}
