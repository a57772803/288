#pragma checksum "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Shared\Components\MessageManagementData\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "415e74f094f2399d5222ed886c493c44f7e54cca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MessageManagementData_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MessageManagementData/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/MessageManagementData/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_MessageManagementData_Default))]
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
#line 1 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\_ViewImports.cshtml"
using YunQiWholesale;

#line default
#line hidden
#line 2 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\_ViewImports.cshtml"
using YunQiWholesale.Models;

#line default
#line hidden
#line 1 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Shared\Components\MessageManagementData\Default.cshtml"
using DataModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"415e74f094f2399d5222ed886c493c44f7e54cca", @"/Views/Shared/Components/MessageManagementData/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28caaf0241098ecd91020ca85cf41e4615f1e192", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MessageManagementData_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessageManagementDataManageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/hs2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Generic placeholder image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("other-pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Shared\Components\MessageManagementData\Default.cshtml"
 if (@Model.listReplyMessageManagementDataListviewModel != null && @Model.listReplyMessageManagementDataListviewModel.Count > 0)
{
    

#line default
#line hidden
#line 6 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Shared\Components\MessageManagementData\Default.cshtml"
     foreach (var o in Model.listReplyMessageManagementDataListviewModel)
    {

#line default
#line hidden
            BeginContext(280, 73, true);
            WriteLiteral("        <div class=\"media mt-3\">\r\n            <a class=\"pr-3\" href=\"#\">\r\n");
            EndContext();
            BeginContext(386, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(402, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3a588002cb9d4dae827720fcb6667e83", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(480, 119, true);
            WriteLiteral("\r\n            </a>\r\n            <div class=\"media-body\">\r\n                <h5 class=\"mt-0\"></h5>\r\n                <div>");
            EndContext();
            BeginContext(600, 19, false);
#line 15 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Shared\Components\MessageManagementData\Default.cshtml"
                Write(o.ReplyMessageValue);

#line default
#line hidden
            EndContext();
            BeginContext(619, 44, true);
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 18 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Shared\Components\MessageManagementData\Default.cshtml"
    }

#line default
#line hidden
#line 18 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Shared\Components\MessageManagementData\Default.cshtml"
     
}
else
{

#line default
#line hidden
            BeginContext(682, 117, true);
            WriteLiteral("    <h3>沒有回覆內容</h3>\r\n    <button id=\"mobileSide\" type=\"button\" class=\"btn btn-maintype mb-2 mobiletype\">選單</button>\r\n");
            EndContext();
#line 24 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Shared\Components\MessageManagementData\Default.cshtml"
}

#line default
#line hidden
            BeginContext(802, 154, true);
            WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        // 10.系統設定jCurrentPage=9-7回傳CurrentPage，系統設定jTotallPages=9-7回傳TotalPages。\r\n        jCurrentPage =");
            EndContext();
            BeginContext(957, 17, false);
#line 29 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Shared\Components\MessageManagementData\Default.cshtml"
                 Write(Model.CurrentPage);

#line default
#line hidden
            EndContext();
            BeginContext(974, 25, true);
            WriteLiteral(";\r\n        jTotallPages =");
            EndContext();
            BeginContext(1000, 16, false);
#line 30 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Shared\Components\MessageManagementData\Default.cshtml"
                 Write(Model.TotalPages);

#line default
#line hidden
            EndContext();
            BeginContext(1016, 23, true);
            WriteLiteral(";\r\n    });\r\n</script>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessageManagementDataManageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
