using System;

namespace HWReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Derin";

            //Console.WriteLine(person2.FirstName); // Derin


            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "123456789";
            
            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer; // Miras alınan sınıfa, miras alan sınıf atanabilir. 
             
            customer.FirstName = "Ahmet";

            //Console.WriteLine(person3.FirstName); // Salih 
            // person3 customer adresini tutar ama Person sınıfının içindekiler çağırabilir, CreditCardNumber çağıramaz.

            //Console.WriteLine(((Customer)person3).CreditCardNumber); // Customer içindekileri çağırmak için uygulanır. 

            PersonManager personManager = new PersonManager();
            personManager.Add(customer); // customer, employee dahil hepsi gönderilebilir. 

        }
    }

    // base class : Person 
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager // İstenildiği zaman müşteri veya çalışan ile çalışabilmek için kullanılır. Aynı kod farklı nesnelerle çalıştırabilir. 
    {
        public void Add(Person person) // Customer veya Employee de yazabilmek mümkün ama Person hepsini kapsıyor. 
        {
            Console.WriteLine(person.FirstName);
        }
    }


}
