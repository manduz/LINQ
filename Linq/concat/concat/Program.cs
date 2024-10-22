using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Concat() metodu, iki koleksiyonu uç uca ekleyerek yeni bir koleksiyon oluşturur. Concat() ile iki koleksiyonu birleştirdiğinizde, her iki koleksiyonun da tüm elemanları sırasıyla sonuç koleksiyonunda yer alır. Ancak, Union() metodunun aksine, Concat() metodunda tekrarlanan elemanlar filtrelenmez. Yani, iki koleksiyondaki elemanlar birebir sonuç koleksiyonuna eklenir.
            List<int> firstList = new List<int> { 1, 2, 3 };
            List<int> secondList = new List<int> { 2,3,4, 5, 6 };

            // İki listeyi uç uca ekler
            //union gibi yapmaz. concat bütün tekrarlı elemanları yine alır
            var result = firstList.Concat(secondList);

            foreach (var num in result)
            {
                Console.WriteLine(num); 
            }
            Console.ReadLine();
        }
    }
}
