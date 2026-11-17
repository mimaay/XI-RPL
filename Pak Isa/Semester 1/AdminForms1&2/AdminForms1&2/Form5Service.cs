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
    public partial class Form5Service : Form
    {
        BandaraEntities2 db = new BandaraEntities2();
        int idMaskapai ;
        private int idService = -1;
        public Form5Service()
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

        private void Form5Service_Load(object sender, EventArgs e)
        {
            dataGridService.AutoGenerateColumns = false;
            dataGridService.AllowUserToAddRows = false;
            dataGridService.ReadOnly = true;
            
            loadService();
        }

        private void loadService()
        {
            dataGridService.DataSource = db.Maskapais.OrderBy(m => m.Nama).ToList(); // bisa langsung ToList jika yang ingin di tampilkan sesuai dengan kolom yang ada di dalam database
        }

        private void clearForm()
        {
            namaTxt.Clear();
            cabangTxt.Clear();
            deskripsiTxt.Clear();

            terminalCount.Value = 0;
            idMaskapai = -1;
            saveBtn.Text = "Simpan";
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            // validasi isi textbox
            if (namaTxt.Text == "" || cabangTxt.Text == "" || deskripsiTxt.Text == "" )
            {
                MessageBox.Show("Semua data wajib diisi");
                return;
            }

            // validasi jumlah kru
            if (terminalCount.Value < 1)
            {
                MessageBox.Show("JumlahKru minimal 1");
                return;
            }

            //Percabangan Add / update
            if (idMaskapai == -1)
            {
                Maskapai maskapaiBaru = new Maskapai();

                maskapaiBaru.Nama = namaTxt.Text;
                maskapaiBaru.Perusahaan = cabangTxt.Text;
                maskapaiBaru.JumlahKru = Convert.ToInt32(terminalCount.Value);
                maskapaiBaru.Deskripsi = deskripsiTxt.Text;

                db.Maskapais.Add(maskapaiBaru);
                MessageBox.Show("Data berhasil ditambahkan");

            } else // update
            {
                Maskapai editMaskapai = db.Maskapais.Find(idMaskapai);

                editMaskapai.Nama = namaTxt.Text;
                editMaskapai.Perusahaan = cabangTxt.Text;
                editMaskapai.JumlahKru = Convert.ToInt32(terminalCount.Value);
                editMaskapai.Perusahaan = cabangTxt.Text;

                MessageBox.Show("Berhasil mengubah data Maskapai");

            }

            db.SaveChanges();
            loadService();
            clearForm();
        }

        private void dataGridService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridService.Columns[e.ColumnIndex].Name == "edit")
            {
                idMaskapai = Convert.ToInt32(dataGridService.Rows[e.RowIndex].Cells["ID"].Value);

                Maskapai editMaskapai = db.Maskapais.Find(idMaskapai);
                namaTxt.Text = editMaskapai.Nama;
                cabangTxt.Text = editMaskapai.Perusahaan;
                terminalCount.Value = editMaskapai.JumlahKru;
                deskripsiTxt.Text = editMaskapai.Deskripsi;

                saveBtn.Text = "Update";
            }
            else if (dataGridService.Columns[e.ColumnIndex].Name == "hapus")
            { 
                int id = Convert.ToInt32(dataGridService.Rows[e.RowIndex].Cells["ID"].Value);
                var hasil = MessageBox.Show("Apakah yakin untuk menghapus?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           
                if (hasil == DialogResult.Yes)
                {
                    Maskapai hapusMaskapai = db.Maskapais.Find(id);
                    db.Maskapais.Remove(hapusMaskapai);
                    db.SaveChanges();

                    MessageBox.Show("Maskapai Berhasil di hapus");
                    loadService();
                    clearForm();

                }


            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}
