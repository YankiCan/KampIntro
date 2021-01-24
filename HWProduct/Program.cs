using System;

namespace HWProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Brand = "Mavi"; 
            product1.Type = "Pant";
            product1.Material = "Polyamide";
            product1.Color = "Blue";
            product1.Price = 120;

            Product product2 = new Product();
            product2.Brand = "Benetton";
            product2.Type = "Pullover";
            product2.Material = "Wool";
            product2.Color = "Pink";
            product2.Price = 215.50;

            Product product3 = new Product();
            product3.Brand = "Koton";
            product3.Type = "T-shirt";
            product3.Material = "Cotton";
            product3.Color = "White";
            product3.Price = 60.99;

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Brand + " " + product.Type + " : " + product.Material + " , " + product.Color + " , " + product.Price + " TL " );
            }

        }

        class Product
        {
            public string Brand { get; set; }
            public string Type { get; set; }
            public string Material { get; set; }
            public string Color { get; set; }
            public double Price { get; set; }
        }
    }
}
