#pragma checksum "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\Manage\ForgotPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a89411c0f45ac3aa92f4330fb18a3b213797375f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ForgotPasswordConfirmation), @"mvc.1.0.view", @"/Views/Manage/ForgotPasswordConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/ForgotPasswordConfirmation.cshtml", typeof(AspNetCore.Views_Manage_ForgotPasswordConfirmation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a89411c0f45ac3aa92f4330fb18a3b213797375f", @"/Views/Manage/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a649a3cfa04fb545e02453fb747c36d8a6274d9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\Manage\ForgotPasswordConfirmation.cshtml"
  
    ViewData["Title"] = "Сброс пароля";

#line default
#line hidden
            BeginContext(50, 88, true);
            WriteLiteral("\r\n<div id=\"container\" style=\"width:1100px;margin:0 auto;\">\r\n    <h2 class=\"text-center\">");
            EndContext();
            BeginContext(139, 17, false);
#line 7 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\Manage\ForgotPasswordConfirmation.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(156, 100, true);
            WriteLiteral("</h2>\r\n    <p>\r\n        Пожалуйста, проверьте почтовый ящик для сброса пароля.\r\n    </p>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
