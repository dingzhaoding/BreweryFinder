#pragma checksum "C:\Users\davio\Portfolio\TechElevatorBootcamp\BreweryFinder\FinalCapstone\Views\Shared\_AnonymousNav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce63ad6bccbab214b421cae24f7f191affd7ee39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AnonymousNav), @"mvc.1.0.view", @"/Views/Shared/_AnonymousNav.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_AnonymousNav.cshtml", typeof(AspNetCore.Views_Shared__AnonymousNav))]
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
#line 1 "C:\Users\davio\Portfolio\TechElevatorBootcamp\BreweryFinder\FinalCapstone\Views\_ViewImports.cshtml"
using FinalCapstone;

#line default
#line hidden
#line 2 "C:\Users\davio\Portfolio\TechElevatorBootcamp\BreweryFinder\FinalCapstone\Views\_ViewImports.cshtml"
using FinalCapstone.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce63ad6bccbab214b421cae24f7f191affd7ee39", @"/Views/Shared/_AnonymousNav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aba76b8880666c667d3862a5f9cff3f00d85c83", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AnonymousNav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 26, true);
            WriteLiteral("<li class=\"right-aligned\">");
            EndContext();
            BeginContext(27, 41, false);
#line 1 "C:\Users\davio\Portfolio\TechElevatorBootcamp\BreweryFinder\FinalCapstone\Views\Shared\_AnonymousNav.cshtml"
                     Write(Html.ActionLink("Login", "Login", "User"));

#line default
#line hidden
            EndContext();
            BeginContext(68, 5, true);
            WriteLiteral("</li>");
            EndContext();
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
