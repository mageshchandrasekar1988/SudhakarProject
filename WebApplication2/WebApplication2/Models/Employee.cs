using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication2.Models
{
    public class Employee
    {
        private String str = ConfigurationManager.ConnectionStrings["curdConnectionString"].ToString();

        public List<EmployeLayer> getdata()
        {
            List<EmployeLayer> li = new List<EmployeLayer>();
           try
            {
                SqlConnection conn = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand("Sp_Employee_all", conn);
                conn.Open(); // throws if invalid
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    EmployeLayer emp1 = new EmployeLayer();
                    emp1.Id = Convert.ToInt32(rdr.GetValue(0));
                    emp1.Name = rdr.GetValue(1).ToString();
                    emp1.Gender = rdr.GetValue(2).ToString();
                    emp1.City = rdr.GetValue(3).ToString();
                    li.Add(emp1);
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return li;
        }
    }
}
