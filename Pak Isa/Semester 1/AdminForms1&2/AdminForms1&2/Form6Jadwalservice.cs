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
            loadBandara();
            LoadMaskapai();
            LoadJadwalService();
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

    }
}