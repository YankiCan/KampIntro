using System;

namespace HWArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Engin";
            //string student2 = "Derin";
            //string student3 = "Salih";

            //string[] students = new string[3];
            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Salih";

            string[] students = { "Engin", "Derin", "Salih" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
    }
}

 