using System;
using System.Collections.Generic;
using System.Text;

namespace HW_08_Classes
{
    class Customer
    {
        // field - bir alan tanımlamak
        //public string FirstName;

        // Property - özellikle tanımlamak. Doğru yöntemi budur!
        // encapsulation
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}


//// First name set edildiğinde (değer verildiğinde), FirstName başına başka bir karakter getirmek için (ör. Mr.) - Nadir bir kullanımdır. 

//private string _firstName; // Öncelikle bir field tanımlanır
//public string FirstName
//{
//    get { return "Miss." + _firstName; }
//    set { _firstName = value; }

//}
