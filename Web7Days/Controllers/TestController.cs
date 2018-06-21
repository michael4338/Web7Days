using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Web7Days.Models;
using Web7Days.ViewModels;

namespace Web7Days.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string GetString()
        {
            return "Hello World is old now. It's time for wassup bro ;)";
        }

        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Michael";
            emp.LastName = "Lin";
            emp.Salary = 20000;

            // ViewData["Employee"] = emp;
            // ViewBag.Employee = emp;

            EmployeeViewModel vmEmp = new EmployeeViewModel(emp.FirstName,emp.LastName,emp.Salary,"Admin");

            // return View("MyView");

            return View("MyView", vmEmp);
        }

        public ActionResult GetViewList()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp = new Employee();
            emp.FirstName = "johnson";
            emp.LastName = " fernandes"; 
            emp.Salary = 14000;
            employees.Add(emp);

            emp = new Employee();
            emp.FirstName = "michael";
            emp.LastName = "jackson";
            emp.Salary = 16000;
            employees.Add(emp);

            emp = new Employee();
            emp.FirstName = "robert";
            emp.LastName = " pattinson";
            emp.Salary = 20000;
            employees.Add(emp);

            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel("Admin");
            foreach(Employee e in employees)
                employeeListViewModel.Employees.Add(new EmployeeViewModel(e.FirstName,e.LastName,e.Salary,"Admin"));

            return View("MyListView", employeeListViewModel);
        }

        public ActionResult GetViewFromDB()
        {
            EmployeeListViewFromDBModel dbModel = new EmployeeListViewFromDBModel("milin");
            return View("MyListViewDB", dbModel);
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }

        public ActionResult SaveEmployee(Employee e)
        {
            // return e.FirstName + "|" + e.LastName + "|" + e.Salary;

            if (ModelState.IsValid)
            {
                EmployeeListViewFromDBModel dbModel = new EmployeeListViewFromDBModel("milin");
                dbModel.SaveEmployee(e);
                //return new EmptyResult();
                return RedirectToAction("GetViewFromDB");
            }
            else
            {
                // return RedirectToAction("AddNew");
                return View("CreateEmployee");
            }
        }
    }
}