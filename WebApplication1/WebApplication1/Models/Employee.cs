using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Employee
    {
       /* [Table("tblEmployee")]*/
         public int EmployeeId { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }
        public String City { get; set; }
    }
}