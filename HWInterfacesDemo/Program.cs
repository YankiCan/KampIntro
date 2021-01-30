using System;

namespace HW_11_InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot(),
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[]
            {
                new Manager(),
                new Worker(),
                // new Robot(), eat içinde tanımlı olmadığından çağırılamaz.
            };
                
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }



    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            
        }

        public void GetSalary()
        {
           
        }

        public void Work()
        {
           
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            
        }

        public void GetSalary()
        {
          
        }

        public void Work()
        {
          
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
          
        }
    }
}
