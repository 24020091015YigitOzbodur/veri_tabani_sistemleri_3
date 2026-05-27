namespace Odev3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            KullaniciAdi = new TextBox();
            Sifre = new TextBox();
            Rol = new ComboBox();
            KullaniciAdiLabel = new Label();
            SifreLabel = new Label();
            RolLabel = new Label();
            Girisyapbuton = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // KullaniciAdi
            // 
            KullaniciAdi.BackColor = Color.FromArgb(49, 44, 69);
            KullaniciAdi.ForeColor = Color.FromArgb(212, 173, 252);
            KullaniciAdi.Location = new Point(122, 45);
            KullaniciAdi.Name = "KullaniciAdi";
            KullaniciAdi.Size = new Size(100, 23);
            KullaniciAdi.TabIndex = 0;
            // 
            // Sifre
            // 
            Sifre.BackColor = Color.FromArgb(49, 44, 69);
            Sifre.ForeColor = Color.FromArgb(212, 173, 252);
            Sifre.Location = new Point(122, 93);
            Sifre.Name = "Sifre";
            Sifre.Size = new Size(100, 23);
            Sifre.TabIndex = 1;
            // 
            // Rol
            // 
            Rol.BackColor = Color.FromArgb(49, 44, 69);
            Rol.FlatStyle = FlatStyle.Flat;
            Rol.ForeColor = Color.FromArgb(212, 173, 252);
            Rol.FormattingEnabled = true;
            Rol.Items.AddRange(new object[] { "Yönetici", "Öğrenci" });
            Rol.Location = new Point(122, 145);
            Rol.Name = "Rol";
            Rol.Size = new Size(100, 23);
            Rol.TabIndex = 2;
            Rol.SelectedIndexChanged += Rol_SelectedIndexChanged;
            // 
            // KullaniciAdiLabel
            // 
            KullaniciAdiLabel.AutoSize = true;
            KullaniciAdiLabel.ForeColor = Color.FromArgb(224, 216, 234);
            KullaniciAdiLabel.Location = new Point(43, 48);
            KullaniciAdiLabel.Name = "KullaniciAdiLabel";
            KullaniciAdiLabel.Size = new Size(73, 15);
            KullaniciAdiLabel.TabIndex = 3;
            KullaniciAdiLabel.Text = "Kullanıcı Adı";
            // 
            // SifreLabel
            // 
            SifreLabel.AutoSize = true;
            SifreLabel.ForeColor = Color.FromArgb(224, 216, 234);
            SifreLabel.Location = new Point(43, 96);
            SifreLabel.Name = "SifreLabel";
            SifreLabel.Size = new Size(30, 15);
            SifreLabel.TabIndex = 4;
            SifreLabel.Text = "Şifre";
            // 
            // RolLabel
            // 
            RolLabel.AutoSize = true;
            RolLabel.ForeColor = Color.FromArgb(224, 216, 234);
            RolLabel.Location = new Point(43, 148);
            RolLabel.Name = "RolLabel";
            RolLabel.Size = new Size(24, 15);
            RolLabel.TabIndex = 5;
            RolLabel.Text = "Rol";
            // 
            // Girisyapbuton
            // 
            Girisyapbuton.BackColor = Color.FromArgb(200, 182, 255);
            Girisyapbuton.FlatStyle = FlatStyle.Flat;
            Girisyapbuton.Location = new Point(166, 203);
            Girisyapbuton.Name = "Girisyapbuton";
            Girisyapbuton.Size = new Size(75, 23);
            Girisyapbuton.TabIndex = 6;
            Girisyapbuton.Text = "Giriş Yap";
            Girisyapbuton.UseVisualStyleBackColor = false;
            Girisyapbuton.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(200, 182, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(25, 203);
            button2.Name = "button2";
            button2.Size = new Size(119, 23);
            button2.TabIndex = 7;
            button2.Text = "Şifremi Unuttum";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 26, 47);
            ClientSize = new Size(285, 287);
            Controls.Add(button2);
            Controls.Add(Girisyapbuton);
            Controls.Add(RolLabel);
            Controls.Add(SifreLabel);
            Controls.Add(KullaniciAdiLabel);
            Controls.Add(Rol);
            Controls.Add(Sifre);
            Controls.Add(KullaniciAdi);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox KullaniciAdi;
        private TextBox Sifre;
        private ComboBox Rol;
        private Label KullaniciAdiLabel;
        private Label SifreLabel;
        private Label RolLabel;
        private Button Girisyapbuton;
        private Button button2;
    }
}
