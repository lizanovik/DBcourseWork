#pragma checksum "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fa480bc4a58755df361b4155bf0286dc0d6d74d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_ViewCart), @"mvc.1.0.view", @"/Views/ShoppingCart/ViewCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShoppingCart/ViewCart.cshtml", typeof(AspNetCore.Views_ShoppingCart_ViewCart))]
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
#line 1 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\_ViewImports.cshtml"
using EBooks;

#line default
#line hidden
#line 2 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\_ViewImports.cshtml"
using EBooks.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fa480bc4a58755df361b4155bf0286dc0d6d74d", @"/Views/ShoppingCart/ViewCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a649a3cfa04fb545e02453fb747c36d8a6274d9e", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_ViewCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BLL_core.DTO.ProductModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MakeOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-lg text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(48, 268, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fa480bc4a58755df361b4155bf0286dc0d6d74d5385", async() => {
                BeginContext(54, 255, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <style>\r\n        body {\r\n            padding-top: 50px;\r\n        }\r\n        div {\r\n            text-align: center;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(316, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(318, 1375, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fa480bc4a58755df361b4155bf0286dc0d6d74d6847", async() => {
                BeginContext(324, 48, true);
                WriteLiteral("\r\n<h1 class=\"text-center\">Shopping Cart</h1>\r\n\r\n");
                EndContext();
#line 18 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
 if (Model!=null )
{
    if (Model.Count != 0)
    {

#line default
#line hidden
                BeginContext(429, 202, true);
                WriteLiteral("        <table class=\"table \">\r\n            <tr>\r\n                <th>Title</th>\r\n                <th>Price per item</th>\r\n                <th>Amount</th>\r\n                <th></th>\r\n            </tr>\r\n");
                EndContext();
#line 29 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
             foreach (var product in Model)
            {

#line default
#line hidden
                BeginContext(691, 47, true);
                WriteLiteral("                <tr>\r\n                    <td> ");
                EndContext();
                BeginContext(739, 13, false);
#line 32 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
                    Write(product.Title);

#line default
#line hidden
                EndContext();
                BeginContext(752, 32, true);
                WriteLiteral(" </td>\r\n                    <td>");
                EndContext();
                BeginContext(785, 13, false);
#line 33 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
                   Write(product.Price);

#line default
#line hidden
                EndContext();
                BeginContext(798, 57, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(856, 16, false);
#line 35 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
                   Write(product.Quantity);

#line default
#line hidden
                EndContext();
                BeginContext(872, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(951, 213, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fa480bc4a58755df361b4155bf0286dc0d6d74d9376", async() => {
                    BeginContext(1042, 115, true);
                    WriteLiteral("\r\n                            <input type=\"submit\" value=\"Remove\" class=\" btn btn-info \">\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 38 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
                                                                                          WriteLiteral(product.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1164, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 43 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
            }

#line default
#line hidden
                BeginContext(1231, 87, true);
                WriteLiteral("            <tr >\r\n                <td colspan=\"4\"><p class=\"text-center\">Total cost - ");
                EndContext();
                BeginContext(1319, 13, false);
#line 45 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
                                                               Write(ViewBag.Total);

#line default
#line hidden
                EndContext();
                BeginContext(1332, 48, true);
                WriteLiteral("</p></td>\r\n            </tr>\r\n        </table>\r\n");
                EndContext();
                BeginContext(1393, 28, true);
                WriteLiteral("        <div >\r\n            ");
                EndContext();
                BeginContext(1421, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fa480bc4a58755df361b4155bf0286dc0d6d74d13480", async() => {
                    BeginContext(1497, 10, true);
                    WriteLiteral("Make Order");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1511, 18, true);
                WriteLiteral("\r\n        </div>\r\n");
                EndContext();
#line 52 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(1553, 57, true);
                WriteLiteral("        <h2 class=\"text-center\">Your cart is empty</h2>\r\n");
                EndContext();
#line 56 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
    }
}
else
{

#line default
#line hidden
                BeginContext(1629, 54, true);
                WriteLiteral("    <h2 class=\"text-center\" >Your cart is empty</h2>\r\n");
                EndContext();
#line 61 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
}

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1693, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BLL_core.DTO.ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591