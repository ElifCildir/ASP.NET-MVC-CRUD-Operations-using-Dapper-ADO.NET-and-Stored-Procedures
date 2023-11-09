using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace saloonmvcdapper.Models
{
    public class Servicess
    {

        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string ServicePurpose { get; set; }
        public decimal ServiceFee { get; set; } 
        public string PaymentType { get; set; }
        public int StaffID { get; set; }




    }
}