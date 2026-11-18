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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public int NomorPenumpang
        {
            set
            {
                numberLabel.Text = "Penumpang #" + value;
            }
        }

        public string Titel
        {
            get
            {
                return titleBox.Text;
            }
        }

        public string NamaLengkap
        {
            get
            {
                return fullNameText.Text.Trim();
            }
        }

        public bool DataSudahLengkap
        {
            get
            {
                return titleBox.SelectedIndex != 1 && !string.IsNullOrWhiteSpace(fullNameText.Text);
            }
        }
    }
}
