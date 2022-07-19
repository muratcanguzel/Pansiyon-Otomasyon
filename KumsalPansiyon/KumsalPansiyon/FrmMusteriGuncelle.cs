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
    public partial class FrmMusteriGuncelle : Form
    {
        public FrmMusteriGuncelle()
        {
            InitializeComponent();
        }
        public void KayitGuncelle()
        {
            try
            {
                FrmYeniMusteri.BaglantiAc();
                string Sorgu = "update YeniMüsteri set  M_Adi=@M_Adi,M_Soyadi=@M_Soyadi,M_Cinsiyet=@M_Cinsiyet,M_Telefon=@M_Telefon,M_Mail=@M_Mail,M_TC=@M_TC,Oda_No=@Oda_No,Ucret=@Ucret,OdemeTuru=@OdemeTuru,GirisTarihi=@GirisTarihi,CikisTarihi=@CikisTarihi where Müsteriid=@Müsteriid ";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, FrmYeniMusteri.Baglanti);
                EkleKomut.Parameters.AddWithValue("@M_Adi", TxtAdi.Text);
                EkleKomut.Parameters.AddWithValue("@M_Soyadi", TxtSoyadi.Text);
                EkleKomut.Parameters.AddWithValue("@M_Cinsiyet", cmbCinsiyet.Text);
                EkleKomut.Parameters.AddWithValue("@M_Telefon", MskTxtTelefon.Text);
                EkleKomut.Parameters.AddWithValue("@M_Mail", TxtMail.Text);
                EkleKomut.Parameters.AddWithValue("@M_TC", TxtKimlikNo.Text);
                EkleKomut.Parameters.AddWithValue("@Oda_No", TxtOdaNo.Text);
                EkleKomut.Parameters.AddWithValue("@Ucret", TxtUcret.Text);
                EkleKomut.Parameters.AddWithValue("@OdemeTuru", cmbOdemeTuru.Text);
                EkleKomut.Parameters.AddWithValue("@GirisTarihi", DtpGirisTarihi.Value.ToShortDateString());
                EkleKomut.Parameters.AddWithValue("@CikisTarihi", DtpCikisTarihi.Value.ToShortDateString());
                EkleKomut.Parameters.AddWithValue("@Müsteriid", txtId.Text);

                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(TxtAdi.Text + " " + TxtSoyadi.Text + " İsimli Kayıt Güncellendi");
                FrmYeniMusteri.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Güncelle Hata Penceresi");

            }
        }


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
                KayitGuncelle();
            
            
        }

        private void FrmMusteriGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
