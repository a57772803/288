#pragma checksum "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14493b08b57936558543b2e22c7fd67a3a98408b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PurchaseDetailListNoButton_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PurchaseDetailListNoButton/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/PurchaseDetailListNoButton/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_PurchaseDetailListNoButton_Default))]
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
#line 1 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
using DataModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14493b08b57936558543b2e22c7fd67a3a98408b", @"/Views/Shared/Components/PurchaseDetailListNoButton/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b4f9f7d0ad6169b0d02079f8a353bf4ccfe20a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PurchaseDetailListNoButton_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PurchaseDetailListManageViewModel>
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
#line 3 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
  
    List<int> tR = ViewBag.TR;
    int Page = ViewBag.Page;
    int id = (Page - 1) * 10;

#line default
#line hidden
            BeginContext(293, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
 if (Model.listPurchaseDetailListViewModel != null && Model.listPurchaseDetailListViewModel.Count > 0)
{
    // 9-9.系統在View【Views/Shared/Components/PurchaseDetailList/Default.cshtml】中顯示[目前進貨清單] (含修改與刪除，但應依ViewBag.TR之權限顯示)。

#line default
#line hidden
            BeginContext(521, 669, true);
            WriteLiteral(@"    <div class=""container container-fluid"">
        <table class=""table table-bordered table-condensed"" id=""tableProduct"">
            <thead>
                <tr style=""color:gainsboro;background-color:#000000"">
                    <th>商品名稱</th>
                    <th>尺寸</th>
                    <th>顏色</th>
                    <th>進價</th>
                    <th>數量</th>
                    <th>商品費用</th>
                    <th>運費</th>
                    <th>雜費</th>
                    <th>進貨總額</th>
                    <th>進貨總額(NT$)</th>
                    <th>商品進貨均價(NT$))</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 30 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
                 foreach (PurchaseDetailListViewModel MLVM in Model.listPurchaseDetailListViewModel)
                {
                    id += 1;

#line default
#line hidden
            BeginContext(1341, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1396, 12, false);
#line 34 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
                       Write(MLVM.Product);

#line default
#line hidden
            EndContext();
            BeginContext(1408, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1444, 16, false);
#line 35 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
                       Write(MLVM.ProductSize);

#line default
#line hidden
            EndContext();
            BeginContext(1460, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1496, 17, false);
#line 36 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
                       Write(MLVM.ProductColor);

#line default
#line hidden
            EndContext();
            BeginContext(1513, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1549, 45, false);
#line 37 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
                       Write(String.Format("{0:0.00}", MLVM.PurchasePrice));

#line default
#line hidden
            EndContext();
            BeginContext(1594, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1630, 13, false);
#line 38 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
                       Write(MLVM.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1643, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1679, 42, false);
#line 39 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
                       Write(String.Format("{0:0.00}", MLVM.ProductFee));

#line default
#line hidden
            EndContext();
            BeginContext(1721, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1757, 39, false);
#line 40 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
                       Write(String.Format("{0:0.00}", MLVM.Freight));

#line default
#line hidden
            EndContext();
            BeginContext(1796, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1832, 45, false);
#line 41 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
                       Write(String.Format("{0:0.00}", MLVM.miscellaneous));

#line default
#line hidden
            EndContext();
            BeginContext(1877, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1913, 44, false);
#line 42 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
                       Write(String.Format("{0:0.00}", MLVM.TotalExpense));

#line default
#line hidden
            EndContext();
            BeginContext(1957, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1993, 46, false);
#line 43 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
                       Write(String.Format("{0:0.00}", MLVM.TotalExpenseNT));

#line default
#line hidden
            EndContext();
            BeginContext(2039, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2075, 52, false);
#line 44 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
                       Write(String.Format("{0:0.00}", MLVM.PurchasePriceTotalNT));

#line default
#line hidden
            EndContext();
            BeginContext(2127, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 46 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(2180, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
#line 50 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
    // 9-10.系統在View【Views/Shared/Components/PurchaseDetailList/Default.cshtml】中顯示換頁超連結。

#line default
#line hidden
            BeginContext(2321, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(2340, 305, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10738d241bdd4433809938dfb0ce85c0", async() => {
            }
            );
            __YunQiERP_TagHelpers_PagerTagHelper = CreateTagHelper<global::YunQiERP.TagHelpers.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__YunQiERP_TagHelpers_PagerTagHelper);
#line 52 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.CurrentPage = Model.CurrentPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __YunQiERP_TagHelpers_PagerTagHelper.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 52 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.PageCount = Model.PageCount;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __YunQiERP_TagHelpers_PagerTagHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 52 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.Parameters = null;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("parameters", __YunQiERP_TagHelpers_PagerTagHelper.Parameters, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 52 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.StartPage = Model.StartPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("start-page", __YunQiERP_TagHelpers_PagerTagHelper.StartPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 52 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
__YunQiERP_TagHelpers_PagerTagHelper.TotalPages = Model.TotalPages;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("total-pages", __YunQiERP_TagHelpers_PagerTagHelper.TotalPages, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
                                                                                                                                                        WriteLiteral(Url.Action("GetPurchaseDetailListNoButton", "Purchase"));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __YunQiERP_TagHelpers_PagerTagHelper.Url = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("url", __YunQiERP_TagHelpers_PagerTagHelper.Url, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __YunQiERP_TagHelpers_PagerTagHelper.PageLinkSize = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
                                                                                                                                                                                                                                                          WriteLiteral(Model.AClass);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __YunQiERP_TagHelpers_PagerTagHelper.AClass = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("a-class", __YunQiERP_TagHelpers_PagerTagHelper.AClass, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 52 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
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
            BeginContext(2645, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 54 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(2671, 21, true);
            WriteLiteral("    <h3>沒有進貨明細</h3>\r\n");
            EndContext();
#line 58 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Shared\Components\PurchaseDetailListNoButton\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PurchaseDetailListManageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
