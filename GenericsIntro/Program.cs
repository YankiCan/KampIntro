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


        }
    }
}
