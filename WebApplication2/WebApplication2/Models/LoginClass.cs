using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class LoginClass
    {
        [Required (ErrorMessage = "Please Enter the username")]
        [Display (Name ="Enter Username : ")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please Enter the Password")]
        [Display(Name = "Enter Password : ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}