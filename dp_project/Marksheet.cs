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
    public partial class Marksheet : Form
    {
       
        public Marksheet()
        {
            InitializeComponent();
                      

        }

        private void StudentsCourse_Load(object sender, EventArgs e)
        {

        }

        private void cboCourses_SelectedIndexChanged_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void register_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3, Total, Obtain, p1, p2, p3, per;
            num1 = Convert.ToInt32(textBox6.Text);
            num2 = Convert.ToInt32(textBox7.Text);
            num3 = Convert.ToInt32(textBox8.Text);

            Total = num1 + num2 + num3;
            label28.Text = Total.ToString();

            int A;
            A = Convert.ToInt32(textBox6.Text);
            if (A >= 80 && A <= 100)
            {
                label18.Text = "A+";
            }
            else if (A >= 70 && A <= 79)
            {
                label18.Text = "A";
            }
            else if (A >= 60 && A <= 69)
            {
                label18.Text = "B";
            }
            else if (A >= 50 && A <= 59)
            {
                label18.Text = "C";
            }
            else if (A >= 40 && A <= 49)
            {
                label18.Text = "Fail";
            }
            int B;
            B = Convert.ToInt32(textBox7.Text);
            if (B >= 80 && B <= 100)
            {
                label19.Text = "A+";
            }
            else if (B >= 70 && B <= 79)
            {
                label19.Text = "A";
            }
            else if (B >= 60 && B <= 69)
            {
                label19.Text = "B";
            }
            else if (B >= 50 && B <= 59)
            {
                label19.Text = "C";
            }
            else if (B >= 40 && B <= 49)
            {
                label19.Text = "Fail";
            }

            int C;
            C = Convert.ToInt32(textBox8.Text);
            if (C >= 80 && C <= 100)
            {
                label20.Text = "A+";
            }
            else if (C >= 70 && C <= 79)
            {
                label20.Text = "A";
            }
            else if (C >= 60 && C <= 69)
            {
                label20.Text = "B";
            }
            else if (C >= 50 && C <= 59)
            {
                label20.Text = "C";
            }
            else if (C >= 40 && C <= 49)
            {
                label20.Text = "Fail";
            }

            Total = Convert.ToInt32(label28.Text);
            if (Total >= 240 && Total <= 300)
            {
                label26.Text = "A+";
            }
            else if (Total >= 170 && Total <= 239)
            {
                label26.Text = "A";
            }
            else if (Total >= 100 && Total <= 169)
            {
                label26.Text = "B";
            }
            else if (Total >= 40 && Total <= 99)
            {
                label26.Text = "C";
            }
            else if (Total >= 1 && Total <= 39)
            {
                label26.Text = "Fail";
            }

            p1 = num1 * 100 / 100;
            label21.Text = p1.ToString();
            p2 = num2 * 100 / 100;
            label22.Text = p2.ToString();
            p3 = num3 * 100 / 100;
            label23.Text = p3.ToString();

            per = Total / 3;
            label27.Text = per.ToString();

            string name, id, total, grade, perc;
            name = textBox1.Text;
            id = textBox2.Text;
            total = label28.Text;
            grade = label26.Text;
            perc = label27.Text;
            string query = "insert into marks values('" + name + "' , '" + id + "', '" + total + "', '" + grade + "', '" + perc + "')";
            SqlCommand cmd = new SqlCommand(query, connection.GetConnection());
            cmd.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
