using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace any
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Any() metodu, bir koleksiyonda belirtilen bir koşulu sağlayan en az bir elemanın olup olmadığını kontrol eder. Eğer en az bir eleman koşulu sağlıyorsa true, aksi takdirde false döner. Any() metodu, tüm koleksiyonu taramak yerine, ilk koşulu sağlayan elemanı bulduğunda işlemi durdurur, bu da performans açısından fayda sağlar.
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // En az bir elemanın tek olup olmadığını kontrol eder
            bool anyOdd = numbers.Any(num => num % 2 != 0);

            Console.WriteLine(anyOdd); // Çıktı: True


            //*********************************************//
            List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 },
            new Person { Name = "Charlie", Age = 35 }
        };

            // En az bir kişinin 30 yaşında olup olmadığını kontrol eder
            bool anyPersonIs30 = people.Any(person => person.Age == 30);

            Console.WriteLine(anyPersonIs30); // Çıktı: True

            Console.ReadLine();

        }
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
