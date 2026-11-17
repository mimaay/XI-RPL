using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameWork
{
    public partial class Form1 : Form
    {
        SekolahModelEntities db = new SekolahModelEntities();
        public Form1()
        {
            InitializeComponent();
        }

        int idSiswa;

        private void LoadData()
        {
            dataGridView1.DataSource = db.Siswas.Select(s => new
            {
                s.Id,
                s.Nama,
                s.Umur,
                s.Alamat,
                Jurusan = s.Jurusan.NamaJurusan
            }).ToList();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            LoadData();

            jurusanBox.DataSource = db.Jurusans.ToList();
            jurusanBox.DisplayMember = "NamaJurusan";
            jurusanBox.ValueMember = "Id";
            jurusanBox.SelectedIndex = -1;
        }

        private void ClearForm()
        {
            namaTxt.Text = "";
            umurTxt.Text = "";
            alamatTxt.Text = "";
            jurusanBox.SelectedIndex = -1;
        }
        
        private void addBtn_Click_1(object sender, EventArgs e)
        {
            if (namaTxt.Text == "" || umurTxt.Text == "" || alamatTxt.Text == "" || jurusanBox.SelectedIndex == -1)
            {
                MessageBox.Show("Tolong lengkapi data yang diperlukan terlebih dahulu");
            }
            var siswa = new Siswa();
            siswa.Nama = namaTxt.Text;
            siswa.Umur = Convert.ToInt32(umurTxt.Text);
            siswa.Alamat = alamatTxt.Text;
            siswa.JurusanID = Convert.ToInt32(jurusanBox.SelectedValue);
            db.Siswas.Add(siswa);
            db.SaveChanges();
            MessageBox.Show("Data berhasil di tambahkan");
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }   // Error handling agar ketika pengguna mengklik Header DGV, nilai Rowindex akan bernilai - 1
                // Jika kondisi tersebut terjadi, program akan langsung berhenti menggunakan perintah return

            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;  // untuk mengambil nama Kolom
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (columnName == "Update")
            {
                idSiswa = Convert.ToInt32(row.Cells["Id"].Value); // Mengambil value kolom id dari baris yang dipilih
                namaTxt.Text = row.Cells["Nama"].Value.ToString();
                umurTxt.Text = row.Cells["Umur"].Value.ToString();
                alamatTxt.Text = row.Cells["Alamat"].Value.ToString();
                jurusanBox.Text = row.Cells["Jurusan"].Value.ToString();

                addBtn.Text = "Update";
            }
            else if (columnName == "Delete")
            {
                var result = MessageBox.Show("Hapus Data Ini?", "Konfirmasi", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int idDelete = Convert.ToInt32(row.Cells["Id"].Value);
                    var siswa = db.Siswas.Find(idDelete);

                    if (siswa != null)
                    {
                        db.Siswas.Remove(siswa);
                        db.SaveChanges();
                        MessageBox.Show("Data berhasil di hapus!");

                    }
                }
                LoadData();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string key = searchTxt1.Text;

            if (key == "") // memasukkan error handling jika textbox search kosong
            {
                LoadData();
                return;
            }
                dataGridView1.DataSource = db.Siswas.Where(s => s.Nama.Contains(key) || s.Umur.ToString().Contains(key) || s.Alamat.Contains(key) || s.Jurusan.NamaJurusan.Contains(key))
                    .Select(s => new
                    {
                        s.Id,
                        s.Nama,
                        s.Umur,
                        s.Alamat,
                        Jurusan = s.Jurusan.NamaJurusan
                    })
                    .ToList();
        }
    }
}
