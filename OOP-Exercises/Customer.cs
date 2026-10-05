using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Exercises
{
    public class Customer
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime JoinDate { get; set; }

        public string SubmitOrder()
        {
            return "Order submitted.";
        }
        public string CancelOrder()
        {
            return "Order cenceled.";
        }
 } 
}
