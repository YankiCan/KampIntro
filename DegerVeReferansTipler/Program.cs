using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değer Tip - int

            // sayi1 değeri 10, sayi2 değeri 30 diye okunur. 
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; // sayi1 değeri sayi2 değerine eşitlenir (30), sayi1 in ilk değeri (10) unutulur.
            sayi2 = 65; // Değer tip olduğundan, sayi2 değerinin değişmesi sayi1 değerini etkilemez. 

            Console.WriteLine(sayi1); // 30 




            // Referans Tip - Array

            // int[] sayilar1 kısmında stack alanında bir değişken tanımlanır, 
            // new yazıldığında sayilar1 için heap içerisinde bir alan oluşturulur ve değerler oraya yazılır (10, 20, 30).
            // sayilar1 heapte bir adres (101) içerisinde tutulur.
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 }; // heapte 102 numaralı adreste tutulur
            sayilar1 = sayilar2; // Eşitlik sağlandığında sayilar1 adresi heapte sayilar2 nin adresine (102) eşitlenir. 101 adresi çöp olur. 
            sayilar2[0] = 999; // sayilar1 artık 102 adresine bağlı olduğundan sayilar2 deki değişiklikten etkilenir. 
            
            Console.WriteLine(sayilar1[0]); // 999

        }
    }
}

// Değer Tip (Value Types) ; int, decimal, flood, double, bool
// Referans Tip; array, class, interface
// Bellekte stack ve heap alanları vardır. 
// Değer tipler stack içinde gerçekleşir. 
// Garbage collector ile unutulan adresler bellekten atılır.