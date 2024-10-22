using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intersect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kesişim elemanlarını alır
            //tekrarlanan elemanlar kaldırırlır ama
            //metodu, iki koleksiyonun kesişimini alarak, her iki koleksiyonda bulunan benzersiz elemanları döndürü
            List<int> firstList = new List<int> { 1, 2, 3, 4, 5 };
            List<int> secondList = new List<int> { 4, 5,5, 6, 7, 8,8 };

            // İki liste arasındaki kesişimi bulur
            var result = firstList.Intersect(secondList);

            foreach (var num in result)
            {
                Console.WriteLine(num); // Çıktı: 4, 5
            }
            Console.ReadLine();
        }
    }
}
