// SOAL :
// Buatlah program untuk memasukkan 1 data mahasiswa menggunakan scanner
// kemudian tampilkan hasilnya. Berikut ketentuan yang harus ada di programmnya:
// - Buat class dengan nama DataPerson()
// - Buat variable instance dengan atribut: nama, nim, prodi, alamat, no_telpon (sesuaikan dengan data personil masing-masing).
// - Buatlah method dengan nama FillData() untuk mengisi data mahasiswa
// - Buatlah method dengan nama ShowData() untuk menampilkan data mahasiswa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modul8Ibnu
{
    class DataPerson // Membuat class
    {
        // instance atribut
        public string nama;
        public string nim;
        public string prodi;
        public string alamat;
        public string no_telpon;

        public void FillData()
        {
            // Input Data Mahasiswa
            Console.WriteLine();
            Console.WriteLine("          Input Data Mahasiswa         ");
            Console.WriteLine(" --------------------------------------");
            Console.Write(" Nama      = ");
            this.nama = Console.ReadLine();
            Console.Write(" NIM       = ");
            this.nim = Console.ReadLine();
            Console.Write(" Prodi     = ");
            this.prodi = Console.ReadLine();
            Console.Write(" Alamat    = ");
            this.alamat = Console.ReadLine();
            Console.Write(" No Telpon = ");
            this.no_telpon = Console.ReadLine();
            Console.WriteLine(" --------------------------------------");
            Console.Write("\n press any key to continue this program ...");
            Console.ReadKey();
        }

        public void ShowData()
        {
            // Membuat object input data mahasiswa
            DataPerson Tampil = new DataPerson();
            Tampil.FillData(); // Menampilkan object input data mahasiswa

            Console.Clear(); // Membersihkan Layar Console
            Console.WriteLine();
            // Menampilkan data mahasiswa yang sudah di input melalui method FillData
            Console.WriteLine("         Output  Data Mahasiswa        ");
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine(" Nama      : " + Tampil.nama);
            Console.WriteLine(" Nim       : " + Tampil.nim);
            Console.WriteLine(" Prodi     : " + Tampil.prodi);
            Console.WriteLine(" Alamat    : " + Tampil.alamat);
            Console.WriteLine(" No Telpon : " + Tampil.no_telpon);
            Console.WriteLine(" --------------------------------------");
        }

        public void IdentitasProgram() // Method untuk memberikan identitas program
        {
            Console.WriteLine();
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine("                TUGAS 08               ");
            Console.WriteLine("      Praktikum Pemrograman Lanjut     ");
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine(" Nama           : Ibnu Ahmad Fauzi     ");
            Console.WriteLine(" Nim            : 19104410028          ");
            Console.WriteLine(" Kelas          : TI B Semester 2      ");
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            DataPerson Identitas = new DataPerson(); // Membuat object untuk method IdentitasProgram
            DataPerson TampilData = new DataPerson(); // Membuat object untuk method ShowData

            Identitas.IdentitasProgram(); // Menampilkan Method IdentitasProgram

            Console.Write(" press any key to continue this program... ");
            Console.ReadKey();

            Console.Clear(); // Membersihkan Layar Console

            TampilData.ShowData(); // Menampilkan method ShowData

            Console.ReadKey();
        }
    }
}
