using System;

namespace Kalkulatorconsole
{
    public class Zodiac
    {
        public string TentukanZodiac(int tanggal, int bulan)
        {
            if ((bulan == 3 && tanggal >= 21) || (bulan == 4 && tanggal <= 19))
                return "Aries (21 Maret - 19 April)";
            else if ((bulan == 4 && tanggal >= 20) || (bulan == 5 && tanggal <= 20))
                return "Taurus (20 April - 20 Mei)";
            else if ((bulan == 5 && tanggal >= 21) || (bulan == 6 && tanggal <= 20))
                return "Gemini (21 Mei - 20 Juni)";
            else if ((bulan == 6 && tanggal >= 21) || (bulan == 7 && tanggal <= 22))
                return "Cancer (21 Juni - 22 Juli)";
            else if ((bulan == 7 && tanggal >= 23) || (bulan == 8 && tanggal <= 22))
                return "Leo (23 Juli - 22 Agustus)";
            else if ((bulan == 8 && tanggal >= 23) || (bulan == 9 && tanggal <= 22))
                return "Virgo (23 Agustus - 22 September)";
            else if ((bulan == 9 && tanggal >= 23) || (bulan == 10 && tanggal <= 22))
                return "Libra (23 September - 22 Oktober)";
            else if ((bulan == 10 && tanggal >= 23) || (bulan == 11 && tanggal <= 21))
                return "Scorpio (23 Oktober - 21 November)";
            else if ((bulan == 11 && tanggal >= 22) || (bulan == 12 && tanggal <= 21))
                return "Sagitarius (22 November - 21 Desember)";
            else if ((bulan == 12 && tanggal >= 22) || (bulan == 1 && tanggal <= 19))
                return "Capricorn (22 Desember - 19 Januari)";
            else if ((bulan == 1 && tanggal >= 20) || (bulan == 2 && tanggal <= 18))
                return "Aquarius (20 Januari - 18 Februari)";
            else if ((bulan == 2 && tanggal >= 19) || (bulan == 3 && tanggal <= 20))
                return "Pisces (19 Februari - 20 Maret)";
            else
                return "Tanggal tidak valid!";
        }

        public void JalankanZodiac()
        {
            Console.Clear();
            Console.WriteLine("========== CEK ZODIAC ANDA ==========");
            Console.WriteLine();

            try
            {
                Console.Write("Masukkan tanggal lahir (1-31): ");
                int tanggal = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukkan bulan lahir (1-12): ");
                int bulan = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("====================================================");

                // Validasi
                if (tanggal < 1 || tanggal > 31 || bulan < 1 || bulan > 12)
                {
                    Console.WriteLine("ERROR: Tanggal harus 1-31 dan Bulan harus 1-12!");
                }
                else if ((bulan == 4 || bulan == 6 || bulan == 9 || bulan == 11) && tanggal > 30)
                {
                    Console.WriteLine($"ERROR: Bulan {bulan} hanya memiliki 30 hari!");
                }
                else if (bulan == 2 && tanggal > 29)
                {
                    Console.WriteLine("ERROR: Bulan Februari hanya memiliki 28 atau 29 hari!");
                }
                else
                {
                    string zodiac = TentukanZodiac(tanggal, bulan);
                    Console.WriteLine($"Tanggal Lahir : {tanggal}/{bulan}");
                    Console.WriteLine($"Zodiac Anda   : {zodiac}");
                }

                Console.WriteLine("====================================================");
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("ERROR: Masukkan angka yang valid!");
                Console.WriteLine("====================================");
            }

            Console.WriteLine();
            Console.Write("Tekan Enter untuk kembali ke menu...");
            Console.ReadLine();
        }
    }
}