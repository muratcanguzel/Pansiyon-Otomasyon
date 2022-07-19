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
    public partial class Birimler : Form
    {
        public Birimler()
        {
            InitializeComponent();
        }
        public void BirimEkle()
        {
            try
            {
                FrmYeniMusteri.BaglantiAc();
                string Sorgu = "Insert Into Birimler (BirimAdi) Values (@BirimAdi)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, FrmYeniMusteri.Baglanti);
                EkleKomut.Parameters.AddWithValue("@BirimAdi", txtBirimAdi.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtBirimAdi.Text + " Birimi Eklendi");
                FrmYeniMusteri.Baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Birim Ekleme Hatası");
            }
        }

        public void BirimListele()
        {
            try
            {
                FrmYeniMusteri.BaglantiAc();
                DataSet ds = new DataSet();
                string SorguListele = "Select * From Birimler";
                OleDbDataAdapter da = new OleDbDataAdapter(SorguListele, FrmYeniMusteri.Baglanti);
                da.Fill(ds, "Birimler");
                dataGridView1.DataSource = ds.Tables["Birimler"];
                FrmYeniMusteri.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Birim Listele Hata Penceresi");
            }
        }
        public void Birimsil()
        {
            try
            {
                FrmYeniMusteri.BaglantiAc();
                string Sorgu = "delete from Birimler where BirimKod=" + txtBirimKod.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, FrmYeniMusteri.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(txtBirimKod.Text + " nolu Kayıt Silindi");
                }
                FrmYeniMusteri.Baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Birim Sil Hata Penceresi");
            }

        }
        public void BirimDegistir()
        {
            try
            {
                FrmYeniMusteri.BaglantiAc();
                string Sorgu = "update Birimler set BirimAdi=@BirimAdi where BirimKod=@BirimKod";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, FrmYeniMusteri.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@BirimAdi", txtBirimAdi.Text);

                DegistirKomut.Parameters.AddWithValue("@BirimKod", txtBirimKod.Text);
                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtBirimKod.Text + " " + " nolu birim Değiştirildi");
                FrmYeniMusteri.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Birim Değiştir Hata Penceresi");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Birimler_Load(object sender, EventArgs e)
        {
            BirimListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBirimKod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBirimAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtBirimKod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBirimAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            txtBirimKod.Text = "";
            txtBirimAdi.Text = ""; 
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtBirimAdi.Text == "")
            {
                MessageBox.Show("Lütfen birim adını giriniz.", "Boşluk Kontrol");
                txtBirimAdi.Focus();
            }
            else if (txtBirimKod.Text != "")
            {
                MessageBox.Show("Temizle butonuna basınız.");
                btnTemizle.Focus();
            }
            else
            {
                BirimEkle();
                BirimListele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show(txtBirimKod.Text + " Kodlu Kayıt Silinecektir.\nOnaylıyor Musunuz?", "Kayıt silme onay", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cevap == DialogResult.Yes)
            {
                Birimsil();
                BirimListele();
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi.");
                this.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtBirimKod.Text == "")
                MessageBox.Show("Güncellenecek veriyi seçiniz");
            else
            {
                BirimDegistir();
                BirimListele();

            }
        }
    }
}
