using System;
using System.Collections.Generic;
using System.Text;

namespace HWInterfaces
{
    interface ICustomerDal // data access layer - veri işlerini yapmak için kullanılır.
        // Oracle vb. destekli sistemler yazılmak istendiğinde (her biri için kullanılan teknoloji farklıdır), her bir sistem için ICustomerDal ayrı ayrı implemente edilmelidir. 
    {
        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }
    }


    class MySqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}


// polimorfizm : Bir nesneyi farklı amaçlarla implemente edip, o implementasyonların belli bir kısmına ya da tamamına ulaşmaktır. 