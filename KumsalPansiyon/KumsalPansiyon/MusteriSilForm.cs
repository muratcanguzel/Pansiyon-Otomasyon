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
    public partial class MusteriSilForm : Form
    {
        public MusteriSilForm()
        {
            InitializeComponent();
        }
        public void kayitsil()
        {
            try
            {
                FrmYeniMusteri.BaglantiAc();
                string Sorgu = "delete from YeniMüsteri where Müsteriid=" + txtID.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, FrmYeniMusteri.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(txtID.Text + " ID'li Kayıt Silindi");
                }
                FrmYeniMusteri.Baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Kayıt Sil Hata Penceresi");
            }

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show(txtID.Text + " ID'li Kayıt Silinecektir.\nOnaylıyor Musunuz?", "Kayıt silme onay", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cevap == DialogResult.Yes)
            {
                kayitsil();
                this.Close();
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi.");
                this.Close();
            }
        }
    }
}
