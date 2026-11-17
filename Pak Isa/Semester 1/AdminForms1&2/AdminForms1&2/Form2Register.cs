using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminForms1_2
{
    public partial class Form2Register : Form
    {
        BandaraEntities2 DB = new BandaraEntities2(); // membuat koneksi ke database
        public Form2Register()
        {
            InitializeComponent();
        }


        private void label9_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Close();
            login.Show();
        }

        private void daftarBtn_Click(object sender, EventArgs e)  // tempat logic simpan user
        {
            // cek semua textbox telah terisi
            if (usernameTxt.Text == "" || namaTxt.Text == "" || tglDate.Value.Date == DateTime.Today || telpTxt.Text == "" || passwordTxt.Text == "")
            {
                MessageBox.Show("Tolong lengkapi keseluruhan data untuk membuat akun baru");
                return;
            }

            // username harus unik
            bool usernameSudahAda = DB.Akuns.Any(a => a.Username == usernameTxt.Text);

            if (usernameSudahAda)
            {
                MessageBox.Show("Username sudah digunakan");
                return;
            }

            // validasi nomor telepon
            if (!telpTxt.Text.All(char.IsDigit)) // jika nomor telepon terdapat hurus atau simbol lainnya
            { 
                MessageBox.Show("Nomor telepon hanya boleh berisi angka");
                return;
            }

            if (telpTxt.Text.Length < 10 || telpTxt.Text.Length > 15) // nomor telpon harus lebih dari 10 dan tidak boleh lebih dari 15 karakter
            {
                MessageBox.Show("Nomor telepon hanya boleh berisikan angka");
                return;
            }

            // validasi password
            if (passwordTxt.Text.Length < 8)
            {
                MessageBox.Show("Password minimal 8 huruf");
                return;
            }

            // validasi tanggal lahir
            int umur = DateTime.Now.Year - tglDate.Value.Year;

            // jika ulang tahun ini belum lewat (belum genap)
            if (tglDate.Value.Date > DateTime.Today.AddYears(-umur)) // menyamakan tahun ini dengan tahun lahir agar bisa menghitung genapnya tanggal lahir
            {
                umur--;
            }

            if (umur < 17)
            {
                MessageBox.Show("Umur minimal 17 Tahun");
                return;
            }

            // daftar akun baru dan masukkan ke dalam database
            Akun akunBaru = new Akun();

            akunBaru.Username = usernameTxt.Text;
            akunBaru.Nama = namaTxt.Text;
            akunBaru.TanggalLahir = tglDate.Value.Date;
            akunBaru.NomorTelepon = telpTxt.Text;
            akunBaru.Password = passwordTxt.Text;
            akunBaru.MerupakanAdmin = false;

            DB.Akuns.Add(akunBaru);
            DB.SaveChanges();

            // Tampilkan pesan
            MessageBox.Show("Berhasil membuat akun baru. \nSilahkan Login");

            // Lompat ke login screen
            Form1Login login = new Form1Login();
            login.Show();
            this.Hide();

        }
    }
}
