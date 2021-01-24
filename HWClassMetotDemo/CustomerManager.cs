using System;
using System.Collections.Generic;
using System.Text;

namespace HWClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("New customer has been added!" + " Id : " + customer.Id);
        }

        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine("Registered customer has been removed!" + " Id : "  + customer.Id);
        }

        public void UpdateCustomerInfo(Customer customer)
        {
            Console.WriteLine("Customer Information has been updated!" + " Id : " + customer.Id);
        }

        public void ListCustomers(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name + " " + customer.Surname + " , " + " Id : " + customer.Id);
            }
        }
    }
}


// 3. MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz.