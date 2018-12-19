using Asp.Net_MvcPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.Net_MvcPractice.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string GetString()

        {
            return "TestController Action GetString";
        }

        public ActionResult GetView()
        {
            Employee employee = new Employee()
            {
                FirstName = "Sukesh",
                LastName = "Marla",
                Salary = 100
            };
            EmployeeViewModel employeeViewModel = new EmployeeViewModel()
            {
                EmployeeName = employee.FirstName + employee.LastName,
                Salary = employee.Salary.ToString("C"),
                SalaryColor = employee.Salary > 15000 ? "yellow" : "green",
                UserName = "admin"
            };

            ViewBag.employee = employee;
            return View("MyView", employeeViewModel);
        }
    }
}