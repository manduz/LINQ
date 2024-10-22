using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByDescending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OrderBy: Koleksiyonu artan sıraya göre sıralar (küçükten büyüğe veya A'dan Z'ye).
            //OrderByDescending = Koleksiyonu azalan sıraya göre sıralar (büyükten küçüğe veya Z'den A'ya).
            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David" };

            // İsimleri ters alfabetik sıraya göre sıralar
            var descendingNames = names.OrderByDescending(name => name);

            foreach (var name in descendingNames)
            {
                Console.WriteLine(name); // David, Charlie, Bob, Alice
            }
            Console.ReadLine();
        }
    }
}
