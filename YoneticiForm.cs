using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Odev3
{
    public partial class YoneticiForm : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Hafta3Odev;Integrated Security=True");

        public YoneticiForm()
        {
            InitializeComponent();

            this.Load += YoneticiForm_Load;
            dataGridView1.CellClick += DataGridView1_CellClick;
            eklebutton.Click += Eklebutton_Click;
            silbutton.Click += Silbutton_Click;
            guncellebutton.Click += Guncellebutton_Click;
            TemizleButton.Click += TemizleButton_Click;
            Cikisyapbuton.Click += Cikisyapbuton_Click;
        }

        // Form açıldığında verileri çeker
        private void YoneticiForm_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        // Tabloyu veritabanından dolduran metodumuz
        private void VerileriGetir()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ogrenciler", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Veri çekme hatası: " + hata.Message);
            }
        }

        // TABLOYA TIKLANDIĞINDA: Tıklanan kişinin bilgilerini yandaki kutulara doldurur
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dataGridView1.Rows[e.RowIndex];
                IDTEXT.Text = satir.Cells["ID"].Value.ToString();
                ADTEXT.Text = satir.Cells["Ad"].Value.ToString();
                SOYADTEXT.Text = satir.Cells["Soyad"].Value.ToString();
                NUMARATEXT.Text = satir.Cells["Numara"].Value.ToString();
                SIFRETEXT.Text = satir.Cells["Sifre"].Value.ToString();
            }
        }

        // TEMİZLE BUTONU
        private void TemizleButton_Click(object sender, EventArgs e)
        {
            IDTEXT.Clear();
            ADTEXT.Clear();
            SOYADTEXT.Clear();
            NUMARATEXT.Clear();
            SIFRETEXT.Clear();
        }

        // EKLE BUTONU
        private void Eklebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ADTEXT.Text) || string.IsNullOrWhiteSpace(SOYADTEXT.Text))
            {
                MessageBox.Show("Ad ve Soyad boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Ogrenciler (Ad, Soyad, Numara, Sifre) VALUES (@ad, @soyad, @no, @sifre)", baglanti);
                komut.Parameters.AddWithValue("@ad", ADTEXT.Text);
                komut.Parameters.AddWithValue("@soyad", SOYADTEXT.Text);
                komut.Parameters.AddWithValue("@no", NUMARATEXT.Text);
                komut.Parameters.AddWithValue("@sifre", SIFRETEXT.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Yeni öğrenci sisteme başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VerileriGetir(); // Tabloyu yenile
                TemizleButton_Click(sender, e); // Kutuları temizle
            }
            catch (Exception hata)
            {
                MessageBox.Show("Ekleme işlemi başarısız: " + hata.Message);
            }
        }

        // SİL BUTONU
        private void Silbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IDTEXT.Text))
            {
                MessageBox.Show("Lütfen silmek için tablodan bir öğrenci seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Ogrenciler WHERE ID=@id", baglanti);
                komut.Parameters.AddWithValue("@id", IDTEXT.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Öğrenci sistemden silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VerileriGetir();
                TemizleButton_Click(sender, e);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Silme işlemi başarısız: " + hata.Message);
            }
        }

        // GÜNCELLE BUTONU
        private void Guncellebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IDTEXT.Text))
            {
                MessageBox.Show("Lütfen güncellemek için tablodan bir öğrenci seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE Ogrenciler SET Ad=@ad, Soyad=@soyad, Numara=@no, Sifre=@sifre WHERE ID=@id", baglanti);
                komut.Parameters.AddWithValue("@ad", ADTEXT.Text);
                komut.Parameters.AddWithValue("@soyad", SOYADTEXT.Text);
                komut.Parameters.AddWithValue("@no", NUMARATEXT.Text);
                komut.Parameters.AddWithValue("@sifre", SIFRETEXT.Text);
                komut.Parameters.AddWithValue("@id", IDTEXT.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Öğrenci bilgileri güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VerileriGetir();
                TemizleButton_Click(sender, e);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme işlemi başarısız: " + hata.Message);
            }
        }

        // ÇIKIŞ YAP BUTONU
        private void Cikisyapbuton_Click(object sender, EventArgs e)
        {
            // İlk baştaki giriş ekranına geri dön
            Form1 girisEkrani = new Form1();
            girisEkrani.Show();
            this.Close(); // Yönetici panelini kapat
        }

        private void eklebutton_Click_1(object sender, EventArgs e)
        {

        }
    }
}