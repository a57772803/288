#pragma checksum "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc740469481c0f590f788be37abbe55d358744c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_StockList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/StockList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/StockList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_StockList_Default))]
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
#line 1 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\_ViewImports.cshtml"
using YunQiERP;

#line default
#line hidden
#line 2 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\_ViewImports.cshtml"
using YunQiERP.Models;

#line default
#line hidden
#line 1 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
using DataModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc740469481c0f590f788be37abbe55d358744c8", @"/Views/Shared/Components/StockList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b4f9f7d0ad6169b0d02079f8a353bf4ccfe20a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_StockList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StockListManageViewModel>
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
#line 3 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
  
    List<int> tR = ViewBag.TR;
    int id = 0;

#line default
#line hidden
            BeginContext(222, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
 if (Model.listStockListViewModel != null && Model.listStockListViewModel.Count > 0)
{
    // 9-9.系統在View【Views/Shared/Components/ProductStockList/Default.cshtml】中顯示[目前商品分類清單] (含盤整，但應依ViewBag.TR之權限顯示)。

#line default
#line hidden
            BeginContext(429, 183, true);
            WriteLiteral("    <div class=\"container container-fluid\">\r\n        <table class=\"table table-bordered\">\r\n            <thead>\r\n                <tr style=\"color:gainsboro;background-color:#000000\">\r\n");
            EndContext();
            BeginContext(648, 374, true);
            WriteLiteral(@"                    <th>盤整代碼</th>
                    <th>盤整日期</th>
                    <th>商品代碼</th>
                    <th>商品名稱</th>
                    <th>尺寸</th>
                    <th>顏色</th>
                    <th>原庫存</th>
                    <th>新庫存</th>
                    <th>盤整量</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 28 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
                 foreach (StockListViewModel MLVM in Model.listStockListViewModel)
                {
                    id += 1;

#line default
#line hidden
            BeginContext(1155, 26, true);
            WriteLiteral("                    <tr>\r\n");
            EndContext();
            BeginContext(1223, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(1252, 32, false);
#line 33 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
                       Write(MLVM.ProductStockConsolidationId);

#line default
#line hidden
            EndContext();
            BeginContext(1284, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1320, 27, false);
#line 34 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
                       Write(MLVM.StockConsolidationTime);

#line default
#line hidden
            EndContext();
            BeginContext(1347, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1383, 14, false);
#line 35 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
                       Write(MLVM.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(1397, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1433, 12, false);
#line 36 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
                       Write(MLVM.Product);

#line default
#line hidden
            EndContext();
            BeginContext(1445, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1481, 16, false);
#line 37 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
                       Write(MLVM.ProductSize);

#line default
#line hidden
            EndContext();
            BeginContext(1497, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1533, 17, false);
#line 38 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
                       Write(MLVM.ProductColor);

#line default
#line hidden
            EndContext();
            BeginContext(1550, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1586, 10, false);
#line 39 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
                       Write(MLVM.Stock);

#line default
#line hidden
            EndContext();
            BeginContext(1596, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1632, 22, false);
#line 40 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
                       Write(MLVM.StockConsolidatio);

#line default
#line hidden
            EndContext();
            BeginContext(1654, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1690, 18, false);
#line 41 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
                       Write(MLVM.Consolidation);

#line default
#line hidden
            EndContext();
            BeginContext(1708, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 43 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(1761, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
#line 47 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
    // 9-10.系統在View【Views/Shared/Components/StockList/Default.cshtml】中顯示換頁超連結。

#line default
#line hidden
            BeginContext(1893, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(1912, 285, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a00f67015034ad5aec5cd6e931fd4d3", async() => {
            }
            );
            __YunQiERP_TagHelpers_PagerTagHelper = CreateTagHelper<global::YunQiERP.TagHelpers.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__YunQiERP_TagHelpers_PagerTagHelper);
#line 49 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.CurrentPage = Model.CurrentPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __YunQiERP_TagHelpers_PagerTagHelper.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 49 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.PageCount = Model.PageCount;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __YunQiERP_TagHelpers_PagerTagHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 49 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.Parameters = null;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("parameters", __YunQiERP_TagHelpers_PagerTagHelper.Parameters, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 49 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.StartPage = Model.StartPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("start-page", __YunQiERP_TagHelpers_PagerTagHelper.StartPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 49 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.TotalPages = Model.TotalPages;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("total-pages", __YunQiERP_TagHelpers_PagerTagHelper.TotalPages, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
                                                                                                                                                        WriteLiteral(Url.Action("GetStockList", "Stock"));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __YunQiERP_TagHelpers_PagerTagHelper.Url = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("url", __YunQiERP_TagHelpers_PagerTagHelper.Url, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __YunQiERP_TagHelpers_PagerTagHelper.PageLinkSize = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
                                                                                                                                                                                                                                      WriteLiteral(Model.AClass);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __YunQiERP_TagHelpers_PagerTagHelper.AClass = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("a-class", __YunQiERP_TagHelpers_PagerTagHelper.AClass, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 49 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
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
            BeginContext(2197, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 51 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
}
else
{
    // 9-8a.系統判斷!(9-7傳回之listStockListViewModel!=null and Count>0)。

#line default
#line hidden
            BeginContext(2291, 21, true);
            WriteLiteral("    <h3>沒有盤整記錄</h3>\r\n");
            EndContext();
#line 56 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\StockList\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StockListManageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
