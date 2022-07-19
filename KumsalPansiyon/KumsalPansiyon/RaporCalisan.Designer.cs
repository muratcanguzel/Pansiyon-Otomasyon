namespace KumsalPansiyon
{
    partial class RaporCalisan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporCalisan));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pansiyonVtDataSet = new KumsalPansiyon.pansiyonVtDataSet();
            this.CalisanlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CalisanlarTableAdapter = new KumsalPansiyon.pansiyonVtDataSetTableAdapters.CalisanlarTableAdapter();
            this.LogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LogTableAdapter = new KumsalPansiyon.pansiyonVtDataSetTableAdapters.LogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonVtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalisanlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.CalisanlarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KumsalPansiyon.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(10, 30);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(643, 429);
            this.reportViewer1.TabIndex = 0;
            // 
            // pansiyonVtDataSet
            // 
            this.pansiyonVtDataSet.DataSetName = "pansiyonVtDataSet";
            this.pansiyonVtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CalisanlarBindingSource
            // 
            this.CalisanlarBindingSource.DataMember = "Calisanlar";
            this.CalisanlarBindingSource.DataSource = this.pansiyonVtDataSet;
            // 
            // CalisanlarTableAdapter
            // 
            this.CalisanlarTableAdapter.ClearBeforeFill = true;
            // 
            // LogBindingSource
            // 
            this.LogBindingSource.DataMember = "Log";
            this.LogBindingSource.DataSource = this.pansiyonVtDataSet;
            // 
            // LogTableAdapter
            // 
            this.LogTableAdapter.ClearBeforeFill = true;
            // 
            // RaporCalisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(669, 481);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RaporCalisan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RaporCalisan";
            this.Load += new System.EventHandler(this.RaporCalisan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonVtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalisanlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CalisanlarBindingSource;
        private pansiyonVtDataSet pansiyonVtDataSet;
        private pansiyonVtDataSetTableAdapters.CalisanlarTableAdapter CalisanlarTableAdapter;
        private System.Windows.Forms.BindingSource LogBindingSource;
        private pansiyonVtDataSetTableAdapters.LogTableAdapter LogTableAdapter;
    }
}