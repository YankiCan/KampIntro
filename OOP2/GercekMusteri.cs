using System;
using System.Collections.Generic;
using System.Text;

namespace _10_OOP2
{
    class GercekMusteri:Musteri
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}

// Individual - Ing Gerçek

// Aritmatik işlemde kullanılmayan sayılar (TC No, Müşteri No gibi) string tanımlanabilir, long da olabilir.