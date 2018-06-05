using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web7Days.ViewModels
{
    public class EmployeeViewModel
    {
        public string EmployeeName { get; set; }
        public string Salary { get; set; }
        public string SalaryColor { get; set; }
        public string UserName { get; set; }

        public EmployeeViewModel(string fn, string ln, int sa, string un)
        {
            this.EmployeeName = fn + " " + ln;
            this.Salary = sa.ToString();
            this.SalaryColor = (sa > 15000 ? "yellow" : "green");
            this.UserName = un;
        }
    }
}