using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev1
{
    public partial class Ortalama : Form
    {
        public Ortalama()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ogrenciSeciniz(string ad, string soyad)
        {
            // ComboBox'a yeni öğrenci adını ve soyadını ekleyin
            comboBoxOgr.Items.Add(ad + " " + soyad);
        }
        private void Ortalama_Load(object sender, EventArgs e)
        {

        }
    }
}
