using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KumsalPansiyon
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void boslukkontrol()
        {
            txtKad.BackColor = Color.White;
            txtSifre.BackColor = Color.White;
            if (txtSifre.Text == "")
            {
                txtSifre.BackColor = Color.Red;
                txtSifre.Focus();
            }
            if (txtKad.Text == "")
            {
                txtKad.BackColor = Color.Red;
                txtKad.Focus();
            }
            if (txtKad.Text == "" || txtSifre.Text == "")
                MessageBox.Show("Eksik Veri Girişi Lütfen Kontrol Ediniz.", "Veri Girişi");
            else if (txtKad.Text == "admin" && txtSifre.Text == "admin")
            {
                FrmAnaForm frmana = new FrmAnaForm();
                frmana.ShowDialog();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Lütfen Kontrol Ediniz", "Veri Girişi");
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            boslukkontrol();
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisForm Login = new GirisForm();
            this.Hide();
            Login.ShowDialog();
        }
    }
}
