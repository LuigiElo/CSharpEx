#pragma checksum "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04cee328b49489a54a617f0334abda15513f135e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EmployeeWeb.Pages.Pages_Privacy), @"mvc.1.0.razor-page", @"/Pages/Privacy.cshtml")]
namespace EmployeeWeb.Pages
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
#line 1 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\_ViewImports.cshtml"
using EmployeeWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04cee328b49489a54a617f0334abda15513f135e", @"/Pages/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5145d045bf2092c022860c8c1998aa50db9ad182", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Privacy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
  
    ViewData["Title"] = "Employees";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<t1>All Employees</t1>\r\n<table class=\"table\">\r\n    <tbody>\r\n    <div id=\"people\">\r\n");
#nullable restore
#line 12 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
         if (Model.Overtime != null & Model.Regular != null)
        {
            foreach (var employee in Model.Overtime)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <p>");
#nullable restore
#line 18 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
                      Write(Html.DisplayFor(modelItem => employee.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n                                    \r\n                    <td>\r\n                        <p>");
#nullable restore
#line 22 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
                      Write(Html.DisplayFor(modelItem => employee.HourlyWage));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n\r\n                    <td>\r\n                        <p>");
#nullable restore
#line 26 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
                      Write(Html.DisplayFor(modelItem => employee.HoursPerMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
            }
            foreach (var employee in Model.Regular)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <p>");
#nullable restore
#line 35 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
                      Write(Html.DisplayFor(modelItem => employee.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n                                    \r\n                    <td>\r\n                        <p>");
#nullable restore
#line 39 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
                      Write(Html.DisplayFor(modelItem => employee.HourlyWage));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n\r\n                    <td>\r\n                        <p>");
#nullable restore
#line 43 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
                      Write(Html.DisplayFor(modelItem => employee.HoursPerMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 47 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>Total Monthly Pay</td>\r\n            <td>\r\n");
            WriteLiteral("                    <p class=\"text-center\"> ");
#nullable restore
#line 54 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
                                       Write(Html.DisplayFor(modelItem => Model.total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n    </div>\r\n    </tbody>\r\n</table>\r\n\r\n<t1>Overtime Employees</t1>\r\n<table class=\"table\">\r\n    <tbody>\r\n    <div id=\"people\">\r\n");
#nullable restore
#line 67 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
         if (Model.Overtime != null)
        {
            foreach (var employee in Model.Overtime)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <p>");
#nullable restore
#line 73 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
                      Write(Html.DisplayFor(modelItem => employee.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n                                    \r\n                    <td>\r\n                        <p>");
#nullable restore
#line 77 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
                      Write(Html.DisplayFor(modelItem => employee.HourlyWage));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n\r\n                    <td>\r\n                        <p>");
#nullable restore
#line 81 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
                      Write(Html.DisplayFor(modelItem => employee.HoursPerMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 85 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>Total Monthly Pay</td>\r\n            <td>\r\n");
            WriteLiteral("                        <p class=\"text-center\"> ");
#nullable restore
#line 92 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
                                           Write(Html.DisplayFor(modelItem => Model.totalOvertime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n    </div>\r\n    \r\n    </tbody>\r\n</table>\r\n\r\n<t1>Regular Employees</t1>\r\n<table class=\"table\">\r\n    <tbody>\r\n    <div id=\"people\">\r\n");
#nullable restore
#line 106 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
         if (Model.Regular != null)
        {
            foreach (var employee in Model.Regular)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <p>");
#nullable restore
#line 112 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
                      Write(Html.DisplayFor(modelItem => employee.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n                                    \r\n                    <td>\r\n                        <p>");
#nullable restore
#line 116 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
                      Write(Html.DisplayFor(modelItem => employee.HourlyWage));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n\r\n                    <td>\r\n                        <p>");
#nullable restore
#line 120 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
                      Write(Html.DisplayFor(modelItem => employee.HoursPerMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 124 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n                    <td>Total Monthly Pay</td>\r\n                    <td>\r\n");
            WriteLiteral("                                <p class=\"text-center\"> ");
#nullable restore
#line 131 "C:\Users\luisf\RiderProjects\DNPExamPt2\EmployeeWeb\Pages\Privacy.cshtml"
                                                   Write(Html.DisplayFor(modelItem => Model.totalRegular));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n    </div>\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrivacyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel>)PageContext?.ViewData;
        public PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
