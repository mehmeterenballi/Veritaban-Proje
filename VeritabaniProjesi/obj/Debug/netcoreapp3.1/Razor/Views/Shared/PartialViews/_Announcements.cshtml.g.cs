#pragma checksum "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Shared\PartialViews\_Announcements.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed49295ddddc806c84ae94a89d152e91fd42d1ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PartialViews__Announcements), @"mvc.1.0.view", @"/Views/Shared/PartialViews/_Announcements.cshtml")]
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
#line 1 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\_ViewImports.cshtml"
using VeritabaniProjesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\_ViewImports.cshtml"
using VeritabaniProjesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed49295ddddc806c84ae94a89d152e91fd42d1ae", @"/Views/Shared/PartialViews/_Announcements.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9690d4889ed265db239446d694324e877dbea8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews__Announcements : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VeritabaniProjesi.Models.Announcement>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Shared\PartialViews\_Announcements.cshtml"
 foreach (var annoucment in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"display: table-row\">\r\n        <h3>");
#nullable restore
#line 7 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Shared\PartialViews\_Announcements.cshtml"
       Write(annoucment.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p class=\"lead\">");
#nullable restore
#line 8 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Shared\PartialViews\_Announcements.cshtml"
                   Write(annoucment.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 9 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Shared\PartialViews\_Announcements.cshtml"
      Write(annoucment.SourceList);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 10 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Shared\PartialViews\_Announcements.cshtml"
      Write(annoucment.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <dl class=\"inline\">\r\n            <dt>");
#nullable restore
#line 13 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Shared\PartialViews\_Announcements.cshtml"
           Write(Html.DisplayFor(model => annoucment.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n            <dt>");
#nullable restore
#line 14 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Shared\PartialViews\_Announcements.cshtml"
           Write(Html.DisplayFor(model => annoucment.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n            <dt>");
#nullable restore
#line 15 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Shared\PartialViews\_Announcements.cshtml"
           Write(Html.DisplayFor(model => annoucment.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n");
            WriteLiteral("            \r\n");
#nullable restore
#line 18 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Shared\PartialViews\_Announcements.cshtml"
             if (annoucment.SourceList != null && annoucment.SourceList.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Shared\PartialViews\_Announcements.cshtml"
                 foreach (var source in annoucment.SourceList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt>Source</dt>\r\n                    <dd>");
#nullable restore
#line 23 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Shared\PartialViews\_Announcements.cshtml"
                   Write(Html.DisplayFor(x => source));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 24 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Shared\PartialViews\_Announcements.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Shared\PartialViews\_Announcements.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dl>\r\n    </div>\r\n");
#nullable restore
#line 28 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Shared\PartialViews\_Announcements.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VeritabaniProjesi.Models.Announcement>> Html { get; private set; }
    }
}
#pragma warning restore 1591