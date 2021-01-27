using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager // Ampulden implement interface seçilir, aşağısı otomatik dolar. 
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            // Hesaplama kodları burada yapılır. 
            //
            // Kredi simulasyonu en sonunda gerçekleştirilir. 

            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
