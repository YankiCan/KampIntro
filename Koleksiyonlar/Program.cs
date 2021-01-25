using System;
using System.Collections.Generic; // List yazıldığından çıkan ampulden eklenilmesi gereklidir.

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" }; 
            // Normalde bu veriler bir veri kaynağından geldiği için sonradan bir veri eklenemiyor. Bu sebepten Koleksiyonlar kullanılır.
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; // new denildiğinde bellekte yeni bir adres oluşur. 
            // Bir önceki isimler arrayi ref tip olduğundan adres değiştirerek yeni arraye bağlandı. 
            // Dolayısıyla bu yeni arrayde yalnızca 5. elemanı tanımlı olan bomboş bir array oluşturulmuş olundu. 
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]); // Dolayısıyla başa dönüp 0. elemanı yeniden okuyamadı. 

          
            List<string> isimler2 = new List<string>() { "Engin", "Murat", "Kerem", "Halil" }; // <> generic yapıdır. 
           
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker"); // Bu şekilde listeye eklmee yapılabilir. 
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}

// ctrl K + ctrl C = Hepsini comment satırı yap
// ctrl K + ctrl U = Comment satırlarını normal koda döndürür.