#pragma checksum "D:\Impetus\Impetus Website\ImpetusWebSite-main\ImpetusWebsite\ImpetusWebsite\Views\Game\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4526435eaae3488b0a2c69a62203dabd5df6f8ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Index), @"mvc.1.0.view", @"/Views/Game/Index.cshtml")]
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
#line 1 "D:\Impetus\Impetus Website\ImpetusWebSite-main\ImpetusWebsite\ImpetusWebsite\Views\_ViewImports.cshtml"
using ImpetusWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Impetus\Impetus Website\ImpetusWebSite-main\ImpetusWebsite\ImpetusWebsite\Views\_ViewImports.cshtml"
using ImpetusWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4526435eaae3488b0a2c69a62203dabd5df6f8ea", @"/Views/Game/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1c29f12bb8bc387b603d50ddfdb71ede765ae4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ImpetusWebsite.Areas.Identity.Data.Match>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Impetus\Impetus Website\ImpetusWebSite-main\ImpetusWebsite\ImpetusWebsite\Views\Game\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<iframe");
            BeginWriteAttribute("src", " src=\"", 161, "\"", 208, 2);
            WriteAttributeValue("", 167, "https://i.simmer.io/", 167, 20, true);
            WriteLiteral("@");
            WriteAttributeValue("", 189, "DenisIvanov/impetus", 189, 19, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:960px;height:600px;border:0\"></iframe>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ImpetusWebsite.Areas.Identity.Data.Match>> Html { get; private set; }
    }
}
#pragma warning restore 1591