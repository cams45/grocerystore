#pragma checksum "C:\Users\n01407405\Desktop\V2.5\PartyInvites\Views\Home\OrderRetrive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ac0b3eb05b72c9a72b4cd9dda9270b64b6d259c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OrderRetrive), @"mvc.1.0.view", @"/Views/Home/OrderRetrive.cshtml")]
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
#nullable restore
#line 1 "C:\Users\n01407405\Desktop\V2.5\PartyInvites\Views\_ViewImports.cshtml"
using PartyInvites;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\n01407405\Desktop\V2.5\PartyInvites\Views\_ViewImports.cshtml"
using PartyInvites.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ac0b3eb05b72c9a72b4cd9dda9270b64b6d259c", @"/Views/Home/OrderRetrive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e21af70e33a7c205d8bf678bceb4feaec54d3ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OrderRetrive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartyInvites.Models.PurchaseConfirm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\n01407405\Desktop\V2.5\PartyInvites\Views\Home\OrderRetrive.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";
    double total = 0;
    double extended;
    string item;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""col-25"">
    <div class=""container"">
        <h4>
            Receipt Number:
            <span class=""price"" style=""color:black"">
                <b>1</b>
            </span>
        </h4>
        <table id=""shoppingCart"">
            <thead>
                <tr>
                    <th>Quantity</th>
                    <th>ItemName</th>
                    <th>Unit Price</th>
                    <th>Amount</th>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 31 "C:\Users\n01407405\Desktop\V2.5\PartyInvites\Views\Home\OrderRetrive.cshtml"
                 foreach (PartyInvites.Models.CartItem r in CartItem.cartItems)
                {


                    extended = Math.Round((r.Price * r.Quantity), 2);
                    total += extended;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\n01407405\Desktop\V2.5\PartyInvites\Views\Home\OrderRetrive.cshtml"
                       Write(r.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\n01407405\Desktop\V2.5\PartyInvites\Views\Home\OrderRetrive.cshtml"
                       Write(r.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>$");
#nullable restore
#line 40 "C:\Users\n01407405\Desktop\V2.5\PartyInvites\Views\Home\OrderRetrive.cshtml"
                        Write(r.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>$");
#nullable restore
#line 41 "C:\Users\n01407405\Desktop\V2.5\PartyInvites\Views\Home\OrderRetrive.cshtml"
                        Write(extended);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n                    </tr>\r\n");
#nullable restore
#line 43 "C:\Users\n01407405\Desktop\V2.5\PartyInvites\Views\Home\OrderRetrive.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n       \r\n\r\n\r\n        <hr>\r\n        <p>Total <span class=\"price\" style=\"color:black\"><b>$");
#nullable restore
#line 51 "C:\Users\n01407405\Desktop\V2.5\PartyInvites\Views\Home\OrderRetrive.cshtml"
                                                        Write(Math.Round(total, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span></p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartyInvites.Models.PurchaseConfirm> Html { get; private set; }
    }
}
#pragma warning restore 1591
