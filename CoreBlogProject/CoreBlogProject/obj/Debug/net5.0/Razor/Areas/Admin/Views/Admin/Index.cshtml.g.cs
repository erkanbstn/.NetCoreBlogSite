#pragma checksum "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8406e87afd209f0603e177ee07fb40f5913c8623"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Admin_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Admin/Index.cshtml")]
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
#line 1 "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Admin\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8406e87afd209f0603e177ee07fb40f5913c8623", @"/Areas/Admin/Views/Admin/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Admin>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Yöneticiler</h1>
<br />
<table class=""table table-hover"">
    <tr>
        <th>
            Kullanıcı Adı
        </th>
        <th>
            Rol
        </th>
        <th>
            Sil
        </th>
        <th>
            Düzenle
        </th>
    </tr>
");
#nullable restore
#line 26 "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Admin\Index.cshtml"
     foreach (var admin in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Admin\Index.cshtml"
           Write(admin.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Admin\Index.cshtml"
           Write(admin.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 670, "\"", 716, 2);
            WriteAttributeValue("", 677, "/Admin/Admin/DeleteAdmin/", 677, 25, true);
#nullable restore
#line 36 "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Admin\Index.cshtml"
WriteAttributeValue("", 702, admin.AdminID, 702, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Silmek İstediğinize Emin misiniz?\')\" class=\"btn btn-outline-danger\">Delete</a>\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 878, "\"", 922, 2);
            WriteAttributeValue("", 885, "/Admin/Admin/EditAdmin/", 885, 23, true);
#nullable restore
#line 39 "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Admin\Index.cshtml"
WriteAttributeValue("", 908, admin.AdminID, 908, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Edit</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Admin/AddAdmin/\" class=\"btn btn-primary\">Add New Admin</a>\r\n<br />\r\n<br />\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Admin>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591