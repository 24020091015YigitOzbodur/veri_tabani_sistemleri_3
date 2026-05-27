namespace Odev3
{
    partial class Ogrenciform
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
            cikisyapbuton = new Button();
            Hosgeldinlabel1 = new Label();
            adtxt = new TextBox();
            sydtxt = new TextBox();
            sifretxt = new TextBox();
            notxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cikisyapbuton
            // 
            cikisyapbuton.BackColor = Color.FromArgb(231, 198, 255);
            cikisyapbuton.FlatStyle = FlatStyle.Flat;
            cikisyapbuton.Location = new Point(295, 335);
            cikisyapbuton.Name = "cikisyapbuton";
            cikisyapbuton.Size = new Size(75, 23);
            cikisyapbuton.TabIndex = 1;
            cikisyapbuton.Text = "Çıkış Yap";
            cikisyapbuton.UseVisualStyleBackColor = false;
            cikisyapbuton.Click += Cikisyapbuton_Click;
            // 
            // Hosgeldinlabel1
            // 
            Hosgeldinlabel1.AutoSize = true;
            Hosgeldinlabel1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Hosgeldinlabel1.ForeColor = Color.FromArgb(224, 216, 234);
            Hosgeldinlabel1.Location = new Point(32, 30);
            Hosgeldinlabel1.Name = "Hosgeldinlabel1";
            Hosgeldinlabel1.Size = new Size(376, 42);
            Hosgeldinlabel1.TabIndex = 2;
            Hosgeldinlabel1.Text = "Hoşgeldin Öğrenci";
            // 
            // adtxt
            // 
            adtxt.BackColor = Color.FromArgb(49, 44, 69);
            adtxt.ForeColor = Color.FromArgb(212, 173, 252);
            adtxt.Location = new Point(194, 129);
            adtxt.Name = "adtxt";
            adtxt.ReadOnly = true;
            adtxt.Size = new Size(100, 23);
            adtxt.TabIndex = 3;
            // 
            // sydtxt
            // 
            sydtxt.BackColor = Color.FromArgb(49, 44, 69);
            sydtxt.ForeColor = Color.FromArgb(212, 173, 252);
            sydtxt.Location = new Point(194, 179);
            sydtxt.Name = "sydtxt";
            sydtxt.ReadOnly = true;
            sydtxt.Size = new Size(100, 23);
            sydtxt.TabIndex = 4;
            // 
            // sifretxt
            // 
            sifretxt.BackColor = Color.FromArgb(49, 44, 69);
            sifretxt.ForeColor = Color.FromArgb(212, 173, 252);
            sifretxt.Location = new Point(194, 269);
            sifretxt.Name = "sifretxt";
            sifretxt.ReadOnly = true;
            sifretxt.Size = new Size(100, 23);
            sifretxt.TabIndex = 5;
            // 
            // notxt
            // 
            notxt.BackColor = Color.FromArgb(49, 44, 69);
            notxt.ForeColor = Color.FromArgb(212, 173, 252);
            notxt.Location = new Point(194, 228);
            notxt.Name = "notxt";
            notxt.ReadOnly = true;
            notxt.Size = new Size(100, 23);
            notxt.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(224, 216, 234);
            label1.Location = new Point(129, 132);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 7;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(224, 216, 234);
            label2.Location = new Point(129, 182);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(224, 216, 234);
            label3.Location = new Point(129, 231);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 9;
            label3.Text = "Numara";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(224, 216, 234);
            label4.Location = new Point(129, 272);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 10;
            label4.Text = "Şifre";
            // 
            // Ogrenciform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 26, 47);
            ClientSize = new Size(437, 410);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(notxt);
            Controls.Add(sifretxt);
            Controls.Add(sydtxt);
            Controls.Add(adtxt);
            Controls.Add(Hosgeldinlabel1);
            Controls.Add(cikisyapbuton);
            Name = "Ogrenciform";
            Text = "Ogrenciform";
            Load += Ogrenciform_Load;
            Click += Cikisyapbuton_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cikisyapbuton;
        private Label Hosgeldinlabel1;
        private TextBox adtxt;
        private TextBox sydtxt;
        private TextBox sifretxt;
        private TextBox notxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}