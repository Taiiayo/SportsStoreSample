#pragma checksum "C:\Users\User\Desktop\mvc_samples\SportsStore\SportsStore\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ee43cd6222abdaa50a4ce1ae40a16df7beac43e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
#line 1 "C:\Users\User\Desktop\mvc_samples\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\mvc_samples\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\mvc_samples\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ee43cd6222abdaa50a4ce1ae40a16df7beac43e", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9348774597fd9833a52b188f2d9f8864fb404305", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 262, true);
            WriteLiteral(@"
<h2>Your Cart</h2>
<table class=""table table-bordered table-striped"">
    <thead><tr>
        <th>Quantity</th>
        <th>Item</th>
        <th class=""text-right"">Price</th>
        <th class=""text-right"">Subtotal</th>
    </tr></thead>
    <tbody>
");
            EndContext();
#line 12 "C:\Users\User\Desktop\mvc_samples\SportsStore\SportsStore\Views\Cart\Index.cshtml"
     foreach (var line in Model.Cart.Lines)
    {

#line default
#line hidden
            BeginContext(341, 50, true);
            WriteLiteral("        <tr>\r\n            <td class=\"text-center\">");
            EndContext();
            BeginContext(392, 13, false);
#line 15 "C:\Users\User\Desktop\mvc_samples\SportsStore\SportsStore\Views\Cart\Index.cshtml"
                               Write(line.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(405, 41, true);
            WriteLiteral("</td>\r\n            <td class=\"text-left\">");
            EndContext();
            BeginContext(447, 17, false);
#line 16 "C:\Users\User\Desktop\mvc_samples\SportsStore\SportsStore\Views\Cart\Index.cshtml"
                             Write(line.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(464, 42, true);
            WriteLiteral("</td>\r\n            <td class=\"text-right\">");
            EndContext();
            BeginContext(507, 32, false);
#line 17 "C:\Users\User\Desktop\mvc_samples\SportsStore\SportsStore\Views\Cart\Index.cshtml"
                              Write(line.Product.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(539, 42, true);
            WriteLiteral("</td>\r\n            <td class=\"text-right\">");
            EndContext();
            BeginContext(583, 50, false);
#line 18 "C:\Users\User\Desktop\mvc_samples\SportsStore\SportsStore\Views\Cart\Index.cshtml"
                               Write((line.Quantity * line.Product.Price).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(634, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(675, 397, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2993e0c034ac4596b0240a51118e6a9d", async() => {
                BeginContext(723, 59, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"ProductID\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                           value=\"", 782, "\"", 841, 1);
#line 22 "C:\Users\User\Desktop\mvc_samples\SportsStore\SportsStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 818, line.Product.ProductID, 818, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(842, 61, true);
                WriteLiteral("/>\r\n                    <input type=\"hidden\" name=\"returnUrl\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                           value=\"", 903, "\"", 955, 1);
#line 24 "C:\Users\User\Desktop\mvc_samples\SportsStore\SportsStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 939, Model.ReturnUrl, 939, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(956, 109, true);
                WriteLiteral("/>\r\n                    <button type=\"submit\" class=\"btn btn-sm btn-danger\">Remove</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1072, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 29 "C:\Users\User\Desktop\mvc_samples\SportsStore\SportsStore\Views\Cart\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1115, 124, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n    <tr>\r\n        <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n        <td class=\"text-right\">");
            EndContext();
            BeginContext(1240, 44, false);
#line 34 "C:\Users\User\Desktop\mvc_samples\SportsStore\SportsStore\Views\Cart\Index.cshtml"
                          Write(Model.Cart.ComputeTotalValue().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 101, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n<div class=\"text-center\">\r\n    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1385, "\"", 1408, 1);
#line 40 "C:\Users\User\Desktop\mvc_samples\SportsStore\SportsStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1392, Model.ReturnUrl, 1392, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1409, 28, true);
            WriteLiteral(">Continue shopping</a>\r\n    ");
            EndContext();
            BeginContext(1437, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5453592835b2490393fe0c319ad8a85c", async() => {
                BeginContext(1509, 8, true);
                WriteLiteral("Checkout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1521, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591