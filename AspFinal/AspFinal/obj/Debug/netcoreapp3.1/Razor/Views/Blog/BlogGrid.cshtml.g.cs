#pragma checksum "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Blog\BlogGrid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "320918b1e12f19043b49ebc155f54a5ecff9aa5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogGrid), @"mvc.1.0.view", @"/Views/Blog/BlogGrid.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\_ViewImports.cshtml"
using AspFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\_ViewImports.cshtml"
using AspFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\_ViewImports.cshtml"
using Repository.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\_ViewImports.cshtml"
using AspFinal.Models.Contact;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\_ViewImports.cshtml"
using AspFinal.Areas.Admin.Models.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"320918b1e12f19043b49ebc155f54a5ecff9aa5c", @"/Views/Blog/BlogGrid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52cebd563a2b98582a8cbd9866c8e8212ef4c809", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogGrid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
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
            WriteLiteral("<!-- start page-title -->\r\n<section class=\"page-title\"");
            BeginWriteAttribute("style", " style=\"", 76, "\"", 154, 3);
            WriteAttributeValue("", 84, "background-image:url(/uploads/", 84, 30, true);
#nullable restore
#line 3 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Blog\BlogGrid.cshtml"
WriteAttributeValue("", 114, Model.Settings.ElementAt(0).CoverImage, 114, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 153, ")", 153, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""page-title-container"">
        <div class=""page-title-wrapper"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col col-xs-12"">
                        <h2>Grid 4 columns</h2>
                        <ol class=""breadcrumb"">
                            <li><a href=""index.html"">Home</a></li>
                            <li>Grid 4 columns</li>
                        </ol>
                    </div>
                </div> <!-- end row -->
            </div> <!-- end container -->
        </div>
    </div>
</section>
<!-- end page-title -->
<!-- start blog-pg-section -->
<section class=""blog-pg-section blog-grid-4-columns section-padding"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""blog-content clearfix"">
");
#nullable restore
#line 27 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Blog\BlogGrid.cshtml"
                     foreach (var item in Model.Blogs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"post format-standard-image\">\r\n                            <div class=\"entry-media\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "320918b1e12f19043b49ebc155f54a5ecff9aa5c5677", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1289, "~/uploads/", 1289, 10, true);
#nullable restore
#line 31 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Blog\BlogGrid.cshtml"
AddHtmlAttributeValue("", 1299, item.Image, 1299, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Blog\BlogGrid.cshtml"
AddHtmlAttributeValue("", 1317, item.Image, 1317, 11, false);

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
            WriteLiteral("\r\n                            </div>\r\n                            <ul class=\"entry-meta\">\r\n                                <li><a href=\"#\"><i class=\"fi flaticon-tag-1\"></i>");
#nullable restore
#line 34 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Blog\BlogGrid.cshtml"
                                                                            Write(item.ConpanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            </ul>\r\n                            <h3><a href=\"#\">");
#nullable restore
#line 36 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Blog\BlogGrid.cshtml"
                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <p>");
#nullable restore
#line 37 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Blog\BlogGrid.cshtml"
                          Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <a href=\"#\" class=\"theme-btn-s3\">");
#nullable restore
#line 38 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Blog\BlogGrid.cshtml"
                                                        Write(item.ActionText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n");
#nullable restore
#line 40 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Blog\BlogGrid.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    <div class=""pagination-wrapper pagination-wrapper-center"">
                        <ul class=""pg-pagination"">
                            <li>
                                <a href=""#"" aria-label=""Previous"">
                                    <i class=""fi flaticon-back""></i>
                                </a>
                            </li>
                            <li class=""active""><a href=""#"">1</a></li>
                            <li><a href=""#"">2</a></li>
                            <li><a href=""#"">3</a></li>
                            <li>
                                <a href=""#"" aria-label=""Next"">
                                    <i class=""fi flaticon-next""></i>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div> <!-- end container -->
</section>
<!-- end blog-pg-section -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
