using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ödev1
{
    public partial class Sınıf : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\byhas\\OneDrive\\Masaüstü\\ÖDEV 1\\ÖDEV1.accdb\"");

        private void verilerigoruntule()
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.ShowDialog();
        }
        public void VerileriEkle(string okulNo, string ad, string soyad, string telefon, string adres, string ders1, string ders2, string ders3, string ders4, string ders5, string ders6, string ders7, string ders8)
        {
            // DataGridView'e verileri ekle
            dataGridView1.Rows.Add(okulNo, ad, soyad, telefon, adres, ders1, ders2, ders3, ders4, ders5, ders6, ders7, ders8);
        }
        private void Sınıf_Load(object sender, EventArgs e)
        {

        }
    }
}