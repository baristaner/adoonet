using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adoonet
{
    public partial class ogrekle : Form
    {
        public ogrekle()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-B2541I7\\SQLEXPRESS;Initial Catalog=dene;Integrated Security=True");
        private void ogrekle_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("BP");
            comboBox1.Items.Add("ZP");
            comboBox2.Items.Add("BP");
            comboBox2.Items.Add("ZP");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into ogr(okulno,isimsoyisim,cepno,bolum,sinif)" + "values (@okulno,@isimsoyisim,@cepno,@bolum,@sinif)";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@okulno", textBox1.Text);
            komut.Parameters.AddWithValue("@isimsoyisim", textBox2.Text);
            komut.Parameters.AddWithValue("@cepno", textBox3.Text);
            komut.Parameters.AddWithValue("@bolum", comboBox1.Text);
            komut.Parameters.AddWithValue("@sinif", comboBox2.Text);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
        }
    }
}
