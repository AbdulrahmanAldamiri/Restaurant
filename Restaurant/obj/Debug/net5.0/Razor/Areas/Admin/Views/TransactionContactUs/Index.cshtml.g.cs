#pragma checksum "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d38144a448ccd63af04117764e26dbbbe5c17a4c34edcfc22c259495cd26c105"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TransactionContactUs_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/TransactionContactUs/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d38144a448ccd63af04117764e26dbbbe5c17a4c34edcfc22c259495cd26c105", @"/Areas/Admin/Views/TransactionContactUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f68c967ecac2dee79a0753fe99077890945878b3e87c560bd67de47177eeb66f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_TransactionContactUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Restaurant.Models.TransactionContactUs>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ToggleActive", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/vendor/jquery-v1.12.4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""pagetitle"">
    <nav>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""/Admin/Home"">Home</a></li>
            <li class=""breadcrumb-item""><a href=""/Admin/TransactionContactUs"">TransactionContactUs</a></li>
            <li class=""breadcrumb-item active"">Index</li>
        </ol>
    </nav>
</div>

<p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d38144a448ccd63af04117764e26dbbbe5c17a4c34edcfc22c259495cd26c1055215", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <div class=\"card\">\r\n            <div class=\"cardbody\">\r\n                <table id=\"DeleteFix\" class=\"table datatable\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransactionContactUsFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransactionContactUsEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransactionContactUsSubject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransactionContactUsMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransactionContactUsFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransactionContactUsEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransactionContactUsSubject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransactionContactUsMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d38144a448ccd63af04117764e26dbbbe5c17a4c34edcfc22c259495cd26c10510237", async() => {
                WriteLiteral("<i class=\"fa-solid fa-pencil\" style=\"font-size:20px;color:saddlebrown\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                                                           WriteLiteral(item.TransactionContactUsId);

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
            WriteLiteral(" |\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d38144a448ccd63af04117764e26dbbbe5c17a4c34edcfc22c259495cd26c10512623", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                                         if (item.IsActive == true)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <i class=\"fa-solid fa-eye\" style=\"font-size:20px;\"></i>\r\n");
#nullable restore
#line 63 "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <i class=\"fa-sharp fa-solid fa-eye-slash\" style=\"color:red;font-size:20px;\"></i>\r\n");
#nullable restore
#line 67 "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                                                                   WriteLiteral(item.TransactionContactUsId);

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
            WriteLiteral(" |\r\n                                    <a class=\"btnDelete\" href=\"#\" data-bs-toggle=\"modal\" data-bs-target=\"#exampleModal\"\r\n                                       data-path=\"");
#nullable restore
#line 70 "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
                                             Write(Url.ActionLink("Index","TransactionContactUs",new{DeleteId=item.TransactionContactUsId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> <i class=\"fa-regular fa-circle-xmark\" style=\"font-size:20px;color:red\"></i> </a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 73 "C:\Users\Abdul\OneDrive\Desktop\Desktop\ASP.NET\2023 02 13 Project\Restaurant\Restaurant\Areas\Admin\Views\TransactionContactUs\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Confirm Deletion</h5>
                <button type=""button"" class=""close"" data-bs-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Are you sure you want to delete?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                <input type=""button"" class=""btn btn-primary"" id=""btnConfirmDelete"" value=""Delete"" />
            </div>
        </div>
    </div>");
            WriteLiteral("\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d38144a448ccd63af04117764e26dbbbe5c17a4c34edcfc22c259495cd26c10518323", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>






    var urlPathDelete = """";
    $(function () {
        //$("".btnDelete"").click(function () {
        //    //alert($(this).data(""path""))
        //    urlPathDelete = $(this).data(""path"");
        //    console.log(urlPathDelete)
        //})
        $(""#DeleteFix tbody"").on(""click"", "".btnDelete"", function () {
            urlPathDelete = $(this).data(""path"");
            //console.log(urlPathDelete);
        });


        $(""#btnConfirmDelete"").click(function () {

            window.location = urlPathDelete;
        })

    });


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Restaurant.Models.TransactionContactUs>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
