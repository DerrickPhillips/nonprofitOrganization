#pragma checksum "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Views\News\SingleView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bb945179b536585ce1aa12a340b01f1b6da4370"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_SingleView), @"mvc.1.0.view", @"/Views/News/SingleView.cshtml")]
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
#line 1 "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Views\_ViewImports.cshtml"
using nonprofitOrganization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Views\_ViewImports.cshtml"
using nonprofitOrganization.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bb945179b536585ce1aa12a340b01f1b6da4370", @"/Views/News/SingleView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd81f7adc913432bc5e19cc61c5639df8128b488", @"/Views/_ViewImports.cshtml")]
    public class Views_News_SingleView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<nonprofitOrganization.Models.News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewLatest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("View-More font-weight-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Views\News\SingleView.cshtml"
  
    ViewData["Title"] = "News and Events";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2 class=\"Post-Title\">");
#nullable restore
#line 8 "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Views\News\SingleView.cshtml"
                  Write(Html.DisplayFor(model => model.NewsTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3 class=\"Post-Info\">");
#nullable restore
#line 9 "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Views\News\SingleView.cshtml"
                 Write(Html.DisplayFor(model => model.NewsAuthor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3 class=\"Post-Info\">");
#nullable restore
#line 10 "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Views\News\SingleView.cshtml"
                 Write(Html.DisplayFor(model => model.DatePosted));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<p>");
#nullable restore
#line 11 "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Views\News\SingleView.cshtml"
Write(Html.DisplayFor(model => model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<hr />\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bb945179b536585ce1aa12a340b01f1b6da43705468", async() => {
                WriteLiteral("Back to News and Events");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<nonprofitOrganization.Models.News> Html { get; private set; }
    }
}
#pragma warning restore 1591
