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
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }
        public static string Kullanıcıadı;
        OleDbConnection baglan = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=pansiyonVt.accdb");
        
       

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisForm Grs = new GirisForm();
            Grs.Show();
            this.Hide();

            
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select *from Calisanlar where Calisan_ID=@Calisan_ID and Calisan_Sifre=@Calisan_Sifre",baglan);
            da.SelectCommand.Parameters.AddWithValue("Calisan_ID", txtPersonelKad.Text);
            da.SelectCommand.Parameters.AddWithValue("Calisan_Sifre", txtPersonelSifre.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count>0)
            {
                SabitYetki.pId = dt.Rows[0]["Calisan_ID"].ToString();
                SabitYetki.pAd = dt.Rows[0]["Calisan_Ad"].ToString();
                SabitYetki.pSoyad = dt.Rows[0]["Calisan_Soyad"].ToString();
                SabitYetki.pYetki = dt.Rows[0]["Calisan_Yetki"].ToString();
                this.Hide();
                PersonelAnaSayfa frmpersonel = new PersonelAnaSayfa();
                frmpersonel.Show();

                string LogSorgu = "Insert Into Log (Personelid,Islemsaati,Yapilanİslem) values (@Personelid,@Islemsaati,@Yapilanİslem)";
                OleDbCommand komut = new OleDbCommand(LogSorgu, baglan);
                komut.Parameters.AddWithValue("@Personelid", SabitYetki.pId);
                komut.Parameters.AddWithValue("@Islemsaati", DateTime.Now.ToString());
                komut.Parameters.AddWithValue("@Yapilanİslem", "Giriş Yaptı");
                komut.ExecuteNonQuery();
                baglan.Close();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Lütfen Kontrol Ediniz", "Veri Girişi");
            }
               
            

           

        }

        private void PersonelGiris_Load(object sender, EventArgs e)
        {
            
        }
    }
}
