using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace dp_project
{
    public partial class searchteacher : Form
    {
        public searchteacher()
        {
            InitializeComponent();
        }

        private void searchteacher_Load(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection();
            sq.ConnectionString = "Data Source=DESKTOP-SM490GV;Initial Catalog=college;Integrated Security=True";

            SqlCommand sc = new SqlCommand();
            sc.CommandText = "SELECT * FROM teacher";
            sc.Connection = sq; // Set the connection for the SqlCommand

            SqlDataAdapter da = new SqlDataAdapter(sc);
            DataSet sd = new DataSet();

            sq.Open(); // Open the connection before filling the dataset
            da.Fill(sd);
            sq.Close(); // Close the connection after filling the dataset

            dataGridView1.DataSource = sd.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection();
            sq.ConnectionString = "Data Source=DESKTOP-SM490GV;Initial Catalog=college;Integrated Security=True";

            SqlCommand sc = new SqlCommand();
            sc.CommandText = "SELECT * FROM teacher where teacher_id ='"+textBox1.Text+"'";
            sc.Connection = sq; // Set the connection for the SqlCommand

            SqlDataAdapter da = new SqlDataAdapter(sc);
            DataSet sd = new DataSet();

            sq.Open(); // Open the connection before filling the dataset
            da.Fill(sd);
            sq.Close(); // Close the connection after filling the dataset

            dataGridView1.DataSource = sd.Tables[0];
        }
    }
}
