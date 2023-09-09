using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dp_project
{
    public partial class searchstudent : Form
    {
        private SearchSubject searchSubject = new SearchSubject();

        public searchstudent()
        {
            InitializeComponent();
            var dataGridViewObserver = new DataGridViewObserver(dataGridView2);
            searchSubject.Attach(dataGridViewObserver);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SM490GV;Initial Catalog=college;Integrated Security=True");
            string query = "SELECT * FROM students WHERE student_id = @StudentID";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@StudentID", textBox1.Text);

            try
            {
                sqlConnection.Open();
                DataTable resultTable = new DataTable();
                resultTable.Load(sqlCommand.ExecuteReader());
                searchSubject.NotifyObservers(resultTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public interface IObserver
        {
            void Update(DataTable data);
        }

        public class SearchSubject
        {
            private List<IObserver> observers = new List<IObserver>();

            public void Attach(IObserver observer)
            {
                observers.Add(observer);
            }

            public void NotifyObservers(DataTable data)
            {
                foreach (var observer in observers)
                {
                    observer.Update(data);
                }
            }
        }

        public class DataGridViewObserver : IObserver
        {
            private DataGridView dataGridView;

            public DataGridViewObserver(DataGridView dataGridView)
            {
                this.dataGridView = dataGridView;
            }

            public void Update(DataTable data)
            {
                dataGridView.DataSource = data;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This event handler is called when the text in textBox1 changes.
            // You can perform any required actions here.
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This event handler is called when a cell content in dataGridView2 is clicked.
            // You can perform any required actions here.
        }

        private void searchstudent_Load(object sender, EventArgs e)
        {

        }
    }
}
