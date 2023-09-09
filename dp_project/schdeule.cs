using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dp_project
{
    public partial class schdeule : Form
    {
        private SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-PD4CV4V;Initial Catalog=college;Integrated Security=True"); // Replace with your connection string

        public schdeule()
        {
            InitializeComponent();
            LoadSchedules();
        }

        private void LoadSchedules()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SM490GV;Initial Catalog=college;Integrated Security=True"))
                {
                    sqlConnection.Open();
                    string query = "SELECT ClassName, DateTimes FROM dbo.Schedules";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading schedules: " + ex.Message);
            }
        }

        private void buttonAddSchedule_Click_1(object sender, EventArgs e)
        {
            try
            {
                string className = textBoxClassName.Text;
                DateTime dateTime = dateTimePicker.Value;

                using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SM490GV;Initial Catalog=college;Integrated Security=True"))
                {
                    sqlConnection.Open();
                    string insertQuery = "INSERT INTO Schedules (ClassName, DateTimes) VALUES (@ClassName, @DateTime)";
                    SqlCommand cmd = new SqlCommand(insertQuery, sqlConnection);
                    cmd.Parameters.AddWithValue("@ClassName", className);
                    cmd.Parameters.AddWithValue("@DateTime", dateTime);
                    cmd.ExecuteNonQuery();
                }

                LoadSchedules();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding schedule: " + ex.Message);
            }
        }
    }
}