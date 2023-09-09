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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StuRegis p = new StuRegis();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

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

        private void button3_Click_1(object sender, EventArgs e)
        {
       
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuRegis p = new StuRegis();
            p.Show();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TechData t = new TechData();
            t.Show();
        }

        private void addMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marksheet SC = new Marksheet();
            SC.Show();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatestudent us = new updatestudent();
            us.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees ss = new Fees();
            ss.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchstudent std = new searchstudent();
            std.Show();

        }

        private void addScheddlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            schdeule sd = new schdeule();
            sd.Show();
        }

        private void searchTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchteacher stdd = new searchteacher();
            stdd.Show();
        }

        private void Management_Load(object sender, EventArgs e)
        {

        }
    }
}
