using System;

namespace AplikasiDataSiswa
{
    class Home
    {
        static void Main(string[] args)
        {
            Identitas.Siswa();
            Identitas.Wali();
            Identitas.Sekolah();

            MataPelajaran.NonProduktif();
            MataPelajaran.Produktif();

            Absensi.BulanJanuari();

            Absensi.BulanFebruari();

            Absensi.BulanMaret();

            Absensi.BulanApril();

            Absensi.BulanMei();

            Absensi.BulanJuni();

            Absensi.BulanJuli();

            Absensi.BulanAgustus();

            Absensi.BulanSeptember();

            Absensi.BulanOktober();

            Absensi.BulanNovember();

            Absensi.BulanDesember();

            Nilai.NonProduktif();
            Nilai.Produktif();
        }
    }
    class Identitas
    {
        // ----- VOID SISWA -----
        public static void Siswa()
        {
            Console.WriteLine("┌─────────────────────────────────────────┐");
            Console.WriteLine("│             DATA SISWA                  │");
            Console.WriteLine("├─────────────────────────────────────────┤");
            Console.WriteLine("│  NISN         : 0094376647              │");
            Console.WriteLine("│  Nama         : YEMIMA OKTAVIA SATOKO   │");
            Console.WriteLine("│  Tempat/Tgl   : Sidoarjo,31 - 10 - 2009 │");
            Console.WriteLine("│  Jenis Kelamin: Perempuan               │");
            Console.WriteLine("│  Alamat       : Perum AURI Jln capung   │");
            Console.WriteLine("│  No. HP       : 085334410684            │");
            Console.WriteLine("│  Email        : yaudahsihhh31@gmail.com │");
            Console.WriteLine("└─────────────────────────────────────────┘");
        }

        // ----- VOID WALI -----
        public static void Wali()
        {
            Console.WriteLine("┌───────────────────────────────────────--──┐");
            Console.WriteLine("│             DATA WALI                     │");
            Console.WriteLine("├─────────────────────────────────────────--┤");
            Console.WriteLine("│  Nama Ayah     : Paulus Satoko            │");
            Console.WriteLine("│  Pekerjaan     : Wiraswasta               │");
            Console.WriteLine("│  No. HP Ayah   : 082330597983             │");
            Console.WriteLine("│  Nama Ibu      : Banni Rihi               │");
            Console.WriteLine("│  Pekerjaan     : Wiraswasta               │");
            Console.WriteLine("│  No. HP Ibu    : 082330597983             │");
            Console.WriteLine("│  Alamat        : Perum AURI Jln capung    │");
            Console.WriteLine("└────────────────────────────────────────--─┘");
        }

        // ----- VOID SEKOLAH -----
        public static void Sekolah()
        {
            Console.WriteLine("┌─────────────────────────────────────────┐");
            Console.WriteLine("│             DATA SEKOLAH                │");
            Console.WriteLine("├─────────────────────────────────────────┤");
            Console.WriteLine("│  Nama Sekolah   : SMKN 2 BUDURAN        │");
            Console.WriteLine("│  NPSN           : 20501695              │");
            Console.WriteLine("│  Alamat         : Perum AURI Jln capung │");
            Console.WriteLine("│  Kecamatan      : Sidoarjo              │");
            Console.WriteLine("│  Kota/Kab       : Sidoarjo              │");
            Console.WriteLine("│  Provinsi       : Jawa Timur            │");
            Console.WriteLine("│  Telp Sekolah   : 0318964034            │");
            Console.WriteLine("└─────────────────────────────────────────┘");
        }
    }

    // =============================================
    // CLASS MATA PELAJARAN
    // =============================================
    class MataPelajaran
    {
        // ----- VOID PRODUKTIF -----
        public static void Produktif()
        {
            Console.WriteLine("┌─────────────────────────────────────────┐");
            Console.WriteLine("│        MATA PELAJARAN PRODUKTIF         │");
            Console.WriteLine("├─────────────────────────────────────────┤");
            Console.WriteLine("│  1. PPLG (Pemrograman)                  │");
            Console.WriteLine("│  2. KIK (Kewirausahaan)                 │");
            Console.WriteLine("└─────────────────────────────────────────┘");
        }

        // ----- VOID NON PRODUKTIF -----
        public static void NonProduktif()
        {
            Console.WriteLine("┌─────────────────────────────────────────┐");
            Console.WriteLine("│        MATA PELAJARAN NON PRODUKTIF     │");
            Console.WriteLine("├─────────────────────────────────────────┤");
            Console.WriteLine("│  1. Matematika                          │");
            Console.WriteLine("│  2. Bahasa Indonesia                    │");
            Console.WriteLine("│  3. Bahasa Inggris                      │");
            Console.WriteLine("│  4. Bahasa Jawa                         │");
            Console.WriteLine("│  5. Bahasa Jerman                       │");
            Console.WriteLine("│  6. Bahasa Jepang                       │");
            Console.WriteLine("│  7. Sejarah                             │");
            Console.WriteLine("│  8. Pendidikan Pancasila                │");
            Console.WriteLine("│  9. Agama                               │");
            Console.WriteLine("│ 10. BK (Bimbingan Konseling)            │");
            Console.WriteLine("└─────────────────────────────────────────┘");
        }
    }

    // =============================================
    // CLASS ABSENSI
    // =============================================
    class Absensi
    {
        // ----- VOID BULAN JANUARI -----
        public static void BulanJanuari()
        {
            Console.WriteLine("========= ABSENSI BULAN JANUARI ===========");
            Console.WriteLine($"  Total Hari Efektif  : 0 Hari         ");
            Console.WriteLine($"  Hadir               : 31 Hari         ");
            Console.WriteLine($"  Sakit               : - Hari          ");
            Console.WriteLine($"  Izin                : - Hari          ");
            Console.WriteLine($"  Tidak Masuk         : - Hari          ");
            Console.WriteLine($"  Persentase Kehadiran: 100%           \n");
        }

        // ----- VOID BULAN FEBRUARI -----
        public static void BulanFebruari()
        {
            Console.WriteLine("========= ABSENSI BULAN FEBUARI ===========");
            Console.WriteLine($"  Total Hari Efektif  : 0 Hari         ");
            Console.WriteLine($"  Hadir               : 28 Hari         ");
            Console.WriteLine($"  Sakit               : - Hari          ");
            Console.WriteLine($"  Izin                : - Hari          ");
            Console.WriteLine($"  Tidak Masuk         : - Hari          ");
            Console.WriteLine($"  Persentase Kehadiran: 100%           \n");
        }

        // ----- VOID BULAN MARET -----
        public static void BulanMaret()
        {
            Console.WriteLine("========= ABSENSI BULAN MARET ===========");
            Console.WriteLine($"  Total Hari Efektif  : 0 Hari         ");
            Console.WriteLine($"  Hadir               : 31 Hari         ");
            Console.WriteLine($"  Sakit               : - Hari          ");
            Console.WriteLine($"  Izin                : - Hari          ");
            Console.WriteLine($"  Tidak Masuk         : - Hari          ");
            Console.WriteLine($"  Persentase Kehadiran: 100%           \n");
        }

        // ----- VOID BULAN APRIL -----
        public static void BulanApril()
        {
            Console.WriteLine("========= ABSENSI BULAN APRIL  ===========");
            Console.WriteLine($"  Total Hari Efektif  : 0 Hari         ");
            Console.WriteLine($"  Hadir               : 30 Hari         ");
            Console.WriteLine($"  Sakit               : - Hari          ");
            Console.WriteLine($"  Izin                : - Hari          ");
            Console.WriteLine($"  Tidak Masuk         : - Hari          ");
            Console.WriteLine($"  Persentase Kehadiran: 100%           \n");
        }

        // ----- VOID BULAN MEI -----
        public static void BulanMei()
        {
            Console.WriteLine("========= ABSENSI BULAN MEI  ===========");
            Console.WriteLine($"  Total Hari Efektif  : 0 Hari         ");
            Console.WriteLine($"  Hadir               : 31 Hari         ");
            Console.WriteLine($"  Sakit               : - Hari          ");
            Console.WriteLine($"  Izin                : - Hari          ");
            Console.WriteLine($"  Tidak Masuk         : - Hari          ");
            Console.WriteLine($"  Persentase Kehadiran: 100%           \n");
        }

        // ----- VOID BULAN JUNI -----
        public static void BulanJuni()
        {
            Console.WriteLine("========= ABSENSI BULAN JUNI  ===========");
            Console.WriteLine($"  Total Hari Efektif  : 0 Hari         ");
            Console.WriteLine($"  Hadir               : 31 Hari         ");
            Console.WriteLine($"  Sakit               : - Hari          ");
            Console.WriteLine($"  Izin                : - Hari          ");
            Console.WriteLine($"  Tidak Masuk         : - Hari          ");
            Console.WriteLine($"  Persentase Kehadiran: 100%           \n");
        }
        public static void BulanJuli()
        {
            Console.WriteLine("========= ABSENSI BULAN JULI  ===========");
            Console.WriteLine($"  Total Hari Efektif  : 0 Hari         ");
            Console.WriteLine($"  Hadir               : 31 Hari         ");
            Console.WriteLine($"  Sakit               : - Hari          ");
            Console.WriteLine($"  Izin                : - Hari          ");
            Console.WriteLine($"  Tidak Masuk         : - Hari          ");
            Console.WriteLine($"  Persentase Kehadiran: 100%           \n");
        }

        public static void BulanAgustus()
        {
            Console.WriteLine("========= ABSENSI BULAN AGUSTUS  ===========");
            Console.WriteLine($"  Total Hari Efektif  : 0 Hari         ");
            Console.WriteLine($"  Hadir               : 31 Hari         ");
            Console.WriteLine($"  Sakit               : - Hari          ");
            Console.WriteLine($"  Izin                : - Hari          ");
            Console.WriteLine($"  Tidak Masuk         : - Hari          ");
            Console.WriteLine($"  Persentase Kehadiran: 100%           \n");
        }

        public static void BulanSeptember()
        {
            Console.WriteLine("========= ABSENSI BULAN SEPTEMBER  ===========");
            Console.WriteLine($"  Total Hari Efektif  : 0 Hari         ");
            Console.WriteLine($"  Hadir               : 30 Hari         ");
            Console.WriteLine($"  Sakit               : - Hari          ");
            Console.WriteLine($"  Izin                : - Hari          ");
            Console.WriteLine($"  Tidak Masuk         : - Hari          ");
            Console.WriteLine($"  Persentase Kehadiran: 100%           \n");
        }

        public static void BulanOktober()
        {
            Console.WriteLine("========= ABSENSI BULAN Oktober  ===========");
            Console.WriteLine($"  Total Hari Efektif  : 0 Hari         ");
            Console.WriteLine($"  Hadir               : 31 Hari         ");
            Console.WriteLine($"  Sakit               : - Hari          ");
            Console.WriteLine($"  Izin                : - Hari          ");
            Console.WriteLine($"  Tidak Masuk         : - Hari          ");
            Console.WriteLine($"  Persentase Kehadiran: 100%           \n");
        }

        public static void BulanNovember()
        {
            Console.WriteLine("========= ABSENSI BULAN November  ===========");
            Console.WriteLine($"  Total Hari Efektif  : 0 Hari         ");
            Console.WriteLine($"  Hadir               : 30 Hari         ");
            Console.WriteLine($"  Sakit               : - Hari          ");
            Console.WriteLine($"  Izin                : - Hari          ");
            Console.WriteLine($"  Tidak Masuk         : - Hari          ");
            Console.WriteLine($"  Persentase Kehadiran: 100%           \n");
        }

        public static void BulanDesember()
        {
            Console.WriteLine("========= ABSENSI BULAN DESEMBER  ===========");
            Console.WriteLine($"  Total Hari Efektif  : 0 Hari         ");
            Console.WriteLine($"  Hadir               : 31 Hari         ");
            Console.WriteLine($"  Sakit               : - Hari          ");
            Console.WriteLine($"  Izin                : - Hari          ");
            Console.WriteLine($"  Tidak Masuk         : - Hari          ");
            Console.WriteLine($"  Persentase Kehadiran: 100%           \n");
        }

    }

    // =============================================
    // CLASS NILAI
    // =============================================
    class Nilai
    {
        // ----- VOID MATEMATIKA -----
        public static void NonProduktif()
        {
            Console.WriteLine("1. Matematika : 100");
            Console.WriteLine("2. Bahasa Indones : 100");
            Console.WriteLine("3. Bahasa Inggris : 100");
            Console.WriteLine("4. Bahasa Jawa : 100");
            Console.WriteLine("5. Bahasa Jerman : 100");
            Console.WriteLine("6. Bahasa Jepang : 100");
            Console.WriteLine("7. Sejarah : 100");
            Console.WriteLine("8. Pendidikan Pancasila : 100");
            Console.WriteLine("9. Agama : 100");
            Console.WriteLine("10. BK (Bimbingan Konseling) : 100");

        }

        public static void Produktif()
        {
            Console.WriteLine("1. PPLG (Pemrograman) : 95");
            Console.WriteLine("2. KIK (Kewirausahaan) : 95");
        }
    }
}