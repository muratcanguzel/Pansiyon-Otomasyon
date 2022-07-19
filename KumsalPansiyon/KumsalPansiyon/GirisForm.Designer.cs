namespace KumsalPansiyon
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.btnCalisanGiris = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.BackColor = System.Drawing.Color.Aqua;
            this.btnAdminGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdminGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminGiris.Image = global::KumsalPansiyon.Properties.Resources.pixlr_bg_result;
            this.btnAdminGiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdminGiris.Location = new System.Drawing.Point(12, 46);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(154, 106);
            this.btnAdminGiris.TabIndex = 1;
            this.btnAdminGiris.Text = "Admin Giriş";
            this.btnAdminGiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminGiris.UseVisualStyleBackColor = false;
            this.btnAdminGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalisanGiris
            // 
            this.btnCalisanGiris.BackColor = System.Drawing.Color.Aqua;
            this.btnCalisanGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanGiris.Image = global::KumsalPansiyon.Properties.Resources.pixlr_bg_result1;
            this.btnCalisanGiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalisanGiris.Location = new System.Drawing.Point(199, 46);
            this.btnCalisanGiris.Name = "btnCalisanGiris";
            this.btnCalisanGiris.Size = new System.Drawing.Size(154, 106);
            this.btnCalisanGiris.TabIndex = 2;
            this.btnCalisanGiris.Text = "Personel Giriş";
            this.btnCalisanGiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalisanGiris.UseVisualStyleBackColor = false;
            this.btnCalisanGiris.Click += new System.EventHandler(this.btnCalisanGiris_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Aqua;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Image = global::KumsalPansiyon.Properties.Resources.pixlr_bg_result_22;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.Location = new System.Drawing.Point(109, 185);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(134, 106);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KumsalPansiyon.Properties.Resources.HD_wallpaper_akdeniz_sea_water_beach_sahil_deniz_kumsal_peace_huzur_turkey_thumbnail;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(365, 334);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnCalisanGiris);
            this.Controls.Add(this.btnAdminGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Button btnCalisanGiris;
        private System.Windows.Forms.Button btnCikis;
    }
}