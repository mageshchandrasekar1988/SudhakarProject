using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using ADOCURD.Models;
using System.Data;
using FastMember;
using OfficeOpenXml;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using OfficeOpenXml.Style;
using System.Drawing;
using MimeKit;
using MimeKit.;


namespace ADOCURD.Controllers
{
    public class HomeController : Controller
    {
        // db Connection = new db();
        string ConnectionInfo = "Data Source =SSCCHN1DT0900\\SQLEXPRESS; Initial Catalog= sample1; User ID=sa;Password=sudhakar_2012;Integrated Security=false";

        public FileResult Index()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Test Project", "test191@gmail.com"));
            message.To.Add(new MailboxAddress("sudhakarvmca1989@gmail.com"));
            message.Body = new TextPart("Palin")
            {
                Text = "hello World"
            };

            using (var client = new SmtpClient()) { 
                client.Connect()
            }

                return null;
            ////List<Student> oStudent = new List<Student>()
            ////{
            ////    new Student() { ID=1,Name = "Sudhakar",Roll =1001},
            ////    new Student() { ID=2,Name = "Sudhakar",Roll =1002},
            ////    new Student() { ID=3,Name = "Sudhakar",Roll =1003},
            ////    new Student() { ID=4,Name = "Sudhakar",Roll =1004},
            ////    new Student() { ID=5,Name = "Sudhakar",Roll =1005},
            ////};

           
            //using (var reader = ObjectReader.Create(oStudent))
            //{
            //    dt.Load(reader);
            //}


            ////ListtoDataTableConverter converter = new ListtoDataTableConverter();

            ////DataTable dtExport = converter.ToDataTable(oStudent);

            //string Queue = "test";

            //using (ExcelPackage pck = new ExcelPackage())
            //{
            //    //Create the worksheet
            //    //ExcelWorksheet ws = pck.Workbook.Worksheets.Add(fileName);
            //    ExcelWorksheet ws = pck.Workbook.Worksheets.Add(Queue);

            //    //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1
            //    ws.Cells["A1"].LoadFromDataTable(dtExport, true);

            //    //Format the header for column 1-3
            //    using (ExcelRange rng = ws.Cells["A1:DB1"])
            //    {
            //        rng.Style.Font.Bold = true;
            //        rng.Style.Fill.PatternType = ExcelFillStyle.Solid;                      //Set Pattern for the background to Solid
            //        //rng.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(79, 129, 189));  //Set color to dark blue
            //        //rng.Style.Font.Color.SetColor(Color.White);
            //    }

            //    //Example how to Format Column 1 as numeric 
            //    using (ExcelRange col = ws.Cells[2, 1, 2 + dtExport.Columns.Count, 1])
            //    {
            //        col.Style.Numberformat.Format = "#,##0.00";
            //        col.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            //    }

            //    //ws.Cells[2, 5, 2 + dtExport.Rows.Count, 5].Style.Numberformat.Format = "dd-MMM-yyyy hh:mm";
            //    //ws.Cells[2, 7, 2 + dtExport.Rows.Count, 7].Style.Numberformat.Format = "dd-MMM-yyyy";
            //    //ws.Cells[2, 14, 2 + dtExport.Rows.Count, 14].Style.Numberformat.Format = "dd-MMM-yyyy hh:mm";//etd
            //    //ws.Cells[2, 20, 2 + dtExport.Rows.Count, 20].Style.Numberformat.Format = "dd-MMM-yyyy hh:mm";
            //    //ws.Cells[2, 37, 2 + dtExport.Rows.Count, 37].Style.Numberformat.Format = "dd-MMM-yyyy hh:mm";//bkg confirm
            //    //ws.Cells[2, 43, 2 + dtExport.Rows.Count, 43].Style.Numberformat.Format = "dd-MMM-yyyy hh:mm";
            //    //ws.Cells[2, 45, 2 + dtExport.Rows.Count, 45].Style.Numberformat.Format = "dd-MMM-yyyy hh:mm";
            //    //ws.Cells[2, 46, 2 + dtExport.Rows.Count, 46].Style.Numberformat.Format = "dd-MMM-yyyy hh:mm";

            //    //ws.Cells[2, 48, 2 + dtExport.Rows.Count, 48].Style.Numberformat.Format = "dd-MMM-yyyy hh:mm";
            //    //ws.Cells[2, 49, 2 + dtExport.Rows.Count, 49].Style.Numberformat.Format = "dd-MMM-yyyy hh:mm";

            //    //ws.Cells[2, 51, 2 + dtExport.Rows.Count, 51].Style.Numberformat.Format = "dd-MMM-yyyy hh:mm";
            //    //ws.Cells[2, 54, 2 + dtExport.Rows.Count, 54].Style.Numberformat.Format = "dd-MMM-yyyy hh:mm";
            //    //ws.Cells[2, 56, 2 + dtExport.Rows.Count, 56].Style.Numberformat.Format = "dd-MMM-yyyy hh:mm";

            //    //ws.Cells[2, 61, 2 + dtExport.Rows.Count, 61].Style.Numberformat.Format = "dd-MMM-yyyy hh:mm";
            //    //ws.Cells[2, 63, 2 + dtExport.Rows.Count, 63].Style.Numberformat.Format = "dd-MMM-yyyy hh:mm";
            //    //ws.Cells[2, 65, 2 + dtExport.Rows.Count, 65].Style.Numberformat.Format = "dd-MMM-yyyy hh:mm";



            //    //ws.Cells["A:ZZ"].AutoFitColumns();
            //    //Write it back to the client

            //    //Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            //    //Response.AddHeader("content-disposition", "attachment;  filename=" + Queue + "_" + DateTime.Now.ToFileTime() + ".xlsx");
            //    //Response.BinaryWrite(pck.GetAsByteArray());

            //    HttpContext.Response.Headers["ContentType"] = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            //    HttpContext.Response.Headers["content-disposition"] = new[] { "attachment;  filename=" + Queue + "_" + DateTime.Now.ToFileTime() + ".xlsx" };
            //    HttpContext.Response.Body.Write(pck.GetAsByteArray());
            //}

            //byte[] fileContents;
            //using (var package = new ExcelPackage())

            //{
            //    var worksheet = package.Workbook.Worksheets.Add("StudentList");
            //    worksheet.Cells["A1"].LoadFromDataTable(dtExport, true);

            //    using (ExcelRange rng = worksheet.Cells["A1:C1"])
            //    {
            //        rng.Style.Font.Bold = true;
            //        rng.Style.Fill.PatternType = ExcelFillStyle.Solid;                      //Set Pattern for the background to Solid
            //        rng.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(79, 129, 189));  //Set color to dark blue
            //        rng.Style.Font.Color.SetColor(Color.White);
            //    }

            //    fileContents = package.GetAsByteArray();
            //}
            //if (fileContents == null || fileContents.Length == 0)
            //{
            //    return null;
            //}
            //return File(
            //    fileContents: fileContents,
            //    contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            //    fileDownloadName: "StudentList.xlsx"
            // );

            //return null;

            //return View();
        }

        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Roll { get; set; }
        }

        [HttpPost]
        public IActionResult Index1(Userinfo UI)
        {
            SqlConnection Mainconnection = new SqlConnection(ConnectionInfo);
            Mainconnection.Open();
            string myquery = "Insert into dbo.tbluser(user_name,password) values ('" + UI.username + "', '1234')";
            SqlCommand mycom = new SqlCommand(myquery, Mainconnection);
            mycom.ExecuteNonQuery();
            Mainconnection.Close();
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }

    public class ListtoDataTableConverter

    {

        public DataTable ToDataTable<T>(List<T> items)

        {

            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties

            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in Props)

            {

                //Setting column names as Property names

                dataTable.Columns.Add(prop.Name);

            }

            foreach (T item in items)

            {

                var values = new object[Props.Length];

                for (int i = 0; i < Props.Length; i++)

                {

                    //inserting property values to datatable rows

                    values[i] = Props[i].GetValue(item, null);

                }

                dataTable.Rows.Add(values);

            }

            //put a breakpoint here and check datatable

            return dataTable;

        }

    }
}
