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
    public partial class Form8Riwayat : Form
    {
        public Form8Riwayat()
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
    }
}
