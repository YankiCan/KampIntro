using System;

namespace HW_10_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Elindeki veriyi hem Oracle hem de Sql veri tabanına yazmak için;
            ICustomerDal[] customerDals = new ICustomerDal[3] 
            {
                new SqlServerCustomerDal(), 
                new OracleCustomerDal(), 
                new MySqlServerCustomerDal() 
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
           
        }

        private static void Demo()
        {
            //IPerson person = new Customer(); // Customer yerine IPerson yazılması mümkün değildir, interfaceler kendi başına new lenemez. 

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }


        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();

            Customer customer = new Customer 
            {
                Id = 2,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Adress = "Ankara"
            };
            manager.Add(customer);

            Student student = new Student 
            {
                Id = 1,
                FirstName = "Yankı",
                LastName = "Can",
                Department = "İstanbul"
            };
            manager.Add(student);
        }
    }

    // Soyut nesne - Tek başına bir anlam ifade etmez. New lenemez!
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    // Somut nesne
    class Customer : IPerson 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }

    class Student : IPerson // implement missing members ayarından bu şekilde temiz sonuç elde edilebilir ???
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person) // IPerson kullanıldığında ister customer ister student gönderilebilir
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
