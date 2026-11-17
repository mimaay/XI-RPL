using System;

namespace BAB1_BAB3
{
    internal class bab10
    {
        public static void Jalankan()
        {
            Console.WriteLine("=== BAB 10: PERCABANGAN PADA C# (Studi Kasus) ===");

            Console.Write("1. Buat program menentukan bilangan ganjil atau genap:\n   Masukkan angka: ");
            int angka = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("   " + (angka % 2 == 0 ? "Genap" : "Ganjil"));

            Console.Write("\n2. Buat program menghitung diskon berdasarkan total belanja:\n   Total belanja: ");
            double belanja = Convert.ToDouble(Console.ReadLine());
            double diskon = (belanja >= 100000) ? belanja * 0.1 : 0;
            Console.WriteLine($"   Diskon: {diskon}\n   Bayar: {belanja - diskon}");

            Console.Write("\n3. Buat program menentukan kategori nilai siswa:\n   Masukkan nilai: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 90) Console.WriteLine("   Kategori A");
            else if (n >= 80) Console.WriteLine("   Kategori B");
            else if (n >= 70) Console.WriteLine("   Kategori C");
            else Console.WriteLine("   Kategori D");

            // Mini Project
            Console.WriteLine("\n=== MINI PROJECT: CEK KELAYAKAN KTP ===\n");

            Console.Write("Masukkan Umur: ");
            int umur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=== HASIL CEK ===");
            if (umur >= 17)
            {
                Console.WriteLine("✅ Selamat! Anda Boleh membuat KTP");
                Console.WriteLine($"Umur Anda {umur} tahun, sudah memenuhi syarat.");
            }
            else
            {
                int kurang = 17 - umur;
                Console.WriteLine("❌ Maaf! Anda Belum memenuhi syarat");
                Console.WriteLine($"Umur Anda {umur} tahun, kurang {kurang} tahun lagi.");
            }
        }
    }
}