#pragma checksum "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\Depart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00c7602bfc95b2d95b0ea945781b5bd2db2ef7db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Depart_Index), @"mvc.1.0.view", @"/Views/Depart/Index.cshtml")]
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
#line 1 "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\Depart\Index.cshtml"
using CoreDepartmentApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00c7602bfc95b2d95b0ea945781b5bd2db2ef7db", @"/Views/Depart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6304d43b65a82d9e28db646c75a74896aae1035c", @"/Views/_ViewImports.cshtml")]
    public class Views_Depart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<department>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\Depart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Departman</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n        <th>Detaylar</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\Depart\Index.cshtml"
     foreach (var dep in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\Depart\Index.cshtml"
           Write(dep.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\Depart\Index.cshtml"
           Write(dep.departmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 498, "\"", 537, 2);
            WriteAttributeValue("", 505, "/Depart/RemoveDepartment/", 505, 25, true);
#nullable restore
#line 23 "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\Depart\Index.cshtml"
WriteAttributeValue("", 530, dep.id, 530, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">SİL</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-success\">Güncelle</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-dark\">Detaylar</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\hatip\Documents\GitHub\asp.net-core\CoreDepartmentApp\CoreDepartmentApp\Views\Depart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<a href=\"/Depart/NewDepartman\" class=\"btn btn-primary\">Yeni Departman Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<department>> Html { get; private set; }
    }
}
#pragma warning restore 1591