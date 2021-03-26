using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class Apply
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public decimal MinimumStartingSalary { get; set; }
        public DateTime ApplicationDate { get; set; }
        public bool Rejected { get; set; }
        public string Comment { get; set; }
    }
}