using System;
namespace Matematika
{
    class Home 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Belajar PBO");
            Kalkulator kal = new Kalkulator();
            BangunDatar bdatar = new BangunDatar();
            BangunRuang bruang = new BangunRuang();
            bruang.VolumeTabung();
            kal.Penjumlahan();
            BangunDatar.LuasLingkaran();
        }
    }

    class Kalkulator
    {
        public void Penjumlahan()
        {
            Console.WriteLine ("Hasil Penjumlahan");
        }
        public void Pengurangan()
        {
            Console.WriteLine("Hasil Pengurangan");
        }
        public void PPerkalian ()
        {
            Console.WriteLine("Hasil Pengurangan");
        }
        public void Pembagian()
        {
            Console.WriteLine("Hasil Pembagian");
        }


    }

    class BangunDatar
    {
        public static void KelilingPersegiPanjang ()
        {
            Console.WriteLine("Keliling Persegi Panjang");
        }

        public static void KelilingLingkaran()
        {
            Console.WriteLine("Keliling Lingkaran");
        }

        public static void LuasPersegiPanjang()
        { 
            Console.WriteLine("Luas Persegi Panjang");
        }

        public static void LuasLingkaran()
        {
            Console.WriteLine("Luas Lingkaran");
        }


    }

    class BangunRuang
    {
        public void VolumeBalok()
        {
            Console.WriteLine("Volume Balok");
        }

        public void VolumeTabung()
        {
            Console.WriteLine("Volume Tabung");
        }

        public void VolumePiramida()
        {
            Console.WriteLine("Volume Piramida");
        }

    }
}