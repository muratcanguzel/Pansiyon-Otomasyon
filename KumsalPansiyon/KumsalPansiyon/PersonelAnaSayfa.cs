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
    public partial class PersonelAnaSayfa : Form
    {
        public PersonelAnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri FrmMusteri = new FrmYeniMusteri();
            FrmMusteri.ShowDialog();
        }

        private void PersonelAnaSayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOdalar FrOda = new FrmOdalar();
            FrOda.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MüsteriListele frmmüsteriler = new MüsteriListele();
            frmmüsteriler.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Raporlama frmrapor = new Raporlama();
            frmrapor.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnRadyo_Click(object sender, EventArgs e)
        {
            RadyoDinle frmradyo = new RadyoDinle();
            frmradyo.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }
    }
}
