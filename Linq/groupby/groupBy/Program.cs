using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GroupBy() metodu, bir koleksiyondaki elemanları belirli bir kritere göre gruplamak için kullanılır. Bu metot, aynı anahtar değere sahip elemanları gruplar ve her grup için bir koleksiyon döndürür. Her bir grup, bir anahtar (Key) ve bu anahtara sahip elemanlardan oluşan bir koleksiyon içerir.
            //Sayıları Gruplama

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Sayıları çift ve tek olmasına göre gruplama
            var groupedNumbers = numbers.GroupBy(num => num % 2 == 0 ? "Çift" : "Tek");

            foreach (var group in groupedNumbers)
            {
                Console.WriteLine($"{group.Key} Sayılar:");
                foreach (var number in group)
                {
                    Console.WriteLine(number); // Her grup için sayılar yazdırılır
                }
             //   Console.ReadLine();
            }

            //*************************************//
            //yaşlara göre gruplandırma
            List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 20 },
            new Person { Name = "Charlie", Age = 25 },
            new Person { Name = "David", Age = 30 }
        };

            // Kişileri yaşlarına göre gruplama
            var groupedPeople = people.GroupBy(person => person.Age);

            foreach (var group in groupedPeople)
            {
                Console.WriteLine($"Yaş: {group.Key}");
                foreach (var person2 in group)
                {
                    Console.WriteLine(person2.Name); // Aynı yaşa sahip kişiler yazdırılır
                }
                Console.ReadLine();
            }


        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
