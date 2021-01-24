using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2) // Bu parametre kısmı toplama metodunun ihtiyacı olanlardır, 2 sayı gibi. 
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
    }
}

// Birçok sayfada kullanılacak olan aynı toplama işlemleri için metot olarak yazılır ve o kod her sayfada çağırılır. 
