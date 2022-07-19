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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        public void DoluOda()
        {
            FrmYeniMusteri.BaglantiAc();
            string sorgu = "Select * From Oda ";
            OleDbCommand Komut = new OleDbCommand(sorgu, FrmYeniMusteri.Baglanti);
            OleDbDataReader read = Komut.ExecuteReader();
            while (read.Read())
            {
                if (BtnOda102.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "1")
                { BtnOda102.BackColor = Color.Red;}
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
            FrmYeniMusteri.Baglanti.Close();
        }
        public void OdaTemizle()
        {
            FrmYeniMusteri.BaglantiAc();
            string Sorgu2 = "update Oda set Oda_Doluluk='0' where Oda_Numarasi like '" + label1.Text + "'";
            OleDbCommand Komut2 = new OleDbCommand(Sorgu2, FrmYeniMusteri.Baglanti);
            Komut2.ExecuteNonQuery();
            FrmYeniMusteri.Baglanti.Close();


            FrmYeniMusteri.BaglantiAc();
            string sorgu = "Select * From Oda ";
            OleDbCommand Komut = new OleDbCommand(sorgu, FrmYeniMusteri.Baglanti);
            OleDbDataReader read = Komut.ExecuteReader();
            while (read.Read())
            {
                if (BtnOda102.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "0")
                { BtnOda102.BackColor = Color.GreenYellow; }
                if (BtnOda104.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "0")
                { BtnOda104.BackColor = Color.GreenYellow; }
                if (BtnOda106.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "0")
                { BtnOda106.BackColor = Color.GreenYellow; }
                if (BtnOda108.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "0")
                { BtnOda108.BackColor = Color.GreenYellow; }
                if (BtnOda202.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "0")
                { BtnOda202.BackColor = Color.GreenYellow; }
                if (BtnOda204.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "0")
                { BtnOda204.BackColor = Color.GreenYellow; }
                if (BtnOda206.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "0")
                { BtnOda206.BackColor = Color.GreenYellow; }
                if (BtnOda208.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "0")
                { BtnOda208.BackColor = Color.GreenYellow; }
                if (BtnOda302.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "0")
                { BtnOda302.BackColor = Color.GreenYellow; }
                if (BtnOda304.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "0")
                { BtnOda304.BackColor = Color.GreenYellow; }
                if (BtnOda306.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "0")
                { BtnOda306.BackColor = Color.GreenYellow; }
                if (BtnOda308.Text == read["Oda_Numarasi"].ToString() && read["Oda_Doluluk"].ToString() == "0")
                { BtnOda308.BackColor = Color.GreenYellow; }
            }
            FrmYeniMusteri.Baglanti.Close(); 
        }

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            DoluOda();
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            label1.Text = "102";
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            label1.Text = "104";
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            label1.Text = "106";
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            label1.Text = "108";
        }

        private void BtnOda202_Click(object sender, EventArgs e)
        {
            label1.Text = "202";
        }

        private void BtnOda204_Click(object sender, EventArgs e)
        {
            label1.Text = "204";
        }

        private void BtnOda206_Click(object sender, EventArgs e)
        {
            label1.Text = "206";
        }

        private void BtnOda208_Click(object sender, EventArgs e)
        {
            label1.Text = "208";
        }

        private void BtnOda302_Click(object sender, EventArgs e)
        {
            label1.Text = "302";
        }

        private void BtnOda304_Click(object sender, EventArgs e)
        {
            label1.Text = "304";
        }

        private void BtnOda306_Click(object sender, EventArgs e)
        {
            label1.Text = "306";
        }

        private void BtnOda308_Click(object sender, EventArgs e)
        {
            label1.Text = "308";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            OdaTemizle();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
