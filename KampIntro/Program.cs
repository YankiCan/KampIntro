using System;

namespace _01_KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type safety
            // Do not repeat yourself! 
            // Değer tutucu, alias (ex.kategoriEtiketi)

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000; // int belli sınırlara sahiptir, kırmızı çizgi oluşursa kod çalışmaz.
            double faizOrani = 1.45;
           
            bool sistemeGirisYapmisMi = false; // Gerçek hayatta cevap veri kaynağından gelir.
          
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            // Şart Blokları - if + tabtab

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }

            else
            {
                Console.WriteLine("Değişmedi butonu");
            }
     

// ---------------------------------------------------------------------


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
           

        }
    }
}


// Değişkenler veri tutuculardır.
// Değişken tanımlamak, farklı sayfalarda birçok kez yazılanlar ileride değiştirilmek istendiğinde toplu olarak düzeltme imkanı sağlar. 