#pragma checksum "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c5aeb9435c3f10776777b4feba0957744a49134"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Freight_Index), @"mvc.1.0.view", @"/Views/Freight/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Freight/Index.cshtml", typeof(AspNetCore.Views_Freight_Index))]
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
#line 1 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
using DataModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c5aeb9435c3f10776777b4feba0957744a49134", @"/Views/Freight/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b4f9f7d0ad6169b0d02079f8a353bf4ccfe20a", @"/Views/_ViewImports.cshtml")]
    public class Views_Freight_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FreightViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("qFrom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/lib/jquery.form.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Freight.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/lib/jquery.form.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
  
    ViewData["Title"] = "運費設定";

#line default
#line hidden
#line 6 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
 if (ViewBag.HavePrivilege == true)
{
    // 6.系統在View【Freight/Index】判斷ViewBag.HavePrivilege=true。

#line default
#line hidden
            BeginContext(191, 66, true);
            WriteLiteral("    <div class=\"page-header\">\r\n        <h2>運費設定</h2>\r\n    </div>\r\n");
            EndContext();
#line 12 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
    // 6.系統在View【Freight/Index】判斷ViewBag.HavePrivilege=true。

#line default
#line hidden
            BeginContext(319, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(323, 1289, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7e6243ed21a4ea0a8a4dcb1d6f67cd5", async() => {
                BeginContext(353, 41, true);
                WriteLiteral("\r\n        <div class=\"form-horizontal\">\r\n");
                EndContext();
#line 15 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
             foreach (FreightViewModel item in Model)
            {

#line default
#line hidden
                BeginContext(464, 101, true);
                WriteLiteral("            <div class=\"form-group row\">\r\n                <label class=\"col-xs-2 control-label left\">");
                EndContext();
                BeginContext(566, 13, false);
#line 18 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
                                                      Write(item.Operator);

#line default
#line hidden
                EndContext();
                BeginContext(579, 10, true);
                WriteLiteral("</label>\r\n");
                EndContext();
#line 19 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
                 if (item.Operator == "離島地區運費")
                {

#line default
#line hidden
                BeginContext(657, 48, true);
                WriteLiteral("                    <div class=\"col-xs-2\"><input");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 705, "\"", 725, 1);
#line 21 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
WriteAttributeValue("", 710, item.FreightId, 710, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(726, 12, true);
                WriteLiteral(" type=\"text\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 738, "\"", 760, 1);
#line 21 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
WriteAttributeValue("", 745, item.FreightId, 745, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(761, 32, true);
                WriteLiteral(" class=\"form-control BonusLimit\"");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 793, "\'", 819, 1);
#line 21 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
WriteAttributeValue("", 801, item.FreightLimit, 801, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(820, 20, true);
                WriteLiteral(" readonly /></div>\r\n");
                EndContext();
#line 22 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(900, 48, true);
                WriteLiteral("                    <div class=\"col-xs-2\"><input");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 948, "\"", 968, 1);
#line 25 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
WriteAttributeValue("", 953, item.FreightId, 953, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(969, 12, true);
                WriteLiteral(" type=\"text\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 981, "\"", 1003, 1);
#line 25 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
WriteAttributeValue("", 988, item.FreightId, 988, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1004, 32, true);
                WriteLiteral(" class=\"form-control BonusLimit\"");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 1036, "\'", 1062, 1);
#line 25 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
WriteAttributeValue("", 1044, item.FreightLimit, 1044, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1063, 11, true);
                WriteLiteral(" /></div>\r\n");
                EndContext();
#line 26 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(1093, 44, true);
                WriteLiteral("                <div class=\"col-xs-2\"><input");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1137, "\"", 1157, 1);
#line 27 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
WriteAttributeValue("", 1142, item.FreightId, 1142, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1158, 12, true);
                WriteLiteral(" type=\"text\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1170, "\"", 1192, 1);
#line 27 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
WriteAttributeValue("", 1177, item.FreightId, 1177, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1193, 32, true);
                WriteLiteral(" class=\"form-control BonusValue\"");
                EndContext();
                BeginWriteAttribute("value", " value=\'", 1225, "\'", 1251, 1);
#line 27 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
WriteAttributeValue("", 1233, item.FreightValue, 1233, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1252, 31, true);
                WriteLiteral(" /></div>\r\n            </div>\r\n");
                EndContext();
#line 29 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(1298, 307, true);
                WriteLiteral(@"            <hr />
            <div class=""form-group row"">
                <div class=""col-xs-2""></div>
                <div class=""col-xs-2"">
                    <button type=""submit"" class=""btn btn-default"" id=""btnReset"">重設運費</button>
                </div>
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1612, 14, true);
            WriteLiteral("\r\n    <hr />\r\n");
            EndContext();
#line 40 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
    // 8.系統在查詢元件下方安置<Div FreightList>以便用來顯示運費設定查詢結果清單。
    

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(1703, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1713, 220, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "943db8bf9dc341b8ad0d6f92f592f3a2", async() => {
                    BeginContext(1746, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1760, 70, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a11a0ade57284380a9b0ca0fe2f321cd", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 43 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1830, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1844, 65, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eac72a5c361040a384820d012863c84e", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 44 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1909, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1933, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1943, 231, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53b003e0d54f46cfad9bb25d6c6b4be8", async() => {
                    BeginContext(1983, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(1997, 74, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d0a453a6ba7401487666634e7fda678", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 47 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2071, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(2085, 65, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d600137ddd994201b5c7a8181cc71d7e", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 48 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2150, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2174, 126, true);
                WriteLiteral("\r\n        <script>\r\n\r\n            $(function () {\r\n                Freightfunction({\r\n                    GetFreightListUrl: \'");
                EndContext();
                BeginContext(2301, 39, false);
#line 54 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
                                   Write(Url.Action("GetFreightList", "Freight"));

#line default
#line hidden
                EndContext();
                BeginContext(2340, 40, true);
                WriteLiteral("\',\r\n                    PutFreightUrl: \'");
                EndContext();
                BeginContext(2381, 35, false);
#line 55 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
                               Write(Url.Action("PutFreight", "Freight"));

#line default
#line hidden
                EndContext();
                BeginContext(2416, 64, true);
                WriteLiteral("\'\r\n                });\r\n            });\r\n        </script>\r\n    ");
                EndContext();
            }
            );
#line 59 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
     
}
else
{
    // 6a.系統在View【Freight/Index】判斷ViewBag.HavePrivilege=false。
    //  6a-1.系統顯示"無此權限"。

#line default
#line hidden
            BeginContext(2585, 66, true);
            WriteLiteral("    <div class=\"page-header\">\r\n        <h2>無此權限</h2>\r\n    </div>\r\n");
            EndContext();
#line 68 "C:\Users\a5772\Desktop\1.6\YunQi\YunQiERP\Views\Freight\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FreightViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591