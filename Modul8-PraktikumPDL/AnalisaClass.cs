class Mobil
{
   String warna; // Atribut warna
   int roda; // Atribut roda
   int tahun; // Atribut tahun

   public static void Main(string[] args)
   {
        Mobil toyota = new Mobil(); // Membuat objek mobil toyota
        toyota.warna = "kuning"; // Menambahkan nilai atribut warna pada mobil toyota
        toyota.roda = 4; // Menambahkan nilai atribut roda pada mobil toyota
        toyota.tahun = 2002; // Menambahkan nilai atribut tahun pada mobil toyota

        Mobil honda = new Mobil(); // Membuat objek mobil honda
        honda.warna = "hijau"; // Menambahkan nilai atribut warna pada mobil honda
        honda.roda = 6; // Menambahkan nilai atribut roda pada mobil honda
        honda.tahun = 2005; // Menambahkan nilai atribut tahun pada mobil honda

        // Menampilkan objek dan atribut-atributnya
        Console.WriteLine("Toyota berwarna: " + toyota.warna + " memiliki roda: " + toyota.roda + " memiliki tahun: " + toyota.tahun);
        Console.WriteLine("Honda berwarna: " + honda.warna + " memiliki roda: " + honda.roda + " memiliki tahun: " + honda.tahun);

        Console.ReadKey();
    }
}
