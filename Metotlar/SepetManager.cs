using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - Ekle için büyük E ile başlamak doğrudur.
        // syntax
        public void Ekle(Urun urun) // Ne eklemek istediğini belirtmek için parantez içine eklenecek urun yazılmalıdır. 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

       
        // Kullanışsız bir örnek;
        public void Ekle2(string urunAdi, string açiklama, double fiyat, int stokAdedi) // Bu bir class değildir
            // Urun sayfasındaki gibi bir metot kullanılmadığı ve bu şekilde yazıldığı taktirde, ...
            // bir ekleme yapıldığında tüm sayfalarda tek tek eklenen bilgiyi girmek gerekli olur. 
            // Bu sebeple kulanışlı değildir. 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}

// Manager içerisinde bir operasyon tutar.
// Bir class içerisinde birden fazla method olabilir.