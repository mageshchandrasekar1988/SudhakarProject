using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.SqlClient;

namespace ADOCURD.Models
{
    public class db
    {
        SqlConnection con;
        public db() { 
            var configuration = GetConfiguration();
            con = new SqlConnection(configuration.GetSection("Data").GetSection("ConnectionInfo").Value);
        }
        public IConfigurationRoot GetConfiguration()
        {
            var bulider = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings", optional: true, reloadOnChange: true);
            return bulider.Build();
        }
    }
   



}
