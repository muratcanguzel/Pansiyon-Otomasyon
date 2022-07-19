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
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();


        }
        

        public static OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=pansiyonVt.accdb");
        public static void BaglantiAc()
        {
            try
            {
                Baglanti.Open();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Bağlantı Açma Hata Penceresi");

            }
        }
        public void Log1()
        {

            BaglantiAc();
            string LogSorgu = "Insert Into Log (Personelid,Islemsaati,Yapilanİslem) values (@Personelid,@Islemsaati,@Yapilanİslem)";
            OleDbCommand komut = new OleDbCommand(LogSorgu, Baglanti);
            komut.Parameters.AddWithValue("@Personelid", SabitYetki.pId);
            komut.Parameters.AddWithValue("@Islemsaati", DateTime.Now.ToString());
            komut.Parameters.AddWithValue("@Yapilanİslem", "Yeni Müşteri Ekledi");
            komut.ExecuteNonQuery();
            Baglanti.Close();


        }
       
        public void DoluOda()
        {
            BaglantiAc();
            string sorgu = "Select * From Oda";
            OleDbCommand Komut = new OleDbCommand(sorgu, Baglanti);
            OleDbDataReader read = Komut.ExecuteReader();
            while (read.Read())
            {
                if (BtnOda102.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "1")
                { BtnOda102.BackColor = Color.Red;  }
                if (BtnOda104.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "1")
                { BtnOda104.BackColor = Color.Red; }
                if (BtnOda106.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "1")
                { BtnOda106.BackColor = Color.Red; }
                if (BtnOda108.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "1")
                { BtnOda108.BackColor = Color.Red; }
                if (BtnOda202.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "1")
                { BtnOda202.BackColor = Color.Red; }
                if (BtnOda204.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "1")
                { BtnOda204.BackColor = Color.Red; }
                if (BtnOda206.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "1")
                { BtnOda206.BackColor = Color.Red; }
                if (BtnOda208.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "1")
                { BtnOda208.BackColor = Color.Red; }
                if (BtnOda302.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "1")
                { BtnOda302.BackColor = Color.Red; }
                if (BtnOda304.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "1")
                { BtnOda304.BackColor = Color.Red; }
                if (BtnOda306.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "1")
                { BtnOda306.BackColor = Color.Red; }
                if (BtnOda308.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "1")
                { BtnOda308.BackColor = Color.Red; }

            }
            Baglanti.Close();
        }

        public void Kayitekle()
        {
            try
            {
                BaglantiAc();
                string Sorgu = "Insert Into YeniMüsteri (M_Adi,M_Soyadi,M_Cinsiyet,M_Telefon,M_Mail,M_TC,Oda_No,Ucret,OdemeTuru,GirisTarihi,CikisTarihi) Values (@M_Adi,@M_Soyadi,@M_Cinsiyet,@M_Telefon,@M_Mail,@M_TC,@Oda_No,@Ucret,@OdemeTuru,@GirisTarihi,@CikisTarihi)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Baglanti);
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
               
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(TxtAdi.Text + " " + TxtSoyadi.Text + " İsimli Kayıt Eklendi");
                Baglanti.Close();
                BaglantiAc();
                string Sorgu2 = "update Oda set Oda_Doluluk='1' where Oda_Numarasi like '" + TxtOdaNo.Text + "'";
                OleDbCommand Komut2 = new OleDbCommand(Sorgu2, Baglanti);
                Komut2.ExecuteNonQuery();
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");

            }
        }
      
    
    
        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            DoluOda();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
        }

        private void BtnOda202_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "202";
        }

        private void BtnOda204_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "204";
        }

        private void BtnOda206_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "206";
        }

        private void BtnOda208_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "208";
        }

        private void BtnOda302_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "302";
        }

        private void BtnOda304_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "304";
        }

        private void BtnOda306_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "306";
        }

        private void BtnOda308_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "308";
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir.");
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;
            label12.Text = Sonuc.TotalDays.ToString();
            if (TxtOdaNo.Text == "102" || TxtOdaNo.Text == "104"|| TxtOdaNo.Text == "106" ||  TxtOdaNo.Text=="108")
            {
                Ucret = Convert.ToInt32(label12.Text) * 200 ;
                TxtUcret.Text = Ucret.ToString();
            }
            else if (TxtOdaNo.Text == "202" || TxtOdaNo.Text == "204" || TxtOdaNo.Text == "206" || TxtOdaNo.Text == "208")
            {
                Ucret = Convert.ToInt32(label12.Text) * 250;
                TxtUcret.Text = Ucret.ToString();
            }
            if (TxtOdaNo.Text == "302" || TxtOdaNo.Text == "304" || TxtOdaNo.Text == "306" || TxtOdaNo.Text == "308")
            {
                Ucret = Convert.ToInt32(label12.Text) * 300;
                TxtUcret.Text = Ucret.ToString();
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Kayitekle();
            DoluOda();
            Log1();
            
           
        }
    }
}
