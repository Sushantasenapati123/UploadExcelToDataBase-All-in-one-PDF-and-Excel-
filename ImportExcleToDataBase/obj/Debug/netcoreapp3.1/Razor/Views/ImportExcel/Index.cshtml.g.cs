#pragma checksum "C:\Users\sushanta.senapati\Desktop\All excelpdf\UploadExcelToDataBase\ImportExcleToDataBase\Views\ImportExcel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8cb6ec97f897fd3472cf1b06c4d1f820381c65c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ImportExcel_Index), @"mvc.1.0.view", @"/Views/ImportExcel/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\sushanta.senapati\Desktop\All excelpdf\UploadExcelToDataBase\ImportExcleToDataBase\Views\_ViewImports.cshtml"
using ImportExcleToDataBase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sushanta.senapati\Desktop\All excelpdf\UploadExcelToDataBase\ImportExcleToDataBase\Views\_ViewImports.cshtml"
using ImportExcleToDataBase.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8cb6ec97f897fd3472cf1b06c4d1f820381c65c", @"/Views/ImportExcel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfa8bb0ade634b43a17d9a68f04a7fe2657d73be", @"/Views/_ViewImports.cshtml")]
    public class Views_ImportExcel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ImportExcleToDataBase.Models.StudentEntity>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/GenerateExcelFile.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sushanta.senapati\Desktop\All excelpdf\UploadExcelToDataBase\ImportExcleToDataBase\Views\ImportExcel\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.2/css/all.min.css\">\r\n\r\n<h1 style=\"text-align:center\">Import to Excel</h1>\r\n<hr />\r\n<h5 style=\"text-align:center\"><a href=\"ImportExcel/Graph\">Graphhh</a> </h5>\r\n<hr />\r\n\r\n");
#nullable restore
#line 13 "C:\Users\sushanta.senapati\Desktop\All excelpdf\UploadExcelToDataBase\ImportExcleToDataBase\Views\ImportExcel\Index.cshtml"
 using (Html.BeginForm("Index", "ImportExcel", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-12"" style=""padding-top:20px"">
        <div class=""col-4"">
        </div>
        <div class=""col-4"">
            <input type=""file"" name=""file"" class=""form-control"" />

        </div>
        <div class=""col-4"" style=""padding-top:20px"">

            <input type=""submit"" value=""Upload"" class=""form-control btn-danger"" />
        </div>

    </div>
    <br />
");
#nullable restore
#line 29 "C:\Users\sushanta.senapati\Desktop\All excelpdf\UploadExcelToDataBase\ImportExcleToDataBase\Views\ImportExcel\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-lg-12"">
    <a href=""/ImportExcel/ImportoExcelFromDataBase"" title=""Export to Excel"" id=""printIcon"" data-toggle=""tooltip"" data-placement=""top"" class=""btn btn-outline-info float-right mt-2 mb-2""><i class=""fa-solid fa-file-excel""></i></a>

    <br />
    <table class=""table"" id=""bindTable"">
        <thead>
            <tr>
                <th>sl#</th>
                <th>Student Name</th>
                <th>Total Mark(600)</th>
                <th>Obtained Mark</th>
                <th>Percentage(%)</th>
                <th>Grade</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 46 "C:\Users\sushanta.senapati\Desktop\All excelpdf\UploadExcelToDataBase\ImportExcleToDataBase\Views\ImportExcel\Index.cshtml"
             if (Model != null)
            {

                foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\sushanta.senapati\Desktop\All excelpdf\UploadExcelToDataBase\ImportExcleToDataBase\Views\ImportExcel\Index.cshtml"
                       Write(item.STUD_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\sushanta.senapati\Desktop\All excelpdf\UploadExcelToDataBase\ImportExcleToDataBase\Views\ImportExcel\Index.cshtml"
                       Write(item.STUD_NAME);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 54 "C:\Users\sushanta.senapati\Desktop\All excelpdf\UploadExcelToDataBase\ImportExcleToDataBase\Views\ImportExcel\Index.cshtml"
                       Write(item.TOTAL_MARK);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 55 "C:\Users\sushanta.senapati\Desktop\All excelpdf\UploadExcelToDataBase\ImportExcleToDataBase\Views\ImportExcel\Index.cshtml"
                       Write(item.OBTAINED_MARK);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "C:\Users\sushanta.senapati\Desktop\All excelpdf\UploadExcelToDataBase\ImportExcleToDataBase\Views\ImportExcel\Index.cshtml"
                       Write(item.PERCENTAGE_MARK);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 57 "C:\Users\sushanta.senapati\Desktop\All excelpdf\UploadExcelToDataBase\ImportExcleToDataBase\Views\ImportExcel\Index.cshtml"
                       Write(item.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 59 "C:\Users\sushanta.senapati\Desktop\All excelpdf\UploadExcelToDataBase\ImportExcleToDataBase\Views\ImportExcel\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n<button id=\"btnExportPdf\" class=\"btn btn-primary float-right\">Convert to PDF</button>\r\n");
#nullable restore
#line 66 "C:\Users\sushanta.senapati\Desktop\All excelpdf\UploadExcelToDataBase\ImportExcleToDataBase\Views\ImportExcel\Index.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8cb6ec97f897fd3472cf1b06c4d1f820381c65c9256", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(window).on(\"load\", function () {\r\n            debugger\r\n            alert(\"");
#nullable restore
#line 72 "C:\Users\sushanta.senapati\Desktop\All excelpdf\UploadExcelToDataBase\ImportExcleToDataBase\Views\ImportExcel\Index.cshtml"
              Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n\r\n            window.location.href = \"ImportExcel/Index\";\r\n        });\r\n    </script>\r\n");
#nullable restore
#line 77 "C:\Users\sushanta.senapati\Desktop\All excelpdf\UploadExcelToDataBase\ImportExcleToDataBase\Views\ImportExcel\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script src=\"https://cdn.datatables.net/1.13.4/js/jquery.dataTables.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8cb6ec97f897fd3472cf1b06c4d1f820381c65c11140", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8cb6ec97f897fd3472cf1b06c4d1f820381c65c12180", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n\r\n\r\n\r\n</script>\r\n\r\n<script type=\"text/javascript\">\r\n    $(\"#btnExportPdf\").click(function () {\r\n        window.location.href = \"ImportExcel/GeneratePDF\";\r\n    });\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ImportExcleToDataBase.Models.StudentEntity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
