#pragma checksum "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "663d74351e47cdf91bfd91d6e17486d3fa9e51f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_About), @"mvc.1.0.view", @"/Views/Pages/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"663d74351e47cdf91bfd91d6e17486d3fa9e51f0", @"/Views/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52cebd563a2b98582a8cbd9866c8e8212ef4c809", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspFinal.Models.AboutUsFolder.AboutUsViewModel>
    {
        private global::AspNetCore.Views_Pages_About.__Generated__TestmonialViewComponentTagHelper __TestmonialViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "pages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "about", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("theme-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("item.Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- start page-title -->\r\n<section class=\"page-title\"");
            BeginWriteAttribute("style", " style=\"", 109, "\"", 174, 3);
            WriteAttributeValue("", 117, "background-image:url(/uploads/", 117, 30, true);
#nullable restore
#line 3 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
WriteAttributeValue("", 147, Model.Settings.CoverImage, 147, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 173, ")", 173, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""page-title-container"">
        <div class=""page-title-wrapper"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col col-xs-12"">
                        <h2>About us</h2>
                        <ol class=""breadcrumb"">
                            <li><a href=""index.html"">Home</a></li>
                            <li>About us</li>
                        </ol>
                    </div>
                </div> <!-- end row -->
            </div> <!-- end container -->
        </div>
    </div>
</section>
<!-- end page-title -->
<!-- start about-section-s4 -->
<section class=""about-section-s4 section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-md-3"">
                <div class=""section-title mt"">
                    <span>About us</span>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "663d74351e47cdf91bfd91d6e17486d3fa9e51f06839", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1098, "~/uploads/", 1098, 10, true);
#nullable restore
#line 28 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
AddHtmlAttributeValue("", 1108, Model.Settings.Logo2, 1108, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 28 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
AddHtmlAttributeValue("", 1136, Model.Settings.Logo2, 1136, 21, false);

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
            WriteLiteral("\r\n                </div>\r\n                <div class=\"info\">\r\n                    <h3>");
#nullable restore
#line 31 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                   Write(Model.Settings.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h4>");
#nullable restore
#line 32 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                   Write(Model.Settings.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "663d74351e47cdf91bfd91d6e17486d3fa9e51f09453", async() => {
                WriteLiteral("More About Us");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            <div class=""col col-md-5"">
                <div class=""details-text mt"">
                    <h4>Since 1950, we are providing the insurance solution for our client’s and  we are very successfull about</h4>
                    <p>It showed a lady fitted out with a fur hat and fur boa who sat upright, raising a heavy fur muff that covered the whole of her lower arm towards the viewer. Gregor then turned to look outIt showed a lady fitted out with a fur hat and fur boa who sat upright, raising a heavy fur muff that covered the whole of her lower arm towards the viewer</p>
                </div>
            </div>
            <div class=""col col-md-4"">
                <div class=""features-grid clearfix"">
");
#nullable restore
#line 44 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                     foreach (var item in Model.AboutUs.AboutClaims)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"grid\">\r\n                            <div class=\"icon\">\r\n                                <i");
            BeginWriteAttribute("class", " class=\"", 2420, "\"", 2443, 1);
#nullable restore
#line 48 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
WriteAttributeValue("", 2428, item.ClaimLogo, 2428, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                            </div>\r\n                            <h3>");
#nullable restore
#line 50 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                           Write(item.ClaimSubtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 51 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                          Write(item.ClaimSubtext);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n");
#nullable restore
#line 53 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div> <!-- end container -->
</section>
<!-- end about-section-s4 -->
<!-- stat fun-fact-section -->
<section class=""fun-fact-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""fun-fact-area"">
                    <div class=""fun-fact-grids clearfix"">
");
#nullable restore
#line 82 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                         foreach (var item in Model.AboutUs.AboutPolicies)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"grid\">\r\n                                <div class=\"info\">\r\n                                    <h3><span class=\"odometer\" data-count=\"");
#nullable restore
#line 86 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                                                                      Write(item.PolicyCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">00</span>+</h3>\r\n                                    <p>");
#nullable restore
#line 87 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                                  Write(item.PolicySubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p>");
#nullable restore
#line 88 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                                  Write(item.PolicySubText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <a href=\"#\" class=\"theme-btn-s3\">");
#nullable restore
#line 89 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                                                                Write(item.ActionText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 92 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                </div>

            </div>
        </div>
    </div> <!-- end container -->
</section>
<!-- end fun-fact-section -->
<!-- start agents-section -->
<section class=""agents-section p-b-0 section-padding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""agents-area-with-title"">
                    <div class=""agents-grids clearfix"">
                        <div class=""grid"">
                            <div class=""section-title"">
                                <span>Agents</span>
                                <h2>Our Agents</h2>
                            </div>
                            <div class=""info"">
                                <h3>");
#nullable restore
#line 131 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                               Write(Model.Settings.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <h4>");
#nullable restore
#line 132 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                               Write(Model.Settings.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "663d74351e47cdf91bfd91d6e17486d3fa9e51f017325", async() => {
                WriteLiteral("More About Us");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 136 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                         foreach (var item in Model.Agents)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"grid\">\r\n                                <div class=\"img-holder\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "663d74351e47cdf91bfd91d6e17486d3fa9e51f019285", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6672, "~/uploads/", 6672, 10, true);
#nullable restore
#line 140 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
AddHtmlAttributeValue("", 6682, item.Image, 6682, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"agent-info\">\r\n                                    <h4>");
#nullable restore
#line 143 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <p>");
#nullable restore
#line 144 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                                  Write(item.WorkExperience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 147 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div> <!-- end container -->
</section>
<!-- end agents-section -->
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
                <div class=""testimonials-slider-hold");
            WriteLiteral("er\">\r\n                    <div class=\"testimonials-slider-s2\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:testmonial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "663d74351e47cdf91bfd91d6e17486d3fa9e51f023051", async() => {
            }
            );
            __TestmonialViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Pages_About.__Generated__TestmonialViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__TestmonialViewComponentTagHelper);
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
    </div> <!-- end container -->
</section>
<!-- end testimonials-section-s2 -->
<!-- start partners-section -->
<section class=""partners-section"">
    <h2 class=""hidden"">Partners</h2>
    <div class=""container"">
        <div class=""row"">
            <div class=""col col-xs-12"">
                <div class=""partner-grids partners-slider"">
");
#nullable restore
#line 191 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                     foreach (var item in Model.Brands)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"grid\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "663d74351e47cdf91bfd91d6e17486d3fa9e51f024766", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8784, "~/uploads/", 8784, 10, true);
#nullable restore
#line 194 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
AddHtmlAttributeValue("", 8794, item.Logo, 8794, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 194 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
AddHtmlAttributeValue("", 8811, item.Logo, 8811, 10, false);

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
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 196 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div> <!-- end container -->\r\n</section>\r\n<!-- end partners-section -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspFinal.Models.AboutUsFolder.AboutUsViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:testmonial")]
        public class __Generated__TestmonialViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__TestmonialViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("Testmonial", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
