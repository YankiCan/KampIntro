using System;

namespace HW_01_Product
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

            Console.WriteLine("Foreach Loop");
            
            foreach (var product in products)
            {
                Console.WriteLine(product.Brand + " " + product.Type + " : " + product.Material + " , " + product.Color + " , " + product.Price + " TL " );
            }


            Console.WriteLine("--------------------------------------");
            Console.WriteLine("For Loop");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Brand + " " + products[i].Type + " : " + products[i].Material + " , " + products[i].Color + " , " + products[i].Price + " TL ");
            }


            Console.WriteLine("--------------------------------------");
            Console.WriteLine("While Loop");

            int y = 0;
            while (y<products.Length)
            {
                Console.WriteLine(products[y].Brand + " " + products[y].Type + " : " + products[y].Material + " , " + products[y].Color + " , " + products[y].Price + " TL ");
                y++;
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
