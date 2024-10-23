using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDictinnary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //anahtarlar benzersiz olmalıdır.
            //ToDictionary() bir koleksiyondan bir sözlük (Dictionary) oluşturmanızı sağlar.
            //Bu metod, sorgu sonucunda her öğeyi bir anahtar ve bir değer ile ilişkilendirir.
            //bir koleksiyon kişilerin adlarını anahtar, yaşlarını değer olarak kullanarak bir sözlük oluşturuyor.
            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 30 },
                new Person { Name = "Charlie", Age = 35 }
            };

            // Kişileri isimlerini anahtar, yaşlarını değer olarak kullanarak bir sözlük oluşturma
            Dictionary<string, int> peopleDictionary = people.ToDictionary(p => p.Name, p => p.Age);

            foreach (var kvp in peopleDictionary)
            {
                Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
            }
            Console.ReadLine();
        }

    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
