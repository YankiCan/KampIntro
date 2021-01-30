using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_02_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();

            Add2(20, 30);
            var result = Add2(4); // number2=30 tanımlaması yapıldığından dolayı bir daha yazılmasına gerek yoktur.
            Console.WriteLine(result);


            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2); // method cw den önce yazıldığından 30 değeri baz alınır, toplam 130 olur.
            Console.WriteLine(result2);
            Console.WriteLine(number1); // Değer tip olduğundan sonucu hala 20 dir. ref kullanıldığında değer 30 olur. 


            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 3));

            Console.WriteLine(Add4(1,2,3,4,5,6));

            Console.ReadLine(); // ???
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

       
        // void yerine sayılarla işlem yapılacağı için int yazılmalıdır.
        static int Add2(int x, int number1=20, int number2=30)  
            // Yalnızca 2. sayıya değer ataması yapılabilir, ya da daha fazka sayı toplamlarında baştaki sayı hariç diğerlerine değerler atanabilir. 
        {
            var result = x + number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2) // ref number1 değerinin komple değişmesine yol açar. 
            // (Her iki tarafta) ref yerine out da kullanılabilir. Mantık olarak aynıdır. 
            // ref kullanırken number1 = 20 değeri belirtilmiş olmak zorundayken, out kullanımında number1 değeri belirtilmek zorunda değil. 
        {
            number1 = 30; // Bu değer atandığında number1 = 20 ataması geçersiz kılınır, 30 değeri baz alınır.
            return number1 + number2;
        }

        static int Multiply(int number1, int number2) // Metodun imzasıdır. 
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3) // Aynı mehtod ismiyle farklı parametreler kullanmakta bir sıkıntı yoktur. 
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers) // Çokça sayıyı aynı anda toplamak için kullanılır. 
        // params başına int number1 gibi başka bir sayı daha eklenebilir. Sonuna ekleme yapılamazi params son parametre olmak zorundadır. 
        // return kısmında number1 olarak yeniden yazılmadığı takdirde, yukarıdaki toplamda ilk sayıyı dikkate almaz. 
        {
            return numbers.Sum(); // Sum bir fonksiyondur, hazır metodlardan biridir. 
        }
    }
}
