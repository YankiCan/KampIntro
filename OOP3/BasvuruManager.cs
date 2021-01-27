using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Method Injection

       //public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) // Birden çok log çağırmak için
        {
            // Başvuran bilgilerini değerlendirme

            // Bu yapılırsa tüm başvurular konut kredisi üzerinden hesaplanır!
            //KonutKrediManager konutKrediManager = new KonutKrediManager(); 
            //konutKrediManager.Hesapla();

            krediManager.Hesapla(); // Bu formatta hangi kredi gönderilirse o çalışır. 
            //loggerService.Log(); // Hangi logger service gönderilmişse onu logla

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }


        // Aynı veri türünde belirsiz sayıda bir veri grubu oluşturmak için liste kullanılır. 
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler) // IKrediManager türünde liste eklenir
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}

// Constructor Injection ödevlerde izle!
