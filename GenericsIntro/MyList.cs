using System;
using System.Collections.Generic;
using System.Text;

namespace _09_GenericsIntro
{
    class MyList<T> // Type - Generic 1 tane değer alıyorsa T olarak yazılır. Verilen tipe göre aşağısındaki kodlar yapılandırılır. 
    {
        T[] items; // methodun dışında, class içerisine yazılır, bu her yerden erişilme imkanı sağlar. 
        // class new lendiğinde T items array oluşturulmalıdır. 
        // Add içerisine T items elemanlarını eklemek için class ın new lenmesi gerekmektedir. 
       
        // constructor - Bir class new lendiğinde çalışan bloktur.
        public MyList() //  ctor tabtab - class new lendiğinde otomatik çalışır.
        {
            items = new T[0];
        }

        // Artık 0 elemanlı bir dizi mevcuttur ve Ad altında elemanlar eklenebilir. 
        public void Add(T item) // T istediğimiz türe (string, int, oluşturulan classlar vs) göre çalışır. Item yerine herhangi bir şey yazılabilir. 
        {
            T[] tempArray = items; // geçiçi dizi - alt satırdaki gibi yeni bir ref oluşturulduğunda eski kaynağın korunmasını sağlar. Ref numarasını geçici olarak tutar. 
            items = new T[items.Length+1]; // Dizinin eleman sayısını 1 arttırır. 
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // tempArray ın geçiçi tuttuğu elemanlar sırasıyla items a yeniden alınır. items eski değerlerine kavuşur. 
            }

            items[items.Length - 1] = item; // -1 olmasının sebebi eleman sayısı 0 dan başladığından items uzunluğunun bir eksiği olması gerektiğidir. 
            // Eklenmek istenen eleman bu kod ile eklenebilir. 

        }

        public int Length // Henüz bu yapıyı öğrenmedik, kodu test etmek için kullanıyoruz! Eleman sayısını verir.
        {
            get { return items.Length; }
        }

        public T[] Items // Elemanları görmek için kullanılır. 
        {
            get { return items; }
        }

    }
}

// Listenin arkasında bir array oluşturmak için 