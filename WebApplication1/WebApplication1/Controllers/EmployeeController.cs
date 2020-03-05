using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        SampleEntities jobEntities = new SampleEntities();

        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.();

            return View();

        }

        public ActionResult Details ()
        {
            string strcon = ConfigurationManager.ConnectionStrings["EmployeeContext"].ConnectionString;
            //create new sqlconnection and connection to database by using connection string from web.config file  
            SqlConnection con = new SqlConnection(strcon);
            // open Connection String 
            con.Open();
            // Closing Connection String
            con.Close();
            var varEmployee = from emp in jobEntities.tblEmployees select emp;
            return View(varEmployee);
        }
    }
}