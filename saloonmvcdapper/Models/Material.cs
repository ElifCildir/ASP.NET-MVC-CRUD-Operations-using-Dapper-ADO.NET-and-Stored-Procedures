using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace saloonmvcdapper.Models
{
    public class Material
    {
        public int MaterialID { get; set; }
        public string MaterialName { get; set; }

        public decimal MaterialPrice { get; set; }
        public string MaterialFunction { get; set; }
        public string MaterialDefiniton { get; set; }
        public int ServiceID { get; set; }
    }
}