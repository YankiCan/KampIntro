using System;
using System.Collections.Generic;


namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interfacelerde o interface i implemente eden classın ref nosunu tutabiliyor. 
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); // IhtiyacKrediManager yerine IKrediManager da yazılabilir. Diğerleri içinde geçerlidir.
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            // Yukarıdakiler ekranda görülecek olan kredi seçenekleridir. 

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            // hangi kredi türü yazılırsa sistem onu yazdırır
            //basvuruManager.BasvuruYap(ihtiyacKrediManageri, databaseLoggerService);
            // ILoggerService newlemesi yerine BasvuruYap kodunun içine (ihtiyacKrediManager, new DatabaseLoggerService()) şeklinde de yazılabilirdi. 

            basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService> {new SmsLoggerService(), databaseLoggerService }); 
            
            //List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasıtKrediManager }; // Hangi kredilerin hesaplanması isteniyorsa listeye eklenir. 
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
           
   
        }
    }
}

// interface
// Object Oriented Programming (OOP) - Nesne Yönelimli Programlama
