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
    public partial class CalisanSil : Form
    {
        public CalisanSil()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void KayitSil()
        {
            try
            {
                Calisanlar.BaglantiAc();
                string Sorgu = "delete from Calisanlar where Calisan_ID=" + txtId.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Calisanlar.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(txtId.Text + " ID'li Çalışan Silindi. ");
                }
                Calisanlar.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Silme Hatası");
                
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult Cevap;
            Cevap = MessageBox.Show(txtId.Text + " ID'li Çalışanı Silmek İstiyor Musunuz?", "Çalışan Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (Cevap == DialogResult.Yes)
            {
                MessageBox.Show("Kayıt Silindi");
                KayitSil();
                this.Close();

            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi.");
                this.Close();
            }
        }

        private void CalisanSil_Load(object sender, EventArgs e)
        {
            
        }
    }
}
