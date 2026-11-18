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
    public partial class Form6JadwalService : Form
    {
        BandaraEntities2 db = new BandaraEntities2();
        private int idJadwalService = -1;


        public Form6JadwalService()
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

        private void Form6Jadwalservice_Load(object sender, EventArgs e)
        {
            LoadBandara();
            LoadMaskapai();
            LoadJadwal();
        }

        private void LoadBandara()
        {
            nomorBox.DataSource = db.Bandaras.OrderBy(b => b.Nama).ToList();
            nomorBox.DisplayMember = "Nama";
            nomorBox.ValueMember = "ID";
            nomorBox.SelectedIndex = -1;

            //
            cabangBox.DataSource = db.Bandaras.OrderBy(b => b.Nama).ToList();
            cabangBox.DisplayMember = "Nama";
            cabangBox.ValueMember = "ID";
            cabangBox.SelectedIndex = -1;
        }

        private void LoadMaskapai()
        {
            namaBox.DataSource = db.Maskapais.OrderBy(b => b.Nama).ToList();
            namaBox.DisplayMember = "Nama";
            namaBox.ValueMember = "ID";
            namaBox.SelectedIndex = -1;
        }

        private void LoadJadwal()
        {
            dataGridJadwal.DataSource = db.JadwalPenerbangans.OrderByDescending(j => j.TanggalKeberangkatan)
                .ThenByDescending(j => j.WaktuKeberangkatan)
                .Select(j => new
                {
                    j.ID,
                    j.KodePenerbangan,
                    BandaraAsal = j.Bandara.Nama,
                    BandaraTujuan = j.Bandara1.Nama,
                    Maskapai = j.Maskapai.Nama,
                    j.TanggalKeberangkatan,
                    j.DurasiPenerbangan,
                    j.HargaPerTiket
                }).ToList();
        }

        private void ClearForm()
        {
            kodeTxt.Clear();
            durasiTxt.Text = "__ Jam __ Menit";

            nomorBox.SelectedIndex = -1;
            cabangBox.SelectedIndex = -1;
            namaBox.SelectedIndex = -1;

            tanggalDate.Value = DateTime.Now;
            waktuTxt.Value = DateTime.Now;

            hargaCount.Value = 0;

            idJadwalService = -1;

            saveBtn.Text = "Simpan";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // validasi input kosong
            if (kodeTxt.Text == "" || durasiTxt.Text == "" || nomorBox.SelectedIndex == -1 || cabangBox.SelectedIndex == -1 || namaBox.SelectedIndex == -1)
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            // validasi kode penerbangan (cukup panjang)
            // format kode harus AA-0000 (2 huruf, 1 strip, 4 angka)

            if (kodeTxt.Text.Length != 7)
            {
                MessageBox.Show("Format kode: AA-0000");
                return;
            }

            if (!char.IsLetter(kodeTxt.Text[0]) || !char.IsLetter(kodeTxt.Text[1]))
            {
                MessageBox.Show("2 karakter pertama harus berupa huruf");
                return;
            }

            if (kodeTxt.Text[2] != '-')
            {
                MessageBox.Show("Kode harus mengandung '-'");
                return;
            }

            if (!char.IsDigit(kodeTxt.Text[3]) || !char.IsDigit(kodeTxt.Text[4]) || !char.IsDigit(kodeTxt.Text[5]) || !char.IsDigit(kodeTxt.Text[6]))
            {
                MessageBox.Show("4 karakter terakhir harus berupa angka");
                return;
            }

            // validasi bandara
            // keberangkatan dan tujuan tidak boleh sama
            if (nomorBox.SelectedValue.Equals(cabangBox.SelectedValue))
            {
                MessageBox.Show("Bandara asal dan tujuan tidak boleh sama!");
                return;
            }

            // validasi format durasi
            string[] durasi = durasiTxt.Text.Split(' '); // memisah durasi menjadi beberapa bagian

            // harus terdiri dari 4 bagian
            if (durasi.Length != 4)
            {
                MessageBox.Show("Format durasi : xx Jam xx Menit");
                return;
            }

            // bagian kedua harus "jam"
            // bagian keempat harus "menit"
            if (durasi[1] != "Jam" || durasi[3] != "Menit")
            {
                MessageBox.Show("Format durasi : xx Jam xx Menit");
                return;
            }

            // bagian pertama dan ketiga harus angla
            if (!durasi[0].All(char.IsDigit) || !durasi[2].All(char.IsDigit))
            {
                MessageBox.Show("Jam dan Menit harus berupa Angka");
                return;
            }

            int jam = Convert.ToInt32(durasi[0]);
            int menit = Convert.ToInt32(durasi[2]);

            int totalMenit = (jam * 60) + menit;

            // validasi harga
            if (hargaCount.Value < 1)
            {
                MessageBox.Show("Harga tidak valid");
                return;
            }

            // validasi tanggal keberangkatan tidak boleh hari sebelum hari ini
            if (tanggalDate.Value < DateTime.Today)
            {
                MessageBox.Show("Tanggal keberangkatan tidak boleh hari kemarin");
                return;
            }

            MessageBox.Show("Data berhasil ditambahkan");

            if (idJadwalService == -1) // mode tambah
            {
                JadwalPenerbangan jadwalBaru = new JadwalPenerbangan();
                PerubahanStatusJadwalPenerbangan statusJadwal = new PerubahanStatusJadwalPenerbangan();

                jadwalBaru.KodePenerbangan = kodeTxt.Text;
                jadwalBaru.BandaraKeberangkatanID = Convert.ToInt32(nomorBox.SelectedValue);
                jadwalBaru.BandaraTujuanID = Convert.ToInt32(cabangBox.SelectedValue);
                jadwalBaru.MaskapaiID = Convert.ToInt32(namaBox.SelectedValue);
                jadwalBaru.TanggalKeberangkatan = tanggalDate.Value.Date + waktuTxt.Value.TimeOfDay;
                jadwalBaru.DurasiPenerbangan = totalMenit; // kita akan membuatkan variabel untuk memformat teks durasi
                jadwalBaru.HargaPerTiket = Convert.ToInt32(hargaCount.Value);

                db.JadwalPenerbangans.Add(jadwalBaru);
                db.SaveChanges();

                statusJadwal.JadwalPenerbanganID = jadwalBaru.ID;
                statusJadwal.StatusPenerbanganID = 1;
                statusJadwal.WaktuPerubahanTerjadi = DateTime.Now;
                statusJadwal.PerkiraanDurasiDelay = null;

                db.PerubahanStatusJadwalPenerbangans.Add(statusJadwal);
                MessageBox.Show("Jadwal berhasil dibuat");
            }
            else
            {
                JadwalPenerbangan editJadwal = db.JadwalPenerbangans.Find(idJadwalService);

                editJadwal.KodePenerbangan = kodeTxt.Text;
                editJadwal.BandaraKeberangkatanID = Convert.ToInt32(nomorBox.SelectedValue);
                editJadwal.BandaraTujuanID = Convert.ToInt32(cabangBox.SelectedValue);
                editJadwal.MaskapaiID = Convert.ToInt32(namaBox.SelectedValue);
                editJadwal.TanggalKeberangkatan = tanggalDate.Value.Date + waktuTxt.Value.TimeOfDay;
                editJadwal.DurasiPenerbangan = totalMenit; // kita akan membuatkan variabel untuk memformat teks durasi
                editJadwal.HargaPerTiket = Convert.ToInt32(hargaCount.Value);

                MessageBox.Show("Jadwal berhasil diubah");
            }

            db.SaveChanges();
            ClearForm();
            LoadJadwal();
        }

        private void dataGridJadwal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridJadwal.Columns[e.ColumnIndex].Name == "edit")
            {
                // edit
                idJadwalService = Convert.ToInt32(dataGridJadwal.Rows[e.RowIndex].Cells["ID"].Value);

                JadwalPenerbangan editJadwal = db.JadwalPenerbangans.Find(idJadwalService);

                // format durasi
                int jam = editJadwal.DurasiPenerbangan / 60;
                int menit = editJadwal.DurasiPenerbangan % 60;

                string menitKeDurasi = jam + " Jam " + menit + " Menit";

                kodeTxt.Text = editJadwal.KodePenerbangan;
                nomorBox.SelectedValue = editJadwal.BandaraKeberangkatanID;
                cabangBox.SelectedValue = editJadwal.BandaraTujuanID;
                namaBox.SelectedValue = editJadwal.MaskapaiID;
                tanggalDate.Value = editJadwal.TanggalKeberangkatan;
                waktuTxt.Value = editJadwal.TanggalKeberangkatan;
                durasiTxt.Text = menitKeDurasi; // nanti kita akan buatkan variabel untuk mengubah total menit ke format durasi
                hargaCount.Value = Convert.ToInt32(editJadwal.HargaPerTiket);

                saveBtn.Text = "Update";
            }
            else if (dataGridJadwal.Columns[e.ColumnIndex].Name == "hapus")
            {
                int id = Convert.ToInt32(dataGridJadwal.Rows[e.RowIndex].Cells["ID"].Value);

                var hasil = MessageBox.Show("Apakah anda yakin menghapus jadwal ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    var hapusJadwal = db.JadwalPenerbangans.Find(id);

                    db.JadwalPenerbangans.Remove(hapusJadwal);
                    db.SaveChanges();

                    LoadJadwal();
                    ClearForm();

                    MessageBox.Show("Data berhasil dihapus");
                }
            }
        }
    }
}