using System;
using System.Collections.Generic;

namespace BAB1_BAB3
{
    internal class bab12
    {
        public static void Jalankan()
        {
            Console.WriteLine("=== BAB 12: ARRAY DAN KOLEKSI (Studi Kasus) ===");

            Console.WriteLine("1. Menyimpan nilai 10 siswa dalam array:");
            int[] nilaiSiswa = { 80, 75, 90, 85, 95, 88, 72, 91, 78, 84 };
            Console.WriteLine("   Tersimpan 10 nilai dalam array.");

            int tertinggi = nilaiSiswa[0], total = 0;
            foreach (int n in nilaiSiswa)
            {
                if (n > tertinggi) tertinggi = n;
                total += n;
            }
            Console.WriteLine($"\n2. Menghitung nilai tertinggi dan rata-rata:\n   Tertinggi: {tertinggi}\n   Rata-rata: {(double)total / nilaiSiswa.Length:F2}");

            Console.WriteLine("\n3. Mengelola daftar nama menggunakan List<T>:");
            List<string> daftarNama = new List<string> { "Jessica", "Rian" };
            daftarNama.Add("Citra");
            foreach (string nama in daftarNama)
            {
                Console.WriteLine($"   - {nama}");
            }

            // Mini Project
            Console.WriteLine("\n=== MINI PROJECT: HITUNG RATA-RATA NILAI ===\n");

            int[] nilai = { 75, 80, 90, 85, 70 };
            int totalNilai = 0;

            Console.WriteLine("Daftar nilai:");
            for (int i = 0; i < nilai.Length; i++)
            {
                Console.WriteLine($"Nilai ke-{i + 1}: {nilai[i]}");
                totalNilai += nilai[i];
            }

            double rataRata = (double)totalNilai / nilai.Length;

            Console.WriteLine("\n=== HASIL PERHITUNGAN ===");
            Console.WriteLine($"Total nilai    : {totalNilai}");
            Console.WriteLine($"Jumlah data    : {nilai.Length}");
            Console.WriteLine($"Rata-rata      : {rataRata:F2}");

            if (rataRata >= 75)
                Console.WriteLine("✅ Status: Lulus");
            else
                Console.WriteLine("❌ Status: Tidak Lulus");
        }
    }
}