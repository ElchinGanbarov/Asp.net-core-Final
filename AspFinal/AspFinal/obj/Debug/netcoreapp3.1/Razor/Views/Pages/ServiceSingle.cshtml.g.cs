#pragma checksum "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "667dc415a55fdca469f0ea84dcf0626dbdbc30e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_ServiceSingle), @"mvc.1.0.view", @"/Views/Pages/ServiceSingle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"667dc415a55fdca469f0ea84dcf0626dbdbc30e5", @"/Views/Pages/ServiceSingle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52cebd563a2b98582a8cbd9866c8e8212ef4c809", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_ServiceSingle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/service-single/img-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginWriteAttribute("style", " style=\"", 76, "\"", 140, 3);
            WriteAttributeValue("", 84, "background-image:url(/images/", 84, 29, true);
#nullable restore
#line 3 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
WriteAttributeValue("", 113, Model.Settings.CoverImage, 113, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 139, ")", 139, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""page-title-container"">
        <div class=""page-title-wrapper"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col col-xs-12"">
                        <h2>Service single</h2>
                        <ol class=""breadcrumb"">
                            <li><a href=""index.html"">Home</a></li>
                            <li>Service single</li>
                        </ol>
                    </div>
                </div> <!-- end row -->
            </div> <!-- end container -->
        </div>
    </div>
</section>
<!-- end page-title -->
<!-- start service-single-section -->
<section class=""service-single-section section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""service-single-tab"">
                    <ul class=""nav tab-links clearfix"">
                        <li class=""active"">
                            <a href=""#01234"" ");
            WriteLiteral("data-toggle=\"tab\">\r\n                                <i class=\"fi flaticon-car\"></i>\r\n                                <h3>Life insurance</h3>\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 34 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
                         foreach (var category in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1536, "\"", 1556, 2);
            WriteAttributeValue("", 1543, "#", 1543, 1, true);
#nullable restore
#line 37 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
WriteAttributeValue("", 1544, category.Id, 1544, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\">\r\n                                    <i");
            BeginWriteAttribute("class", " class=\"", 1616, "\"", 1638, 1);
#nullable restore
#line 38 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
WriteAttributeValue("", 1624, category.Logo, 1624, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                    <h3>");
#nullable restore
#line 39 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
                                   Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 42 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </ul>

                    <div class=""tab-content"">
                        <div class=""tab-pane fade in active"" id=""01234"">
                            <div class=""content-area clearfix"">
                                <div class=""grid info-grid"">
                                    <h3>Life Insurance</h3>
                                    <p>Samsa was a travelling salesman - and above it there hung a picture that he had recently cut out of an illustrated magazine and housed in a nice, gilded frame. It showed a lady fitted out with a fur hat and fur boa who sat upright, raising a heavy fur muff that covered the whole of her lower arm towards the viewer. Gregor then turned to look out the window at the dull weather</p>
                                    <p><strong>Samsa was a travelling salesman and above it there hung a picture that he had recently cut out of an illustrated magazine</strong></p>
                                    <table>
                                   ");
            WriteLiteral(@"     <tbody>
                                            <tr>
                                                <td>Payment:</td>
                                                <td>from $15.000 to $1.000.000</td>
                                            </tr>
                                            <tr>
                                                <td>Grace Period:</td>
                                                <td>up to 30 days</td>
                                            </tr>
                                            <tr>
                                                <td>Support:</td>
                                                <td>24 hours</td>
                                            </tr>
                                            <tr>
                                                <td>Policy Modification:</td>
                                                <td>Online</td>
                                            </tr>
                                ");
            WriteLiteral(@"            <tr>
                                                <td>Number of people:</td>
                                                <td>Max 5</td>
                                            </tr>
                                            <tr>
                                                <td>Location:</td>
                                                <td>Dubai</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <div class=""grid"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "667dc415a55fdca469f0ea84dcf0626dbdbc30e510731", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("alt", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
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
                            <div class=""bottom-info"">
                                <div class=""text"">
                                    <h4>Samsa was a travelling salesman and above it there hung a picture that he had recently cut out of an illustrated magazine</h4>
                                    <p>Samsa was a travelling salesman - and above it there hung a picture that he had recently cut out of an illustrated magazine and housed in a nice, gilded frame. It showed a lady fitted out with a fur hat and fur boa who sat upright, raising a heavy fur muff that covered the whole of her lower arm towards the viewer. Gregor then turned to look out the window at the dull weather</p>
                                </div>
                                <div class=""pdf-dwn-area"">
                                    <a href=""#"">
                                        <i class=""ti-receipt""></i>
                              ");
            WriteLiteral(@"          <h5>General Insurance Conditions</h5>
                                        <p>Document size: 34kb</p>
                                    </a>
                                </div>
                            </div>
                            <div class=""features-grid clearfix"">
                                <div class=""grid"">
                                    <div class=""icon"">
                                        <i class=""fi flaticon-house""></i>
                                    </div>
                                    <h3>House protected</h3>
                                    <p>Window at the dull weather</p>
                                </div>
                                <div class=""grid"">
                                    <div class=""icon"">
                                        <i class=""fi flaticon-umbrella-1""></i>
                                    </div>
                                    <h3>Helth protected</h3>
                             ");
            WriteLiteral(@"       <p>Window at the dull weather</p>
                                </div>
                                <div class=""grid"">
                                    <div class=""icon"">
                                        <i class=""fi flaticon-cost""></i>
                                    </div>
                                    <h3>Small Premium</h3>
                                    <p>Window at the dull weather</p>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 153 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
                         foreach (var category in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"tab-pane fade\"");
            BeginWriteAttribute("id", " id=\"", 8849, "\"", 8866, 1);
#nullable restore
#line 155 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
WriteAttributeValue("", 8854, category.Id, 8854, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"content-area clearfix\">\r\n                                    <div class=\"grid info-grid\">\r\n                                        <h3>");
#nullable restore
#line 158 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
                                       Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        <p>");
#nullable restore
#line 159 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
                                      Write(Html.Raw(@category.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <table>\r\n                                            <tbody>\r\n");
#nullable restore
#line 162 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
                                                 foreach (var item in category.CategorySpecs)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td>");
#nullable restore
#line 165 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
                                                       Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 166 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
                                                       Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 168 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                                            </tbody>\r\n                                        </table>\r\n                                    </div>\r\n                                    <div class=\"grid\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "667dc415a55fdca469f0ea84dcf0626dbdbc30e518114", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 11336, "~/uploads/", 11336, 10, true);
#nullable restore
#line 194 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
AddHtmlAttributeValue("", 11346, category.Image, 11346, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 194 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
AddHtmlAttributeValue("", 11368, category.Image, 11368, 15, false);

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
                                <div class=""bottom-info"">
                                    <div class=""text"">
                                        <h4>Samsa was a travelling salesman and above it there hung a picture that he had recently cut out of an illustrated magazine</h4>
                                        <p>Samsa was a travelling salesman - and above it there hung a picture that he had recently cut out of an illustrated magazine and housed in a nice, gilded frame. It showed a lady fitted out with a fur hat and fur boa who sat upright, raising a heavy fur muff that covered the whole of her lower arm towards the viewer. Gregor then turned to look out the window at the dull weather</p>
                                    </div>
                                    <div class=""pdf-dwn-area"">
                                        <a href=""#"">
                                            <i class=""ti-recei");
            WriteLiteral(@"pt""></i>
                                            <h5>General Insurance Conditions</h5>
                                            <p>Document size: 34kb</p>
                                        </a>
                                    </div>
                                </div>
                                <div class=""features-grid clearfix"">
                                    <div class=""grid"">
                                        <div class=""icon"">
                                            <i class=""fi flaticon-house""></i>
                                        </div>
                                        <h3>House protected</h3>
                                        <p>Window at the dull weather</p>
                                    </div>
                                    <div class=""grid"">
                                        <div class=""icon"">
                                            <i class=""fi flaticon-umbrella-1""></i>
                               ");
            WriteLiteral(@"         </div>
                                        <h3>Helth protected</h3>
                                        <p>Window at the dull weather</p>
                                    </div>
                                    <div class=""grid"">
                                        <div class=""icon"">
                                            <i class=""fi flaticon-cost""></i>
                                        </div>
                                        <h3>Small Premium</h3>
                                        <p>Window at the dull weather</p>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 234 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div> <!-- end container -->
</section>
<!-- end service-single-section -->
<!-- start testimonials-section-s2 -->
<section class=""testimonials-section-s2 section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""section-title"">
                    <span>Testimonials</span>
                    <h2>What People Says About Us</h2>
                </div>

                <div class=""testimonials-s2-nav"">
                    <div class=""slider-s2-arrows"">
                        <div class=""slider-prev""><i class=""fi flaticon-left-arrow-angle-big-gross-symbol""></i></div>
                        <div class=""slider-next""><i class=""fi flaticon-arrow-angle-pointing-to-right""></i></div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-8"">
                <div class=""testimonials-sli");
            WriteLiteral("der-holder\">\r\n                    <div class=\"testimonials-slider-s2\">\r\n");
#nullable restore
#line 567 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
                         foreach (var item in Model.Testimonials)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"testimonials-slider-item\">\r\n                                <div class=\"grid\">\r\n                                    <p>");
#nullable restore
#line 571 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
                                  Write(item.Review);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <div class=\"quoter\">\r\n                                        <h4>");
#nullable restore
#line 573 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        <span>");
#nullable restore
#line 574 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"
                                         Write(item.WorkExperience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 578 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\ServiceSingle.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div> <!-- end container -->\r\n</section>\r\n<!-- end testimonials-section-s2 -->\r\n");
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
