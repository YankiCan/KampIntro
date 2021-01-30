using System;

namespace HW_03_ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 13579;
            customer1.Name = "Yankı";
            customer1.Surname = "Can";
            customer1.TcNo = "01234567890";
            customer1.CustomerNo = "24680";

            Customer customer2 = new Customer();
            customer2.Id = 12345;
            customer2.Name = "Zühal";
            customer2.Surname = "Can";
            customer2.TcNo = "09876543210";
            customer2.CustomerNo = "35790";

            Customer[] customers = new Customer[] {customer1, customer2 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Customer Follow-up");
                Console.WriteLine("");
                Console.WriteLine("Id" + " : " + customer.Id);
                Console.WriteLine("Name" + " : " + customer.Name);
                Console.WriteLine("Surname" + " : " + customer.Surname);
                Console.WriteLine("Tc No" + " : " + customer.TcNo);
                Console.WriteLine("Customer No" + " : " + customer.CustomerNo);
                Console.WriteLine("\n"); ;              
            }

            CustomerManager customerManager = new CustomerManager();

            Console.WriteLine("Added Customer");
            Console.WriteLine("");
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);

            Console.WriteLine("\n");
       
            Console.WriteLine("Removed Customer");
            Console.WriteLine("");
            customerManager.RemoveCustomer(customer1);
            customerManager.RemoveCustomer(customer2);

            Console.WriteLine("\n");

            Console.WriteLine("Updated Customer Informations");
            Console.WriteLine("");
            customerManager.UpdateCustomerInfo(customer1);
            customerManager.UpdateCustomerInfo(customer2);

            Console.WriteLine("\n");

            Console.WriteLine("List of Customers");
            Console.WriteLine("");
            customerManager.ListCustomers(customers);

        }
    }
}



// 1. Bir bankada müşteri takibi yapmak istiyorsunuz.

