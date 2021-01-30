using System;

namespace HW_13_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            //customerManager.Update();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();
            //employeeManager.Update();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());
        }
    }

    interface IPersonManager
    {
        // unimplemented operation (class olsaydı implemented operation)
        void Add(); // interface ler zaten public olduğundan yazılmaz, içleri doldurulmaz (her class ta ayrı hesaplama kodları kullanılır).
        // class larda kodlar ortak olur. 

        void Update();
    }

    // inherits - class -------------- implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            // Müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // Personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
