#pragma checksum "/Users/ihorvasyliev/Downloads/WP/WP/Views/Home/Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a04721ea9a07201cf6d33c7b3fbbda80db6d75f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "/Users/ihorvasyliev/Downloads/WP/WP/Views/_ViewImports.cshtml"
using WP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ihorvasyliev/Downloads/WP/WP/Views/_ViewImports.cshtml"
using WP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a04721ea9a07201cf6d33c7b3fbbda80db6d75f7", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75dcae3a640e450a1ebd52e2aa561540b9d40974", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WP.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome to WearPlan!</h1>\n</div>\n\n\n<div class=\"container\">\n    <div class=\"row row-cols-2 row-cols-md-2\">\n");
#nullable restore
#line 10 "/Users/ihorvasyliev/Downloads/WP/WP/Views/Home/Privacy.cshtml"
         foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-4 mb-4\">\n                    <div class=\"card\">\n                        <img");
            BeginWriteAttribute("src", " src=", 357, "", 403, 1);
#nullable restore
#line 15 "/Users/ihorvasyliev/Downloads/WP/WP/Views/Home/Privacy.cshtml"
WriteAttributeValue("", 362, Html.DisplayFor(modelItem => item.image), 362, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 424, "\"", 430, 0);
            EndWriteAttribute();
            WriteLiteral(" height=\"300\">\n                        <div class=\"card-body\">\n                            <h5 class=\"card-title\"> ");
#nullable restore
#line 17 "/Users/ihorvasyliev/Downloads/WP/WP/Views/Home/Privacy.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                            <p class=\"card-text\">");
#nullable restore
#line 18 "/Users/ihorvasyliev/Downloads/WP/WP/Views/Home/Privacy.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        </div>\n                    </div>\n                </div>\n");
#nullable restore
#line 22 "/Users/ihorvasyliev/Downloads/WP/WP/Views/Home/Privacy.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WP.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
