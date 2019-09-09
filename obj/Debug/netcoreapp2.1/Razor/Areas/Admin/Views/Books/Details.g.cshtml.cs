#pragma checksum "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28b20e7ecf243179eb133d8aacf8dacdca502dd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Books_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Books/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Books/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Books_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28b20e7ecf243179eb133d8aacf8dacdca502dd4", @"/Areas/Admin/Views/Books/Details.cshtml")]
    public class Areas_Admin_Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookShop.Models.ViewModels.ReadAllBook>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Book.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(186, 157, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header bg-light\">\r\n                اطلاعات کتاب ");
            EndContext();
            BeginContext(344, 11, false);
#line 13 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                        Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(355, 162, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-3\">\r\n                        ");
            EndContext();
            BeginContext(517, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a571d9aceec4da8a829d211c24e4010", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(561, 219, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-md-9\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n                                <p>عنوان کتاب : ");
            EndContext();
            BeginContext(781, 11, false);
#line 24 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(792, 48, true);
            WriteLiteral("</p>\r\n                                <p>شابک : ");
            EndContext();
            BeginContext(841, 10, false);
#line 25 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                     Write(Model.ISBN);

#line default
#line hidden
            EndContext();
            BeginContext(851, 54, true);
            WriteLiteral("</p>\r\n                                <p>سال انتشار : ");
            EndContext();
            BeginContext(906, 17, false);
#line 26 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                           Write(Model.PublishYear);

#line default
#line hidden
            EndContext();
            BeginContext(923, 48, true);
            WriteLiteral("</p>\r\n                                <p>قیمت : ");
            EndContext();
            BeginContext(972, 11, false);
#line 27 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                     Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(983, 50, true);
            WriteLiteral("</p>\r\n                                <p>موجودی : ");
            EndContext();
            BeginContext(1034, 11, false);
#line 28 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                       Write(Model.Stock);

#line default
#line hidden
            EndContext();
            BeginContext(1045, 55, true);
            WriteLiteral("</p>\r\n                                <p>تعداد صفحات : ");
            EndContext();
            BeginContext(1101, 16, false);
#line 29 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                            Write(Model.NumOfPages);

#line default
#line hidden
            EndContext();
            BeginContext(1117, 53, true);
            WriteLiteral("</p>\r\n                                <p>زبان کتاب : ");
            EndContext();
            BeginContext(1171, 18, false);
#line 30 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                          Write(Model.LanguageName);

#line default
#line hidden
            EndContext();
            BeginContext(1189, 138, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n\r\n                                <p>ناشر : ");
            EndContext();
            BeginContext(1328, 19, false);
#line 34 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                     Write(Model.PublisherName);

#line default
#line hidden
            EndContext();
            BeginContext(1347, 90, true);
            WriteLiteral("</p>\r\n                                <p>\r\n                                    نویسندگان :");
            EndContext();
            BeginContext(1438, 13, false);
#line 36 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                          Write(Model.Authors);

#line default
#line hidden
            EndContext();
            BeginContext(1451, 159, true);
            WriteLiteral("\r\n                                   \r\n                                </p>\r\n                                <p>\r\n                                    مترجمان :");
            EndContext();
            BeginContext(1611, 17, false);
#line 40 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                        Write(Model.Translstors);

#line default
#line hidden
            EndContext();
            BeginContext(1628, 166, true);
            WriteLiteral("\r\n                                   \r\n\r\n                                </p>\r\n                                <p>\r\n                                    دسته بندی ها :");
            EndContext();
            BeginContext(1795, 16, false);
#line 45 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                             Write(Model.Categories);

#line default
#line hidden
            EndContext();
            BeginContext(1811, 166, true);
            WriteLiteral("\r\n                                   \r\n                                </p>\r\n                                <p>\r\n                                    تاریخ انتشار :\r\n");
            EndContext();
#line 50 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                     if (Model.PublishDate != null)
                                    {
                                        

#line default
#line hidden
            BeginContext(2126, 76, false);
#line 52 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                   Write(convertDate.ConvertMiladiToShamsi((DateTime)Model.PublishDate, "yyyy/MM/dd"));

#line default
#line hidden
            EndContext();
#line 52 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                                                                                                     
                                    }

                                    else
                                    {

#line default
#line hidden
            BeginContext(2326, 56, true);
            WriteLiteral("                                        <span>-</span>\r\n");
            EndContext();
#line 58 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2421, 120, true);
            WriteLiteral("                                </p>\r\n                                <p>\r\n                                    وضعیت :\r\n");
            EndContext();
#line 62 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                     if (Model.IsPublish == true)
                                    {

#line default
#line hidden
            BeginContext(2647, 64, true);
            WriteLiteral("                                        <span>منتشر شده</span>\r\n");
            EndContext();
#line 65 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                    }

                                    else
                                    {

#line default
#line hidden
            BeginContext(2833, 63, true);
            WriteLiteral("                                        <span>پیش نویس</span>\r\n");
            EndContext();
#line 70 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2935, 153, true);
            WriteLiteral("                                </p>\r\n                                <p>\r\n                                    وزن:\r\n                                    ");
            EndContext();
            BeginContext(3089, 12, false);
#line 74 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                               Write(Model.Weight);

#line default
#line hidden
            EndContext();
            BeginContext(3101, 291, true);
            WriteLiteral(@"
                                </p>

                            </div>

                        </div>

                    </div>

                    <div class=""col-md-12"">
                        <hr />
                        <p>
                            خلاصه کتاب : ");
            EndContext();
            BeginContext(3393, 13, false);
#line 86 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Details.cshtml"
                                    Write(Model.Summary);

#line default
#line hidden
            EndContext();
            BeginContext(3406, 150, true);
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BookShop.Classes.ConvertDate convertDate { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookShop.Models.ViewModels.ReadAllBook> Html { get; private set; }
    }
}
#pragma warning restore 1591
