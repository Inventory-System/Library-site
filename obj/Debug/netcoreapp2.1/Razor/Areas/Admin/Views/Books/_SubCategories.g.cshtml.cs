#pragma checksum "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\_SubCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a33d795bb3edc2c06bc86c8d99ca9caddd82c9c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Books__SubCategories), @"mvc.1.0.view", @"/Areas/Admin/Views/Books/_SubCategories.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Books/_SubCategories.cshtml", typeof(AspNetCore.Areas_Admin_Views_Books__SubCategories))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a33d795bb3edc2c06bc86c8d99ca9caddd82c9c0", @"/Areas/Admin/Views/Books/_SubCategories.cshtml")]
    public class Areas_Admin_Views_Books__SubCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookShop.Models.ViewModels.TreeViewCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 8, true);
            WriteLiteral("\r\n<ul>\r\n");
            EndContext();
#line 4 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\_SubCategories.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(114, 48, true);
            WriteLiteral("        <li>\r\n            <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 162, "\"", 178, 1);
#line 7 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\_SubCategories.cshtml"
WriteAttributeValue("", 170, item.id, 170, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(179, 22, true);
            WriteLiteral(" name=\"CategoryID\" /> ");
            EndContext();
            BeginContext(202, 10, false);
#line 7 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\_SubCategories.cshtml"
                                                                    Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(212, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(227, 52, false);
#line 8 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\_SubCategories.cshtml"
       Write(await Html.PartialAsync("_SubCategories", item.subs));

#line default
#line hidden
            EndContext();
            BeginContext(279, 17, true);
            WriteLiteral("\r\n        </li>\r\n");
            EndContext();
#line 10 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\_SubCategories.cshtml"
    }

#line default
#line hidden
            BeginContext(303, 7, true);
            WriteLiteral("\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookShop.Models.ViewModels.TreeViewCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591