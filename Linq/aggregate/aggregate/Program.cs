using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aggregate() metodu, bir koleksiyondaki elemanları belirli bir işlem üzerinden birleştirmek (reduce) için kullanılır. Bu metodun mantığı, koleksiyondaki her elemanı sırayla alarak bir "kümülatif" işlem gerçekleştirmektir. Aggregate(), genellikle bir koleksiyondaki elemanlar üzerinde toplama, çarpma, birleştirme gibi işlemleri yapmak için kullanılır.
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Aggregate ile sayıları toplama
            int sum = numbers.Aggregate((total, next) => total + next);
            int sum2 = numbers.Aggregate(10, (total, next) => total + next);
            //  numbers.Sum();
            int max = (from x in numbers select x).Max();
            int min = (from x in numbers select x).Min();

            Console.WriteLine("max deger : "+ max);
            Console.WriteLine("min deger : "+ min);
            Console.WriteLine(sum); // Çıktı: 15
            Console.WriteLine(sum2); //Çıktı : 25


            //*********************************//

            List<string> words = new List<string> { "Hello", "World", "LINQ", "is", "awesome" };

            // Tüm kelimeleri boşluk ile birleştirme
            string sentence = words.Aggregate((current, next) => current + " " + next); //current 1. elemen, next 2. eleman

            Console.WriteLine(sentence); // Çıktı: "Hello World LINQ is awesome"

            Console.ReadLine();
        }
    }
}
