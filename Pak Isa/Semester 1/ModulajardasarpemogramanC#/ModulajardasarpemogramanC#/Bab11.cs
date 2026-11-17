using System;

namespace BAB1_BAB3
{
    internal class bab13
    {
        // METHOD-METHODNYA
        static double LuasPersegiPanjang(double p, double l) => p * l;
        static double LuasLingkaran(double r) => 3.14 * r * r;
        static string CekGenapGanjil(int angka) => (angka % 2 == 0) ? "Genap" : "Ganjil";

        public static void Jalankan()
        {
            Console.WriteLine("=== BAB 13: METHOD / FUNGSI (Studi Kasus) ===\n");

            // ===== 1. LUAS PERSEGI PANJANG =====
            Console.WriteLine("1. Menghitung Luas Persegi Panjang");
            Console.Write("   Masukkan panjang: ");
            double panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("   Masukkan lebar: ");
            double lebar = Convert.ToDouble(Console.ReadLine());
            double luasPP = LuasPersegiPanjang(panjang, lebar);
            Console.WriteLine($"   ✅ Luas persegi panjang = {luasPP}\n");

            // ===== 2. LUAS LINGKARAN =====
            Console.WriteLine("2. Menghitung Luas Lingkaran");
            Console.Write("   Masukkan jari-jari: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double luasLing = LuasLingkaran(r);
            Console.WriteLine($"   ✅ Luas lingkaran = {luasLing}\n");

            // ===== 3. CEK GANJIL GENAP =====
            Console.WriteLine("3. Menentukan Bilangan Ganjil/Genap");
            Console.Write("   Masukkan angka: ");
            int angka = Convert.ToInt32(Console.ReadLine());
            string hasil = CekGenapGanjil(angka);
            Console.WriteLine($"   ✅ {angka} adalah {hasil}\n");

            Console.WriteLine("--- Tekan ENTER untuk kembali ke menu utama ---");
            Console.ReadLine();
        }
    }
}