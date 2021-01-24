using System;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;
            var result = Add(ref number1, number2);
            Console.WriteLine(result); // = 130 (Değer tip referans tipe dönüştürüldüğünden yeni değer baz alınır.)
            Console.WriteLine(number1); // =30 (Ref kullanıldığında değer referans tip özelliğinden değer 30 olur. )

        }

        static int Add(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

    }
}
