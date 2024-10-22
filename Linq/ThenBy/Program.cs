using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThenBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ'de birden fazla kritere göre sıralama yapmak için kullanılır.
            //İlk sıralama eşitse, ikinci kriteri artan sırada sıralar.

            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Charlie", Age = 35 },
                new Person { Name = "Alice", Age = 40 }
            };
            // İlk olarak isme göre artan sırada, sonra yaşa göre artan sırada sıralama
            var orderedPeople = people.OrderBy(person => person.Name).ThenBy(person => person.Age);

            foreach (var item in orderedPeople)//item = people
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
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
