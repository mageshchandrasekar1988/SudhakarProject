using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using WebApplication2.Models;
using System.Data.SqlClient;
using System.Configuration;


namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        database.db dblayer = new database.db();
        [AllowAnonymous]
        public ActionResult Index()
        {


            Employee obj = new Employee();
            List<EmployeLayer> emp = obj.getdata();

            return View(emp);
        }
        [AllowAnonymous]
        public ActionResult About(string id)
        {
            ViewBag.Message = "Your application description page.";

            //ViewContext.Message = "Your application description page.";

            return View();
        }
        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult LoadData()
        {
            String str = ConfigurationManager.ConnectionStrings["curdConnectionString"].ToString();
            List<EmployeLayer> li = new List<EmployeLayer>();
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("Sp_Employee_all", conn);
            conn.Open(); // throws if invalid
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                EmployeLayer emp1 = new EmployeLayer();
                //emp1.Id = Convert.ToInt32(rdr.GetValue(0));
                emp1.Name = rdr.GetValue(1).ToString();
                emp1.Gender = rdr.GetValue(2).ToString();
                emp1.City = rdr.GetValue(3).ToString();
                li.Add(emp1);
            }
            return Json(new { data = li }, JsonRequestBehavior.AllowGet);

        }
    }
}