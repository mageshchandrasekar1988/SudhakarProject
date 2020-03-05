using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication2.Controllers
{
    public class UserloginController : Controller
    {
        // GET: Userlogin
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Index(LoginClass lc)
        {
            String maincon = ConfigurationManager.ConnectionStrings["curdConnectionString"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(maincon);
            string sqlquery = "select user_name, password from tbluser where user_name = @user_name and password = @password";
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sqlquery, sqlcon);
            sqlcom.Parameters.AddWithValue("@user_name", lc.Username);
            sqlcom.Parameters.AddWithValue("@password", lc.Password);
            SqlDataReader sd = sqlcom.ExecuteReader();
            if (sd.Read())
            {
                Session["username"] = lc.Username.ToString();
                //return RedirectToAction("/Home");
                return RedirectToAction("Index", "Home");

            }
            else
            {
                ViewData["message"] = "User Login Details is failed!"; 
            }
            sqlcon.Close();
            return View();
        }

        public ActionResult welcome()
        {
            return View();
        }


    }
}