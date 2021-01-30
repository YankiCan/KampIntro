using System;

namespace _03_ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Yankı";
            int yas = 25;

            Kurs kurs1 = new Kurs(); // Kurs tipi class içinde birden fazla eleman içerir.
            kurs1.Kursadi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs(); 
            kurs2.Kursadi = "Java";
            kurs2.Egitmen ="Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.Kursadi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            // Console.WriteLine(kurs1.Kursadi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Kursadi + " : " + kurs.Egitmen + " , " + kurs.IzlenmeOrani + " % ");
            }
        }
    }

    // class + tabtab
    class Kurs
    {
        public string Kursadi { get; set; } // prob + tabtab
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}


// Class kendi veri tipini oluşturmak için kullanılır. 
// string adi = "Yankı"; der gibi Kurs kurs1; gibi veri tipi de oluşturmak mümkündür.
// Bunun için öncelikle Kurs veri tipinin tanıtılması için class oluşturulur. 