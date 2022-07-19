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
    public partial class CalisanYenile : Form
    {
        public CalisanYenile()
        {
            InitializeComponent();
        }

        public void KayitGuncelle()
        {
            try
            {
                Calisanlar.BaglantiAc();
                string Sorgu = "update Calisanlar set Calisan_Ad=@Calisan_Ad,Calisan_Soyad=@Calisan_Soyad,Calisan_Tel=@Calisan_Tel,Calisan_Yetki=@Calisan_Yetki where Calisan_ID=@Calisan_ID";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, Calisanlar.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@Calisan_Ad", txtAd.Text);
                DegistirKomut.Parameters.AddWithValue("@Calisan_Soyad", txtSoyad.Text);
                DegistirKomut.Parameters.AddWithValue("@Calisan_Tel", txtTel.Text);
                DegistirKomut.Parameters.AddWithValue("@Calisan_Yetki", cmbYetki.Text);
                DegistirKomut.Parameters.AddWithValue("@Calisan_ID", txtId.Text);
                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + " İsimli Kayıt Değiştirildi.");
                Calisanlar.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Düzenle Hata Penceresi");
                
            }
        }
        public void BirimYukle()
        {
            try
            {
                FrmYeniMusteri.BaglantiAc();
                string Sorgu = "Select BirimAdi From Birimler";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, FrmYeniMusteri.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbYetki.Items.Add(dr["BirimAdi"]);
                }
                FrmYeniMusteri.Baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Veri Yükleme Hatası");
            }
        }
        public bool BoslukKontrol()
        {
            bool bos = false;
            txtAd.BackColor = Color.White;
            txtSoyad.BackColor = Color.White;
            txtTel.BackColor = Color.White;
            cmbYetki.BackColor = Color.White;
            if (cmbYetki.Text == "Birim Seçiniz" || cmbYetki.Text == "")
            {
                cmbYetki.BackColor = Color.Red;
                cmbYetki.Focus();
                bos = true;
            }
            if (txtTel.Text == "(   )    -" || txtTel.Text.Length != 14)
            {
                txtTel.BackColor = Color.Red;
                txtTel.Focus();
                bos = true;
            }
            if (txtSoyad.Text == "")
            {
                txtSoyad.BackColor = Color.Red;
                txtSoyad.Focus();
                bos = true;

            }
            if (txtAd.Text == "")
            {
                txtAd.BackColor = Color.Red;
                txtAd.Focus();
                bos = true;

            }
            return bos;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş Alanları Doldurunuz", "Dikkat");
            else
                KayitGuncelle();
        }

        private void CalisanYenile_Load(object sender, EventArgs e)
        {
            BirimYukle();
        }

        private void cmbYetki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
