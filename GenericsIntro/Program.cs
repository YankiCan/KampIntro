using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); // Arka planda yazılan T burada string olarak kodlanmış oldu. 
            // MyList burada arka planda bir array yönetir. 
            isimler.Add("Engin");
            Console.WriteLine(isimler.Length);

            isimler.Add("Kerem");
            Console.WriteLine(isimler.Length); // 1 ve 2 yazılması elemanların eklediğini gösterir. 

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim); // Yazılan isimleri gösterir. 
            }


        }
    }
}
