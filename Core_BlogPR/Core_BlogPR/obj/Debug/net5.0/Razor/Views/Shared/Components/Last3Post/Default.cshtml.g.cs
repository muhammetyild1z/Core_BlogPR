#pragma checksum "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\Shared\Components\Last3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50bf2f061bb5d200f726a2ac8075a74dc82a1f5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Last3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Last3Post/Default.cshtml")]
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
#line 1 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\_ViewImports.cshtml"
using Core_BlogPR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\_ViewImports.cshtml"
using Core_BlogPR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50bf2f061bb5d200f726a2ac8075a74dc82a1f5f", @"/Views/Shared/Components/Last3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f836ed4cc5e9c27abcef7c84b8e6bffb878bb4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Last3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral(@"


<footer>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 footer-grid-agileits-w3ls text-left"">
                <h3>Hakkımızda</h3>
                <p>
                    İnternet üzerinde bireysel olarak oluşturulan, genel veya belli bir odak noktası olan blog çeşididir.
                    Büyük oranda blog yazarının ismini veya takma adını alırlar.
                    Yazarın bireysel günlüğü olmak dışında gündemi kendi kalemi ile yansıttığı ortamdır...
                </p>
                <div class=""read"">
                    <a href=""/About/Index"" class=""btn btn-primary read-m"">Devamını Oku</a>
                </div>
            </div>
            <div class=""col-lg-4 footer-grid-agileits-w3ls text-left"">

                <div class=""tech-btm"">
                    <h3>Son Gönderiler</h3>
");
#nullable restore
#line 23 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\Shared\Components\Last3Post\Default.cshtml"
                     foreach (var item in Model)
                    {

                   

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"blog-grids row mb-3\">\r\n                        <div class=\"col-md-5 blog-grid-left\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1160, "\"", 1197, 2);
            WriteAttributeValue("", 1167, "/Blog/BlogReadAll/", 1167, 18, true);
#nullable restore
#line 29 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\Shared\Components\Last3Post\Default.cshtml"
WriteAttributeValue("", 1185, item.blogID, 1185, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "50bf2f061bb5d200f726a2ac8075a74dc82a1f5f5938", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1243, "~/AddBlogImage/", 1243, 15, true);
#nullable restore
#line 30 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\Shared\Components\Last3Post\Default.cshtml"
AddHtmlAttributeValue("", 1258, item.blogThumbnailImage, 1258, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </a>\r\n                        </div>\r\n                        <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                            <h5>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1524, "\"", 1561, 2);
            WriteAttributeValue("", 1531, "/Blog/BlogReadAll/", 1531, 18, true);
#nullable restore
#line 36 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\Shared\Components\Last3Post\Default.cshtml"
WriteAttributeValue("", 1549, item.blogID, 1549, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\Shared\Components\Last3Post\Default.cshtml"
                                                                    Write(item.blogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                            </h5>\r\n                            <div class=\"sub-meta\">\r\n                                <span>\r\n                                    <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 40 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\Shared\Components\Last3Post\Default.cshtml"
                                                            Write(item.blogCreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 46 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\Shared\Components\Last3Post\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
            <!-- subscribe -->
            <div class=""col-lg-4 subscribe-main footer-grid-agileits-w3ls text-left"">
                <h4 class=""mb-3"" style=""color:white"">Mail Bültenine Abone Olun</h4>
                ");
#nullable restore
#line 53 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\Shared\Components\Last3Post\Default.cshtml"
           Write(await Html.PartialAsync("~/Views/NewsLatter/subscribeMail.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
        <!-- footer -->
        <div class=""footer-cpy text-center"">
            <div class=""footer-social"">
                <div class=""copyrighttop"">
                    <ul>
                        <li class=""mx-3"">
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-facebook-f""></i>
                                <span>Facebook</span>
                            </a>
                        </li>
                        <li>
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-twitter""></i>
                                <span>Twitter</span>
                            </a>
                        </li>
                        <li class=""mx-3"">
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-google-plus-g""></i>
                                <span>Google+</span>
                 ");
            WriteLiteral(@"           </a>
                        </li>
                        <li>
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-pinterest-p""></i>
                                <span>Pinterest</span>
                            </a>
                        </li>
                    </ul>

                </div>
            </div>
            <div class=""w3layouts-agile-copyrightbottom"">
                <p>
                    © ");
#nullable restore
#line 91 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\Shared\Components\Last3Post\Default.cshtml"
                 Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Asp.Net .Core 5.0 Tüm Hakları Saklıdır | Design by\r\n                    <a href=\"#\">####</a>\r\n                </p>\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <!-- //footer -->\r\n\r\n\r\n    </div>\r\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591