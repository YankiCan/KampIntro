using System;

namespace _04_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aşağıdaki üç madde beraber bir ürünü anlatır, class bu maddeleri beraber tutan yapıdır. 
            // Bu şekilde tanımlamak yerine Urun içerisinde class oluşturulur. 
           
            // string urunAdi = "Elma";
            // double fiyati = 15;
            // string aciklama = "Amasya elması";

            // string[] meyveler = new string[] { }; // Bu array içerisinde sadece string tutulabilir
            
            Urun urun1 = new Urun(); // class örneğidir
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            // type safe- tip güvenli
            foreach (Urun urun in urunler) // Urun yerine var yazılsa da olur.
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("----------Metotlar-----------");

            // instance - örnek
            // encapsulation
            // SepetManager sayfasındaki yazı değiştirildiğinde, Ekle kullanılan tüm sayfalarda otomatik değişiklik yapılmasını sağlar. 
            SepetManager sepetManager = new SepetManager(); 
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);



            // Farklı sayfalarda simule etme örneği
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 10);
            // sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12); // Stok adedi otomatik eklenmediği için hata verdi.
            // Bu tip gösterimlerde, tüm sayfalarda yeni bir eklenti olduğunda (stok adedi gibi) tek tek el ile düzeltme yapılması gereklidir. 

        }
    }
}

// Metotlar tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
// Sayfalarda kullanılacak ortak kodlar metot haline getirilir ve tekrar tekrar kullanılır.
// Do not repeat yourself (DRY) - Clean Code - Best Practice


