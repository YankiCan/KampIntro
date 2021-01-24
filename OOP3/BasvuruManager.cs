using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Method Injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            // Başvuran bilgilerini değerlendirme

            // Bu yapılırsa tüm başvurular konut kredisine bağımlı haline getirir!
            //KonutKrediManager konutKrediManager = new KonutKrediManager(); 
            //konutKrediManager.Hesapla();

            krediManager.Hesapla(); // Bu formatta hangi kredi gönderilirse o çalışır.
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List <IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        internal void BasvuruYap(TasıtKrediManager tasıtKrediManager, object filelogger)
        {
            throw new NotImplementedException();
        }
    }
}
