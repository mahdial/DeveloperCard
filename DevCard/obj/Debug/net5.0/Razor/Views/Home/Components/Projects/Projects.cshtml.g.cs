#pragma checksum "C:\Users\Emi\Source\Repos\DeveloperCard\DevCard\Views\Home\Components\Projects\Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9be030c30e3cf5f30b4340a2e5fec7aa8f120163"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Projects_Projects), @"mvc.1.0.view", @"/Views/Home/Components/Projects/Projects.cshtml")]
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
#line 1 "C:\Users\Emi\Source\Repos\DeveloperCard\DevCard\Views\_ViewImports.cshtml"
using DevCard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emi\Source\Repos\DeveloperCard\DevCard\Views\_ViewImports.cshtml"
using DevCard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be030c30e3cf5f30b4340a2e5fec7aa8f120163", @"/Views/Home/Components/Projects/Projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6b75dc465b0faba9ae06d8c6ded052dbd26de23", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_Projects_Projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DevCard.Models.Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section class=\"featured-section p-3 p-lg-5\">\r\n<div class=\"container\">\r\n<h2 class=\"section-title font-weight-bold mb-5\">خاص ترین پروژه ها</h2>\r\n<div class=\"row\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Emi\Source\Repos\DeveloperCard\DevCard\Views\Home\Components\Projects\Projects.cshtml"
 foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6 mb-5\">\r\n                <div class=\"card project-card\">\r\n                    <div class=\"row no-gutters\">\r\n                        <div class=\"col-lg-4 card-img-holder\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9be030c30e3cf5f30b4340a2e5fec7aa8f1201634573", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 492, "~/assets/images/project/", 492, 24, true);
#nullable restore
#line 15 "C:\Users\Emi\Source\Repos\DeveloperCard\DevCard\Views\Home\Components\Projects\Projects.cshtml"
AddHtmlAttributeValue("", 516, item.IMG, 516, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""col-lg-8"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">
                                    <a href=""project.html"" class=""theme-link"">
                                        ");
#nullable restore
#line 21 "C:\Users\Emi\Source\Repos\DeveloperCard\DevCard\Views\Home\Components\Projects\Projects.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </h5>\r\n                                <p class=\"card-text\">\r\n                                    ");
#nullable restore
#line 25 "C:\Users\Emi\Source\Repos\DeveloperCard\DevCard\Views\Home\Components\Projects\Projects.cshtml"
                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p class=\"card-text\"><small class=\"text-muted\">Client: ");
#nullable restore
#line 27 "C:\Users\Emi\Source\Repos\DeveloperCard\DevCard\Views\Home\Components\Projects\Projects.cshtml"
                                                                                  Write(item.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\Emi\Source\Repos\DeveloperCard\DevCard\Views\Home\Components\Projects\Projects.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n</div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DevCard.Models.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
