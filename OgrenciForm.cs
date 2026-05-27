using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Odev3
{
    public partial class Ogrenciform : Form
    {
        public string adTxt = "";
        public string sifreTxt = "";

        public Ogrenciform()
        {
            InitializeComponent();
        }

        private void Ogrenciform_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Hafta3Odev;Integrated Security=True");
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Ogrenciler WHERE Numara=@no AND Sifre=@sifre", baglanti);
                komut.Parameters.AddWithValue("@no", adTxt);
                komut.Parameters.AddWithValue("@sifre", sifreTxt);

                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    adtxt.Text = oku["Ad"].ToString();
                    sydtxt.Text = oku["Soyad"].ToString();
                    notxt.Text = oku["Numara"].ToString();
                    sifretxt.Text = oku["Sifre"].ToString();
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void Cikisyapbuton_Click(object sender, EventArgs e)
        {
            Form1 girisEkrani = (Form1)Application.OpenForms["Form1"];
            if (girisEkrani != null)
                girisEkrani.Show();
            else
                new Form1().Show();
            this.Close();
        }
    }
}