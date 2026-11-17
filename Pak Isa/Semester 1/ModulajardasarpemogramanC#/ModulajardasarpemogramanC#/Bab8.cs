using System;

namespace BAB1_BAB3
{
    internal class bab8
    {
        public static void Jalankan()
        {
            Console.WriteLine("=== BAB 8: OPERATOR DALAM C# (Studi Kasus) ===");

            // Mini Project: Hitung Total Belanja
            Console.WriteLine("=== MINI PROJECT: HITUNG TOTAL BELANJA ===\n");

            Console.Write("Harga Barang : ");
            double harga = Convert.ToDouble(Console.ReadLine());

            Console.Write("Jumlah : ");
            int jumlah = Convert.ToInt32(Console.ReadLine());

            double total = harga * jumlah;

            Console.WriteLine("\n=== RINCIAN BELANJA ===");
            Console.WriteLine($"Harga per item : Rp {harga:N0}");
            Console.WriteLine($"Jumlah item   : {jumlah}");
            Console.WriteLine($"Total belanja : Rp {total:N0}");

            Console.WriteLine("\n--- Studi Kasus Lainnya ---\n");

            Console.Write("2. Tentukan apakah siswa lulus berdasarkan nilai\n   Masukkan nilai: ");
            int nilai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("   Status: " + (nilai >= 75 ? "Lulus" : "Tidak Lulus"));

            Console.Write("\n3. Hitung sisa pembagian menggunakan operator modulus\n   Angka 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("   Angka 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"   Sisa bagi ({a} % {b}) = {a % b}");
        }
    }
}