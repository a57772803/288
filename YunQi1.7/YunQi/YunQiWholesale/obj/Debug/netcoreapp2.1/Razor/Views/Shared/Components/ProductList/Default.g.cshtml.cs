#pragma checksum "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4308f8ecf184c4a5936f59cf35f57c0fff7e3737"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProductList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProductList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ProductList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ProductList_Default))]
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
#line 1 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
using DataModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4308f8ecf184c4a5936f59cf35f57c0fff7e3737", @"/Views/Shared/Components/ProductList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28caaf0241098ecd91020ca85cf41e4615f1e192", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProductList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListManageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
  
    string tmp = Model.ProductCategory;

#line default
#line hidden
            BeginContext(221, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
 if (Model.listProductListViewModel != null && Model.listProductListViewModel.Count > 0)
{
    

#line default
#line hidden
            BeginContext(413, 505, true);
            WriteLiteral(@"    <div class=""productsearch-box row align-items-center"">
        <div class=""formobile col-12 col-sm-12 col-md-12 mb-3"">
            <button id=""mobileSide"" type=""button"" class=""btn btn-maintype mobiletype"">分類</button>
        </div>
        <div class=""col col-12 col-sm-12 col-md-4 col-lg-4 col-xl-4 container"">
            <div class=""row"">
                <div class=""groupaddon col-12 col-sm-12 col-md-4 col-lg-4 col-xl-4 d-flex align-items-center input-group-addon"" id=""spanProductCategory"">");
            EndContext();
            BeginContext(919, 21, false);
#line 16 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                                                                                                                                                    Write(Model.ProductCategory);

#line default
#line hidden
            EndContext();
            BeginContext(940, 947, true);
            WriteLiteral(@"</div>
                <div class=""col-12 col-sm-12 col-md-8 col-lg-8 col-xl-8"">
                    <input id=""Product"" type=""text"" class=""form-control"" name=""Product"" placeholder=""商品名稱"">
                </div>
            </div>
        </div>
        <div class=""col col-5 col-sm-5 col-md-2 col-lg-3 col-xl-3"">
            <input id=""lowPrice"" type=""text"" placeholder=""最低價"" class=""form-control"" name=""lowPrice"" />
        </div>
        <div class=""flexcenter col col-2 col-sm-2 col-md-1 col-lg-1 col-xl-1 to"">~</div>
        <div class=""col col-5 col-sm-5 col-md-2 col-lg-3 col-xl-3"">
            <input id=""hightPrice"" type=""text"" placeholder=""最高價"" class=""form-control"" name=""hightPrice"" />
        </div>
        <div class=""col col-12 col-sm-12 col-md-2 col-lg-2 col-xl-2"">
            <button type=""button"" class=""btn btn-block btn-searchproduct btn-maintype"" id=""btnSerachProduct"">搜尋商品</button>
        </div>
    </div>
");
            EndContext();
            BeginContext(1970, 646, true);
            WriteLiteral(@"    <div class=""pagination-box row justify-content-between"">
        <div class=""col-12 col-sm-12 col-md-12 col-lg-5 col-xl-5"">
            <div class=""row mb-3"">
                <div class=""col-8 col-sm-8 col-md-9 col-lg-9 col-xl-9"">
                    <div class=""row"">
                        <div class=""col-3 col-sm-3 col-md-3 col-lg-3 col-xl-4"">
                            <button type=""button"" class=""btn btn-block btn-page btn-maintype"" id=""btnPrePage""><i class=""fas fa-angle-left""></i></button>
                        </div>
                        <div class=""pagination flexcenter col-6 col-sm-6 col-md-6 col-lg-6 col-xl-4"">");
            EndContext();
            BeginContext(2617, 17, false);
#line 42 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                                                                                                Write(Model.CurrentPage);

#line default
#line hidden
            EndContext();
            BeginContext(2634, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(2636, 16, false);
#line 42 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                                                                                                                   Write(Model.TotalPages);

#line default
#line hidden
            EndContext();
            BeginContext(2652, 896, true);
            WriteLiteral(@"</div>
                        <div class=""col-3 col-sm-3 col-md-3 col-lg-3 col-xl-4"">
                            <button type=""button"" class=""btn btn-block btn-page btn-maintype"" id=""btnNextPage""><i class=""fas fa-angle-right""></i></button>
                        </div>
                    </div>
                </div>
                <div class=""col-4 col-sm-4 col-md-3 col-lg-3 col-xl-3"">
                    <div class=""dropdown"">
                        <button class=""btn dropdown-toggle btn-pageselect btn-maintype"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">第1頁</button>
                        <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"" id=""PageList"" x-placement=""bottom-start"" style=""position: absolute; will-change: transform; top: 0px; left: 0px; transform: translate3d(0px, 38px, 0px);"">
");
            EndContext();
#line 52 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                             for (int i = 1; i <= Model.TotalPages; i++)
                            {

#line default
#line hidden
            BeginContext(3653, 77, true);
            WriteLiteral("                                <a class=\"dropdown-item\" href=\"#\" data-page=\"");
            EndContext();
            BeginContext(3732, 1, false);
#line 54 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                                                                         Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3734, 3, true);
            WriteLiteral("\">第");
            EndContext();
            BeginContext(3739, 1, false);
#line 54 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                                                                                Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3741, 7, true);
            WriteLiteral("頁</a>\r\n");
            EndContext();
#line 55 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                            }

#line default
#line hidden
            BeginContext(3779, 685, true);
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-12 col-sm-12 col-md-12 col-lg-5 col-xl-5"">
            <div class=""row"">
                <div class=""col-6 col-sm-6 col-md-6 col-lg-6 col-xl-6"">
                    <button type=""button"" class=""btn btn-block btn-maintype"" id=""btnOfferProduct"">優惠商品</button>
                </div>
                <div class=""col-6 col-sm-6 col-md-6 col-lg-6 col-xl-6"">
                    <button type=""button"" class=""btn btn-block btn-maintype"" id=""btnAllProduct"">所有商品</button>
                </div>
            </div>
        </div>
    </div>
");
            EndContext();
            BeginContext(4547, 72, true);
            WriteLiteral("    <div class=\"productlist-box container\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 76 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
             foreach (var item in Model.listProductListViewModel)
            {

#line default
#line hidden
            BeginContext(4792, 114, true);
            WriteLiteral("                <div class=\"productlist-item col-6 col-sm-6 col-md-6 col-lg-3 col-xl-3\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4906, "\"", 4986, 1);
#line 79 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
WriteAttributeValue("", 4912, Url.Action("GetProductImage", "Mall", new { ProeuctId = item.ProductId }), 4912, 74, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4987, "\"", 5006, 1);
#line 79 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
WriteAttributeValue("", 4993, item.Product, 4993, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5007, 37, true);
            WriteLiteral(" class=\"product-pic\" data-productid=\"");
            EndContext();
            BeginContext(5045, 14, false);
#line 79 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                                                                                                                                                             Write(item.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(5059, 6, true);
            WriteLiteral("\" />\r\n");
            EndContext();
            BeginContext(5393, 46, true);
            WriteLiteral("                    <div class=\"product-name\">");
            EndContext();
            BeginContext(5440, 12, false);
#line 81 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                                         Write(item.Product);

#line default
#line hidden
            EndContext();
            BeginContext(5452, 61, true);
            WriteLiteral("</div>\r\n                    <div class=\"product-pricing\">零售價：");
            EndContext();
            BeginContext(5515, 21, false);
#line 82 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                                                 Write($"{item.Price:#,###}");

#line default
#line hidden
            EndContext();
            BeginContext(5537, 9, true);
            WriteLiteral("元</div>\r\n");
            EndContext();
#line 83 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                     if (Model.MemberLevelId <= 0)
                    {

#line default
#line hidden
            BeginContext(5621, 211, true);
            WriteLiteral("                        <div class=\"product-special\">批發價：<a href=\"#\" class=\"joinus-link\">加入我們</a> </div>\r\n                        <div class=\"product-upset\">量批價： <a href=\"#\" class=\"joinus-link\">加入我們</a> </div>\r\n");
            EndContext();
#line 87 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(5855, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 88 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                     if (Model.MemberLevelId == 1 || Model.MemberLevelId == 2)
                    {

#line default
#line hidden
            BeginContext(5958, 229, true);
            WriteLiteral("                        <div class=\"product-special\">批發價：<a href=\"#\" class=\"JoinusWholesale-link\">批發會員</a> </div>\r\n                        <div class=\"product-upset\">量批價： <a href=\"#\" class=\"JoinusWholesale-link\">批發會員</a> </div>\r\n");
            EndContext();
#line 92 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(6210, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 93 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                     if (Model.MemberLevelId == 3)
                    {


#line default
#line hidden
            BeginContext(6287, 57, true);
            WriteLiteral("                        <div class=\"product-special\">批發價：");
            EndContext();
            BeginContext(6346, 30, false);
#line 96 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                                                     Write($"{item.SaleLimitPrice:#,###}");

#line default
#line hidden
            EndContext();
            BeginContext(6377, 64, true);
            WriteLiteral("元</div>\r\n                        <div class=\"product-upset\">量批價：");
            EndContext();
            BeginContext(6443, 26, false);
#line 97 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                                                   Write($"{item.OfferPrice:#,###}");

#line default
#line hidden
            EndContext();
            BeginContext(6470, 9, true);
            WriteLiteral("元</div>\r\n");
            EndContext();
#line 98 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(6502, 322, true);
            WriteLiteral(@"                    <div class=""function-box container product-function"">
                        <div class=""row"">
                            <div class=""col-6 col-sm-6 col-md-6 col-lg-6 col-xl-6"">
                                <button type=""button"" class=""btn btn-block btn-AddToCart btn-maintype"" data-productid=""");
            EndContext();
            BeginContext(6825, 14, false);
#line 102 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                                                                                                                  Write(item.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(6839, 298, true);
            WriteLiteral(@""" title=""加入購物車""><i class=""fas fa-cart-plus""></i></button>
                            </div>
                            <div class=""col-6 col-sm-6 col-md-6 col-lg-6 col-xl-6"">
                                <button type=""button"" class=""btn btn-block btn-favorite btn-maintype"" data-productid=""");
            EndContext();
            BeginContext(7138, 14, false);
#line 105 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                                                                                                                 Write(item.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(7152, 175, true);
            WriteLiteral("\" title=\"加入我的最愛\"><i class=\"fas fa-star\"></i></button>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 110 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(7342, 28, true);
            WriteLiteral("        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(7386, 81, true);
            WriteLiteral("    <div id=\"productDetail\" class=\"productdetail-box bg-light p-3\">\r\n    </div>\r\n");
            EndContext();
#line 116 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(7479, 115, true);
            WriteLiteral("    <h3>沒有商品</h3>\r\n    <button id=\"mobileSide\" type=\"button\" class=\"btn btn-maintype mb-2 mobiletype\">選單</button>\r\n");
            EndContext();
#line 121 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
}

#line default
#line hidden
            BeginContext(7597, 92, true);
            WriteLiteral("<script>\r\n    // 10.系統設定jCurrentPage=1，系統設定jTotallPages=9-7回傳TotalPages。\r\n    jCurrentPage =");
            EndContext();
            BeginContext(7690, 17, false);
#line 124 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
             Write(Model.CurrentPage);

#line default
#line hidden
            EndContext();
            BeginContext(7707, 21, true);
            WriteLiteral(";\r\n    jTotallPages =");
            EndContext();
            BeginContext(7729, 16, false);
#line 125 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
             Write(Model.TotalPages);

#line default
#line hidden
            EndContext();
            BeginContext(7745, 27, true);
            WriteLiteral(";\r\n    jProductCategoryId =");
            EndContext();
            BeginContext(7773, 23, false);
#line 126 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                   Write(Model.ProductCategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(7796, 26, true);
            WriteLiteral(";\r\n    $(\"#Product\").val(\'");
            EndContext();
            BeginContext(7823, 23, false);
#line 127 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                  Write(Html.Raw(Model.Product));

#line default
#line hidden
            EndContext();
            BeginContext(7846, 29, true);
            WriteLiteral("\');\r\n    $(\"#lowPrice\").val(\'");
            EndContext();
            BeginContext(7876, 14, false);
#line 128 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                   Write(Model.lowPrice);

#line default
#line hidden
            EndContext();
            BeginContext(7890, 31, true);
            WriteLiteral("\');\r\n    $(\"#hightPrice\").val(\'");
            EndContext();
            BeginContext(7922, 16, false);
#line 129 "C:\Users\a5772\Desktop\專案\public\允奇行銷\YunQi1.7\YunQi\YunQiWholesale\Views\Shared\Components\ProductList\Default.cshtml"
                     Write(Model.hightPrice);

#line default
#line hidden
            EndContext();
            BeginContext(7938, 5, true);
            WriteLiteral("\');\r\n");
            EndContext();
            BeginContext(7994, 11, true);
            WriteLiteral("</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListManageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
