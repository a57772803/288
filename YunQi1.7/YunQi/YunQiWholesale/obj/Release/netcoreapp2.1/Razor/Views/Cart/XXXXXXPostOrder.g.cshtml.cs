#pragma checksum "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Cart\XXXXXXPostOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6d381c54548b3052fd00b8bd5616c2bf97b07fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_XXXXXXPostOrder), @"mvc.1.0.view", @"/Views/Cart/XXXXXXPostOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/XXXXXXPostOrder.cshtml", typeof(AspNetCore.Views_Cart_XXXXXXPostOrder))]
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
#line 1 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Cart\XXXXXXPostOrder.cshtml"
using DataModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6d381c54548b3052fd00b8bd5616c2bf97b07fc", @"/Views/Cart/XXXXXXPostOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28caaf0241098ecd91020ca85cf41e4615f1e192", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_XXXXXXPostOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostOrderViewModel1>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Cart\XXXXXXPostOrder.cshtml"
  
    Layout = null;


    

#line default
#line hidden
            BeginContext(2408, 3, true);
            WriteLiteral("}\r\n");
            EndContext();
#line 54 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Cart\XXXXXXPostOrder.cshtml"
 if (Model.OrderDetail != null && Model.OrderDetail.Count > 0)
{
    // 18.系統顯示連絡資料，訂購明細(含運費/合計/訂單編號)。
    // 19.系統設定orderId=16回傳OrderId。
    // 20.系統顯示金流公司付款方式。
    if (Model.CartTobal <= 10000)
    {

        // 當訂單總額超過20000時不透過綠界，超過6000不顯示超商代碼。
        

#line default
#line hidden
#line 70 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Cart\XXXXXXPostOrder.cshtml"
                                                              

        //<script src="https://payment-stage.ecpay.com.tw/Scripts/SP/ECPayPayment_1.0.0.js"
        //正式

#line default
#line hidden
            BeginContext(3279, 118, true);
            WriteLiteral("        <script src=\"https://payment.ecpay.com.tw/Scripts/SP/ECPayPayment_1.0.0.js\"\r\n                data-MerchantID=\"");
            EndContext();
            BeginContext(3398, 25, false);
#line 75 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Cart\XXXXXXPostOrder.cshtml"
                            Write(Model.RtnModel.MerchantID);

#line default
#line hidden
            EndContext();
            BeginContext(3423, 33, true);
            WriteLiteral("\"\r\n                data-SPToken=\"");
            EndContext();
            BeginContext(3457, 22, false);
#line 76 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Cart\XXXXXXPostOrder.cshtml"
                         Write(Model.RtnModel.SPToken);

#line default
#line hidden
            EndContext();
            BeginContext(3479, 198, true);
            WriteLiteral("\"\r\n                data-PaymentType=\"ATM\"\r\n                data-PaymentName=\"ATM\"\r\n                data-CustomerBtn=\"1\">\r\n        </script>\r\n        <button onclick=\"checkOut(\'ATM\');\">ATM</button>\r\n");
            EndContext();
#line 82 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Cart\XXXXXXPostOrder.cshtml"
        if (Model.CartTobal <= 6000)
        {
            //<script src="https://payment-stage.ecpay.com.tw/Scripts/SP/ECPayPayment_1.0.0.js"
            //正式


#line default
#line hidden
            BeginContext(3843, 126, true);
            WriteLiteral("            <script src=\"https://payment.ecpay.com.tw/Scripts/SP/ECPayPayment_1.0.0.js\"\r\n                    data-MerchantID=\"");
            EndContext();
            BeginContext(3970, 25, false);
#line 88 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Cart\XXXXXXPostOrder.cshtml"
                                Write(Model.RtnModel.MerchantID);

#line default
#line hidden
            EndContext();
            BeginContext(3995, 37, true);
            WriteLiteral("\"\r\n                    data-SPToken=\"");
            EndContext();
            BeginContext(4033, 22, false);
#line 89 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Cart\XXXXXXPostOrder.cshtml"
                             Write(Model.RtnModel.SPToken);

#line default
#line hidden
            EndContext();
            BeginContext(4055, 218, true);
            WriteLiteral("\"\r\n                    data-PaymentType=\"CVS\"\r\n                    data-PaymentName=\"CVS\"\r\n                    data-CustomerBtn=\"1\">\r\n            </script>\r\n            <button onclick=\"checkOut(\'CVS\');\">CVS</button>\r\n");
            EndContext();
#line 95 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Cart\XXXXXXPostOrder.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(4308, 247, true);
            WriteLiteral("        <div>\r\n            金額超過1萬元，請直接匯款至本公司帳戶  : 郵局代號 : 700 帳號 : 00310220499344 ，<br />\r\n            匯款完成後請至[會員中心/我的訂單]提出己付款，或電洽服務人員(04)24260263，謝謝！\r\n        </div>\r\n        <div>\r\n            <button id=\"FinishCart\">完成</button>\r\n        </div>\r\n");
            EndContext();
#line 106 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Cart\XXXXXXPostOrder.cshtml"
    }
}
else
{
    // 17a.系統在View【Cart/PostOrder】判斷16回傳之OrderDetail == null。
    //  17a-1.系統顯示"系統錯誤，請連絡客服人員！”。

#line default
#line hidden
            BeginContext(4673, 73, true);
            WriteLiteral("    <div class=\"container\">\r\n        <h3>系統錯誤，請連絡客服人員！</h3>\r\n    </div>\r\n");
            EndContext();
#line 115 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Cart\XXXXXXPostOrder.cshtml"
    //  17a-2.結束。
}

#line default
#line hidden
            BeginContext(4768, 59, true);
            WriteLiteral("<script>\r\n    // 19.系統設定orderId=16回傳OrderId。\r\n    orderId =");
            EndContext();
            BeginContext(4828, 13, false);
#line 119 "C:\Users\a5772\Desktop\1.7\YunQi\YunQiWholesale\Views\Cart\XXXXXXPostOrder.cshtml"
        Write(Model.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(4841, 387, true);
            WriteLiteral(@";
    //// 點按結帳時
    //$(document).on(""click"", ""#btnPay"", () => {
    //    if ($(""#CardRadio"").prop(""checked"")) {
    //        checkOut('CREDIT');
    //    }
    //    else if ($(""#ATMRadio"").prop(""checked"")) {
    //        checkOut('ATM');
    //    }
    //    else if ($(""#CVSRadio"").prop(""checked"")) {
    //        checkOut('CVS');
    //    }
    //});
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostOrderViewModel1> Html { get; private set; }
    }
}
#pragma warning restore 1591
