using System;

namespace BAB1_BAB3
{
    internal class bab4
    {
        public static void Jalankan()
        {
            Console.WriteLine("=== BAB 4: PSEUDOCODE (Studi Kasus) ===");

            Console.WriteLine("1. Pseudocode menghitung rata-rata tiga nilai[cite: 1]:");
            Console.WriteLine("   BEGIN\n   INPUT n1, n2, n3\n   rata = (n1 + n2 + n3) / 3\n   OUTPUT rata\n   END");

            Console.WriteLine("\n2. Pseudocode menentukan nilai lulus atau tidak lulus[cite: 1]:");
            Console.WriteLine("   BEGIN\n   INPUT nilai\n   IF nilai >= 75 THEN\n      OUTPUT \"Lulus\"\n   ELSE\n      OUTPUT \"Tidak Lulus\"\n   ENDIF\n   END");

            Console.WriteLine("\n3. Pseudocode menghitung luas segitiga[cite: 1]:");
            Console.WriteLine("   BEGIN\n   INPUT alas, tinggi\n   luas = 0.5 * alas * tinggi\n   OUTPUT luas\n   END");
        }
    }
}