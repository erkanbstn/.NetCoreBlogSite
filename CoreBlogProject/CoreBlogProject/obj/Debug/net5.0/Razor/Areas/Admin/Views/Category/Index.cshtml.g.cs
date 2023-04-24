#pragma checksum "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "645680420ea5005e772b676c0842edc47124910f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"645680420ea5005e772b676c0842edc47124910f", @"/Areas/Admin/Views/Category/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<EntityLayer.Concrete.Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kategoriler</h1>\r\n<br />\r\n<table class=\"table table-hover\">\r\n    <tr>\r\n        <th>\r\n            Kategori Adı\r\n        </th>\r\n        <th>\r\n            Sil\r\n        </th>\r\n        <th>\r\n            Düzenle\r\n        </th>\r\n    </tr>\r\n");
#nullable restore
#line 23 "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Category\Index.cshtml"
     foreach (var kategori in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Category\Index.cshtml"
           Write(kategori.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 617, "\"", 675, 2);
            WriteAttributeValue("", 624, "/Admin/Category/DeleteCategory/", 624, 31, true);
#nullable restore
#line 30 "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 655, kategori.CategoryID, 655, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Silmek İstediğinize Emin misiniz?\')\" class=\"btn btn-outline-danger\">Delete</a>\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 837, "\"", 893, 2);
            WriteAttributeValue("", 844, "/Admin/Category/EditCategory/", 844, 29, true);
#nullable restore
#line 33 "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 873, kategori.CategoryID, 873, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Edit</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Category/AddCategory/\" class=\"btn btn-primary\">Add New Category</a>\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 41 "E:\VisualProjects\Finish\NETCore\NetCoreMVC\MVC\CoreBlogProject\CoreBlogProject\Areas\Admin\Views\Category\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<EntityLayer.Concrete.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
