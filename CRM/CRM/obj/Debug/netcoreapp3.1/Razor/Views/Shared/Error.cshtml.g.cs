#pragma checksum "C:\Users\MSI\Desktop\Аверин Текстовая часть сдано\CRM\CRM\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b410231c95aa01926c4ada6512ae1aea399df2b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\MSI\Desktop\Аверин Текстовая часть сдано\CRM\CRM\Views\_ViewImports.cshtml"
using CRM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MSI\Desktop\Аверин Текстовая часть сдано\CRM\CRM\Views\_ViewImports.cshtml"
using CRM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b410231c95aa01926c4ada6512ae1aea399df2b4", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b16a7ccb85590fca9010f5f3fac5f1b6b0aa4c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\MSI\Desktop\Аверин Текстовая часть сдано\CRM\CRM\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"text-danger\">Ошибка.</h1>\n<h2 class=\"text-danger\">При обработке вашего запроса произошла ошибка.</h2>\n\n");
#nullable restore
#line 9 "C:\Users\MSI\Desktop\Аверин Текстовая часть сдано\CRM\CRM\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\n        <strong>Идентификатор запроса:</strong> <code>");
#nullable restore
#line 12 "C:\Users\MSI\Desktop\Аверин Текстовая часть сдано\CRM\CRM\Views\Shared\Error.cshtml"
                                                 Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\n    </p>\n");
#nullable restore
#line 14 "C:\Users\MSI\Desktop\Аверин Текстовая часть сдано\CRM\CRM\Views\Shared\Error.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Режим разработки</h3>
<p>
    Замена на <strong>разработку</strong> среда отобразит более подробную информацию о произошедшей ошибке.
</p>
<p>
    <strong>Среда разработки не должна быть включена для развернутых приложений.</strong>
    Это может привести к отображению конфиденциальной информации конечным пользователям.
    Для локальной отладки включите <strong>Режим разработки</strong> окружающей среды, установив <strong>ASPNETCORE_ENVIRONMENT</strong> переменная окружения для <strong>разработки</strong>
    и перезапутите приложение.
</p>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
