using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContohSoal
{
    public partial class Form3Dashboard : Form
    {
        public Form3Dashboard()
        {
            InitializeComponent();
        }

        private void ShowMarketplace(object sender, EventArgs e)
        {
            Form4Bandara marketplace = new Form4Bandara();
            this.Hide();
            marketplace.Show();
        }

        private void ShowService(object sender, EventArgs e)
        {
            Form5Maskapai service = new Form5Maskapai();
            this.Hide();
            service.Show();
        }

        private void ShowJadwalService(object sender, EventArgs e)
        {
            Form6JadwalPenerbangan jadwalservice = new Form6JadwalPenerbangan();
            this.Hide();
            jadwalservice.Show();
        }

        private void ShowVoucherMember(object sender, EventArgs e)
        {
            Form7KodePromo Vouchermember = new Form7KodePromo();
            this.Hide();
            Vouchermember.Show();
        }

        private void ShowRiwayat(object sender, EventArgs e)
        {
            Form8UbahStatusPenerbangan riwayat = new Form8UbahStatusPenerbangan();
            this.Hide();
            riwayat.Show();
        }

        private void BackToLogin(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Hide();
            login.Show();
        }
    }
}
