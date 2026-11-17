using System;

namespace BAB1_BAB3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Menghapus isi layar setiap kali menu utama dipanggil
                Console.Clear();

                Console.WriteLine("==================================================");
                Console.WriteLine("      MENU TUGAS DASAR PEMROGRAMAN C# (BAB 1-14)  ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Bab 1  : Pengenalan Pemrograman Komputer");
                Console.WriteLine("2. Bab 2  : Algoritma dalam Pemrograman");
                Console.WriteLine("3. Bab 3  : Flowchart (Diagram Alir)");
                Console.WriteLine("4. Bab 4  : Pseudocode");
                Console.WriteLine("5. Bab 5  : Instalasi Visual Studio dan .NET");
                Console.WriteLine("6. Bab 6  : Struktur Dasar Program C#");
                Console.WriteLine("7. Bab 7  : Variabel dan Tipe Data C#");
                Console.WriteLine("8. Bab 8  : Operator dalam C#");
                Console.WriteLine("9. Bab 9  : Input dan Output pada C#");
                Console.WriteLine("10. Bab 10 : Percabangan (Selection)");
                Console.WriteLine("11. Bab 11 : Perulangan (Looping)");
                Console.WriteLine("12. Bab 12 : Array dan Koleksi Dasar");
                Console.WriteLine("13. Bab 13 : Method (Fungsi)");
                Console.WriteLine("14. Bab 14 : Object-Oriented Programming (OOP)");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("0. Keluar Aplikasi");
                Console.WriteLine("==================================================");
                Console.Write("Masukkan nomor pilihan bab (1-14): ");

                string pilihan = Console.ReadLine();

                // Menghapus layar SETELAH memilih bab, agar hasil bab tampil di layar kosong yang baru
                Console.Clear();

                if (pilihan == "0")
                {
                    Console.WriteLine("Keluar dari program. Terima kasih!");
                    break; // Keluar dari loop while
                }
                else if (pilihan == "1") bab1.Jalankan();
                else if (pilihan == "2") bab2.Jalankan();
                else if (pilihan == "3") bab3.Jalankan();
                else if (pilihan == "4") bab4.Jalankan();
                else if (pilihan == "5") bab5.Jalankan();
                else if (pilihan == "6") bab6.Jalankan();
                else if (pilihan == "7") bab7.Jalankan();
                else if (pilihan == "8") bab8.Jalankan();
                else if (pilihan == "9") bab9.Jalankan();
                else if (pilihan == "10") bab10.Jalankan();
                else if (pilihan == "11") bab11.Jalankan();
                else if (pilihan == "12") bab12.Jalankan();
                else if (pilihan == "13") bab13.Jalankan();
                else if (pilihan == "14") bab14.Jalankan();
                else
                {
                    Console.WriteLine("Pilihan tidak valid, silakan masukkan angka 1 sampai 14.");
                }

                // Menahan layar agar tidak langsung kembali ke menu
                Console.WriteLine("\n--------------------------------------------------");
                Console.WriteLine("Tekan ENTER untuk kembali ke menu utama...");
                Console.ReadLine();
            }
        }
    }
}