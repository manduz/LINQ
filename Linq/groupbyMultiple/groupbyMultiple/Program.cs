using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupbyMultiple
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Sale> sales = new List<Sale>
            {
                new Sale { Product = "Laptop", Category = "Electronics", Quantity = 5 },
                new Sale { Product = "Phone", Category = "Electronics", Quantity = 10 },
                new Sale { Product = "Shirt", Category = "Clothing", Quantity = 20 },
                new Sale { Product = "Pants", Category = "Clothing", Quantity = 15 },
                new Sale { Product = "Laptop", Category = "Electronics", Quantity = 3 }
            };

            // Satışları hem ürüne hem de kategoriye göre gruplama ve her gruptaki toplam miktarı hesaplama
            var groupedSales = sales.GroupBy(s => new { s.Product, s.Category })
                                    .Select(group => new
                                    {
                                        Product = group.Key.Product,
                                        Category = group.Key.Category,
                                        TotalQuantity = group.Sum(s => s.Quantity)
                                    });
            foreach (var sale in groupedSales)
            {
                Console.WriteLine($"Product: {sale.Product}, Category: {sale.Category}, Total Quantity: {sale.TotalQuantity}");
            }
           // Console.ReadLine();

            //************************************//

            List<Person> people = new List<Person>
            {
                new Person 
                { 
                    Name = "Alice", Age = 25, City = "New York" 
                },
                new Person 
                {
                    Name = "Bob", Age = 30, City = "London" 
                },
                new Person 
                {
                    Name = "Charlie", Age = 25, City = "Paris" 
                },
                new Person 
                {
                    Name = "David", Age = 30, City = "New York" 
                },
                new Person 
                {
                    Name = "Eve", Age = 30, City = "Paris" 
                }
            };

            // Kişileri yaş ve şehirlerine göre gruplama ve grupları önce yaşa, sonra şehre göre sıralama
            var groupedPeople = people.GroupBy(p => new { p.Age, p.City })
                                      .OrderBy(group => group.Key.Age)
                                      .ThenBy(group => group.Key.City);


            foreach (var group in groupedPeople)
            {
                Console.WriteLine($" Age: {group.Key.Age}, City: {group.Key.City}");
                foreach (var person in group)
                {
                    Console.Write(" Name :"+person.Name);
                }

            }
            Console.ReadLine();
        }
    }
    class Sale
    {
        public string Product { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
    }


    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
