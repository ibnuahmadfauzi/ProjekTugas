using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modul8Ibnu
{
    class Bangunan
    {
        public Bangunan()
        {
            Console.WriteLine("Halo Ini Bangunan");
        }

        public Bangunan(int sisi)
        {
            Console.WriteLine("Luas bangunan: " + Math.Pow(sisi, 2));
        }

        public Bangunan(int panjang, int lebar)
        {
            Console.WriteLine("Luas Bangun: " + panjang * lebar);
        }

        public Bangunan(double alas = 0, double tinggi = 0, double setengah = 0.5)
        {
            Console.WriteLine("Luas Segitiga: " + (setengah * alas * tinggi));
        }

        public static void Main(string[] args)
        {
            Bangunan persegi = new Bangunan(5);
            Bangunan persegi_panjang = new Bangunan(2, 8);
            Bangunan bangunan_default = new Bangunan();
            Bangunan luas_segitiga = new Bangunan(20.0, 20.0);

            Console.ReadKey();
        }
    }
}
