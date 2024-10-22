using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace except
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //metodu küme mantığı ile çalışır
            // Except() metodu, bir koleksiyondaki elemanları diğer bir koleksiyonla karşılaştırarak, ilk koleksiyonda olup ikinci koleksiyonda olmayan elemanları döndürür. Yani, iki koleksiyon arasındaki farkı alır.
            List<int> firstList = new List<int> { 1, 2, 3, 4, 5 };
            List<int> secondList = new List<int> { 3, 4, 5, 6, 7 };

            // firstList'te olup secondList'te olmayan elemanlar
            var result = firstList.Except(secondList);

            foreach (var num in result)
            {
                Console.WriteLine(num); // Çıktı: 1, 2
            }
            Console.ReadLine();
        }
    }
}
