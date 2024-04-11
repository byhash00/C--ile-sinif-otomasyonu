using System.Windows.Forms;
using System.Data.OleDb;

namespace ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sınıf Sınıf = new Sınıf();
            Sınıf.Show();
            verilerigoruntule();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\byhas\\OneDrive\\Masaüstü\\ÖDEV 1\\ÖDEV1.accdb\"");
        private void verilerigoruntule()
        {
            Sınıf Sınıf = new Sınıf();
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = ("Select * from ÖDEV1");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                dataGridView1 ekle = new dataGridView1();
                ekle.Text = oku["ad"].ToString();
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["adres"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["BİLİŞİM GÜVENLİĞİ VE HUKUKU"].ToString());

                dataGridView1.Items.Add(ekle);
            }
            baglantı.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Ortalama Ortalama = new Ortalama();
            Ortalama.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Öğrenci_Ekle Öğrenci_Ekle = new Öğrenci_Ekle();
            Öğrenci_Ekle.ShowDialog();

        }
    }
}