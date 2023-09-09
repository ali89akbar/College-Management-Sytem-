using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClassScheduleSystem;

namespace dp_project1
{
    class students
    {
        private SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-SM490GV;Initial Catalog=college;Integrated Security=True");

        public List<Schedule> GetSchedules()
        {
            List<Schedule> studentSchedules = new List<Schedule>();

            try
            {
                sqlConnection.Open();
                string query = "SELECT ClassName, DateTimes FROM Schedules"; // Change column names if needed
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Schedule schedule = new Schedule
                    {
                        ClassName = reader["ClassName"].ToString(),
                        DateTime = Convert.ToDateTime(reader["DateTimes"])
                    };
                    studentSchedules.Add(schedule);
                }
            }
            catch (Exception ex)
            {
                // Handle exception or display error message
            }
            finally
            {
                sqlConnection.Close();
            }

            return studentSchedules;
        }
    }
}
