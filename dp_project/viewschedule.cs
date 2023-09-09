using System;
using System.Windows.Forms;
using System.Collections.Generic;
using dp_project1;

namespace ClassScheduleSystem
{
    public partial class viewschedule : Form
    {
        private students student = new students(); // Create an instance of the students class

        public viewschedule()
        {
            InitializeComponent();
            RefreshSchedules();
        }

        private void RefreshSchedules()
        {
            listBox1.Items.Clear();

            // Call the GetSchedules method on the students instance
            List<Schedule> schedules = student.GetSchedules();

            foreach (var schedule in schedules)
            { 
                listBox1.Items.Add($"{schedule.ClassName} - {schedule.DateTime}");
            }
        }

        private void viewschedule_Load(object sender, EventArgs e)
        {

        }
    }
}

