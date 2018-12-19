using Asp.Net_MvcPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Asp.Net_MvcPractice.Controllers
{
    public class HtmlHelperController : Controller
    {
        // GET: HtmlHelper
        public ActionResult Index()
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
            return View(employeeViewModel);
        }
        public string GetString()
        {
            return "HtmlHelperController Action GetString";
        }
        public string GetParameters()
        {
            return Request.RawUrl;
        }
        public string  SubmitForm_Get()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Get_TextBoxID:");
           builder.Append( Request.QueryString["Get_TextBoxID"].ToString());
            builder.Append("<br/>");
            builder.Append("Get_CheckBoxID:");
            builder.Append(
            Request.QueryString["Get_CheckBoxID"].ToString().IndexOf(',')>-1?true:false);//选中时返回true，false 故检查字符串中若存在‘，’则返回的时两个值为true 否则为false
            return builder.ToString();
        }
        public string SubmitForm_Post()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Post_TextBoxID:");
            builder.Append(Request.Form["Post_TextBoxID"].ToString());
            builder.Append("<br/>");
            builder.Append("Post_CheckBoxID:");
            builder.Append(
            Request.Form["Post_CheckBoxID"].ToString().IndexOf(',') > -1 ? true : false);//与上面同理
            return builder.ToString();
        }
    }
}