using System;

namespace _02_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Birçok kurs bu şekilde tek tek değişkenlerle tanımlanamaz. 
            // Liste formatında gösterilmek istenenler string, int gibi değişkelerde değil, dizilerde tanımlanır!  
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı"; // Tek bir değişken tutar.
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            // array - dizi
            // İstenilen kadar kursu tek bir değişkende tutmayı sağlar. 
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya Başlangıç İçin Temel Kurs", "Java", "Python", "C++" }; // Birden fazla değişken tutabilir.


            // for + tabtab
            for (int i = 0; i < kurslar.Length; i++) // Java kodu ile aynıdır.
                // 0 den başla (i=0), 4 ten küçük olduğu sürece (i<4), bir bir arttırarak (i++ or i=i+1) çalıştır.
                // i=i+2 or i+=2 (ikişer ikişer arttır)
                // Her yeni kurs eklendiğinde i< değerini değiştirmemek için kurslar.Length ile tanımlanır. 
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");


            // foreach dizi temelli yapıları tek tek dönmeye yarar, for döngülerinin alternatif yoludur. 
            // for yaz foreach seçili iken tabtab
            foreach (string kurs in kurslar) // string yerine var ile de çalışır - kurs takma isimdir, değiştrilebilir. 
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}

// Döngüler birşeyleri tekrar etmke için kullanılan yapılardır. 
// Class lar birden fazla veriyi tutabilmek için kullanılır. 