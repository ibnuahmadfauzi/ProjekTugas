using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modul9ibnu
{
    class ContohMethod
    {
        static void namaBarang(String inputNama)
        {
            Console.WriteLine("Nama Barang: " + inputNama);
        }

        static double hargaBarang(double inputHarga)
        {
            Console.WriteLine("Harganya: " + inputHarga + " juta");
            return 0;
        }

        static void Main(string[] args)
        {
            namaBarang("Samsung Gear");
            hargaBarang(3.8);
            Console.ReadKey();
        }
    }
}
