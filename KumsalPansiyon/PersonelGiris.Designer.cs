namespace KumsalPansiyon
{
    partial class PersonelGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelKad = new System.Windows.Forms.TextBox();
            this.txtPersonelSifre = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnPersonelGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(104, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(177, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // txtPersonelKad
            // 
            this.txtPersonelKad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPersonelKad.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonelKad.Location = new System.Drawing.Point(255, 168);
            this.txtPersonelKad.Name = "txtPersonelKad";
            this.txtPersonelKad.Size = new System.Drawing.Size(152, 30);
            this.txtPersonelKad.TabIndex = 3;
            // 
            // txtPersonelSifre
            // 
            this.txtPersonelSifre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPersonelSifre.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelSifre.Location = new System.Drawing.Point(255, 227);
            this.txtPersonelSifre.Name = "txtPersonelSifre";
            this.txtPersonelSifre.PasswordChar = '*';
            this.txtPersonelSifre.Size = new System.Drawing.Size(152, 30);
            this.txtPersonelSifre.TabIndex = 4;
            this.txtPersonelSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(92, 286);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(136, 32);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGiris.Location = new System.Drawing.Point(271, 286);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(136, 32);
            this.btnPersonelGiris.TabIndex = 8;
            this.btnPersonelGiris.Text = "Giriş Yap";
            this.btnPersonelGiris.UseVisualStyleBackColor = true;
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KumsalPansiyon.Properties.Resources._37517977_10160584510695481_9069137974549020672_n3;
            this.pictureBox1.Location = new System.Drawing.Point(120, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KumsalPansiyon.Properties.Resources.hd_sky_blue_beach_wallpaper_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(505, 378);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPersonelGiris);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtPersonelSifre);
            this.Controls.Add(this.txtPersonelKad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelGiris";
            this.Load += new System.EventHandler(this.PersonelGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelKad;
        private System.Windows.Forms.TextBox txtPersonelSifre;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnPersonelGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}