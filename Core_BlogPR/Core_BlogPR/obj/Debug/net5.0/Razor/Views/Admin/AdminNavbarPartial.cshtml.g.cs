#pragma checksum "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\Admin\AdminNavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ebf1a7f3976f30876cc45d4988c2bff83b4189c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminNavbarPartial), @"mvc.1.0.view", @"/Views/Admin/AdminNavbarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ebf1a7f3976f30876cc45d4988c2bff83b4189c", @"/Views/Admin/AdminNavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f836ed4cc5e9c27abcef7c84b8e6bffb878bb4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminNavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<nav class=""navbar-default navbar-static-side"" role=""navigation"">
    <div class=""sidebar-collapse"">
        <ul class=""nav metismenu"" id=""side-menu"">
            <li class=""nav-header"">
                <div class=""dropdown profile-element"">
                    <img alt=""image"" class=""rounded-circle"" src=""img/profile_small.jpg"" />
                    <a data-toggle=""dropdown"" class=""dropdown-toggle"" href=""#"">
                        <span class=""block m-t-xs font-bold"">David Williams</span>
                        <span class=""text-muted text-xs block"">Art Director <b class=""caret""></b></span>
                    </a>
                    <ul class=""dropdown-menu animated fadeInRight m-t-xs"">
                        <li><a class=""dropdown-item"" href=""profile.html"">Profile</a></li>
                        <li><a class=""dropdown-item"" href=""contacts.html"">Contacts</a></li>
                        <li><a class=""dropdown-item"" href=""mailbox.html"">Mailbox</a></li>
                        <li class=""");
            WriteLiteral(@"dropdown-divider""></li>
                        <li><a class=""dropdown-item"" href=""login.html"">Logout</a></li>
                    </ul>
                </div>
                <div class=""logo-element"">
                    IN+
                </div>
            </li>
            <li>
                <a href=""index.html""><i class=""fa fa-th-large""></i> <span class=""nav-label"">Dashboards</span> <span class=""fa arrow""></span></a>
                <ul class=""nav nav-second-level collapse"">
                    <li><a href=""index.html"">Dashboard v.1</a></li>
                    <li><a href=""dashboard_2.html"">Dashboard v.2</a></li>
                    <li><a href=""dashboard_3.html"">Dashboard v.3</a></li>
                    <li><a href=""dashboard_4_1.html"">Dashboard v.4</a></li>
                    <li><a href=""dashboard_5.html"">Dashboard v.5 </a></li>
                </ul>
            </li>

            <li>
                <a href=""#""><i class=""fa fa-bar-chart-o""></i> <span class=""nav-label"">Grap");
            WriteLiteral(@"hs</span><span class=""fa arrow""></span></a>
                <ul class=""nav nav-second-level collapse"">
                    <li><a href=""graph_flot.html"">Flot Charts</a></li>
                    <li><a href=""graph_morris.html"">Morris.js Charts</a></li>
                    <li><a href=""graph_rickshaw.html"">Rickshaw Charts</a></li>
                    <li><a href=""graph_chartjs.html"">Chart.js</a></li>
                    <li><a href=""graph_chartist.html"">Chartist</a></li>
                    <li><a href=""c3.html"">c3 charts</a></li>
                    <li><a href=""graph_peity.html"">Peity Charts</a></li>
                    <li><a href=""graph_sparkline.html"">Sparkline Charts</a></li>
                </ul>
            </li>
            <li>
                <a href=""mailbox.html""><i class=""fa fa-envelope""></i> <span class=""nav-label"">Mesajlar </span><span class=""label label-warning float-right"">16/24</span></a>
                <ul class=""nav nav-second-level collapse"">
                    <li><a href");
            WriteLiteral(@"=""mailbox.html"">Inbox</a></li>
                    <li><a href=""mail_detail.html"">Email view</a></li>
                    <li><a href=""mail_compose.html"">Compose email</a></li>
                    <li><a href=""email_template.html"">Email templates</a></li>
                </ul>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-pie-chart""></i> <span class=""nav-label"">Metrikler</span>  </a>
            </li>
            <li>
                <a href=""/Admin/Catagory/Index""><i class=""fa fa-group""></i> <span class=""nav-label"">Kategoriler</span>  </a>
            </li>
            <li>
                <a href=""/Admin/Blog/Index""><i class=""fa fa-list-alt""></i> <span class=""nav-label"">Bloglar</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-comment""></i> <span class=""nav-label"">Yorumlar</span>  </a>
            </li>
            <li>
                <a href=""/Admin/Blog/Writer""><i class=""fa fa-user""></i> <s");
            WriteLiteral(@"pan class=""nav-label"">Yazarlar</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-cog""></i> <span class=""nav-label"">Ayarlar</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-bell""></i> <span class=""nav-label"">Bildirimler</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-address-book""></i> <span class=""nav-label"">??leti??im</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-info-circle""></i> <span class=""nav-label"">Hakk??m??zda</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-flask""></i> <span class=""nav-label"">Widgets</span>  </a>
            </li>
            
");
            WriteLiteral("\r\n        </ul>\r\n\r\n    </div>\r\n</nav>");
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
