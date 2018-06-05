using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web7Days.ViewModels
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        public string UserName { get; set; }

        public EmployeeListViewModel(string userName)
        {
            this.Employees = new List<EmployeeViewModel>();
            this.UserName = userName;
        }
    }
}