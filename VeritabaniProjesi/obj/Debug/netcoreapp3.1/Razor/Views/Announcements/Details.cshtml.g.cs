<<<<<<< Updated upstream
#pragma checksum "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Announcements\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "634a6faad0e0e3f6580696371e89ecb12be91861"
=======
#pragma checksum "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Announcements\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe69523ae581fb8ae8a85648fc187205ae5a4616"
>>>>>>> Stashed changes
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Announcements_Details), @"mvc.1.0.view", @"/Views/Announcements/Details.cshtml")]
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
<<<<<<< Updated upstream
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"634a6faad0e0e3f6580696371e89ecb12be91861", @"/Views/Announcements/Details.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe69523ae581fb8ae8a85648fc187205ae5a4616", @"/Views/Announcements/Details.cshtml")]
>>>>>>> Stashed changes
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9690d4889ed265db239446d694324e877dbea8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Announcements_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VeritabaniProjesi.Models.Announcement>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Announcements\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Announcement</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Announcements\Details.cshtml"
=======
            WriteLiteral("\r\n<div class=\"container\" style=\"margin-top:50px;\">\r\n<h1>Detaylar</h1>\r\n\r\n<div>\r\n    <h4>Duyuru</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Announcements\Details.cshtml"
>>>>>>> Stashed changes
       Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
<<<<<<< Updated upstream
#line 18 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Announcements\Details.cshtml"
=======
#line 19 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Announcements\Details.cshtml"
>>>>>>> Stashed changes
       Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Announcements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SourceListString));
=======
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Kaynaklar<!--");
#nullable restore
#line 22 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Announcements\Details.cshtml"
                    Write(Html.DisplayNameFor(model => model.SourceListString));
>>>>>>> Stashed changes

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Announcements\Details.cshtml"
=======
            WriteLiteral("-->\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Announcements\Details.cshtml"
>>>>>>> Stashed changes
       Write(Html.DisplayFor(model => model.SourceListString));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
<<<<<<< Updated upstream
#line 27 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Announcements\Details.cshtml"
=======
#line 28 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Announcements\Details.cshtml"
>>>>>>> Stashed changes
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
<<<<<<< Updated upstream
#line 30 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Announcements\Details.cshtml"
=======
#line 31 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Announcements\Details.cshtml"
>>>>>>> Stashed changes
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
<<<<<<< Updated upstream
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "634a6faad0e0e3f6580696371e89ecb12be918616337", async() => {
                WriteLiteral("Edit");
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe69523ae581fb8ae8a85648fc187205ae5a46166418", async() => {
                WriteLiteral("Düzenle");
>>>>>>> Stashed changes
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< Updated upstream
#line 35 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Announcements\Details.cshtml"
=======
#line 36 "C:\Users\Mete ARSLAN\Desktop\GitHub\Veritaban-Proje\VeritabaniProjesi\Views\Announcements\Details.cshtml"
>>>>>>> Stashed changes
                           WriteLiteral(Model.Title);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
<<<<<<< Updated upstream
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "634a6faad0e0e3f6580696371e89ecb12be918618507", async() => {
                WriteLiteral("Back to List");
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe69523ae581fb8ae8a85648fc187205ae5a46168591", async() => {
                WriteLiteral("Listeye Geri Dön");
>>>>>>> Stashed changes
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
<<<<<<< Updated upstream
            WriteLiteral("\r\n</div>\r\n");
=======
            WriteLiteral("\r\n</div>\r\n    </div>");
>>>>>>> Stashed changes
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VeritabaniProjesi.Models.Announcement> Html { get; private set; }
    }
}
#pragma warning restore 1591
