#pragma checksum "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\RequestPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6022ea2cebc5980b518df9ce387f4dcd4d8214f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GagandeepKaurA00224734_SimpleWebPage.Pages.Pages_RequestPage), @"mvc.1.0.razor-page", @"/Pages/RequestPage.cshtml")]
namespace GagandeepKaurA00224734_SimpleWebPage.Pages
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
#line 1 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\_ViewImports.cshtml"
using GagandeepKaurA00224734_SimpleWebPage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6022ea2cebc5980b518df9ce387f4dcd4d8214f1", @"/Pages/RequestPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61b3b82063d2a43db5913fa094670001d17b128d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RequestPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\RequestPage.cshtml"
  
    ViewData["Title"] = "Request Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\RequestPage.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n\r\n<dl>\r\n    <dt>Accept</dt>\r\n    <dd>");
#nullable restore
#line 13 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\RequestPage.cshtml"
   Write(Request.Headers["Accept"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    <dt>Accept-Encoding</dt>\r\n    <dd>");
#nullable restore
#line 15 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\RequestPage.cshtml"
   Write(Request.Headers["Accept-Encoding"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    <dt>User-Agent</dt>\r\n    <dd>");
#nullable restore
#line 17 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\RequestPage.cshtml"
   Write(Request.Headers["User-Agent"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    <dt>Host</dt>\r\n    <dd>");
#nullable restore
#line 19 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\RequestPage.cshtml"
   Write(Request.Headers["Host"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    <!-- Another Way -->\r\n    <dt>Host & Path</dt>\r\n    <dd>");
#nullable restore
#line 22 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\RequestPage.cshtml"
   Write(Request.Scheme);

#line default
#line hidden
#nullable disable
            WriteLiteral("://");
#nullable restore
#line 22 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\RequestPage.cshtml"
                     Write(Request.Host.Value);

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Sony\source\repos\GagandeepKaurA00224734_SimpleWebPage\GagandeepKaurA00224734_SimpleWebPage\Pages\RequestPage.cshtml"
                                        Write(Request.Path.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n</dl>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GagandeepKaurA00224734_SimpleWebPage.Pages.RequestPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GagandeepKaurA00224734_SimpleWebPage.Pages.RequestPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GagandeepKaurA00224734_SimpleWebPage.Pages.RequestPageModel>)PageContext?.ViewData;
        public GagandeepKaurA00224734_SimpleWebPage.Pages.RequestPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591