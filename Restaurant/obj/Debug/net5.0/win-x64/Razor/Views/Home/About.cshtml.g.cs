#pragma checksum "C:\Users\RTX\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40a12569de980cfb5a90a2d62da7a4257369fcca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a12569de980cfb5a90a2d62da7a4257369fcca", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\RTX\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";
    Layout = "SecondLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""breadcrumb-area bg-img ptb-80"" style=""background-image:url(/assets/img/banner/breath.jpg);"">
    <div class=""container"">
        <div class=""breadcrumb-content text-center"">
            <h3>about us</h3>
            <ul>
                <li>
                    <a href=""/Home/Index"">Home</a>
                </li>
                <li class=""active"">about us </li>
            </ul>
        </div>
    </div>
</div>
<div class=""about-area ptb-95"">
    <div class=""container"">
        <div class=""row d-flex align-items-center"">
            <div class=""col-lg-6"">
                <div class=""about-content pr-30"">
                    ");
#nullable restore
#line 26 "C:\Users\RTX\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Views\Home\About.cshtml"
               Write(Html.Raw(Model.SystemSetting.SystemSettingWelcomeNoteTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 27 "C:\Users\RTX\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Views\Home\About.cshtml"
               Write(Html.Raw(Model.SystemSetting.SystemSettingWelcomeNoteBreef));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"about-peragraph\">\r\n                        <p>");
#nullable restore
#line 29 "C:\Users\RTX\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Views\Home\About.cshtml"
                      Write(Model.SystemSetting.SystemSettingWelcomeNoteDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <div class=\"default-btn-style mt-35\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1110, "\"", 1165, 1);
#nullable restore
#line 31 "C:\Users\RTX\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Views\Home\About.cshtml"
WriteAttributeValue("", 1117, Model.SystemSetting.SystemSettingWelcomeNoteUrl, 1117, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">read more</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"about-img\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "40a12569de980cfb5a90a2d62da7a4257369fcca5814", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1400, "~/images/", 1400, 9, true);
#nullable restore
#line 38 "C:\Users\RTX\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Views\Home\About.cshtml"
AddHtmlAttributeValue("", 1409, Model.SystemSetting.SystemSettingWelcomeNoteImageUrl, 1409, 53, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""services-area pt-100 pb-70 gray-bg"">
    <div class=""container"">
        <div class=""section-title text-center mb-50"">
            <h2>Our Services</h2>
            <p> Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim nostrud exercitation ullamco laboris nisi.</p>
        </div>
        <div class=""row"">
");
#nullable restore
#line 53 "C:\Users\RTX\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Views\Home\About.cshtml"
             foreach(var item in Model.MasterServiceList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-4 col-sm-6 col-12\">\r\n                    <div class=\"single-service text-center mb-30\">\r\n                        ");
#nullable restore
#line 57 "C:\Users\RTX\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Views\Home\About.cshtml"
                   Write(Html.Raw(@item.MasterServiceImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <h3>");
#nullable restore
#line 58 "C:\Users\RTX\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Views\Home\About.cshtml"
                       Write(item.MasterServiceTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p>");
#nullable restore
#line 59 "C:\Users\RTX\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Views\Home\About.cshtml"
                      Write(item.MasterServiceDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 62 "C:\Users\RTX\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Views\Home\About.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
