using System;
using System.Collections.Generic;
using System.Text;

namespace _07_OOP1
{
    class ProductManager
    {
       public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }


        // ----------------------------------------------------

        // return; Program akışında yeniden kullanılması gereken sonuçlar için kullanılması gereklidir. 
        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}


        // void; Emir kipinde çağrılan, ekle, sil, güncelle gibi işlemlerde, yalnızca işlem sonucu yazdırılmak isteniyr ve işlem sonucunun ne olduğu ile ilgili ekstra bir bilgiye ihtiyaç yoksa tanımlanır. 
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}

        
        // ----------------------------------------------------


        // Referans Tip Örneği
        //public void Add(Product product)
        //{
        //    product.ProductName = "Kamera";
        //}


        // Değer Tip Örneği
        //public void BiseyYap(int sayi)
        //{
        //    sayi = 99;
        //}
    }
}

// Ürünle ilgili operasyonları içerir. 
// CRUD Operasyonlar - Create, Read, Update, Delete


