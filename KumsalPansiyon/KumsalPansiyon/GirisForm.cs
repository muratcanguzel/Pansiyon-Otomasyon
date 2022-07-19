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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris AdminGiris = new FrmAdminGiris();
            this.Hide();

            AdminGiris.ShowDialog();
            
           
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalisanGiris_Click(object sender, EventArgs e)
        {
            PersonelGiris FrmPersonel = new PersonelGiris();
            FrmPersonel.Show();
            this.Hide();
        }
    }
}
