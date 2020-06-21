using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace modul9ibnuu
{
  class BangunDatar
  {
    protected void HitungLuas(int sisi)
    {
      Console.WriteLine("Luas Persegi: " + Math.Pow(sisi, 2));
      }
        class Persegi : BangunDatar
      {
      public static void Main(string[] args)
      {
        Console.WriteLine("Nama : Ibnu Ahmad Fauzi");
        Console.WriteLine("Nim : 19104410028");
        Console.WriteLine("Kelas : TI B Semester 2\n");
        Persegi luas_persegi = new Persegi();
        luas_persegi.HitungLuas(5);
        Console.ReadKey();
      }
    }
  }
}
