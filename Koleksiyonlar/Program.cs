using System;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5]; // new denildiğinde bellekte yeni bir adres oluşur. 5. elemanı tanımlı olan bomboş bir array oluşturulmuş olundu. 
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]); // Dolayısıyla başa dönüp 0. elemanı yeniden okuyamadı. 
        }
    }
}
