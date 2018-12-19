using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.Net_MvcPractice.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
    }
    public class EmployeeViewModel
    {
        

        public string Salary { get; set; }
        public string SalaryColor { get; set; }
        public string UserName { get; set; }
        [Display(Name = "姓名")]
        [DataType(DataType.Text)]
        public string EmployeeName { get; set; }
    }
}