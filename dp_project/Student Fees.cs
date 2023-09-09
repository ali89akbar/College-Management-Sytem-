using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dp_project
{
    public partial class Student_Fees : Form
    {
        Context context;
        public Student_Fees()
        {
            InitializeComponent();
            context = new Context();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
           
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please Fill All the TextBoxes First!!");
                return; 
            }

            else if (radioButton1.Checked)
            {
                context.SetState(new Discount10State()); // Set the context with the desired state
            }
            else if (radioButton2.Checked)
            {
                context.SetState(new NoDiscountState()); 
            }
            else if (radioButton3.Checked)
            {
                context.SetState(new Discount40State()); 
            }

            context.CalculateFee(); 
        }

        private void Student_Fees_Load(object sender, EventArgs e)
        {
            label6.Hide();
            label7.Hide();
            label8.Hide();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
