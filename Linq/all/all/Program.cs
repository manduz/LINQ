using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bir koleksiyondaki tüm elemanların belirtilen bir koşulu sağlayıp sağlamadığını kontrol etmek için kullanılır. Eğer tüm elemanlar koşulu sağlıyorsa true, aksi takdirde false döner. Bu metot, genellikle koşullu filtreleme yapmak istediğinizde kullanışlıdır.
            List<int> numbers = new List<int> { 2, 4, 6, 8 };

            // Tüm elemanların çift olup olmadığını kontrol eder
            bool allEven = numbers.All(num => num % 2 == 0);//hepsi her bir eleman 2 ye bölümünden kalan sıfır mı diye bakar

            Console.WriteLine(allEven); // Çıktı: True


            //***********************************************//

            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Charlie", Age = 35 }
            };

            // Tüm kişilerin 20 yaşından büyük olup olmadığını kontrol eder
            bool allOver20 = people.All(person => person.Age > 20);

            Console.WriteLine(allOver20); // Çıktı: True

            Console.ReadLine();
        }
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
