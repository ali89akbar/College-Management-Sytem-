using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dp_project
{
    public partial class StuRegis : Form
    {
        public StuRegis()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Prototyping_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Infotype p1 = new Infotype(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text);
            Infotype c1 = (Infotype)p1.Clone();
            listBox2.Items.Add("Name:" + p1.name + "   Father Name:" + p1.fname + "   Contact Name:" + p1.cont + "   Age:" + p1.ages);
            listBox1.Items.Add("Name:"+c1.name+"   Father Name:"+c1.fname + "   Contact Name:" +c1.cont + "   Age:"+c1.ages);
            string name = textBox1.Text;
            string id = textBox5.Text;
            string fname = textBox2.Text;
            int con = Convert.ToInt32(textBox3.Text);
            int age = Convert.ToInt32(textBox4.Text);
            SqlConnection conn = new SqlConnection();
             conn.ConnectionString = "Data Source=DESKTOP-SM490GV;Initial Catalog=college;Integrated Security=True";
            SqlCommand sq = new SqlCommand();
            sq.Connection = conn;
            sq.CommandText = "insert into students(student_id,student_name,father_name,contact,age) values ('"+id+"','"+name+"','"+fname+"','"+con+"','"+age+"') ";
            SqlDataAdapter da = new SqlDataAdapter(sq);
            DataSet db = new DataSet();
            da.Fill(db);
            conn.Close();
            MessageBox.Show("Data Saved ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
