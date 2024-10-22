using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            //   IEnumerable<T>

            //IQueryable

            //obj list elemanlarını temsil eder. where ile koşul belirledik 
            //    var QuerySyntax = from obj in list where obj > 5 select obj;
            //veya

            //IEnumerable <int> QuerySyntax = from obj in list where obj > 5 select obj;

            //veya
            IQueryable<int> QuerySyntax = from obj in list.AsQueryable() where obj > 5 select obj;

            //

            foreach (var item in QuerySyntax)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
