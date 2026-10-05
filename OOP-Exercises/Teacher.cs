using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exercises
{
   public class Teacher
    { 
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Subject { get; set; }
        public GenderType Gender { get; set; }
        public double Salary { get; set; }
        public int WorkingHours { get; set; }
        public int VacationDays { get; set; }
        public string NationalId { get; set; }

        public string CreateExam()
        {
            return " Exam created.";
        }
        public string RecordClass()
        {
            return "Class recorded.";
        }
    }
}
