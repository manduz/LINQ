using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toList_toArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ToList() ve ToArray() metotları, sorgu sonucunda elde edilen verileri liste ya da dizi (array) tipine dönüştürmek için kullanılır.

            int[] numbers = { 1, 2, 3, 4, 5 };

            


            // LINQ sorgusu: Çift sayıları bul ve bir listeye dönüştür
            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number); // Çıktı: 2, 4
            }

            ///*************************//
            ///
            int[] numbers2 = { 10, 20, 30, 40, 50 };

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            //int [ numberList = numbers.toArray();


            // LINQ sorgusu: Çift sayıları bul ve bir diziye dönüştür
            int[] evenNumbersArray = numbers2.Where(n => n % 2 == 0).ToArray();

            foreach (var number in evenNumbersArray)
            {
                Console.WriteLine(number); 
            }

            Console.ReadLine();

        }
    }
}
