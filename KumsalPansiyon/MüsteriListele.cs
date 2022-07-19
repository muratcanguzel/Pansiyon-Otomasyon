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
    public partial class MüsteriListele : Form
    {
        public MüsteriListele()
        {
            InitializeComponent();
        }
        public void KayitListele()
        {
            try
            {
                FrmYeniMusteri.BaglantiAc();
                DataSet ds = new DataSet();
                string SorguListele = "Select * From YeniMüsteri";
                OleDbDataAdapter da = new OleDbDataAdapter(SorguListele, FrmYeniMusteri.Baglanti);
                da.Fill(ds, "YeniMüsteri");
                dataGridView1.DataSource = ds.Tables["YeniMüsteri"];
                FrmYeniMusteri.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, " Kayıt Listele Hata Penceresi");
            }
        }
        public void HizliAra()
        {
            try
            {
                FrmYeniMusteri.BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "Select * From YeniMüsteri";
                string SorguTcnoilebaslayan = "Select * from YeniMüsteri where M_TC like '" + txtHizliara.Text + "%' ";
                string SorguTcnoilebiten = "Select * from YeniMüsteri where M_TC like '%" + txtHizliara.Text + "' ";
                string SorguTcnoiceren = "Select * from YeniMüsteri where M_TC like '%" + txtHizliara.Text + "%' ";
                string SorguDyerilebaslayan = "Select * from YeniMüsteri where M_Adi  like '" + txtHizliara.Text + "%'";
                string SorguDyerilebiten = "Select * from YeniMüsteri where M_Adi  like '%" + txtHizliara.Text + "'";
                string SorguDyericeren = "Select * from YeniMüsteri where M_Adi like '%" + txtHizliara.Text + "%'";
                if (radTcno.Checked == true)
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        SorguTumKayitlar = SorguTcnoilebaslayan;
                    }
                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        SorguTumKayitlar = SorguTcnoilebiten;
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        SorguTumKayitlar = SorguTcnoiceren;
                    }
                }
                else if (radDyer.Checked == true)
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        SorguTumKayitlar = SorguDyerilebaslayan;
                    }
                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        SorguTumKayitlar = SorguDyerilebiten;
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        SorguTumKayitlar = SorguDyericeren;
                    }
                }
                OleDbDataAdapter da = new OleDbDataAdapter(SorguTumKayitlar, FrmYeniMusteri.Baglanti);
                da.Fill(ds, "YeniMüsteri");
                dataGridView1.DataSource = ds.Tables["YeniMüsteri"];
                FrmYeniMusteri.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, " Hızlı Ara Hata Penceresi");
            }
        }

        private void MüsteriListele_Load(object sender, EventArgs e)
        {

        }

        private void MüsteriListele_Activated(object sender, EventArgs e)
        {
            FrmYeniMusteri.Baglanti.Close();
            KayitListele();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radDyer_CheckedChanged(object sender, EventArgs e)
        {
            lblArananalan.Text = "Ad :";
            txtHizliara.Focus();
            txtHizliara.Text = "";
        }

        private void radTcno_CheckedChanged(object sender, EventArgs e)
        {
            lblArananalan.Text = "TC No :";
            txtHizliara.Focus();
            txtHizliara.Text = "";
        }

        private void txtHizliara_TextChanged(object sender, EventArgs e)
        {
            HizliAra();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MusteriSilForm frmSil = new MusteriSilForm();
            frmSil.txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmSil.txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmSil.txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmSil.txtTc.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frmSil.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmMusteriGuncelle frmGuncelle = new FrmMusteriGuncelle();

            frmGuncelle.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmGuncelle.TxtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmGuncelle.TxtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmGuncelle.cmbCinsiyet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmGuncelle.MskTxtTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmGuncelle.TxtMail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmGuncelle.TxtKimlikNo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frmGuncelle.TxtOdaNo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frmGuncelle.TxtUcret.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frmGuncelle.cmbOdemeTuru.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frmGuncelle.DtpGirisTarihi.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frmGuncelle.DtpCikisTarihi.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            
            frmGuncelle.ShowDialog();
        }
    }
}
