using System;
namespace Jadwalrpl
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("==============  JADWAL SISWA RPL ===============");
            Console.WriteLine("================================================");
            Console.WriteLine("Selamat Datang di Jadwal Siswa RPL");
            Console.WriteLine("Silahkan Pilih Hari yang Ingin Anda Lihat");
            Console.WriteLine("1. Senin");
            Console.WriteLine("2. Selasa");
            Console.WriteLine("3. Rabu");
            Console.WriteLine("4. Kamis");
            Console.WriteLine("5. Jumat");
            Console.WriteLine("Masukkan Pilihan Anda (1-5): ");
            int pilihan = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (pilihan)
            {
                case 1:
                    Senin senin = new Senin();
                    senin.Sesi1();
                    senin.Sesi2();
                    senin.Sesi3();
                    break;
                case 2:
                    Selasa selasa = new Selasa();
                    selasa.sesi1();
                    selasa.sesi2();
                    selasa.sesi3();
                    break;
                case 3:
                    Rabu rabu = new Rabu();
                    rabu.sesi1();
                    rabu.sesi2();
                    rabu.sesi3();
                    break;
                case 4:
                    Kamis.sesi1();
                    Kamis.sesi2();
                    Kamis.sesi3();
                    break;
                case 5:
                    Jumat.sesi1();
                    Jumat.sesi2();
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        }
    }

    class Senin
    {
        public void Sesi1()
        {
            Console.WriteLine("============= SENIN ==============");
            Console.WriteLine("1. Upacara (07:00-07:35)");
            Console.WriteLine("2. Bahasa Jepang (07:35-08:10)");
            Console.WriteLine("3. Bahasa Jepang (08:10-08:45)");
            Console.WriteLine("4. Bahasa Inggris (08:45-09:20)");
            Console.WriteLine("5. Bahasa Inggris (09:20-09:55)");
            Console.WriteLine("6. Istirahat Pertama (09:55-10:10)");
        }
        public void Sesi2()
        {
            Console.WriteLine("7. Matematika (10:10-10:40)");
            Console.WriteLine("8. Matematika (10:40-11:10)");
            Console.WriteLine("9. Matematika (11:10-11:40)");
            Console.WriteLine("10. Istirahat Kedua (11:40-12:30)");
        }
        public void Sesi3()
        {
            Console.WriteLine("11. PPLG (12:30-13:00)");
            Console.WriteLine("12. PPLG (13:00-13:30)");
            Console.WriteLine("13. PPLG (13:30-14:00)");
            Console.WriteLine("14. Pulang (14:00 - selesai)");
            Console.WriteLine("===================================");
        }
    }

    class Selasa
    {
        public void sesi1()
        {
            Console.WriteLine("============= SELASA ==============");
            Console.WriteLine("1. KIK (07:00-07:35)");
            Console.WriteLine("2. KIK (07:35-08:10)");
            Console.WriteLine("3. PJOK (08:10-08:45)");
            Console.WriteLine("4. PJOK (08:45-09:20)");
            Console.WriteLine("5. Istirahat Pertama (09:20-09:35)");
        }

        public void sesi2()
        {
            Console.WriteLine("6. Bahasa Indonesia (09:35-10:05)");
            Console.WriteLine("7. Bahasa Indonesia (10:05-10:35)");
            Console.WriteLine("8. Bahasa Indonesia (10:35-11:05)");
            Console.WriteLine("9. PPLG (11:05-11:35)");
            Console.WriteLine("10. Istirahat Kedua (11:35-12:30)");
        }

        public void sesi3()
        {
            Console.WriteLine("11. PPLG (12:30-13:00)");
            Console.WriteLine("12. PPLG (13:00-13:30)");
            Console.WriteLine("13. PPLG (13:30-14:00)");
            Console.WriteLine("14. Pulang (14:00 - selesai)");
            Console.WriteLine("==================================");
        }

    }

    class Rabu
    {
        public void sesi1()
        {
            Console.WriteLine("============= RABU ==============");
            Console.WriteLine("1. PPLG (07:00-07:35)");
            Console.WriteLine("2. PPLG (07:35-08:10)");
            Console.WriteLine("3. PPLG (08:10-08:45)");
            Console.WriteLine("4. PPLG (08:45-09:20)");
            Console.WriteLine("5. Istirahat Pertama (09:20-09:35)");
        }

        public void sesi2()
        { 
            Console.WriteLine("6. PPLG (09:35-10:05)");
            Console.WriteLine("7. PPLG (10:05-10:35)");
            Console.WriteLine("8. PPLG (10:35-11:05)");
            Console.WriteLine("9. PPLG (11:05-11:35)");
            Console.WriteLine("10. Istirahat Kedua (11:35-12:30)");
        }

        public void sesi3()
        { 
            Console.WriteLine("11. PPLG (12:30-13:00)");
            Console.WriteLine("12. PPLG (13:00-13:30)");
            Console.WriteLine("13. BK (13:30-14:00)");
            Console.WriteLine("14. Pulang (14:00 - selesai)");
            Console.WriteLine("================================");
        }
    }

    class Kamis
    {
        public static void sesi1()
        {
            Console.WriteLine("============= KAMIS ==============");
            Console.WriteLine("1. Bahasa Jerman (07:00-07:35)");
            Console.WriteLine("2. Bahasa Jerman (07:35-08:10)");
            Console.WriteLine("3. Bahasa Jawa (08:10-08:45)");
            Console.WriteLine("4. Bahasa Jawa (08:45-09:20)");
            Console.WriteLine("5. Istirahat Pertama (09:20-09:35)");
        }

        public static void sesi2()
        {
            Console.WriteLine("6. KIK (09:35-10:05)");
            Console.WriteLine("7. KIK (10:05-10:35)");
            Console.WriteLine("8. KIK (10:35-11:05)");
            Console.WriteLine("9. PAI (11:05-11:35)");
            Console.WriteLine("10. Istirahat Kedua (11:35-12:30)");
        }

        public static void sesi3()
        { 
            Console.WriteLine("11. PAI (12:30-13:00)");
            Console.WriteLine("12. PAI (13:00-13:30)");
            Console.WriteLine("13. Pulang (13:30 - selesai)");
            Console.WriteLine("==================================");
        }


    }

    class Jumat
    { 
        public static void sesi1()
        {
            Console.WriteLine("============= JUMAT ==============");
            Console.WriteLine("1. Bersih-bersih (07:00-08:00)");
            Console.WriteLine("2. Bahasa Inggris (08:00-08:30)");
            Console.WriteLine("3. Bahasa Inggris (08:30-09:00)");
            Console.WriteLine("4. Sejarah (09:00-09:30)");
            Console.WriteLine("5. Istirahat Pertama (09:30-09:45)");
        }

        public static void sesi2()
        { 
            Console.WriteLine("6. Sejarah (09:45-10:15)");
            Console.WriteLine("7. Pendidikan Pancasila (10:15-10:45)");
            Console.WriteLine("8. Pandidikan Pancasila (10:45-11:15)");
            Console.WriteLine("9. Sholat (11:15-12:30)");
            Console.WriteLine("10. Pramuka (12:30-14:00)");
            Console.WriteLine("11. Pulang (14:00 - selesai)");
            Console.WriteLine("==================================");
        }
    }




}

