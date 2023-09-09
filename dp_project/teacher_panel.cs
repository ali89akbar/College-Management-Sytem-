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
    public partial class teacher_panel : Form
    {
        public teacher_panel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prototyping p = new Prototyping();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ins_upd_dlt t = new ins_upd_dlt();
            t.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
