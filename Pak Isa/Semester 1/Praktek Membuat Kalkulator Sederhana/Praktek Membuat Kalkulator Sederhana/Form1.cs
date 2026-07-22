using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktek_Membuat_Kalkulator_Sederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // kita mengambil text dari textbpox lalu mengubah menjadi interger
            // kita ubah menjadi interger karena hasil dari textbox adalah string (.Text)

            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);

            // lalu kita buat variabel untuk menjumlahkan
            int hasil = angka1 + angka2;

            // setelah itu kita bisa langsung menampilkan ke label hasil
            lblHasil.Text = "Hasil : " + hasil.ToString(); // jangan lupa untuk di convert lagi menjadi string karena kita sudah mengubah ke bentuk interger sebelumnya

        }

        private void btnKurang_Click(object sender, EventArgs e)
        {

            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);
            int hasil = angka1 - angka2;
            lblHasil.Text = "Hasil : " + hasil.ToString();
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);
            int hasil = angka1 * angka2;
            lblHasil.Text = "Hasil : " + hasil.ToString();
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            double angka1 = Convert.ToInt32(txtAngka1.Text);
            double angka2 = Convert.ToInt32(txtAngka2.Text);
            double hasil = angka1 / angka2;
            lblHasil.Text = "Hasil : " + hasil.ToString();
        }
    }
}
