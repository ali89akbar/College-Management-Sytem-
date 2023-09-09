using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace dp_project
{
    public partial class updatestudent : Form
    {
        private string connectionString = "Data Source=DESKTOP-SM490GV;Initial Catalog=college;Integrated Security=True";
        private StudentRepository studentRepository;
        private Dictionary<string, int> studentIdMap = new Dictionary<string, int>();

        public updatestudent()
        {
            InitializeComponent();
            studentRepository = new StudentRepository(connectionString);
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            comboBox1.Items.Clear(); // Clear existing items in the combobox
            studentIdMap.Clear();    // Clear the dictionary

            Dictionary<int, string> students = studentRepository.GetAllStudents();
            HashSet<string> addedNames = new HashSet<string>(); // To track added names

            foreach (var student in students)
            {
                if (!addedNames.Contains(student.Value)) // Check if the name is already added
                {
                    comboBox1.Items.Add(student.Value);
                    studentIdMap.Add(student.Value, student.Key);
                    addedNames.Add(student.Value); // Add the name to the tracking set
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem is string selectedStudentName)
            {
                if (studentIdMap.ContainsKey(selectedStudentName))
                {
                    int studentId = studentIdMap[selectedStudentName];

                    studentRepository.UpdateStudentInfo(studentId, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                    MessageBox.Show("Student information updated successfully.");
                }
                else
                {
                    MessageBox.Show("Selected student not found in the dictionary.");
                }
            }
            else
            {
                MessageBox.Show("Please select a student from the list.");
            }
        }

        private void updatestudent_Load(object sender, EventArgs e)
        {

        }
    }
}
