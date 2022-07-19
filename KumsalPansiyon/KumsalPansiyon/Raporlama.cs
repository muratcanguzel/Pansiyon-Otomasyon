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
    public partial class Raporlama : Form
    {
        public Raporlama()
        {
            InitializeComponent();
        }

        private void Raporlama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pansiyonVtDataSet.YeniMüsteri' table. You can move, or remove it, as needed.
            this.YeniMüsteriTableAdapter.Fill(this.pansiyonVtDataSet.YeniMüsteri);

            this.reportViewer1.RefreshReport();
        }
    }
}
