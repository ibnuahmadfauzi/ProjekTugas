using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modul7Searching
{
    class Binaryibnu
    {
        static void Main(String[] args)
        {
            int[] data = new int[8] { 81, 76, 21, 18, 16, 13, 10, 7 };
            int x = 100;
            squentialSearch(x, data);
            Console.ReadKey();
        }

        private static void squentialSearch(int x, int[] data)
        {
            int min = 0;
            int max = data.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (x == data[mid])
                {
                    Console.WriteLine("Index dengan value: " + x + " ditemukan pada array ke: " + mid);
                    break;
                }
                else if (data[mid] > x)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
        }
    }
}
