#pragma checksum "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Areas\Help\Views\Shared\_HelpLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0a7adabde023e9da0d25300286c1e5e1873e93b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Help_Views_Shared__HelpLayout), @"mvc.1.0.view", @"/Areas/Help/Views/Shared/_HelpLayout.cshtml")]
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
#line 1 "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Areas\Help\Views\_ViewImports.cshtml"
using nonprofitOrganization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Areas\Help\Views\_ViewImports.cshtml"
using nonprofitOrganization.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0a7adabde023e9da0d25300286c1e5e1873e93b", @"/Areas/Help/Views/Shared/_HelpLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f736bd70cd199b4be0a5d7f8c2daa3d05bef58f6", @"/Areas/Help/Views/_ViewImports.cshtml")]
    public class Areas_Help_Views_Shared__HelpLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Areas\Help\Views\Shared\_HelpLayout.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Code to enable the links below to mark the current link in the navbar as active-->\r\n");
#nullable restore
#line 4 "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Areas\Help\Views\Shared\_HelpLayout.cshtml"
    string controller = ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\" style=\"display: inline-block\">\r\n    \r\n</div>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Areas\Help\Views\Shared\_HelpLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
