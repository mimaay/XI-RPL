using System;

namespace Kalkulatorconsole
{
    public class BangunRuang
    {
        // ===== KUBUS =====
        public double VolumeKubus(double sisi)
        {
            return sisi * sisi * sisi;
        }

        public double LuasPermukaanKubus(double sisi)
        {
            return 6 * sisi * sisi;
        }

        // ===== BALOK =====
        public double VolumeBalok(double panjang, double lebar, double tinggi)
        {
            return panjang * lebar * tinggi;
        }

        public double LuasPermukaanBalok(double panjang, double lebar, double tinggi)
        {
            return 2 * (panjang * lebar + panjang * tinggi + lebar * tinggi);
        }

        // ===== TABUNG =====
        public double VolumeTabung(double jariJari, double tinggi)
        {
            return Math.PI * jariJari * jariJari * tinggi;
        }

        public double LuasPermukaanTabung(double jariJari, double tinggi)
        {
            return 2 * Math.PI * jariJari * (jariJari + tinggi);
        }

        // ===== BOLA =====
        public double VolumeBola(double jariJari)
        {
            return (4.0 / 3.0) * Math.PI * jariJari * jariJari * jariJari;
        }

        public double LuasPermukaanBola(double jariJari)
        {
            return 4 * Math.PI * jariJari * jariJari;
        }

        // Method untuk menjalankan bangun ruang
        public void JalankanBangunRuang()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║         BANGUN RUANG               ║");
            Console.WriteLine("╚════════════════════════════════════╝");

            try
            {
                Console.WriteLine("\nPilih bangun ruang:");
                Console.WriteLine("1. Kubus");
                Console.WriteLine("2. Balok");
                Console.WriteLine("3. Tabung");
                Console.WriteLine("4. Bola");
                Console.Write("Pilihan Anda (1-4): ");
                int pilihan = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n╔═════════════════════════════════════════════╗");

                switch (pilihan)
                {
                    case 1: // Kubus
                        Console.Write("Masukkan sisi kubus: ");
                        double sisi = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"\n📦 Volume Kubus          : {VolumeKubus(sisi)}");
                        Console.WriteLine($"📐 Luas Permukaan Kubus  : {LuasPermukaanKubus(sisi)}");
                        break;

                    case 2: // Balok
                        Console.Write("Masukkan panjang: ");
                        double panjang = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan lebar  : ");
                        double lebar = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan tinggi : ");
                        double tinggi = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"\n📦 Volume Balok          : {VolumeBalok(panjang, lebar, tinggi)}");
                        Console.WriteLine($"📐 Luas Permukaan Balok  : {LuasPermukaanBalok(panjang, lebar, tinggi)}");
                        break;

                    case 3: // Tabung
                        Console.Write(" Masukkan jari-jari tabung: ");
                        double jariJari = Convert.ToDouble(Console.ReadLine());
                        Console.Write(" Masukkan tinggi tabung   : ");
                        double tinggiTabung = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"\n Volume Tabung          : {VolumeTabung(jariJari, tinggiTabung)}");
                        Console.WriteLine($" Luas Permukaan Tabung  : {LuasPermukaanTabung(jariJari, tinggiTabung)}");
                        break;

                    case 4: // Bola
                        Console.Write("Masukkan jari-jari bola: ");
                        double jariJariBola = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"\n Volume Bola          : {VolumeBola(jariJariBola)}");
                        Console.WriteLine($" Luas Permukaan Bola  : {LuasPermukaanBola(jariJariBola)}");
                        break;

                    default:
                        Console.WriteLine("\n❌ Pilihan tidak valid!");
                        break;
                }

                Console.WriteLine("╚═════════════════════════════════════════════╝");
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