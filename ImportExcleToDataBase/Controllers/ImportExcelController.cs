using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using System.IO;
using ImportExcleToDataBase.Service;
using ImportExcleToDataBase.Models;
using OfficeOpenXml;
using ClosedXML.Excel;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using PdfSharp;

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
            List<StudentEntity> lstobj = _studservice.GetAllStudentService();
            ViewBag.Message = null;
            return View(lstobj);
        }
        public void ImportoExcelFromDataBase()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Salary Slab");
                var currentRow = 1;

                worksheet.Cell(currentRow, 1).Value = "STUD_NAME";
                worksheet.Cell(currentRow, 2).Value = "TOTAL_MARK";
                worksheet.Cell(currentRow, 3).Value = "OBTAINED_MARK";
                worksheet.Cell(currentRow, 4).Value = "PERCENTAGE_MARK";
                worksheet.Cell(currentRow, 5).Value = "Grade";


                List<StudentEntity> studd = _studservice.GetAllStudentService();


                foreach (var val in studd)
                {
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = val.STUD_NAME;
                        worksheet.Cell(currentRow, 2).Value = val.TOTAL_MARK;
                        worksheet.Cell(currentRow, 3).Value = val.OBTAINED_MARK;
                        worksheet.Cell(currentRow, 4).Value = val.PERCENTAGE_MARK;
                        worksheet.Cell(currentRow, 5).Value = val.Grade;

                    }
                }
                var stream = new MemoryStream();
                workbook.SaveAs(stream);
                var content = stream.ToArray();
                Response.Clear();
                Response.Headers.Add("content-disposition", "attachment;filename=salary slab.xls");
                Response.ContentType = "application/xls";
                Response.Body.WriteAsync(content);
                Response.Body.Flush();
            }
        }
        public void GeneratePDF()
        {
            PdfSharpCore.Pdf.PdfDocument document = new PdfSharpCore.Pdf.PdfDocument();

            int c = 0;
            List<StudentEntity> detail = _studservice.GetAllStudentService();

          
            string htmlcontent = "<div class='col-lg-12'>";
            htmlcontent += "<h2 style='text-align:center'>Salary Slab</h2>";
            htmlcontent += "<hr>";
            htmlcontent += "<br>";
            htmlcontent += "<table align='center' style='width: 100 %; border:1px solid #000; border-collapse:collapse'>";
            htmlcontent += "<thead style='font-weight:bold; background-color:blueviolet'>";
            htmlcontent += "<tr>";
            htmlcontent += "<td style='border:1px solid #000'> Sl# </td>";
            htmlcontent += "<td style='border:1px solid #000'> STUD_NAME  </td>";
            htmlcontent += "<td style='border:1px solid #000'> TOTAL_MARK </td>";
            htmlcontent += "<td style='border:1px solid #000'> OBTAINED_MARK</td >";
            htmlcontent += "<td style='border:1px solid #000'> PERCENTAGE_MARK </td>";
            htmlcontent += "<td style='border:1px solid #000'> Grade </td>";
     
            htmlcontent += "</tr>";
            htmlcontent += "</thead >";
            htmlcontent += "<tbody>";
            if (detail != null && detail.Count > 0)
            {
                detail.ForEach(item =>
                {
                    c++;
                    htmlcontent += "<tr>";
                    htmlcontent += "<td style='border:1px solid #000'>" + c + "</td>";
                    htmlcontent += "<td style='border:1px solid #000'>" + item.STUD_NAME + "</td>";
                    htmlcontent += "<td style='border:1px solid #000'>" + item.TOTAL_MARK + "</td >";
                    htmlcontent += "<td style='border:1px solid #000'>" + item.OBTAINED_MARK + "</td>";
                    htmlcontent += "<td style='border:1px solid #000'> " + item.PERCENTAGE_MARK + "</td >";
                    htmlcontent += "<td style='border:1px solid #000'> " + item.Grade + "</td >";
                   
  
                    htmlcontent += "</tr>";
                });
            }
            htmlcontent += "</tbody>";
            htmlcontent += "</table>";
            htmlcontent += "</div>";
            htmlcontent += "</div>";

            PdfGenerator.AddPdfPages(document, htmlcontent, (PdfSharpCore.PageSize)PageSize.A4);

            byte[]? response = null;
            var stream = new MemoryStream();
            document.Save(stream);
            response = stream.ToArray();
            Response.Clear();
            string Filename = "Salary Slab" + ".pdf";
            Response.Headers.Add("content-disposition", "attachment;" + Filename);
            Response.ContentType = "application/pdf";
            Response.Body.WriteAsync(response);
            Response.Body.Flush();
        }

        [HttpPost]
        public IActionResult Index(IFormFile file)//Excel File Uplaod 
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

      
    } 
}
