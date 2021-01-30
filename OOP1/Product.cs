using System;
using System.Collections.Generic;
using System.Text;

namespace _07_OOP1
{
    class Product // Entity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }


    }
}

// Bu tip classlarda sadece özellik barındırır.
