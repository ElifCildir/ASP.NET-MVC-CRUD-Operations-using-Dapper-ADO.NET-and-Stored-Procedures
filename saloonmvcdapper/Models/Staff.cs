using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace saloonmvcdapper.Models
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string NameSurname { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
        public string WorkSchedule { get; set; }
        public decimal Bonus { get; set; }
        public int CenterID { get; set; }


    }
}