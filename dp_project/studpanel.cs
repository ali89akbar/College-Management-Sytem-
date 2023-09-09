using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassScheduleSystem;
namespace dp_project
{
    public partial class studpanel : Form
    {
        public studpanel()
        {
            InitializeComponent();
        }

        private void viewBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Fees ss = new Student_Fees();
            ss.Show();

        }

        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Replace "GetLoggedInStudentId()" with the actual method you're using to get the logged-in student's ID
      


        }

        private void studpanel_Load(object sender, EventArgs e)
        {
            
        }

        private void viewScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewschedule vs = new viewschedule();
            vs.Show();
        }
    }
}
