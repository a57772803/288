#pragma checksum "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a35af5f394998274759a7e607cdb7c82aad32ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Main), @"mvc.1.0.view", @"/Views/Home/Main.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Main.cshtml", typeof(AspNetCore.Views_Home_Main))]
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
#line 1 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\_ViewImports.cshtml"
using YunQiWholesale;

#line default
#line hidden
#line 2 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\_ViewImports.cshtml"
using YunQiWholesale.Models;

#line default
#line hidden
#line 1 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
using DataModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a35af5f394998274759a7e607cdb7c82aad32ec", @"/Views/Home/Main.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28caaf0241098ecd91020ca85cf41e4615f1e192", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/首頁中間.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/下列橫幅-01 (2).jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
  
    Layout = null;
    ViewBag.Title = "首頁";
    int n = 0;

#line default
#line hidden
            BeginContext(215, 95, true);
            WriteLiteral("\r\n<div id=\"mainContent\" class=\"main-content\">\r\n    <div class=\"home-content container-fluid\">\r\n");
            EndContext();
            BeginContext(348, 240, true);
            WriteLiteral("\r\n        <div class=\"swiper-container\">\r\n            <div class=\" websell-box mb-3 \">\r\n                <div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\">\r\n                    <ol class=\"carousel-indicators\">\r\n");
            EndContext();
#line 17 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
                         for (int i = 0; i <= Model.HomeImage.Count - 1; i++)
                        {
                            n = i + 1;
                            if (i == 0)
                            {

#line default
#line hidden
            BeginContext(806, 92, true);
            WriteLiteral("                                <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
            EndContext();
            BeginContext(899, 1, false);
#line 22 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
                                                                                       Write(n);

#line default
#line hidden
            EndContext();
            BeginContext(900, 24, true);
            WriteLiteral("\" class=\"active\"></li>\r\n");
            EndContext();
#line 23 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1020, 92, true);
            WriteLiteral("                                <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
            EndContext();
            BeginContext(1113, 1, false);
#line 26 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
                                                                                       Write(n);

#line default
#line hidden
            EndContext();
            BeginContext(1114, 9, true);
            WriteLiteral("\"></li>\r\n");
            EndContext();
#line 27 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(1181, 77, true);
            WriteLiteral("                    </ol>\r\n                    <div class=\"carousel-inner\">\r\n");
            EndContext();
#line 31 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
                         for (int i = 0; i <= Model.HomeImage.Count - 1; i++)
                        {
                            if (i == 0)
                            {

#line default
#line hidden
            BeginContext(1436, 130, true);
            WriteLiteral("                                <div class=\"carousel-item active\">\r\n                                    <img class=\"d-block w-100\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1566, "\"", 1664, 1);
#line 36 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
WriteAttributeValue("", 1572, Url.Action("GetOneHomeImage", "Home", new { HomeImageId = Model.HomeImage[i].HomeImageId }), 1572, 92, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1665, 50, true);
            WriteLiteral(" alt=\"\">\r\n                                </div>\r\n");
            EndContext();
#line 38 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1811, 123, true);
            WriteLiteral("                                <div class=\"carousel-item\">\r\n                                    <img class=\"d-block w-100\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1934, "\"", 2032, 1);
#line 42 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
WriteAttributeValue("", 1940, Url.Action("GetOneHomeImage", "Home", new { HomeImageId = Model.HomeImage[i].HomeImageId }), 1940, 92, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2033, 50, true);
            WriteLiteral(" alt=\"\">\r\n                                </div>\r\n");
            EndContext();
#line 44 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(2141, 753, true);
            WriteLiteral(@"                    </div>
                    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
");
            EndContext();
#line 61 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
                 if (Model.YoutubeVideo.YouTubeVideo != "" && Model.YoutubeVideo.YouTubeVideo != null)
                {
                    

#line default
#line hidden
            BeginContext(3338, 137, true);
            WriteLiteral("                    <div class=\"embed-responsive embed-responsive-16by9 \">\r\n                        <iframe class=\"embed-responsive-item\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3475, "\"", 3530, 2);
#line 67 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
WriteAttributeValue("", 3481, Model.YoutubeVideo.YouTubeVideo, 3481, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 3513, "?rel=0&autoplay=1", 3513, 17, true);
            EndWriteAttribute();
            BeginContext(3531, 40, true);
            WriteLiteral("></iframe>\r\n                    </div>\r\n");
            EndContext();
#line 69 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
                }

#line default
#line hidden
            BeginContext(3590, 22, true);
            WriteLiteral("            </div>\r\n\r\n");
            EndContext();
            BeginContext(3635, 97, true);
            WriteLiteral("            <div class=\"col-md-6\">\r\n                <div class=\"thumbnail\">\r\n                    ");
            EndContext();
            BeginContext(3732, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a2f83b69c5bf453faabf88cbda1ea8e9", async() => {
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
            BeginContext(3805, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3879, 44, true);
            WriteLiteral("                </div>\r\n            </div>\r\n");
            EndContext();
            BeginContext(3966, 304, true);
            WriteLiteral(@"
            <div class=""newproduct-box mb-3 col-sm-12"">
                <!-- Slider main container -->
                <div class=""swiper-container"">
                    <!-- Additional required wrapper -->
                    <div class=""swiper-wrapper"">
                        <!-- Slides -->
");
            EndContext();
#line 87 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
                         foreach (var item in Model.NewProduct)
                        {

#line default
#line hidden
            BeginContext(4362, 92, true);
            WriteLiteral("                            <div class=\"swiper-slide\">\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4454, "\"", 4534, 1);
#line 90 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
WriteAttributeValue("", 4460, Url.Action("GetProductImage", "Home", new { ProeuctId = item.ProductId }), 4460, 74, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4535, 97, true);
            WriteLiteral(" alt=\"\" width=\"1492\" height=\"345\" class=\"img-responsive\" />\r\n                            </div>\r\n");
            EndContext();
#line 92 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Home\Main.cshtml"
                        }

#line default
#line hidden
            BeginContext(4659, 251, true);
            WriteLiteral("                    </div>\r\n                    <div class=\"swiper-pagination\"></div>\r\n                    <div class=\"swiper-button-prev\"></div>\r\n                    <div class=\"swiper-button-next\"></div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
            BeginContext(5074, 35, true);
            WriteLiteral("            <div>\r\n                ");
            EndContext();
            BeginContext(5109, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a40a6c4351d4272ba4f4d02585bc3d5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5189, 52, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591