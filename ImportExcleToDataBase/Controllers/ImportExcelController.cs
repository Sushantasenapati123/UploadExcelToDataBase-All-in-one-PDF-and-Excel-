using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using System.IO;
using ImportExcleToDataBase.Service;
using ImportExcleToDataBase.Models;
using OfficeOpenXml;
using ClosedXML.Excel;

namespace ImportExcleToDataBase.Controllers
{
    public class ImportExcelController : Controller
    {
        private readonly IStudentService _studservice;
        public ImportExcelController(IStudentService studservice)
        {
            _studservice = studservice;
        }

        public async Task<IActionResult> Index()
        {
            List<StudentEntity> lstobj = await _studservice.GetAllStudentService();
            ViewBag.Message = null;
            return View(lstobj);
        }

        [HttpPost]
        public IActionResult Index(IFormFile file)
        {
            try
            {
                if (file != null && file.Length > 0)
                {
                    string fileExtension = file.ContentType.Trim();
                    if ((fileExtension == "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet") || (fileExtension == "application/vnd.ms-excel"))
                    {

                        var filename = file.FileName + DateTime.Now.ToString("yymmssfff");
                        var path = Path.Combine(
                                    Directory.GetCurrentDirectory(), "wwwroot/Files",
                                    filename);

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            file.CopyToAsync(stream);
                        }

                        var fileinfo = new FileInfo(path);
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                        using (var package = new ExcelPackage(fileinfo))
                        {
                            var workbook = package.Workbook;
                            var worksheet = workbook.Worksheets.First();
                            int colCount = worksheet.Dimension.End.Column;  //get Column Count
                            int rowCount = worksheet.Dimension.End.Row;
                            List<StudentEntity> lstStud = new List<StudentEntity>();


                            for (int row = 2; row <= rowCount; row++)
                            {
                                StudentEntity stud = new StudentEntity();
                                for (int col = 1; col <= colCount; col++)
                                {
                                    if (!string.IsNullOrEmpty(worksheet.Cells[row, col].Value?.ToString().Trim()))
                                    {
                                        if (col == 1)
                                        {
                                            stud.STUD_NAME = worksheet.Cells[row, col].Value?.ToString().Trim();
                                        }
                                        else if (col == 2)
                                        {
                                            stud.TOTAL_MARK = Convert.ToInt32(worksheet.Cells[row, col].Value?.ToString().Trim());
                                        }
                                        else if (col == 3)
                                        {
                                            stud.OBTAINED_MARK = Convert.ToInt32(worksheet.Cells[row, col].Value?.ToString().Trim());
                                        }
                                    }

                                }
                                if (!string.IsNullOrWhiteSpace(stud.STUD_NAME))
                                {
                                    lstStud.Add(stud);
                                }
                            }
                            if (lstStud != null)
                                foreach (var stud in lstStud)
                                {
                                    StudentEntity studen = new StudentEntity();

                                    studen.STUD_NAME = stud.STUD_NAME;
                                    studen.TOTAL_MARK = stud.TOTAL_MARK;
                                    studen.OBTAINED_MARK = stud.OBTAINED_MARK;

                                    _studservice.InsertStudentService(studen);
                                }

                        }

                    }
                }
                ViewBag.Message = "Excel File Uplaod Sucessfully";
                return View();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Export()
        {
            DataTable dt = new DataTable("StudentMarkList");
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("STUD_NAME"),
                                        new DataColumn("TOTAL_MARK"),
                                        new DataColumn("OBTAINED_MARK"),
                                        new DataColumn("PERCENTAGE_MARK"),
                                        new DataColumn("Grade")});

            var students = await _studservice.GetAllStudentService();

            foreach (var student in students)
            {
                dt.Rows.Add(student.STUD_NAME, student.TOTAL_MARK, student.OBTAINED_MARK, student.PERCENTAGE_MARK, student.Grade);
            }

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "StudentMarkList.xlsx");
                }
            }
        }
    }
}
