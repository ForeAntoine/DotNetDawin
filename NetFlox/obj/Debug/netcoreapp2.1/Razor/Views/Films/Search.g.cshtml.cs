#pragma checksum "C:\Users\Mantaleau\Documents\projetDotNet\NetFlox\Views\Films\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89a15a7fd037fc9207cdf3a0a65b054655f1d1d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Films_Search), @"mvc.1.0.view", @"/Views/Films/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Films/Search.cshtml", typeof(AspNetCore.Views_Films_Search))]
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
#line 1 "C:\Users\Mantaleau\Documents\projetDotNet\NetFlox\Views\_ViewImports.cshtml"
using NetFlox;

#line default
#line hidden
#line 2 "C:\Users\Mantaleau\Documents\projetDotNet\NetFlox\Views\_ViewImports.cshtml"
using NetFlox.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89a15a7fd037fc9207cdf3a0a65b054655f1d1d2", @"/Views/Films/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"787a7193c39904e2e05164d82ddffd8e408f6e10", @"/Views/_ViewImports.cshtml")]
    public class Views_Films_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NetFlox.DAL.Film>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\Mantaleau\Documents\projetDotNet\NetFlox\Views\Films\Search.cshtml"
  
    ViewData["Title"] = "Search";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(122, 120, true);
            WriteLiteral("\n<h2>Search</h2>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th></th>\n            <th>\n                ");
            EndContext();
            BeginContext(243, 41, false);
#line 14 "C:\Users\Mantaleau\Documents\projetDotNet\NetFlox\Views\Films\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Titre));

#line default
#line hidden
            EndContext();
            BeginContext(284, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(337, 41, false);
#line 17 "C:\Users\Mantaleau\Documents\projetDotNet\NetFlox\Views\Films\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Annee));

#line default
#line hidden
            EndContext();
            BeginContext(378, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(431, 40, false);
#line 20 "C:\Users\Mantaleau\Documents\projetDotNet\NetFlox\Views\Films\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Pays));

#line default
#line hidden
            EndContext();
            BeginContext(471, 58, true);
            WriteLiteral("\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 25 "C:\Users\Mantaleau\Documents\projetDotNet\NetFlox\Views\Films\Search.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(576, 62, true);
            WriteLiteral("            <tr>\n                <td>\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 638, "\"", 660, 1);
#line 29 "C:\Users\Mantaleau\Documents\projetDotNet\NetFlox\Views\Films\Search.cshtml"
WriteAttributeValue("", 644, item.UrlAffiche, 644, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(661, 79, true);
            WriteLiteral(" height=\"50\" />\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(740, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7178f9aaa5f4b519d5b102aac8e3eda", async() => {
                BeginContext(789, 40, false);
#line 32 "C:\Users\Mantaleau\Documents\projetDotNet\NetFlox\Views\Films\Search.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.Titre));

#line default
#line hidden
                EndContext();
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
#line 32 "C:\Users\Mantaleau\Documents\projetDotNet\NetFlox\Views\Films\Search.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(833, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(898, 40, false);
#line 35 "C:\Users\Mantaleau\Documents\projetDotNet\NetFlox\Views\Films\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.Annee));

#line default
#line hidden
            EndContext();
            BeginContext(938, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1003, 39, false);
#line 38 "C:\Users\Mantaleau\Documents\projetDotNet\NetFlox\Views\Films\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.Pays));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 41 "C:\Users\Mantaleau\Documents\projetDotNet\NetFlox\Views\Films\Search.cshtml"
        }

#line default
#line hidden
            BeginContext(1093, 21, true);
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NetFlox.DAL.Film>> Html { get; private set; }
    }
}
#pragma warning restore 1591
