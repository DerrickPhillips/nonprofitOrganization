#pragma checksum "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Views\News\SingleView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5417bf966f6d8d64b733d6f33a706452c208de9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5417bf966f6d8d64b733d6f33a706452c208de9", @"/Views/News/SingleView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bb6fc4ccef7e32a0b9d9b82b71e2b4915d8b896", @"/Views/_ViewImports.cshtml")]
    public class Views_News_SingleView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<nonprofitOrganization.Models.News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RecentView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
  
    ViewData["Title"] = "News";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\" style=\"border-style: solid; border: 9px solid #0094cc; border-radius: 20px;margin-top: 15px; background-color: white; padding-bottom: 1rem\">\r\n    <h2 class=\"Post-Title\">Title: ");
#nullable restore
#line 8 "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Views\News\SingleView.cshtml"
                             Write(Html.DisplayFor(model => model.NewsTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h3 class=\"Post-Info\">Author: ");
#nullable restore
#line 9 "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Views\News\SingleView.cshtml"
                             Write(Html.DisplayFor(model => model.NewsAuthor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h3 class=\"Post-Info\">Date: ");
#nullable restore
#line 10 "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Views\News\SingleView.cshtml"
                           Write(Html.DisplayFor(model => model.DatePosted));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <p>");
#nullable restore
#line 11 "C:\Users\derri\OneDrive\Documents\GitHub\nonprofitOrganization\nonprofitOrganization\Views\News\SingleView.cshtml"
  Write(Html.DisplayFor(model => model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <hr />\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5417bf966f6d8d64b733d6f33a706452c208de95703", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
