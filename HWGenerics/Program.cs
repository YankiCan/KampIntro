using System;
using System.Collections.Generic; // List yazılınca eklnemelidir!

namespace HWGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic lerde hangi tip verilirse, içindeki operasyonlar [Add()] gibi o tipte çalışır. 
            List<string> sehirler = new List<string>(); // List burada bir classtır. 
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count); // count burada property dir. Mehtod olsaydı () ile kullanılırdı. 
                     

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
            
            

        }
    }

    class MyList<T> // <T> kullaımı ile classlar generic haline getirildi. 
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0]; // 0 elemanlı bir array oluşturuldu. 
        }
       
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1]; // Eleman sayısını arttırmak için yazılır ama yeni ref alındığından tüm datalar uçar. 
            for (int i = 0; i < _tempArray.Length; i++) // tempArray ın yedekte tuttuğu verilerin yeniden yüklenmesi için kullanılır. 
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
            
        public int Count
        {
            get { return _array.Length; }
           
        }

    }
}
