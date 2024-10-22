using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reverse(): Bir koleksiyonun mevcut sırasını tersine çevirir
            int[] intArray = new int[] {10,20,30,40,50};
            Console.WriteLine("Reverse kullanmadan önce");

            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
            var ReverseArray = intArray.Reverse();
            Console.WriteLine("Reverse kullandıktan sonra");

            foreach (var item in ReverseArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
