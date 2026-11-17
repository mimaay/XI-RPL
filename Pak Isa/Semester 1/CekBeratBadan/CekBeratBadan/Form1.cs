using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CekBeratBadan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            // 1. Deklarasi variabel
            double tinggiCm, beratKg;

            // 2. Validasi input Tinggi
            if (!double.TryParse(txtTinggi.Text, out tinggiCm))
            {
                MessageBox.Show("Mohon masukkan angka yang valid untuk Tinggi Badan!", "Peringatan");
                return;
            }

            // 3. Validasi input Berat
            if (!double.TryParse(txtBerat.Text, out beratKg))
            {
                MessageBox.Show("Mohon masukkan angka yang valid untuk Berat Badan!", "Peringatan");
                return;
            }

            // 4. Validasi angka tidak boleh 0 atau negatif
            if (tinggiCm <= 0 || beratKg <= 0)
            {
                MessageBox.Show("Tinggi dan Berat badan harus lebih dari 0 (nol)!", "Peringatan");
                return;
            }

            // 5. Hitung BMI
            double tinggiM = tinggiCm / 100;
            double bmi = beratKg / (tinggiM * tinggiM);

            // 6. Tentukan STATUS dan SARAN (ini yang baru!)
            string status;
            string saran;

            if (bmi < 18.5)
            {
                status = "🔴 Kekurangan Berat Badan (Kurus)";
                saran = "Saran: Sebaiknya kamu mulai menambah porsi makan dengan makanan tinggi protein (telur, ayam, ikan) dan karbohidrat (nasi, kentang). Jangan lupa konsultasi ke ahli gizi ya!";
            }
            else if (bmi >= 25.0)
            {
                status = "🟠 Kelebihan Berat Badan (Gemuk)";
                saran = "Saran: Yuk kurangi makanan manis, gorengan, dan minuman bersoda. Perbanyak sayur dan buah, serta rutin olahraga jalan kaki atau lari kecil 30 menit sehari.";
            }
            else // ini untuk BMI antara 18.5 sampai 24.9
            {
                status = "🟢 Berat Badan Ideal (Normal)";
                saran = "Saran: Selamat! Pertahankan gaya hidup sehat ini. Konsumsi makanan bergizi seimbang dan tetap rutin berolahraga agar tubuh selalu prima.";
            }

            // 7. Tampilkan hasil yang RAPI dan JELAS ke Label
            lblHasil.Text = $"BMI Anda: {bmi:F2}\n" +
                            $"Status  : {status}\n" +
                            $"{saran}";
        }
    }
}
