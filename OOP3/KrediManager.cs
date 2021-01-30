using System;
using System.Collections.Generic;
using System.Text;

namespace _11_OOP3
{
    interface IKrediManager // Okunurluğu arttırmak çin Kredi Manager I ile başlar, Interface olduğu tanımlanır.
        // İmzanın aynı olduğu ama içerisinin farklı olduğu durumlarda class olarak değil interface olarak oluşturulur. 
        // Her bir kredi türünün hesaplama türü birbirinden farklı olduğundan interface seçilir. 
        // Interface (arayüz) şablon görevi görür. Eğer bu interface kullanılırsa altındaki metodları içermek zorundadır.  
    
        {
        // interface formatın geçirince public ve {} silinir. 
            void Hesapla(); 

            void BiseyYap();
        }
    }


// Interface ler yapısı gereği public yapıdadır, ekstra belirtmeye gerek yoktur
// Interfaceler birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanılır. 

// loglama işlemi - Kimi, ne zaman, hangi operasyonları çağırdığıdır. O sistemde olan hareketlerin dökümüdür. 
// Loglar dosyada, veri tabanında tutulabilir, ya da sms, mail atılabilir (kredi başvuru yapan kişiye sms gönderilmesi).