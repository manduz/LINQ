using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //metodları, bir koleksiyonun öğelerini belirli bir kriter (anahtar) ile sıralamak için kullanılır
            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David" };

            // İsimleri alfabetik olarak sıralar
            var orderedNames = names.OrderBy(name => name);

            foreach (var name in orderedNames)
            {
                Console.WriteLine(name); // Alice, Bob, Charlie, David
            }
        

            ////////////ornek2
            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Charlie", Age = 35 }
            };

            // Yaşa göre artan sırada sıralama
            var orderedByAge = people.OrderBy(person => person.Age);

            foreach (var person in orderedByAge)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
         

            // İlk olarak isme göre, sonra yaşa göre sıralama
            var orderedPeople = people.OrderBy(person => person.Name)
                                 .ThenBy(person => person.Age);

            foreach (var person in orderedPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
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
