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
    public partial class Prototyping : Form
    {
        public Prototyping()
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
            c_prototype p1 = new c_prototype(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text);
            c_prototype c1 = (c_prototype)p1.Clone();
            listBox2.Items.Add("Name:" + p1.name + "   Father Name:" + p1.fname + "   Contact Name:" + p1.cont + "   Age:" + p1.ag);
            listBox1.Items.Add("Name:"+c1.name+"   Father Name:"+c1.fname + "   Contact Name:" +c1.cont + "   Age:"+c1.ag);
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
