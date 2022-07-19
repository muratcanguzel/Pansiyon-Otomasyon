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
    public partial class CalisanEkle : Form
    {
        public CalisanEkle()
        {
            InitializeComponent();
        }

        public bool BoslukKontrol()
        {
            bool bos = false;
            cmbYetki.BackColor = Color.White;
            txtTel.BackColor = Color.White;
            txtSoyad.BackColor = Color.White;
            txtkad.BackColor = Color.White;
            if (cmbYetki.Text == "")
            {
                cmbYetki.BackColor = Color.Red;
                cmbYetki.Focus();
                bos = true;
            }
            if (txtTel.Text == "")
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
            if (txtkad.Text == "")
            {
                txtkad.BackColor = Color.Red;
                txtkad.Focus();
                bos = true;
            }
            return bos;
            
                
        }
        public void KayitEkle()
        {
            try
            {
                Calisanlar.BaglantiAc();
                string Sorgu = "Insert Into Calisanlar ( Calisan_Ad,Calisan_Soyad,Calisan_Tel,Calisan_Yetki) Values (@Calisan_Ad,@Calisan_Soyad,@Calisan_Tel,@Calisan_Yetki)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Calisanlar.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Calisan_Ad", txtkad.Text);
                EkleKomut.Parameters.AddWithValue("@Calisan_Soyad", txtSoyad.Text);
                EkleKomut.Parameters.AddWithValue("@Calisan_Tel", txtTel.Text);
                EkleKomut.Parameters.AddWithValue("@Calisan_Yetki", cmbYetki.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(txtkad.Text + " " + txtSoyad.Text + " Adlı Çalışan Eklendi ");
                }
                Calisanlar.Baglanti.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Çalışan Ekleme Hatası");
                
                
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
    
        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Lütfen Boş Kısımları Doldurunuz.", "Boşluk Hatası");
            else
                KayitEkle();
        }

        private void CalisanEkle_Load(object sender, EventArgs e)
        {
            BirimYukle();
        }
    }
}
