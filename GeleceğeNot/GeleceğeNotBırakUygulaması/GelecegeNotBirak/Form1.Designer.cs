namespace GelecegeNotBirak
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textbox_kullanici_giris = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textbox_sifre_giris = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textbox_kullanici_adi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textbox_sifre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.buton_kayit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buton_giris = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_kullanici_giris
            // 
            this.textbox_kullanici_giris.Depth = 0;
            this.textbox_kullanici_giris.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textbox_kullanici_giris.Hint = "";
            this.textbox_kullanici_giris.Location = new System.Drawing.Point(238, 283);
            this.textbox_kullanici_giris.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox_kullanici_giris.Name = "textbox_kullanici_giris";
            this.textbox_kullanici_giris.PasswordChar = '\0';
            this.textbox_kullanici_giris.SelectedText = "";
            this.textbox_kullanici_giris.SelectionLength = 0;
            this.textbox_kullanici_giris.SelectionStart = 0;
            this.textbox_kullanici_giris.Size = new System.Drawing.Size(184, 28);
            this.textbox_kullanici_giris.TabIndex = 0;
            this.textbox_kullanici_giris.UseSystemPasswordChar = false;
            // 
            // textbox_sifre_giris
            // 
            this.textbox_sifre_giris.Depth = 0;
            this.textbox_sifre_giris.Hint = "";
            this.textbox_sifre_giris.Location = new System.Drawing.Point(238, 333);
            this.textbox_sifre_giris.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox_sifre_giris.Name = "textbox_sifre_giris";
            this.textbox_sifre_giris.PasswordChar = '*';
            this.textbox_sifre_giris.SelectedText = "";
            this.textbox_sifre_giris.SelectionLength = 0;
            this.textbox_sifre_giris.SelectionStart = 0;
            this.textbox_sifre_giris.Size = new System.Drawing.Size(184, 28);
            this.textbox_sifre_giris.TabIndex = 1;
            this.textbox_sifre_giris.UseSystemPasswordChar = false;
            // 
            // textbox_kullanici_adi
            // 
            this.textbox_kullanici_adi.Depth = 0;
            this.textbox_kullanici_adi.Hint = "";
            this.textbox_kullanici_adi.Location = new System.Drawing.Point(704, 283);
            this.textbox_kullanici_adi.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox_kullanici_adi.Name = "textbox_kullanici_adi";
            this.textbox_kullanici_adi.PasswordChar = '\0';
            this.textbox_kullanici_adi.SelectedText = "";
            this.textbox_kullanici_adi.SelectionLength = 0;
            this.textbox_kullanici_adi.SelectionStart = 0;
            this.textbox_kullanici_adi.Size = new System.Drawing.Size(184, 28);
            this.textbox_kullanici_adi.TabIndex = 2;
            this.textbox_kullanici_adi.UseSystemPasswordChar = false;
            // 
            // textbox_sifre
            // 
            this.textbox_sifre.Depth = 0;
            this.textbox_sifre.Hint = "";
            this.textbox_sifre.Location = new System.Drawing.Point(704, 337);
            this.textbox_sifre.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox_sifre.Name = "textbox_sifre";
            this.textbox_sifre.PasswordChar = '*';
            this.textbox_sifre.SelectedText = "";
            this.textbox_sifre.SelectionLength = 0;
            this.textbox_sifre.SelectionStart = 0;
            this.textbox_sifre.Size = new System.Drawing.Size(184, 28);
            this.textbox_sifre.TabIndex = 3;
            this.textbox_sifre.UseSystemPasswordChar = false;
            this.textbox_sifre.Click += new System.EventHandler(this.textbox_sifre_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(87, 283);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(120, 24);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Kullanıcı Adı:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(87, 333);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(54, 24);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Şifre:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(551, 283);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(120, 24);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Kullanıcı Adı:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(551, 337);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(54, 24);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Şifre:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(211, 202);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(86, 24);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Giriş Yap";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(679, 202);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(80, 24);
            this.materialLabel6.TabIndex = 9;
            this.materialLabel6.Text = "Kayıt Ol:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(820, 535);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(101, 24);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "Nergis Işık";
            // 
            // buton_kayit
            // 
            this.buton_kayit.Depth = 0;
            this.buton_kayit.Location = new System.Drawing.Point(551, 430);
            this.buton_kayit.MouseState = MaterialSkin.MouseState.HOVER;
            this.buton_kayit.Name = "buton_kayit";
            this.buton_kayit.Primary = true;
            this.buton_kayit.Size = new System.Drawing.Size(337, 34);
            this.buton_kayit.TabIndex = 12;
            this.buton_kayit.Text = "Kayıt Ol";
            this.buton_kayit.UseVisualStyleBackColor = true;
            this.buton_kayit.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // buton_giris
            // 
            this.buton_giris.Depth = 0;
            this.buton_giris.Location = new System.Drawing.Point(87, 430);
            this.buton_giris.MouseState = MaterialSkin.MouseState.HOVER;
            this.buton_giris.Name = "buton_giris";
            this.buton_giris.Primary = true;
            this.buton_giris.Size = new System.Drawing.Size(335, 34);
            this.buton_giris.TabIndex = 13;
            this.buton_giris.Text = "Giriş Yap";
            this.buton_giris.UseVisualStyleBackColor = true;
            this.buton_giris.Click += new System.EventHandler(this.buton_giris_Click);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(87, 379);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(82, 30);
            this.materialCheckBox1.TabIndex = 14;
            this.materialCheckBox1.Text = "Göster";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            this.materialCheckBox1.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // materialCheckBox2
            // 
            this.materialCheckBox2.AutoSize = true;
            this.materialCheckBox2.Depth = 0;
            this.materialCheckBox2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox2.Location = new System.Drawing.Point(551, 379);
            this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox2.Name = "materialCheckBox2";
            this.materialCheckBox2.Ripple = true;
            this.materialCheckBox2.Size = new System.Drawing.Size(82, 30);
            this.materialCheckBox2.TabIndex = 15;
            this.materialCheckBox2.Text = "Göster";
            this.materialCheckBox2.UseVisualStyleBackColor = true;
            this.materialCheckBox2.CheckedChanged += new System.EventHandler(this.materialCheckBox2_CheckedChanged);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(820, 559);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(109, 24);
            this.materialLabel8.TabIndex = 16;
            this.materialLabel8.Text = "222503033";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GelecegeNotBirak.Properties.Resources.Adsız_tasarım__9__Photoroom_png_Photoroom;
            this.pictureBox2.Location = new System.Drawing.Point(360, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(962, 624);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialCheckBox2);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.buton_giris);
            this.Controls.Add(this.buton_kayit);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textbox_sifre);
            this.Controls.Add(this.textbox_kullanici_adi);
            this.Controls.Add(this.textbox_sifre_giris);
            this.Controls.Add(this.textbox_kullanici_giris);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            this.Text = "Geleceğe Not Bırak Uygulaması";
            this.TransparencyKey = System.Drawing.Color.IndianRed;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField textbox_kullanici_giris;
        private MaterialSkin.Controls.MaterialSingleLineTextField textbox_sifre_giris;
        private MaterialSkin.Controls.MaterialSingleLineTextField textbox_kullanici_adi;
        private MaterialSkin.Controls.MaterialSingleLineTextField textbox_sifre;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialRaisedButton buton_kayit;
        private MaterialSkin.Controls.MaterialRaisedButton buton_giris;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

