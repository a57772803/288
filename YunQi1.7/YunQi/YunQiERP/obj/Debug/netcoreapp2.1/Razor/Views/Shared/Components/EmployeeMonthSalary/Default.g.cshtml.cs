#pragma checksum "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c9a886af6b2e1cc598e7b28cf8b7167ef4400c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_EmployeeMonthSalary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/EmployeeMonthSalary/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/EmployeeMonthSalary/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_EmployeeMonthSalary_Default))]
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
#line 1 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\_ViewImports.cshtml"
using YunQiERP;

#line default
#line hidden
#line 2 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\_ViewImports.cshtml"
using YunQiERP.Models;

#line default
#line hidden
#line 1 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
using DataModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c9a886af6b2e1cc598e7b28cf8b7167ef4400c4", @"/Views/Shared/Components/EmployeeMonthSalary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b4f9f7d0ad6169b0d02079f8a353bf4ccfe20a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_EmployeeMonthSalary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeMonthSalaryManageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-link-size", "pagination-md", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::YunQiERP.TagHelpers.PagerTagHelper __YunQiERP_TagHelpers_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
  
    List<int> tR = ViewBag.TR;
    int Page = ViewBag.Page;
    int id = (Page - 1) * 10;

#line default
#line hidden
            BeginContext(276, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(368, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
 if (Model.listEmployeeMonthSalaryViewModel != null && Model.listEmployeeMonthSalaryViewModel.Count > 0)
{
    // if9.系統在View【Views/Shared/Components/OrderList/Default.cshtml】中顯示[銷貨單清單]。

#line default
#line hidden
            BeginContext(560, 482, true);
            WriteLiteral(@"    <div class=""container container-fluid"">
        <table class=""table table-bordered"">
            <thead>
                <tr style=""color:gainsboro;background-color:#000000"">
                    <th>月份</th>
                    <th>員工代碼</th>
                    <th>員工姓名</th>
                    <th>部門</th>
                    <th>性別</th>
                    <th>薪資</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 28 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                 foreach (var o in @Model.listEmployeeMonthSalaryViewModel)
                {

#line default
#line hidden
            BeginContext(1138, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1193, 33, false);
#line 31 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                       Write(o.Month.ToString().Substring(0,6));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1262, 16, false);
#line 32 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                       Write(o.EmployeeMobile);

#line default
#line hidden
            EndContext();
            BeginContext(1278, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1314, 14, false);
#line 33 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                       Write(o.EmployeeName);

#line default
#line hidden
            EndContext();
            BeginContext(1328, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1364, 12, false);
#line 34 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                       Write(o.Department);

#line default
#line hidden
            EndContext();
            BeginContext(1376, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1412, 5, false);
#line 35 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                       Write(o.sex);

#line default
#line hidden
            EndContext();
            BeginContext(1417, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1453, 8, false);
#line 36 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                       Write(o.Salary);

#line default
#line hidden
            EndContext();
            BeginContext(1461, 123, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a class=\"btn btn-default btn-SalaryAdd\" data-BaseSalary=\"");
            EndContext();
            BeginContext(1585, 12, false);
#line 38 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                                                                                 Write(o.BaseSalary);

#line default
#line hidden
            EndContext();
            BeginContext(1597, 15, true);
            WriteLiteral("\" data-Mobile=\"");
            EndContext();
            BeginContext(1613, 16, false);
#line 38 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                                                                                                             Write(o.EmployeeMobile);

#line default
#line hidden
            EndContext();
            BeginContext(1629, 14, true);
            WriteLiteral("\" data-Month=\"");
            EndContext();
            BeginContext(1644, 7, false);
#line 38 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                                                                                                                                            Write(o.Month);

#line default
#line hidden
            EndContext();
            BeginContext(1651, 16, true);
            WriteLiteral("\" data-Account=\"");
            EndContext();
            BeginContext(1668, 11, false);
#line 38 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                                                                                                                                                                    Write(o.IsAccount);

#line default
#line hidden
            EndContext();
            BeginContext(1679, 104, true);
            WriteLiteral("\" role=\"button\" title=\"新增 /修改\"><span class=\"glyphicon glyphicon-pencil\" aria-hidden=\"true\"></span></a>\r\n");
            EndContext();
#line 39 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                             if (o.IsAccount == 0)
                            {

#line default
#line hidden
            BeginContext(1866, 93, true);
            WriteLiteral("                                <a class=\"btn btn-default btn-SalaryDelete\" data-BaseSalary=\"");
            EndContext();
            BeginContext(1960, 12, false);
#line 41 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                                                                                        Write(o.BaseSalary);

#line default
#line hidden
            EndContext();
            BeginContext(1972, 14, true);
            WriteLiteral("\" data-Month=\"");
            EndContext();
            BeginContext(1987, 7, false);
#line 41 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                                                                                                                   Write(o.Month);

#line default
#line hidden
            EndContext();
            BeginContext(1994, 15, true);
            WriteLiteral("\" data-Mobile=\"");
            EndContext();
            BeginContext(2010, 16, false);
#line 41 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                                                                                                                                          Write(o.EmployeeMobile);

#line default
#line hidden
            EndContext();
            BeginContext(2026, 99, true);
            WriteLiteral("\" role=\"button\" title=\"刪除\"><span class=\"glyphicon glyphicon-trash\" aria-hidden=\"true\"></span></a>\r\n");
            EndContext();
#line 42 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                            }

#line default
#line hidden
            BeginContext(2156, 58, true);
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 45 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(2233, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
#line 49 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
    // 9-10.系統在View【Views/Shared/Components/OrderList/Default.cshtml】中顯示換頁超連結。

#line default
#line hidden
            BeginContext(2365, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(2384, 249, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0d2f028a8684f5290952be73eb3c0e4", async() => {
            }
            );
            __YunQiERP_TagHelpers_PagerTagHelper = CreateTagHelper<global::YunQiERP.TagHelpers.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__YunQiERP_TagHelpers_PagerTagHelper);
#line 51 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.CurrentPage = Model.CurrentPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __YunQiERP_TagHelpers_PagerTagHelper.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 51 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.PageCount = Model.PageCount;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __YunQiERP_TagHelpers_PagerTagHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 51 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.Parameters = null;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("parameters", __YunQiERP_TagHelpers_PagerTagHelper.Parameters, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 51 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.StartPage = Model.StartPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("start-page", __YunQiERP_TagHelpers_PagerTagHelper.StartPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 51 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.TotalPages = Model.TotalPages;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("total-pages", __YunQiERP_TagHelpers_PagerTagHelper.TotalPages, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __YunQiERP_TagHelpers_PagerTagHelper.Url = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __YunQiERP_TagHelpers_PagerTagHelper.PageLinkSize = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
                                                                                                                                                                                                  WriteLiteral(Model.AClass);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __YunQiERP_TagHelpers_PagerTagHelper.AClass = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("a-class", __YunQiERP_TagHelpers_PagerTagHelper.AClass, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 51 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.LinkType = Model.LinkType;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("link-type", __YunQiERP_TagHelpers_PagerTagHelper.LinkType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2633, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 53 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
}
else
{
    // 9-8a.系統判斷!(9-7傳回之listOrderListViewModel!=null and Count>0)。

#line default
#line hidden
            BeginContext(2727, 23, true);
            WriteLiteral("    <h3>沒有員工薪資管理</h3>\r\n");
            EndContext();
#line 58 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\EmployeeMonthSalary\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeMonthSalaryManageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591