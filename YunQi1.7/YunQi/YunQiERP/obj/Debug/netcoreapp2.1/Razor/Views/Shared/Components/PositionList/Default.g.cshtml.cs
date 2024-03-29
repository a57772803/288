#pragma checksum "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbbfe746569c4360e598b8796ec2541b1ebad6c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PositionList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PositionList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/PositionList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_PositionList_Default))]
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
#line 1 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
using DataModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbbfe746569c4360e598b8796ec2541b1ebad6c4", @"/Views/Shared/Components/PositionList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b4f9f7d0ad6169b0d02079f8a353bf4ccfe20a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PositionList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PositionListManageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-link-size", "pagination-md", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
  
    List<int> tR = ViewBag.TR;
    int Page = ViewBag.Page;
    int id = (Page - 1) * 10;

#line default
#line hidden
            BeginContext(276, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
 if (Model.listPositionListViewModel != null && Model.listPositionListViewModel.Count > 0)
{
    // 9-9.系統在View【Views/Shared/Components/PositionList/Default.cshtml】中顯示[目前職務職務清單] (含修改與刪除與新員工，但應依ViewBag.TR之權限顯示)。

#line default
#line hidden
            BeginContext(492, 183, true);
            WriteLiteral("    <div class=\"container container-fluid\">\r\n        <table class=\"table table-bordered\">\r\n            <thead>\r\n                <tr style=\"color:gainsboro;background-color:#000000\">\r\n");
            EndContext();
            BeginContext(711, 202, true);
            WriteLiteral("                    <th>職務代碼</th>\r\n                    <th>職務名稱</th>\r\n                    <th>職務描述</th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 24 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
                 foreach (PositionListViewModel MLVM in Model.listPositionListViewModel)
                {
                    id += 1;

#line default
#line hidden
            BeginContext(1052, 26, true);
            WriteLiteral("                    <tr>\r\n");
            EndContext();
            BeginContext(1120, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(1149, 15, false);
#line 29 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
                       Write(MLVM.PositionId);

#line default
#line hidden
            EndContext();
            BeginContext(1164, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1200, 13, false);
#line 30 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
                       Write(MLVM.Position);

#line default
#line hidden
            EndContext();
            BeginContext(1213, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 31 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
                         if (MLVM.PositionDescription == null)
                        {

#line default
#line hidden
            BeginContext(1311, 39, true);
            WriteLiteral("                            <td></td>\r\n");
            EndContext();
#line 34 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1434, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(1467, 58, false);
#line 37 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
                           Write(Html.Raw(MLVM.PositionDescription.Replace("\n", "<br />")));

#line default
#line hidden
            EndContext();
            BeginContext(1525, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 38 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(1559, 860, true);
            WriteLiteral(@"                        <td>
                            <a class=""btn btn-default btn-edit-position"" role=""button"" title=""修改""><span class=""glyphicon glyphicon-pencil"" aria-hidden=""true""></span></a>
                            <a class=""btn btn-default btn-delete-position"" role=""button"" title=""刪除""><span class=""glyphicon glyphicon-trash"" aria-hidden=""true""></span></a>
                            <a class=""btn btn-default btn-new-employee"" role=""button"" title=""新員工""><span class=""glyphicon glyphicon-plus"" aria-hidden=""true""></span><span class=""glyphicon glyphicon-user"" aria-hidden=""true""></span></a>
                            <a class=""btn btn-default btn-employee"" role=""button"" title=""員工""><span class=""glyphicon glyphicon-user"" aria-hidden=""true""></span></a>
                        </td>
                    </tr>
                    <tr></tr>
");
            EndContext();
#line 47 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(2438, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
#line 51 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
    // 9-10.系統在View【Views/Shared/Components/PositionList/Default.cshtml】中顯示換頁超連結。

#line default
#line hidden
            BeginContext(2573, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(2592, 291, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e174d27e9f64f06932771e6c0882e28", async() => {
            }
            );
            __YunQiERP_TagHelpers_PagerTagHelper = CreateTagHelper<global::YunQiERP.TagHelpers.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__YunQiERP_TagHelpers_PagerTagHelper);
#line 53 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.CurrentPage = Model.CurrentPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __YunQiERP_TagHelpers_PagerTagHelper.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 53 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.PageCount = Model.PageCount;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __YunQiERP_TagHelpers_PagerTagHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 53 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.Parameters = null;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("parameters", __YunQiERP_TagHelpers_PagerTagHelper.Parameters, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 53 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.StartPage = Model.StartPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("start-page", __YunQiERP_TagHelpers_PagerTagHelper.StartPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 53 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.TotalPages = Model.TotalPages;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("total-pages", __YunQiERP_TagHelpers_PagerTagHelper.TotalPages, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
                                                                                                                                                        WriteLiteral(Url.Action("GetPositionList", "Employee"));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __YunQiERP_TagHelpers_PagerTagHelper.Url = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("url", __YunQiERP_TagHelpers_PagerTagHelper.Url, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __YunQiERP_TagHelpers_PagerTagHelper.PageLinkSize = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
                                                                                                                                                                                                                                            WriteLiteral(Model.AClass);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __YunQiERP_TagHelpers_PagerTagHelper.AClass = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("a-class", __YunQiERP_TagHelpers_PagerTagHelper.AClass, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 53 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
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
            BeginContext(2883, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 55 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
}
else
{
    // 9-8a.系統判斷!(9-7傳回之listPositionListViewModel!=null and Count>0)。

#line default
#line hidden
            BeginContext(2980, 20, true);
            WriteLiteral("    <h3>沒有子職務</h3>\r\n");
            EndContext();
#line 60 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\PositionList\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PositionListManageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
