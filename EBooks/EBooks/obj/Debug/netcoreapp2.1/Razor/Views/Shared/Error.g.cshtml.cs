#pragma checksum "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "843e998bedd335861f59c04168a84aa7ff3b843e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\Shared\Error.cshtml"
using DAL_core.EntityFramework;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"843e998bedd335861f59c04168a84aa7ff3b843e", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a649a3cfa04fb545e02453fb747c36d8a6274d9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DAL_core.EntityFramework.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Ошибка";

#line default
#line hidden
            BeginContext(123, 97, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">Ошибка</h1>\r\n<h2 class=\"text-danger\">Ошибка обработки запроса!</h2>\r\n\r\n");
            EndContext();
#line 10 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(250, 52, true);
            WriteLiteral("    <p>\r\n        <strong>ID запроса:</strong> <code>");
            EndContext();
            BeginContext(303, 15, false);
#line 13 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(318, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
#line 15 "D:\epamprojects\DBcourseWork\EBooks\EBooks\Views\Shared\Error.cshtml"
}

#line default
#line hidden
            BeginContext(340, 562, true);
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>Development environment should not be enabled in deployed applications</strong>, as it can result in sensitive information from exceptions being displayed to end users. For local debugging, development environment can be enabled by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>, and restarting the application.
</p>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DAL_core.EntityFramework.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
