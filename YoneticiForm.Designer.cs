namespace Odev3
{
    partial class YoneticiForm
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
            dataGridView1 = new DataGridView();
            eklebutton = new Button();
            silbutton = new Button();
            Cikisyapbuton = new Button();
            TemizleButton = new Button();
            ADTEXT = new TextBox();
            SOYADTEXT = new TextBox();
            NUMARATEXT = new TextBox();
            SIFRETEXT = new TextBox();
            IDTEXT = new TextBox();
            Idlabel = new Label();
            adlabell = new Label();
            soyadlabell = new Label();
            numaralabell = new Label();
            sifrelabell = new Label();
            guncellebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(49, 44, 69);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(414, 365);
            dataGridView1.TabIndex = 0;
            // 
            // eklebutton
            // 
            eklebutton.FlatStyle = FlatStyle.Flat;
            eklebutton.ForeColor = Color.FromArgb(200, 182, 255);
            eklebutton.Location = new Point(624, 300);
            eklebutton.Name = "eklebutton";
            eklebutton.Size = new Size(75, 23);
            eklebutton.TabIndex = 1;
            eklebutton.Text = "Ekle";
            eklebutton.UseVisualStyleBackColor = true;
            eklebutton.Click += eklebutton_Click_1;
            // 
            // silbutton
            // 
            silbutton.FlatStyle = FlatStyle.Flat;
            silbutton.ForeColor = Color.FromArgb(255, 158, 187);
            silbutton.Location = new Point(541, 300);
            silbutton.Name = "silbutton";
            silbutton.Size = new Size(75, 23);
            silbutton.TabIndex = 2;
            silbutton.Text = "Sil";
            silbutton.UseVisualStyleBackColor = true;
            // 
            // Cikisyapbuton
            // 
            Cikisyapbuton.FlatStyle = FlatStyle.Flat;
            Cikisyapbuton.ForeColor = Color.FromArgb(231, 198, 255);
            Cikisyapbuton.Location = new Point(541, 382);
            Cikisyapbuton.Name = "Cikisyapbuton";
            Cikisyapbuton.Size = new Size(75, 23);
            Cikisyapbuton.TabIndex = 4;
            Cikisyapbuton.Text = "Çıkış Yap";
            Cikisyapbuton.UseVisualStyleBackColor = true;
            // 
            // TemizleButton
            // 
            TemizleButton.FlatStyle = FlatStyle.Flat;
            TemizleButton.ForeColor = Color.FromArgb(155, 155, 204);
            TemizleButton.Location = new Point(541, 261);
            TemizleButton.Name = "TemizleButton";
            TemizleButton.Size = new Size(75, 23);
            TemizleButton.TabIndex = 5;
            TemizleButton.Text = "Temizle";
            TemizleButton.UseVisualStyleBackColor = true;
            // 
            // ADTEXT
            // 
            ADTEXT.BackColor = Color.FromArgb(49, 44, 69);
            ADTEXT.ForeColor = Color.FromArgb(212, 173, 252);
            ADTEXT.Location = new Point(599, 97);
            ADTEXT.Name = "ADTEXT";
            ADTEXT.Size = new Size(100, 23);
            ADTEXT.TabIndex = 6;
            // 
            // SOYADTEXT
            // 
            SOYADTEXT.BackColor = Color.FromArgb(49, 44, 69);
            SOYADTEXT.ForeColor = Color.FromArgb(212, 173, 252);
            SOYADTEXT.Location = new Point(599, 136);
            SOYADTEXT.Name = "SOYADTEXT";
            SOYADTEXT.Size = new Size(100, 23);
            SOYADTEXT.TabIndex = 7;
            // 
            // NUMARATEXT
            // 
            NUMARATEXT.BackColor = Color.FromArgb(49, 44, 69);
            NUMARATEXT.ForeColor = Color.FromArgb(212, 173, 252);
            NUMARATEXT.Location = new Point(599, 176);
            NUMARATEXT.Name = "NUMARATEXT";
            NUMARATEXT.Size = new Size(100, 23);
            NUMARATEXT.TabIndex = 8;
            // 
            // SIFRETEXT
            // 
            SIFRETEXT.BackColor = Color.FromArgb(49, 44, 69);
            SIFRETEXT.ForeColor = Color.FromArgb(212, 173, 252);
            SIFRETEXT.Location = new Point(599, 206);
            SIFRETEXT.Name = "SIFRETEXT";
            SIFRETEXT.Size = new Size(100, 23);
            SIFRETEXT.TabIndex = 9;
            // 
            // IDTEXT
            // 
            IDTEXT.BackColor = Color.FromArgb(49, 44, 69);
            IDTEXT.ForeColor = Color.FromArgb(212, 173, 252);
            IDTEXT.Location = new Point(599, 63);
            IDTEXT.Name = "IDTEXT";
            IDTEXT.Size = new Size(100, 23);
            IDTEXT.TabIndex = 10;
            // 
            // Idlabel
            // 
            Idlabel.AutoSize = true;
            Idlabel.ForeColor = Color.FromArgb(224, 216, 234);
            Idlabel.Location = new Point(541, 66);
            Idlabel.Name = "Idlabel";
            Idlabel.Size = new Size(18, 15);
            Idlabel.TabIndex = 11;
            Idlabel.Text = "ID";
            // 
            // adlabell
            // 
            adlabell.AutoSize = true;
            adlabell.ForeColor = Color.FromArgb(224, 216, 234);
            adlabell.Location = new Point(541, 100);
            adlabell.Name = "adlabell";
            adlabell.Size = new Size(22, 15);
            adlabell.TabIndex = 12;
            adlabell.Text = "Ad";
            // 
            // soyadlabell
            // 
            soyadlabell.AutoSize = true;
            soyadlabell.ForeColor = Color.FromArgb(224, 216, 234);
            soyadlabell.Location = new Point(541, 139);
            soyadlabell.Name = "soyadlabell";
            soyadlabell.Size = new Size(39, 15);
            soyadlabell.TabIndex = 13;
            soyadlabell.Text = "Soyad";
            // 
            // numaralabell
            // 
            numaralabell.AutoSize = true;
            numaralabell.ForeColor = Color.FromArgb(224, 216, 234);
            numaralabell.Location = new Point(541, 179);
            numaralabell.Name = "numaralabell";
            numaralabell.Size = new Size(50, 15);
            numaralabell.TabIndex = 14;
            numaralabell.Text = "Numara";
            // 
            // sifrelabell
            // 
            sifrelabell.AutoSize = true;
            sifrelabell.ForeColor = Color.FromArgb(224, 216, 234);
            sifrelabell.Location = new Point(541, 209);
            sifrelabell.Name = "sifrelabell";
            sifrelabell.Size = new Size(30, 15);
            sifrelabell.TabIndex = 15;
            sifrelabell.Text = "Şifre";
            // 
            // guncellebutton
            // 
            guncellebutton.FlatStyle = FlatStyle.Flat;
            guncellebutton.ForeColor = Color.FromArgb(184, 192, 255);
            guncellebutton.Location = new Point(624, 261);
            guncellebutton.Name = "guncellebutton";
            guncellebutton.Size = new Size(75, 23);
            guncellebutton.TabIndex = 16;
            guncellebutton.Text = "Güncelle";
            guncellebutton.UseVisualStyleBackColor = true;
            // 
            // YoneticiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 26, 47);
            ClientSize = new Size(780, 475);
            Controls.Add(guncellebutton);
            Controls.Add(sifrelabell);
            Controls.Add(numaralabell);
            Controls.Add(soyadlabell);
            Controls.Add(adlabell);
            Controls.Add(Idlabel);
            Controls.Add(IDTEXT);
            Controls.Add(SIFRETEXT);
            Controls.Add(NUMARATEXT);
            Controls.Add(SOYADTEXT);
            Controls.Add(ADTEXT);
            Controls.Add(TemizleButton);
            Controls.Add(Cikisyapbuton);
            Controls.Add(silbutton);
            Controls.Add(eklebutton);
            Controls.Add(dataGridView1);
            Name = "YoneticiForm";
            Text = "YoneticiForm";
            Load += YoneticiForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button eklebutton;
        private Button silbutton;
        private Button Cikisyapbuton;
        private Button TemizleButton;
        private TextBox ADTEXT;
        private TextBox SOYADTEXT;
        private TextBox NUMARATEXT;
        private TextBox SIFRETEXT;
        private TextBox IDTEXT;
        private Label Idlabel;
        private Label adlabell;
        private Label soyadlabell;
        private Label numaralabell;
        private Label sifrelabell;
        private Button guncellebutton;
    }
}