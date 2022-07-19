using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KumsalPansiyon
{
    public partial class Hareketler : Form
    {
        public Hareketler()
        {
            InitializeComponent();
        }
        public void PersonelHareket()
        {
            try
            {
                FrmYeniMusteri.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * From Log";
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, FrmYeniMusteri.Baglanti);
                da.Fill(ds, "Log");
                dataGridView1.DataSource = ds.Tables["Log"];
                FrmYeniMusteri.Baglanti.Close();



            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Listeleme Hatası");

            }
        }

        private void Hareketler_Load(object sender, EventArgs e)
        {
            PersonelHareket();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            LogRapor frmcalisan = new LogRapor();
            frmcalisan.ShowDialog();
        }
    }
}
