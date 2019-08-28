#pragma checksum "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32fe7c2a43119327945e2d72f5dcb1121018e3dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Books_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Books/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Books/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Books_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32fe7c2a43119327945e2d72f5dcb1121018e3dd", @"/Areas/Admin/Views/Books/Index.cshtml")]
    public class Areas_Admin_Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/_Admin.cshtml";

#line default
#line hidden
            BeginContext(76, 9126, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header bg-light"">
                لیست کتاب ها
            </div>
            <div class=""card-body"">
                <div class=""col-md-4 mb-3 padding-0px"">
                    <div class=""input-group"">
                        <span class=""input-group-btn"">
                            <button type=""button"" class=""btn btn-primary""><i class=""fa fa-search""></i> جستجو</button>
                        </span>
                        <input id=""input-group-1"" name=""input1-group2"" class=""form-control"" placeholder=""عنوان کتاب را واردکنید ..."" type=""text"">
                    </div>
                </div>
                <p>
                    <a class=""btn btn-primary btn-block"" data-toggle=""collapse"" href=""#collapseExample"" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"">
                        جستجوی پیشرفته کتاب
                    </a>
                </p>
            ");
            WriteLiteral(@"    <div class=""collapse"" id=""collapseExample"">
                    <div class=""card card-body"">
                        <form>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label class=""form-control-label"">عنوان</label>
                                        <input class=""form-control"" placeholder=""عنوان"">
                                    </div>
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label class=""form-control-label"">شابک</label>
                                        <input class=""form-control"" placeholder=""شابک"">
                                    </div>
                                </div>
                                <div class=""col-md-3"">
                              ");
            WriteLiteral(@"      <div class=""form-group"">
                                        <label class=""form-control-label"">زبان</label>
                                        <select class=""select2 js-states form-control"">
                                            <option>فارسی</option>
                                            <option>عربی</option>
                                            <option>purple</option>
                                        </select>
                                    </div>
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label class=""form-control-label"">دسته بندی</label>
                                        <select class=""select2 js-states form-control"">
                                            <option>فارسی</option>
                                            <option>عربی</option>
                                        <");
            WriteLiteral(@"/select>
                                    </div>
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label class=""form-control-label"">نویسنده</label>
                                        <select class=""select2 js-states form-control"">
                                            <option>آرزو ابراهیمی</option>
                                            <option>زهرا رحمانی</option>
                                        </select>
                                    </div>
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label class=""form-control-label"">مترجم</label>
                                        <select class=""select2 js-states form-control"">
                                            <option");
            WriteLiteral(@">آرزو ابراهیمی</option>
                                            <option>زهرا رحمانی</option>
                                        </select>
                                    </div>
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label class=""form-control-label"">ناشر</label>
                                        <select class=""select2 js-states form-control"">
                                            <option>انتشارات رسا</option>

                                        </select>
                                    </div>
                                </div>
                                <div class=""col-md-12"">
                                    <input type=""submit"" value=""جستجو"" class=""btn btn-success float-left"" />
                                </div>
                            </div>
                        </form>
       ");
            WriteLiteral(@"             </div>
                </div>
                <div class=""table-responsive"">
                    <table class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th>ردیف</th>
                                <th>عنوان</th>
                                <th>شابک</th>
                                <th>ناشر</th>
                                <th class=""text-center"">قیمت (ریال)</th>
                                <th class=""text-center"">تاریخ انتشار در سایت</th>
                                <th style=""width:25px;"">وضعیت</th>
                                <th>عملیات</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td class=""text-center"">1</td>
                                <td class=""text-nowrap"">سمفونی مردگان</td>
                                <td>k5675</td>
                   ");
            WriteLiteral(@"             <td>انتشارات رسا</td>
                                <td class=""text-center"">200000</td>
                                <td class=""text-center"">1397/12/09</td>
                                <td class=""text-center"">
                                    <label class=""badge badge-success btn-block"">منتشر شده</label>
                                </td>
                                <td class=""text-center"">
                                    <a class=""btn btn-info btn-icon""><i class=""fa fa-eye text-white""></i></a>
                                    <a class=""btn btn-success btn-icon""><i class=""fa fa-edit text-white""></i></a>
                                    <a class=""btn btn-danger btn-icon""><i class=""fa fa-trash text-white""></i></a>
                                </td>
                            </tr>
                            <tr>
                                <td class=""text-center"">2</td>
                                <td class=""text-nowrap"">دوست داشتم کسی جایی من");
            WriteLiteral(@"تظرم باشد</td>
                                <td>Kg900</td>
                                <td>انتشارات رسا</td>
                                <td class=""text-center"">150000</td>
                                <td class=""text-center"">1397/08/06</td>
                                <td class=""text-center"">
                                    <label class=""badge badge-warning btn-block"">پیش نویس</label>
                                </td>
                                <td class=""text-center"">
                                    <a class=""btn btn-info btn-icon""><i class=""fa fa-eye text-white""></i></a>
                                    <a class=""btn btn-success btn-icon""><i class=""fa fa-edit text-white""></i></a>
                                    <a class=""btn btn-danger btn-icon""><i class=""fa fa-trash text-white""></i></a>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <nav class");
            WriteLiteral(@"=""text-center"">
                        <ul class=""pagination"">
                            <li class=""page-item disabled"">
                                <a class=""page-link"" href=""#"" tabindex=""-1"">قبلی</a>
                            </li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item active"">
                                <a class=""page-link"" href=""#"">2 <span class=""sr-only"">(current)</span></a>
                            </li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">بعدی</a>
                            </li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </div>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
