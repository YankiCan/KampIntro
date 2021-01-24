using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); // IhtiyacKrediManager yerine IKrediManager da yazılabilir. 
            TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

      

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            // basvuruManager.BasvuruYap(konutKrediManager); // hangi kredi türü yazılırsa sistem onu yazdırır
            basvuruManager.BasvuruYap(tasıtKrediManager, fileloggerService);

           
            
            List <IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasıtKrediManager };
            
           
   
        }
    }
}

// interface
// Object Oriented Programming (OOP) - Nesne Yönelimli Programlama
