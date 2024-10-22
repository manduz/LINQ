using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOfType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bir koleksiyonun veya sorgunun yalnızca belirli bir türe (tip) ait olan elemanlarını filtrelemek için kullanılır.
            ArrayList mixedList = new ArrayList();
            mixedList.Add(1);
            mixedList.Add("string");
            mixedList.Add(2.5);
            mixedList.Add(3);
            mixedList.Add("another string");

            // Sadece tamsayıları (int) seçmek için OfType<T> kullanımı
            IEnumerable<int> onlyIntegers = mixedList.OfType<int>();

            foreach (var num in onlyIntegers)
            {
                Console.WriteLine(num); // Sadece int türündeki öğeleri yazdırır: 1, 3
            }
            Console.ReadLine();
        }
    }
}
