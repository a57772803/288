#pragma checksum "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a01dc54d683be3db9030cca99aca9987a6c89ce8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MallImageList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MallImageList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MallImageList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MallImageList_Default))]
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
#line 1 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
using DataModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a01dc54d683be3db9030cca99aca9987a6c89ce8", @"/Views/Shared/Components/MallImageList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b4f9f7d0ad6169b0d02079f8a353bf4ccfe20a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MallImageList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MallImageManageViewModel>
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
#line 3 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
  
    List<int> tR = ViewBag.TR;
    int id = 0;

#line default
#line hidden
            BeginContext(230, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
 if (Model.listMallImageListViewModel != null && Model.listMallImageListViewModel.Count > 0)
{
    // 9-9.系統在View【Views/Shared/Components/MallImageList/Default.cshtml】中顯示[目前商城行銷圖示清單] (含修改與刪除)。

#line default
#line hidden
            BeginContext(428, 418, true);
            WriteLiteral(@"    <div class=""container container-fluid"">
        <table class=""table table-bordered"">
            <thead>
                <tr style=""color:gainsboro;background-color:#000000"">
                    <th>圖示代碼</th>
                    <th>圖示檔名</th>
                    <th>圖示</th>
                    <th>圖示說明</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 23 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
                 foreach (MallImageViewModel MLVM in Model.listMallImageListViewModel)
                {
                    id += 1;

#line default
#line hidden
            BeginContext(983, 42, true);
            WriteLiteral("                    <tr data-MallImageid=\"");
            EndContext();
            BeginContext(1026, 16, false);
#line 26 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
                                     Write(MLVM.MallImageId);

#line default
#line hidden
            EndContext();
            BeginContext(1042, 32, true);
            WriteLiteral("\">\r\n                        <td>");
            EndContext();
            BeginContext(1075, 16, false);
#line 27 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
                       Write(MLVM.MallImageId);

#line default
#line hidden
            EndContext();
            BeginContext(1091, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1127, 13, false);
#line 28 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
                       Write(MLVM.FileName);

#line default
#line hidden
            EndContext();
            BeginContext(1140, 56, true);
            WriteLiteral("</td>\r\n                        <td class=\"item-pic\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1196, "\"", 1285, 1);
#line 29 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
WriteAttributeValue("", 1202, Url.Action("GetOneMallImage", "MallImage", new { MallImageId = MLVM.MallImageId }), 1202, 83, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1286, "\"", 1306, 1);
#line 29 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
WriteAttributeValue("", 1292, MLVM.FileName, 1292, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1307, 103, true);
            WriteLiteral(" class=\"img-responsive\" style=\"max-width:200px;max-height:200px;\" /></td>\r\n                        <td>");
            EndContext();
            BeginContext(1411, 59, false);
#line 30 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
                       Write(Html.Raw(MLVM.MallImageDescription.Replace("\n", "<br />")));

#line default
#line hidden
            EndContext();
            BeginContext(1470, 420, true);
            WriteLiteral(@"</td>
                        <td>
                            <a class=""btn btn-default btn-edit"" role=""button""><span class=""glyphicon glyphicon-pencil"" aria-hidden=""true"" title=""修改""></span></a>
                            <a class=""btn btn-default btn-delete"" role=""button""><span class=""glyphicon glyphicon-trash"" aria-hidden=""true"" title=""刪除""></span></a>
                        </td>
                    </tr>
");
            EndContext();
#line 36 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(1909, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
#line 40 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
    // 9-10.系統在View【Views/Shared/Components/MallImageList/Default.cshtml】中顯示換頁超連結。

#line default
#line hidden
            BeginContext(2045, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(2064, 293, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53ce6853364249ab903d90ba07db8372", async() => {
            }
            );
            __YunQiERP_TagHelpers_PagerTagHelper = CreateTagHelper<global::YunQiERP.TagHelpers.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__YunQiERP_TagHelpers_PagerTagHelper);
#line 42 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.CurrentPage = Model.CurrentPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __YunQiERP_TagHelpers_PagerTagHelper.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 42 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.PageCount = Model.PageCount;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __YunQiERP_TagHelpers_PagerTagHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 42 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.Parameters = null;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("parameters", __YunQiERP_TagHelpers_PagerTagHelper.Parameters, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 42 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.StartPage = Model.StartPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("start-page", __YunQiERP_TagHelpers_PagerTagHelper.StartPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 42 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.TotalPages = Model.TotalPages;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("total-pages", __YunQiERP_TagHelpers_PagerTagHelper.TotalPages, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
                                                                                                                                                        WriteLiteral(Url.Action("GetMallImageList", "MallImage"));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __YunQiERP_TagHelpers_PagerTagHelper.Url = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("url", __YunQiERP_TagHelpers_PagerTagHelper.Url, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __YunQiERP_TagHelpers_PagerTagHelper.PageLinkSize = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
                                                                                                                                                                                                                                              WriteLiteral(Model.AClass);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __YunQiERP_TagHelpers_PagerTagHelper.AClass = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("a-class", __YunQiERP_TagHelpers_PagerTagHelper.AClass, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 42 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
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
            BeginContext(2357, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 44 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(2383, 23, true);
            WriteLiteral("    <h3>沒有商城行銷圖示</h3>\r\n");
            EndContext();
#line 48 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiERP\Views\Shared\Components\MallImageList\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MallImageManageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
