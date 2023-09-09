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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection sq = new SqlConnection();
                sq.ConnectionString = "Data Source=DESKTOP-SM490GV;Initial Catalog=college;Integrated Security=True";
                SqlCommand sd = new SqlCommand();
                sd.Connection = sq;
                sd.CommandText = "select student_name,father_name,discount_type from students join fees on st_id = student_id where st_id ='" + textBox1.Text + "'  ";
                SqlDataAdapter sw = new SqlDataAdapter(sd);
                DataSet ds = new DataSet();
                sw.Fill(ds);
                label6.Text = ds.Tables[0].Rows[0][0].ToString();
                label7.Text = ds.Tables[0].Rows[0][1].ToString();
                discountTypeComboBox.Text= ds.Tables[0].Rows[0][2].ToString();

            }


        }

        private void Fees_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            // First, retrieve the student ID based on student name
            SqlConnection sqRetrieve = new SqlConnection();
            sqRetrieve.ConnectionString = "Data Source=DESKTOP-SM490GV;Initial Catalog=college;Integrated Security=True";

            string studentName = textBox1.Text;
            int studentId;
   

            using (SqlCommand seRetrieve = new SqlCommand())
            {
                seRetrieve.Connection = sqRetrieve;
                seRetrieve.CommandText = "select student_id,student_name, father_name from students join fees on st_id = student_id where st_id = '" + textBox1.Text + "'";
                seRetrieve.Parameters.AddWithValue("@studentName", studentName);

                sqRetrieve.Open();
                studentId = Convert.ToInt32(seRetrieve.ExecuteScalar());
               
                sqRetrieve.Close();
            }

            // Now, perform the insert operation for fees
            SqlConnection sqInsert = new SqlConnection();
            sqInsert.ConnectionString = "Data Source=DESKTOP-SM490GV;Initial Catalog=college;Integrated Security=True";

            decimal discountFactor = 1.0m;
            string discountType = "";

            if (discountTypeComboBox.Text == "govt")
            {
                discountFactor = 0.90m;
                discountType = "govt";
            }
            else if (discountTypeComboBox.Text == "scholarship")
            {
                discountFactor = 0.60m;
                discountType = "scholarship";
            }
            else
            {
                discountFactor = 0;
                discountType = "Normal";
            }

            decimal originalFees = decimal.Parse(textBox2.Text);
            decimal discountedFees = originalFees * discountFactor;

            using (SqlCommand seInsert = new SqlCommand())
            {
                seInsert.Connection = sqInsert;
                seInsert.CommandText = "INSERT INTO fees (st_id, fees, discount_type, discountedFees) VALUES (@studentId, @fees, @discountType, @discountedFees)";
                seInsert.Parameters.AddWithValue("@studentId", studentId);
                seInsert.Parameters.AddWithValue("@fees", originalFees);
                seInsert.Parameters.AddWithValue("@discountType", discountType);
                seInsert.Parameters.AddWithValue("@discountedFees", discountedFees);

                sqInsert.Open();
                seInsert.ExecuteNonQuery();
                sqInsert.Close();
            }

            MessageBox.Show("Fees is Added Successfully");


        }
    }
}
