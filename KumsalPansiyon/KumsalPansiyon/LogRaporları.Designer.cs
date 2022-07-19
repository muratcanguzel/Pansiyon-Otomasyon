namespace KumsalPansiyon
{
    partial class LogRapor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogRapor));
            this.LogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pansiyonVtDataSet = new KumsalPansiyon.pansiyonVtDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LogTableAdapter = new KumsalPansiyon.pansiyonVtDataSetTableAdapters.LogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonVtDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LogBindingSource
            // 
            this.LogBindingSource.DataMember = "Log";
            this.LogBindingSource.DataSource = this.pansiyonVtDataSet;
            // 
            // pansiyonVtDataSet
            // 
            this.pansiyonVtDataSet.DataSetName = "pansiyonVtDataSet";
            this.pansiyonVtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.LogBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KumsalPansiyon.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(388, 344);
            this.reportViewer1.TabIndex = 0;
            // 
            // LogTableAdapter
            // 
            this.LogTableAdapter.ClearBeforeFill = true;
            // 
            // LogRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(419, 395);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LogRaporları";
            this.Load += new System.EventHandler(this.RaporOda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonVtDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LogBindingSource;
        private pansiyonVtDataSet pansiyonVtDataSet;
        private pansiyonVtDataSetTableAdapters.LogTableAdapter LogTableAdapter;
    }
}