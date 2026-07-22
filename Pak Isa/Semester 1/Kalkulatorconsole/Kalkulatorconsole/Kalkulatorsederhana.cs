using System;

namespace Kalkulatorconsole
{
    public class Kalkulator
    {
        // Method operasi matematika
        public int Tambah(int a, int b)
        {
            return a + b;
        }

        public int Kurang(int a, int b)
        {
            return a - b;
        }

        public int Kali(int a, int b)
        {
            return a * b;
        }

        public double Bagi(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("⚠️ ERROR: Tidak bisa membagi dengan 0!");
                return 0;
            }
            return (double)a / b;
        }

        // Method untuk menjalankan kalkulator
        public void JalankanKalkulator()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║       KALKULATOR SEDERHANA         ║");
            Console.WriteLine("╚════════════════════════════════════╝");

            try
            {
                Console.Write("\nMasukkan angka pertama: ");
                int angka1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukkan angka kedua: ");
                int angka2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nPilih operasi:");
                Console.WriteLine("1. Tambah (+)");
                Console.WriteLine("2. Kurang (-)");
                Console.WriteLine("3. Kali (*)");
                Console.WriteLine("4. Bagi (/)");
                Console.Write("Pilihan Anda (1-4): ");
                int pilihan = Convert.ToInt32(Console.ReadLine());

                double hasil = 0;
                string operasi = "";

                switch (pilihan)
                {
                    case 1:
                        hasil = Tambah(angka1, angka2);
                        operasi = "+";
                        break;
                    case 2:
                        hasil = Kurang(angka1, angka2);
                        operasi = "-";
                        break;
                    case 3:
                        hasil = Kali(angka1, angka2);
                        operasi = "*";
                        break;
                    case 4:
                        hasil = Bagi(angka1, angka2);
                        operasi = "/";
                        break;
                    default:
                        Console.WriteLine("\n❌ Pilihan tidak valid!");
                        Console.ReadKey();
                        return;
                }

                Console.WriteLine("\n════════════════════════════════════");
                Console.WriteLine($"  Hasil: {angka1} {operasi} {angka2} = {hasil}  ");
                Console.WriteLine("════════════════════════════════════");
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