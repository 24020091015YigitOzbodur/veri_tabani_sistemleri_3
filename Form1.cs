using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Rol.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir rol seçin!");
                return;
            }

            string secilenRol = Rol.SelectedItem.ToString();

            // 1. YÖNETİCİ GİRİŞİ (Kod üzerinden sabit kontrol)
            if (secilenRol == "Yönetici")
            {
                if (KullaniciAdi.Text == "admin" && Sifre.Text == "1234")
                {
                    YoneticiForm yoneticiEkrani = new YoneticiForm();
                    yoneticiEkrani.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı yönetici bilgileri!");
                }
            }
            // 2. ÖĞRENCİ GİRİŞİ (Veritabanından kontrol)
            else if (secilenRol == "Öğrenci")
            {
                try
                {
                    SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Hafta3Odev;Integrated Security=True");
                    baglanti.Open();

                    // Dikkat: Tablo adın "Ogrenciler" olmalı, "Kullanicilar" değil!
                    SqlCommand komut = new SqlCommand("SELECT * FROM Ogrenciler WHERE Numara=@no AND Sifre=@sifre", baglanti);
                    komut.Parameters.AddWithValue("@no", KullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@sifre", Sifre.Text);

                    SqlDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        Ogrenciform ogrenciEkrani = new Ogrenciform();
                        ogrenciEkrani.adTxt = KullaniciAdi.Text; // Öğrenci numarası
                        ogrenciEkrani.sifreTxt = Sifre.Text;     // Şifre
                        ogrenciEkrani.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bulunamadı!");
                    }
                    baglanti.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata: " + hata.Message);
                }
            }
        }

        private void Rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
