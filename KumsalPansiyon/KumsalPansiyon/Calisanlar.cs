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
    public partial class Calisanlar : Form
    {
        public Calisanlar()
        {
            InitializeComponent();
        }

        public static OleDbConnection Baglanti = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=pansiyonVt.accdb");
        public static void BaglantiAc()
        {
            try
            {
                Baglanti.Open();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                
            }
        }
        public void CalisanListele()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * From Calisanlar";
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu,Baglanti);
                da.Fill(ds, "Calisanlar");
                dataGridView1.DataSource = ds.Tables["Calisanlar"];
                Baglanti.Close();



            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Listeleme Hatası");
                
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            CalisanListele();
        }

        private void Calisanlar_Activated(object sender, EventArgs e)
        {
            Baglanti.Close();
            CalisanListele();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            CalisanEkle frmekle = new CalisanEkle();
            frmekle.ShowDialog();

        }

        private void btnCalisanSil_Click(object sender, EventArgs e)
        {
            CalisanSil frmsil = new CalisanSil();
            frmsil.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmsil.txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmsil.txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmsil.txtTel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmsil.cmbYetki.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmsil.ShowDialog();
            

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            CalisanYenile frmyenile = new CalisanYenile();
            frmyenile.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmyenile.txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmyenile.txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmyenile.txtTel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmyenile.cmbYetki.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmyenile.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Calisanlar_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RaporCalisan frmcalisanrapor = new RaporCalisan();
            frmcalisanrapor.ShowDialog();
        }
    }
}
