#pragma checksum "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Areas\Admin\Views\Catagory\CatagoryEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "520fb9cced6ad655458670d7a6377b89f64c2fa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Catagory_CatagoryEdit), @"mvc.1.0.view", @"/Areas/Admin/Views/Catagory/CatagoryEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"520fb9cced6ad655458670d7a6377b89f64c2fa8", @"/Areas/Admin/Views/Catagory/CatagoryEdit.cshtml")]
    public class Areas_Admin_Views_Catagory_CatagoryEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Catagory>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Areas\Admin\Views\Catagory\CatagoryEdit.cshtml"
  
    ViewData["Title"] = "CatagoryEdit";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<form method=\"post\" action=\"/Admin/Catagory/CatagoryEdit/\" >\r\n    <div class=\"form-group\">\r\n        <label>Katagori Adı</label>\r\n        ");
#nullable restore
#line 10 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Areas\Admin\Views\Catagory\CatagoryEdit.cshtml"
   Write(Html.TextBoxFor(x => x.catagoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <label>Katagori Açıklaması</label>\r\n        ");
#nullable restore
#line 13 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Areas\Admin\Views\Catagory\CatagoryEdit.cshtml"
   Write(Html.TextBoxFor(x => x.catagoryDesc, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Areas\Admin\Views\Catagory\CatagoryEdit.cshtml"
   Write(Html.HiddenFor(x=>x.catagoryID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <input type=\"submit\" name=\"btn\" value=\"Kaydet\" class=\"btn btn-adn btn-info\"  />\r\n    </div>\r\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Catagory> Html { get; private set; }
    }
}
#pragma warning restore 1591
