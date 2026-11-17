using System;

namespace BAB1_BAB3
{
    // Class-class untuk studi kasus
    class SiswaObj
    {
        public string Nama { get; set; }
        public int Nilai { get; set; }
    }

    class PersegiPanjangObj
    {
        public double P { get; set; }
        public double L { get; set; }
        public double Luas() => P * L;
    }

    class RekeningObj
    {
        private double saldo = 0;
        public void Setor(double jumlah) => saldo += jumlah;
        public double Saldo() => saldo;
    }

    // Class Mobil untuk Mini Project
    class Mobil
    {
        public string Merk { get; set; }
        public string Warna { get; set; }
        public int Tahun { get; set; }

        public void Jalan()
        {
            Console.WriteLine($"🚗 {Merk} ({Warna}, {Tahun}) sedang berjalan...");
        }

        public void Informasi()
        {
            Console.WriteLine("\n=== INFORMASI MOBIL ===");
            Console.WriteLine($"Merk   : {Merk}");
            Console.WriteLine($"Warna  : {Warna}");
            Console.WriteLine($"Tahun  : {Tahun}");
        }
    }

    internal class bab14
    {
        public static void Jalankan()
        {
            Console.WriteLine("=== BAB 14: OBJECT-ORIENTED PROGRAMMING (Studi Kasus) ===");

            // Studi Kasus 1
            SiswaObj s = new SiswaObj { Nama = "Rian", Nilai = 90 };
            Console.WriteLine($"1. Objek Siswa -> Nama: {s.Nama}, Nilai: {s.Nilai}");

            // Studi Kasus 2
            PersegiPanjangObj pp = new PersegiPanjangObj { P = 8, L = 5 };
            Console.WriteLine($"2. Objek Persegi Panjang -> Luas: {pp.Luas()}");

            // Studi Kasus 3
            RekeningObj rek = new RekeningObj();
            rek.Setor(500000);
            Console.WriteLine($"3. Objek Rekening -> Saldo: {rek.Saldo()}");

            // Mini Project Mobil
            Console.WriteLine("\n=== MINI PROJECT: DEMO MOBIL OOP ===\n");
            MiniProjectMobil();
        }

        public static void MiniProjectMobil()
        {
            Mobil mobil1 = new Mobil();
            mobil1.Merk = "Toyota";
            mobil1.Warna = "Merah";
            mobil1.Tahun = 2020;

            mobil1.Informasi();
            mobil1.Jalan();

            Console.WriteLine("\n--- Mobil kedua ---");
            Mobil mobil2 = new Mobil();
            mobil2.Merk = "Honda";
            mobil2.Warna = "Hitam";
            mobil2.Tahun = 2022;

            mobil2.Informasi();
            mobil2.Jalan();
        }
    }
}