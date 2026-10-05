using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exercises
{
    public enum GenderType
    {
        Male,
        Female
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public GenderType Gender { get; set; }
        public string NationalId { get; set; }

        public string DoHomework()
        {
            return "Homnework completed.";
        }
		public bool AttendClass()
        {
            return true;
        }
		public string RegisterCourse()
        {
            return "Course registered.";
        }
    }
        

}
