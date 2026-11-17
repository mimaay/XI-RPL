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
    public partial class Form4Marketplace : Form
    {
        BandaraEntities2 db = new BandaraEntities2(); // membuat koneksi ke databasa
        private int idBandara = -1; // menyimpan ID bandara yang sedang di edit (-1 mode tambah)
        public Form4Marketplace()
        {
            InitializeComponent();
        }
        private void ShowDashboard(object sender, EventArgs e)
        {
            Form3Dasboard dashboard = new Form3Dasboard();
            this.Hide();
            dashboard.Show();
        }

        private void ShowMarketplace(object sender, EventArgs e)
        {
            Form4Marketplace marketplace = new Form4Marketplace();
            this.Hide();
            marketplace.Show();
        }

        private void ShowService(object sender, EventArgs e)
        {
            Form5Service service = new Form5Service();
            this.Hide();
            service.Show();
        }
        private void ShowJadwalService(object sender, EventArgs e)
        {
            Form6JadwalService jadwalservice = new Form6JadwalService();
            this.Hide();
            jadwalservice.Show();
        }

        private void ShowVoucherMember(object sender, EventArgs e)
        {
            Form7Vouchermember Vouchermember = new Form7Vouchermember();
            this.Hide();
            Vouchermember.Show();
        }

        private void ShowRiwayat(object sender, EventArgs e)
        {
            Form8Riwayat riwayat = new Form8Riwayat();
            this.Hide();
            riwayat.Show();
        }

        private void BackToLogin(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Hide();
            login.Show();
        }


        private void Form4Marketplace_Load(object sender, EventArgs e)
        {
            LoadNegara(); // menampilkan daftar negara di conbobox
            LoadMarketPlace(); // menampilkan semua data bandara ke dalam DataGridView 

            dataGridMarketplace.AutoGenerateColumns = false;
            dataGridMarketplace.AllowUserToAddRows = false;
            dataGridMarketplace.ReadOnly = true;
        }

        private void LoadNegara()
        {
            ngrBox.DataSource = db.Negaras.OrderBy(n => n.Nama).ToList();

            ngrBox.DisplayMember = "Nama";
            ngrBox.ValueMember = "Id";
            ngrBox.SelectedIndex = -1;
        }

        private void LoadMarketPlace()
        { 
            dataGridMarketplace.DataSource = db.Bandaras.Include("Negara").OrderBy(b => b.Nama).Select(b => new
            {
                b.ID,
                b.Nama,
                b.KodeIATA,
                b.Kota, Negara = b.Negara.Nama,
                b.Alamat
            }).ToList();
            
        }

        private void resetForm()
        {
            namaTxt.Clear();
            aitaTxt.Clear();
            kotaTxt.Clear();
            ngrBox.SelectedIndex = -1;
            terminalCount.Value = 1;
            idBandara = -1;
            saveBtn.Text = "Simpan";

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (namaTxt.Text == "" || aitaTxt.Text == "" || kotaTxt.Text == "" || alamatTxt.Text == "" || ngrBox.SelectedIndex == -1)
            {
                MessageBox.Show("semua data harus diisi");
            }

            // validasi panjang kode IATA
            if (aitaTxt.Text.Length !=3)
            {
                MessageBox.Show("kode IATA wajib memiliki 3 Huruf");
            }

            // semua karakter IATA harus berupa Huruf
            if (aitaTxt.Text.All(char.IsLetter)) // all() mengecek semua karakter
            {
                MessageBox.Show("KodeIATA IATA hanya bolh huruf!");
            }

            // validasi IATA tidak boleh sama
            bool adaAITA = db.Bandaras.Any(b => b.KodeIATA == aitaTxt.Text && b.ID != idBandara);

            if (adaAITA)
            {
                MessageBox.Show("Nama bandara sudah dipakai");
            }

            // validasi jumlah Terminal (Minimal 1 Terminal)
            if (terminalCount.Value < 1)
            {
                MessageBox.Show("Jumlah Terminal minimal 1");
            }

            // validasi Nama Bandara harus unik
            bool adaBandara = db.Bandaras.Any(b => b.Nama.ToLower() == namaTxt.Text.ToLower() && b.ID != idBandara);

            if (adaBandara)
            {
                MessageBox.Show("Nama Bandara sudah di pakai");
                return;
            }

            // Percabangan Edit dan Add data
            if (idBandara == -1)
            {
                Bandara bandara = new Bandara();

                bandara.Nama = namaTxt.Text;
                bandara.KodeIATA = aitaTxt.Text;
                bandara.Kota = namaTxt.Text;
                bandara.NegaraID = Convert.ToInt32(ngrBox.SelectedValue);
                bandara.JumlahTerminal = Convert.ToInt32(terminalCount.Value);
                bandara.Alamat = alamatTxt.Text;

                db.Bandaras.Add(bandara);
                MessageBox.Show("Data berhasil ditambahkan");

            }else 
            {
                Bandara editBandara = db.Bandaras.Find(idBandara);

                editBandara.Nama = namaTxt.Text;
                editBandara.KodeIATA = aitaTxt.Text;
                editBandara.Kota = namaTxt.Text;
                editBandara.NegaraID = Convert.ToInt32(ngrBox.SelectedValue);
                editBandara.JumlahTerminal = Convert.ToInt32(terminalCount.Value);
                editBandara.Alamat = alamatTxt.Text;

                MessageBox.Show("Data berhasil diedit!");
            }

            db.SaveChanges(); 

            LoadMarketPlace();
            resetForm();


        }

        private void dataGridMarketplace_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            // edit dan delete
            if (dataGridMarketplace.Columns[e.ColumnIndex].Name == "edit")
            {
                idBandara = Convert.ToInt32(dataGridMarketplace.Rows[e.RowIndex].Cells["ID"].Value);

                Bandara bandaraEdit = db.Bandaras.Find(idBandara);

                // menampilkan data ke dalam text dan combo box
                namaTxt.Text = bandaraEdit.Nama;
                aitaTxt.Text = bandaraEdit.KodeIATA;
                kotaTxt.Text = bandaraEdit.Kota;
                alamatTxt.Text = bandaraEdit.Alamat;
                ngrBox.SelectedValue = bandaraEdit.NegaraID;
                terminalCount.Value = bandaraEdit.JumlahTerminal;

                saveBtn.Text = "Update";
            } else if (dataGridMarketplace.Columns[e.ColumnIndex].Name == "hapus")
            {
                int id = Convert.ToInt32(dataGridMarketplace.Rows[e.RowIndex].Cells["ID"].Value);
                var hasil = MessageBox.Show("yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Bandara bandaraHapus = db.Bandaras.Find(id);
                    db.Bandaras.Remove(bandaraHapus);
                    db.SaveChanges();

                    LoadMarketPlace();
                    resetForm();

                }
            }
        }
    }
}
