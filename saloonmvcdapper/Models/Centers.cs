using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace saloonmvcdapper.Models
{
    public class Centers
    {
        public int CenterID { get; set; }
        public string CenterName { get; set; }
        public int CenterDoorNumber { get; set; }
        public string OperationPerformed { get; set; }
        public int NumberofOperations { get; set; }
    }
}