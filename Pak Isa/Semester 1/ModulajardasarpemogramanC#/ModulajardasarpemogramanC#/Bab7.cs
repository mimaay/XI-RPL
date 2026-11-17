using System;

namespace BAB1_BAB3
{
    internal class bab7
    {
        public static void Jalankan()
        {
            Console.WriteLine("=== BAB 7: VARIABEL DAN TIPE DATA C# (Studi Kasus) ===");

            Console.Write("1. Program menghitung luas persegi[cite: 1]\n   Masukkan sisi persegi: ");
            int sisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"   Luas Persegi = {sisi * sisi}");

            Console.Write("\n2. Program menghitung umur berdasarkan tahun lahir[cite: 1]\n   Masukkan tahun lahir: ");
            int tahunLahir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"   Umur = {2026 - tahunLahir} tahun");

            Console.WriteLine("\n3. Program input nama, kelas, dan jurusan[cite: 1]:");
            Console.Write("   Nama: "); string nama = Console.ReadLine();
            Console.Write("   Kelas: "); string kelas = Console.ReadLine();
            Console.Write("   Jurusan: "); string jurusan = Console.ReadLine();
            Console.WriteLine($"   Data: {nama} - {kelas} {jurusan}");
        }
    }
}