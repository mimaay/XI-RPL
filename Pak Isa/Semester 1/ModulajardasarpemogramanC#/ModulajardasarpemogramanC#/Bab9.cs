using System;

namespace BAB1_BAB3
{
    internal class bab9
    {
        public static void Jalankan()
        {
            Console.WriteLine("=== BAB 9: INPUT DAN OUTPUT (Studi Kasus) ===");

            Console.WriteLine("1. Buat program input biodata siswa[cite: 1]:");
            Console.Write("   Nama: "); string nama = Console.ReadLine();
            Console.Write("   Kelas: "); string kelas = Console.ReadLine();
            Console.WriteLine($"   Halo {nama} dari kelas {kelas}");

            Console.Write("\n2. Buat program menghitung luas persegi panjang dari input pengguna[cite: 1]:\n   Panjang: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("   Lebar: ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"   Luas = {p * l}");

            Console.WriteLine("\n3. Buat program menghitung rata-rata tiga nilai[cite: 1]:");
            Console.Write("   Nilai 1: "); double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("   Nilai 2: "); double n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("   Nilai 3: "); double n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"   Rata-rata = {(n1 + n2 + n3) / 3.0}");
        }
    }
}