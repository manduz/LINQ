using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distinct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Distinct() metodu, bir koleksiyondaki benzersiz elemanları döndürmek için kullanılır.
            // tekrarlanan elemanları kaldırarak, yalnızca her elemandan bir tane döndürür.
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

            // Tekrarlanan elemanları kaldırarak benzersiz elemanları döndürür
            var distinctNumbers = numbers.Distinct();

            foreach (var num in distinctNumbers)
            {
                Console.WriteLine(num); // Çıktı: 1, 2, 3, 4, 5
            }
            Console.ReadLine();

        }
    }
}
