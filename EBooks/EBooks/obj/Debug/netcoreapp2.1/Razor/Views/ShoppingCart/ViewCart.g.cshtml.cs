#pragma checksum "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58a072e9a9ce84dbc89b19a117f795093b8387c5"
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
#line 2 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58a072e9a9ce84dbc89b19a117f795093b8387c5", @"/Views/ShoppingCart/ViewCart.cshtml")]
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
            BeginContext(69, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(77, 270, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58a072e9a9ce84dbc89b19a117f795093b8387c55534", async() => {
                BeginContext(83, 257, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <style>
        body {
            padding-top: 50px;
        }

        div {
            text-align: center;
        }
    </style>
");
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
            BeginContext(347, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(349, 1939, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58a072e9a9ce84dbc89b19a117f795093b8387c56977", async() => {
                BeginContext(355, 114, true);
                WriteLiteral("\r\n\r\n    <div id=\"container\" style=\"width:1100px;margin:0 auto;\">\r\n        <h1 class=\"text-center\">Корзина</h1>\r\n\r\n");
                EndContext();
#line 22 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
         if (Model != null)
        {
            if (Model.Count != 0)
            {

#line default
#line hidden
                BeginContext(559, 252, true);
                WriteLiteral("                <table class=\"table \">\r\n                    <tr>\r\n                        <th>Товар</th>\r\n                        <th>Цена</th>\r\n                        <th>Количество</th>\r\n                        <th></th>\r\n                    </tr>\r\n");
                EndContext();
#line 33 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
                     foreach (var product in Model)
                    {

#line default
#line hidden
                BeginContext(887, 63, true);
                WriteLiteral("                        <tr>\r\n                            <td> ");
                EndContext();
                BeginContext(951, 13, false);
#line 36 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
                            Write(product.Title);

#line default
#line hidden
                EndContext();
                BeginContext(964, 40, true);
                WriteLiteral(" </td>\r\n                            <td>");
                EndContext();
                BeginContext(1005, 66, false);
#line 37 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
                           Write(String.Format(CultureInfo.CurrentCulture, "{0:C2}", product.Price));

#line default
#line hidden
                EndContext();
                BeginContext(1071, 73, true);
                WriteLiteral("</td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(1145, 16, false);
#line 39 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
                           Write(product.Quantity);

#line default
#line hidden
                EndContext();
                BeginContext(1161, 103, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
                EndContext();
                BeginContext(1264, 230, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58a072e9a9ce84dbc89b19a117f795093b8387c59827", async() => {
                    BeginContext(1355, 132, true);
                    WriteLiteral("\r\n                                    <input type=\"submit\" value=\"Удалить\" class=\" btn btn-info \">\r\n                                ");
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
#line 42 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
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
                BeginContext(1494, 68, true);
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 47 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
                    }

#line default
#line hidden
                BeginContext(1585, 127, true);
                WriteLiteral("                    <tr>\r\n                        <td colspan=\"4\">\r\n                            <p class=\"text-center\">Итого - ");
                EndContext();
                BeginContext(1713, 66, false);
#line 50 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
                                                      Write(String.Format(CultureInfo.CurrentCulture, "{0:C2}", ViewBag.Total));

#line default
#line hidden
                EndContext();
                BeginContext(1779, 90, true);
                WriteLiteral("</p>\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n");
                EndContext();
                BeginContext(1871, 43, true);
                WriteLiteral("                <div>\r\n                    ");
                EndContext();
                BeginContext(1914, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58a072e9a9ce84dbc89b19a117f795093b8387c514126", async() => {
                    BeginContext(1990, 13, true);
                    WriteLiteral("Сделать заказ");
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
                BeginContext(2007, 26, true);
                WriteLiteral("\r\n                </div>\r\n");
                EndContext();
#line 58 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(2081, 65, true);
                WriteLiteral("                <h2 class=\"text-center\">Ваша корзина пуста</h2>\r\n");
                EndContext();
#line 62 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
            }
        }
        else
        {

#line default
#line hidden
                BeginContext(2197, 61, true);
                WriteLiteral("            <h2 class=\"text-center\">Ваша корзина пуста</h2>\r\n");
                EndContext();
#line 67 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\ShoppingCart\ViewCart.cshtml"
        }

#line default
#line hidden
                BeginContext(2269, 12, true);
                WriteLiteral("    </div>\r\n");
                EndContext();
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
            BeginContext(2288, 11, true);
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
