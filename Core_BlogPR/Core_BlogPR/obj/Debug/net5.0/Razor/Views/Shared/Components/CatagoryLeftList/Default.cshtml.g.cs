#pragma checksum "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\Shared\Components\CatagoryLeftList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2665f96f1c168bb875d0f7978b1a364fec38dcb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CatagoryLeftList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CatagoryLeftList/Default.cshtml")]
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
#nullable restore
#line 3 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\Shared\Components\CatagoryLeftList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2665f96f1c168bb875d0f7978b1a364fec38dcb8", @"/Views/Shared/Components/CatagoryLeftList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f836ed4cc5e9c27abcef7c84b8e6bffb878bb4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CatagoryLeftList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Catagory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<ul class=\"list-group single\">\r\n");
#nullable restore
#line 6 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\Shared\Components\CatagoryLeftList\Default.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n          ");
#nullable restore
#line 10 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\Shared\Components\CatagoryLeftList\Default.cshtml"
     Write(item.catagoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           <span class=\"badge badge-primary badge-pill\">\r\n             \r\n            </span>\r\n        </li>\r\n");
#nullable restore
#line 15 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Views\Shared\Components\CatagoryLeftList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Catagory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
