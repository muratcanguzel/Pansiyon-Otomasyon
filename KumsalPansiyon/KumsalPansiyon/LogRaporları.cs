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
    public partial class LogRapor : Form
    {
        public LogRapor()
        {
            InitializeComponent();
        }

        private void RaporOda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pansiyonVtDataSet.Log' table. You can move, or remove it, as needed.
            this.LogTableAdapter.Fill(this.pansiyonVtDataSet.Log);

            this.reportViewer1.RefreshReport();
        }
    }
}
