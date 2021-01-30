using System;

namespace HW_08_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Yankı";
            customer.LastName = "Can";
            customer.City = "İstanbul";

            // Yukarıdakine alternatif bir metottur. 
            Customer customer2 = new Customer {Id = 2, FirstName = "Yankı", LastName = "Can", City = "İstanbul"};

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
