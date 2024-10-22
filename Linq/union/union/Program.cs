using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace union
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // iki koleksiyondaki tüm elemanları birleştirir ve yalnızca benzersiz olanları döndürür. Yani, iki koleksiyonda yer alan her bir eleman yalnızca bir kez döner. Bu metod, kümeler üzerinde birleşim işlemi yapar ve her iki koleksiyonda yer alan tekrarlanan elemanları otomatik olarak filtreler.
            List<int> firstList = new List<int> { 1, 2, 3, 4, 5 };
            List<int> secondList = new List<int> { 4, 5, 6, 7, 8 };

            // İki listeyi birleştirir ve benzersiz elemanları döndürür
            var result = firstList.Union(secondList);

            foreach (var num in result)
            {
                Console.WriteLine(num); // Çıktı: 1, 2, 3, 4, 5, 6, 7, 8
            }
            Console.ReadLine();
        }
    }
}
