using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            // Alternatif yol
            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 35, UnitsInStock = 5, };

            // PascalCase  //camelCase   
            // case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);

            Console.WriteLine(product1.ProductName);




           // -----------------------------------------------------
            
            // return örneği
            //int toplamaSonucu = productManager.Topla(3, 6);
            //Console.WriteLine(toplamaSonucu*2);

            // void örneği
            //productManager.Topla2(3, 6);


            // ------------------------------------------------------


            // Referans Tip Örneği
            //Console.WriteLine(product1.ProductName); // Kamera

            // Değer Tip Örneği
            //int sayi = 100;
            //productManager.BiseyYap(sayi);
            //Console.WriteLine(sayi); //100
        }
    }
}

// Classlar ikiye ayrılır: İçerisinde özellik barındıran - operasyon (metot) barındıran
// ref-out keywords
