using System;

namespace BAB1_BAB3
{
    internal class bab6
    {
        public static void Jalankan()
        {
            Console.WriteLine("=== BAB 6: STRUKTUR DASAR PROGRAM C# (Studi Kasus) ===");

            Console.WriteLine("1. Program yang menampilkan nama sekolah[cite: 1]:");
            Console.WriteLine("   SMK Jurusan Rekayasa Perangkat Lunak Sidoarjo");

            Console.Write("\n2. Meminta nama pengguna lalu menampilkan sapaan[cite: 1]:\n   Masukkan nama Anda: ");
            string nama = Console.ReadLine();
            Console.WriteLine("   Halo " + nama);

            Console.WriteLine("\n3. Menampilkan tiga baris informasi menggunakan Console.WriteLine()[cite: 1]:");
            Console.WriteLine("   Baris 1: Visual Studio Community siap digunakan");
            Console.WriteLine("   Baris 2: Pemrograman Dasar C#");
            Console.WriteLine("   Baris 3: Semangat mengerjakan tugas!");
        }
    }
}