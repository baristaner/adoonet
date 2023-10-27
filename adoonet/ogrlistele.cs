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
    public partial class ogrlistele : Form
    {
        public ogrlistele()
        {
            InitializeComponent();
        }

       SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-B2541I7\\SQLEXPRESS;Initial Catalog=dene;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from ogr", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds, "ogrtab");
            dataGridView1.DataSource = ds.Tables["ogrtab"];
            baglan.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void silButton_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From ogr Where okulno=@okulno";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@okulno", dataGridView1.CurrentRow.Cells[0].Value.ToString());

            baglan.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi");
            baglan.Close();
            Listele();
        }
    }
}
