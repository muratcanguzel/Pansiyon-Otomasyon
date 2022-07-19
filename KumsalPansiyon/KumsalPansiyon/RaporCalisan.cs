using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KumsalPansiyon
{
    public partial class RaporCalisan : Form
    {
        public RaporCalisan()
        {
            InitializeComponent();
        }

        private void RaporCalisan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pansiyonVtDataSet.Log' table. You can move, or remove it, as needed.
            this.LogTableAdapter.Fill(this.pansiyonVtDataSet.Log);
            // TODO: This line of code loads data into the 'pansiyonVtDataSet.Calisanlar' table. You can move, or remove it, as needed.
            this.CalisanlarTableAdapter.Fill(this.pansiyonVtDataSet.Calisanlar);

            this.reportViewer1.RefreshReport();
        }
    }
}
