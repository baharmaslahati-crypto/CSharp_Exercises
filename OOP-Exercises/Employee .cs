using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exercises
{
    public class Employee
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
        public string Job { get; set; }
        public string Salary { get; set; }
        public string Email { get; set; }
        public int EmployeeId { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalId { get; set; }
        public int WorkingHours { get; set; }
        public bool IsFullTime { get; set; }
        public string CompanyName { get; set; }
        public int VacationDays { get; set; }

        public bool StartWork()
        {
            return true;
        }
        public bool ReceiveSalary()
        {
            return true;
        }

    }
      
}
