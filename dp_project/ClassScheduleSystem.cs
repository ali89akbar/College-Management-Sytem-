using System;
using System.Collections.Generic;

namespace ClassScheduleSystem
{
    public class Schedule
    {
        public string ClassName { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class Admin
    {
        private List<Schedule> schedules = new List<Schedule>();

        public void AddSchedule(string className, DateTime dateTime)
        {
            Schedule schedule = new Schedule { ClassName = className, DateTime = dateTime };
            schedules.Add(schedule);
            Console.WriteLine($"Schedule added: {className} on {dateTime}");
        }
    }
}
