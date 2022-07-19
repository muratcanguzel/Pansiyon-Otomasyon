namespace KumsalPansiyon
{
    partial class MüsteriListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüsteriListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtHizliara = new System.Windows.Forms.TextBox();
            this.lblArananalan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTcno = new System.Windows.Forms.RadioButton();
            this.radDyer = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtHizliara
            // 
            this.txtHizliara.Location = new System.Drawing.Point(644, 12);
            this.txtHizliara.Name = "txtHizliara";
            this.txtHizliara.Size = new System.Drawing.Size(170, 30);
            this.txtHizliara.TabIndex = 1;
            this.txtHizliara.TextChanged += new System.EventHandler(this.txtHizliara_TextChanged);
            // 
            // lblArananalan
            // 
            this.lblArananalan.AutoSize = true;
            this.lblArananalan.Location = new System.Drawing.Point(557, 17);
            this.lblArananalan.Name = "lblArananalan";
            this.lblArananalan.Size = new System.Drawing.Size(81, 25);
            this.lblArananalan.TabIndex = 2;
            this.lblArananalan.Text = "TC NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arama Türü:";
            // 
            // cmbAramaTuru
            // 
            this.cmbAramaTuru.FormattingEnabled = true;
            this.cmbAramaTuru.Items.AddRange(new object[] {
            "İle Başlayan",
            "İle Biten",
            "İçeren"});
            this.cmbAramaTuru.Location = new System.Drawing.Point(140, 14);
            this.cmbAramaTuru.Name = "cmbAramaTuru";
            this.cmbAramaTuru.Size = new System.Drawing.Size(163, 33);
            this.cmbAramaTuru.TabIndex = 4;
            this.cmbAramaTuru.Text = "İle Başlayan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radTcno);
            this.groupBox1.Controls.Add(this.radDyer);
            this.groupBox1.Location = new System.Drawing.Point(325, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 67);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aranacak Alan Seçimi";
            // 
            // radTcno
            // 
            this.radTcno.AutoSize = true;
            this.radTcno.Checked = true;
            this.radTcno.Location = new System.Drawing.Point(6, 29);
            this.radTcno.Name = "radTcno";
            this.radTcno.Size = new System.Drawing.Size(61, 29);
            this.radTcno.TabIndex = 2;
            this.radTcno.TabStop = true;
            this.radTcno.Text = "TC";
            this.radTcno.UseVisualStyleBackColor = true;
            this.radTcno.CheckedChanged += new System.EventHandler(this.radTcno_CheckedChanged);
            // 
            // radDyer
            // 
            this.radDyer.AutoSize = true;
            this.radDyer.Location = new System.Drawing.Point(91, 29);
            this.radDyer.Name = "radDyer";
            this.radDyer.Size = new System.Drawing.Size(61, 29);
            this.radDyer.TabIndex = 1;
            this.radDyer.Text = "AD";
            this.radDyer.UseVisualStyleBackColor = true;
            this.radDyer.CheckedChanged += new System.EventHandler(this.radDyer_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Aqua;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 544);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1066, 35);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButton1.Image = global::KumsalPansiyon.Properties.Resources.delete;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(124, 32);
            this.toolStripButton1.Text = "Müşteri Sil";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButton2.Image = global::KumsalPansiyon.Properties.Resources.arrow_refresh;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(178, 32);
            this.toolStripButton2.Text = "Müşteri Güncelle";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // MüsteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1066, 579);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbAramaTuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblArananalan);
            this.Controls.Add(this.txtHizliara);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MüsteriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MüsteriListele";
            this.Activated += new System.EventHandler(this.MüsteriListele_Activated);
            this.Load += new System.EventHandler(this.MüsteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtHizliara;
        private System.Windows.Forms.Label lblArananalan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDyer;
        private System.Windows.Forms.RadioButton radTcno;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}