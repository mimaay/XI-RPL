using System;

namespace Kalkulatorconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Buat objek dari semua class
            Kalkulator kalkulator = new Kalkulator();
            BangunDatar bangunDatar = new BangunDatar();
            BangunRuang bangunRuang = new BangunRuang();
            Zodiac zodiac = new Zodiac();

            int pilihan;

            do
            {
                Console.Clear();
                Console.WriteLine("============================================");
                Console.WriteLine("             MAGIC CALCULATOR");
                Console.WriteLine("============================================");
                Console.WriteLine();
                Console.WriteLine("Pilih Menu:");
                Console.WriteLine("1. Kalkulator Sederhana");
                Console.WriteLine("2. Bangun Datar (Luas & Keliling)");
                Console.WriteLine("3. Bangun Ruang (Volume & Luas Permukaan)");
                Console.WriteLine("4. Cek Zodiac");
                Console.WriteLine("5. Keluar");
                Console.WriteLine("============================================");
                Console.Write("Pilihan Anda (1-5): ");

                try
                {
                    pilihan = Convert.ToInt32(Console.ReadLine());

                    switch (pilihan)
                    {
                        case 1:
                            kalkulator.JalankanKalkulator();
                            break;

                        case 2:
                            bangunDatar.JalankanBangunDatar();
                            break;

                        case 3:
                            bangunRuang.JalankanBangunRuang();
                            break;

                        case 4:
                            zodiac.JalankanZodiac();
                            break;

                        case 5:
                            Console.Clear();
                            Console.WriteLine("============================================");
                            Console.WriteLine("  Terima kasih telah menggunakan!");
                            Console.WriteLine("        Sampai jumpa lagi!");
                            Console.WriteLine("============================================");
                            break;

                        default:
                            Console.WriteLine();
                            Console.WriteLine("Pilihan tidak valid! Masukkan angka 1-5.");
                            Console.WriteLine();
                            Console.WriteLine("Tekan Enter untuk melanjutkan...");
                            Console.ReadLine();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("ERROR: Masukkan angka yang valid!");
                    Console.WriteLine();
                    Console.WriteLine("Tekan Enter untuk melanjutkan...");
                    Console.ReadLine();
                    pilihan = 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine($"ERROR: {ex.Message}");
                    Console.WriteLine();
                    Console.WriteLine("Tekan Enter untuk melanjutkan...");
                    Console.ReadLine();
                    pilihan = 0;
                }

            } while (pilihan != 5);
        }
    }
}