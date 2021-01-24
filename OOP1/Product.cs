﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product // Entity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public UnitInStock MyProperty { get; set; }

    }
}

// Bu tip classlarda sadece özellik olur.
// CRUD Operasyonlar - Create, Read, Update, Delete