#pragma checksum "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Areas\Admin\Views\Catagory\CatagoryAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f03b172ca7f29eb4331882725e912ae9157056c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Catagory_CatagoryAdd), @"mvc.1.0.view", @"/Areas/Admin/Views/Catagory/CatagoryAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f03b172ca7f29eb4331882725e912ae9157056c0", @"/Areas/Admin/Views/Catagory/CatagoryAdd.cshtml")]
    public class Areas_Admin_Views_Catagory_CatagoryAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Catagory>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Areas\Admin\Views\Catagory\CatagoryAdd.cshtml"
  
    ViewData["Title"] = "CatagoryAdd";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<form  method=\"post\" >\r\n    <div class=\"form-control\">\r\n        <div class=\"col-md-8 mb-5\">\r\n            <label>Katagori Adı</label>\r\n            ");
#nullable restore
#line 11 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Areas\Admin\Views\Catagory\CatagoryAdd.cshtml"
       Write(Html.TextBoxFor(x => x.catagoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 12 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Areas\Admin\Views\Catagory\CatagoryAdd.cshtml"
       Write(Html.ValidationMessageFor(x => x.catagoryName,"",  new { @class = "text-danger " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <label>Katagori Açıklaması</label>\r\n            ");
#nullable restore
#line 15 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Areas\Admin\Views\Catagory\CatagoryAdd.cshtml"
       Write(Html.TextBoxFor(x => x.catagoryDesc, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "C:\Users\Muhammet\Desktop\Proje Ve Doyalar\projeler\.CORE\Core_BlogPR\Core_BlogPR\Areas\Admin\Views\Catagory\CatagoryAdd.cshtml"
       Write(Html.ValidationMessageFor(x => x.catagoryDesc ,"",new { @class = "text-danger " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n      <button type=\"submit\" class=\"btn btn-info ml-3 col-md-2\" href=\"/Admin/Catagory/CatagoryAdd\">Ekle</button>\r\n    </div>\r\n    \r\n</form>\r\n\r\n");
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