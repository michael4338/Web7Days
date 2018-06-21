using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Web7Days.DataAccessLayer;
using Web7Days.Models;

namespace Web7Days.ViewModels
{
    public class EmployeeListViewFromDBModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        public string UserName { get; set; }

        public EmployeeListViewFromDBModel(string userName)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            GetEmployeesFromDB();
            this.UserName = userName;
        }

        public void SaveEmployee(Employee e)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
        }

        private void GetEmployeesFromDB()
        {
            Employees = new List<EmployeeViewModel>();
            SalesERPDAL salesDal = new SalesERPDAL();
            List<Employee> employees = salesDal.Employees.ToList();
            foreach(Employee e in employees)
                Employees.Add(new EmployeeViewModel(e.FirstName, e.LastName, e.Salary, this.UserName));
        }
    }
}