using System;

namespace HWInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Person[] persons = new Person[3]
            {
                new Person // Interface değil class olduğu için eklenebilir.
                {
                    FirstName = "Yankı"
                },
                new Customer
                {
                    FirstName = "Engin"
                },
                new Student
                {
                    FirstName = "Derin"
                }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Person2
    {

    }

    class Customer:Person // Yanına Person2 de eklemek mümkün değildir. Bir class ın bir babası olur :) Interface ile farkı budur.
    {
        public string City { get; set; }
    }

    class Student: Person
    {
        public string Departmane { get; set; }
    }
}
