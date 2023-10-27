using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace adoonet
{
    public partial class ogrlistele : Form
    {
        public ogrlistele()
        {
            InitializeComponent();
        }

        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            baglan.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from ogr", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds, "ogrtab");
            dataGridView1.DataSource = ds.Tables["ogrtab"];
            baglan.Close();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From ogr Where okulno=@okulno";
            OleDbCommand komut = new OleDbCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@okulno", dataGridView1.CurrentRow.Cells[0].Value.ToString());

            baglan.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi");
            baglan.Close();
            Listele();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "Update ogr Set isimsoyisim=@isimsoyisim,cepno=@cepno,bolum=@bolum,sinif=@sinif where okulno=@okulno";
            OleDbCommand komut = new OleDbCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@okulno", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            komut.Parameters.AddWithValue("@isimsoyisim", textBox2.Text);
            komut.Parameters.AddWithValue("@cepno", textBox3.Text);
            komut.Parameters.AddWithValue("@bolum", comboBox1.Text);
            komut.Parameters.AddWithValue("@sinif", comboBox2.Text);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Guncelleme gerceklesti");
            Listele();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
