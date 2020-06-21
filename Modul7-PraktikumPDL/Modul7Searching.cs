using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Modul7Searching
{
  class Binaryibnu
  {
    static void Main()
    {
      Console.WriteLine("\n\t========= BINARY SEARCH =========");
      Console.WriteLine("\t----------------------------------");
      Console.WriteLine("\tNama : Ibnu Ahmad Fauzi");
      Console.WriteLine("\tNIM : 19104410028");
      Console.WriteLine("\tKelas : TI-B Semester 2\n\n");
      binaryIbnu();
    }
    public static void binaryIbnu()
    {
      int[] data = new int[9] {10,12,20,32,50,55,65,80,99};
      int x = 80;
      int min = 0;
      int max = data.Length - 1;
      while (min <= max)
      {
        int mid = (min + max) / 2;
        if (x < data[mid])
        {
        max = mid - 1;
        }
       else if (x > data[mid])
        {
        min = mid + 1;
        }
        else if (x == data[mid])
        {
        Console.WriteLine("\t----------------------------------");
        Console.WriteLine("\tIndex dengan value : " + x);
        Console.WriteLine("\tDitemukan pada indek : ke-" + mid);
        Console.WriteLine("\t----------------------------------");
        Console.Write("\n\n\tpress ENTER to continue this program ...");
        Console.ReadKey();
        return;
        }
      }
      Console.WriteLine("\t----------------------------------");
      Console.WriteLine("\t Data tidak ditemukan ");
      Console.WriteLine("\t Di Index manapun ");
      Console.WriteLine("\t----------------------------------");
      Console.Write("\n\n\tpress ENTER to continue this program ...");
      Console.ReadKey();
    }
  }
}
