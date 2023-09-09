using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace dp_project
{
    public interface IRepository<T>
    {
        Dictionary<int, T> GetAll();
        void Update(int id, T entity);
    }

    public class StudentRepository
    {
        private string connectionString;

        public StudentRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Dictionary<int, string> GetAllStudents()
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT student_id, student_name FROM students";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int studentId = Convert.ToInt32(reader["student_id"]);
                                string studentName = reader["student_name"].ToString();

                                students.Add(studentId, studentName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }

            return students;
        }

        public void UpdateStudentInfo(int studentId, string studentName, string fatherName, string contact, string age)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE students SET student_name = @studentName, father_name = @fatherName, contact = @contact, age = @age WHERE student_id = @studentId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentName", studentName);
                        command.Parameters.AddWithValue("@fatherName", fatherName);
                        command.Parameters.AddWithValue("@contact", contact);
                        command.Parameters.AddWithValue("@age", age);
                        command.Parameters.AddWithValue("@studentId", studentId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
