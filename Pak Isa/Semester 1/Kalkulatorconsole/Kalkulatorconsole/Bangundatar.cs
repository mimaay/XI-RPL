using System;

namespace Kalkulatorconsole
{
    public class BangunDatar
    {
        // ===== PERSEGI =====
        public double LuasPersegi(double sisi)
        {
            return sisi * sisi;
        }

        public double KelilingPersegi(double sisi)
        {
            return 4 * sisi;
        }

        // ===== PERSEGI PANJANG =====
        public double LuasPersegiPanjang(double panjang, double lebar)
        {
            return panjang * lebar;
        }

        public double KelilingPersegiPanjang(double panjang, double lebar)
        {
            return 2 * (panjang + lebar);
        }

        // ===== SEGITIGA =====
        public double LuasSegitiga(double alas, double tinggi)
        {
            return 0.5 * alas * tinggi;
        }

        public double KelilingSegitiga(double sisi1, double sisi2, double sisi3)
        {
            return sisi1 + sisi2 + sisi3;
        }

        // ===== LINGKARAN =====
        public double LuasLingkaran(double jariJari)
        {
            return Math.PI * jariJari * jariJari;
        }

        public double KelilingLingkaran(double jariJari)
        {
            return 2 * Math.PI * jariJari;
        }

        // Method untuk menjalankan bangun datar
        public void JalankanBangunDatar()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║         BANGUN DATAR               ║");
            Console.WriteLine("╚════════════════════════════════════╝");

            try
            {
                Console.WriteLine("\nPilih bangun datar:");
                Console.WriteLine("1. Persegi");
                Console.WriteLine("2. Persegi Panjang");
                Console.WriteLine("3. Segitiga");
                Console.WriteLine("4. Lingkaran");
                Console.Write("Pilihan Anda (1-4): ");
                int pilihan = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n════════════════════════════════════════════");

                switch (pilihan)
                {
                    case 1: // Persegi
                        Console.Write("Masukkan sisi: ");
                        double sisi = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"\n📐 Luas Persegi      : {LuasPersegi(sisi)}");
                        Console.WriteLine($"📏 Keliling Persegi  : {KelilingPersegi(sisi)}");
                        break;

                    case 2: // Persegi Panjang
                        Console.Write("Masukkan panjang: ");
                        double panjang = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan lebar  : ");
                        double lebar = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"\n📐 Luas Persegi Panjang      : {LuasPersegiPanjang(panjang, lebar)}");
                        Console.WriteLine($"📏 Keliling Persegi Panjang  : {KelilingPersegiPanjang(panjang, lebar)}");
                        break;

                    case 3: // Segitiga
                        Console.Write("Masukkan alas  : ");
                        double alas = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan tinggi: ");
                        double tinggi = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan sisi 1: ");
                        double sisi1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan sisi 2: ");
                        double sisi2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan sisi 3: ");
                        double sisi3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"\n📐 Luas Segitiga     : {LuasSegitiga(alas, tinggi)}");
                        Console.WriteLine($"📏 Keliling Segitiga : {KelilingSegitiga(sisi1, sisi2, sisi3)}");
                        break;

                    case 4: // Lingkaran
                        Console.Write("Masukkan jari-jari: ");
                        double jariJari = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"\n📐 Luas Lingkaran     : {LuasLingkaran(jariJari)}");
                        Console.WriteLine($"📏 Keliling Lingkaran : {KelilingLingkaran(jariJari)}");
                        break;

                    default:
                        Console.WriteLine("\n❌ Pilihan tidak valid!");
                        break;
                }

                Console.WriteLine("════════════════════════════════════════════");
            }
            catch (FormatException)
            {
                Console.WriteLine("\n❌ ERROR: Masukkan angka yang valid!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n❌ ERROR: {ex.Message}");
            }

            Console.WriteLine("\nTekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }
    }
}