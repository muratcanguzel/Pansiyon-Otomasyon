namespace KumsalPansiyon
{
    partial class Raporlama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlama));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pansiyonVtDataSet = new KumsalPansiyon.pansiyonVtDataSet();
            this.YeniMüsteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.YeniMüsteriTableAdapter = new KumsalPansiyon.pansiyonVtDataSetTableAdapters.YeniMüsteriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonVtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YeniMüsteriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.YeniMüsteriBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KumsalPansiyon.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 14);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(901, 489);
            this.reportViewer1.TabIndex = 0;
            // 
            // pansiyonVtDataSet
            // 
            this.pansiyonVtDataSet.DataSetName = "pansiyonVtDataSet";
            this.pansiyonVtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // YeniMüsteriBindingSource
            // 
            this.YeniMüsteriBindingSource.DataMember = "YeniMüsteri";
            this.YeniMüsteriBindingSource.DataSource = this.pansiyonVtDataSet;
            // 
            // YeniMüsteriTableAdapter
            // 
            this.YeniMüsteriTableAdapter.ClearBeforeFill = true;
            // 
            // Raporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(931, 547);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Raporlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Raporlama";
            this.Load += new System.EventHandler(this.Raporlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonVtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YeniMüsteriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource YeniMüsteriBindingSource;
        private pansiyonVtDataSet pansiyonVtDataSet;
        private pansiyonVtDataSetTableAdapters.YeniMüsteriTableAdapter YeniMüsteriTableAdapter;
    }
}