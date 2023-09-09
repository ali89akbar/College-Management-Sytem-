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
    public partial class TechData : Form
    {
        public TechData()
        {
            InitializeComponent();
        }
        facade f = new facade();
        private void ins_upd_dlt_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            f.insertion(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox7.Text,textBox8.Text);
            MessageBox.Show("Data Inserted!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.updation(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox7.Text, textBox8.Text);
            MessageBox.Show("Data Updated!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
