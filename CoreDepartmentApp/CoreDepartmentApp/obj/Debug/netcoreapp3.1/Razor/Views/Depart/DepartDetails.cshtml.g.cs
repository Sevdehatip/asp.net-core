#pragma checksum "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\Depart\DepartDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "126066274ff2d14d714937552b292358e778d0c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Depart_DepartDetails), @"mvc.1.0.view", @"/Views/Depart/DepartDetails.cshtml")]
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
#line 1 "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\_ViewImports.cshtml"
using CoreDepartmentApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\Depart\DepartDetails.cshtml"
using CoreDepartmentApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"126066274ff2d14d714937552b292358e778d0c6", @"/Views/Depart/DepartDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6304d43b65a82d9e28db646c75a74896aae1035c", @"/Views/_ViewImports.cshtml")]
    public class Views_Depart_DepartDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\Depart\DepartDetails.cshtml"
  
    ViewData["Title"] = "DepartDetails";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>DepartDetails</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Ad</th>\r\n        <th>Soyad</th>\r\n        <th>Şehir</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\Depart\DepartDetails.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\Depart\DepartDetails.cshtml"
           Write(x.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\Depart\DepartDetails.cshtml"
           Write(x.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\Depart\DepartDetails.cshtml"
           Write(x.lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\Depart\DepartDetails.cshtml"
           Write(x.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\Depart\DepartDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<a href=\"/employee/NewEmployee\" class=\"btn btn-primary\">Yeni Personel Ekle</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
