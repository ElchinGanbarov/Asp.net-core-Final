#pragma checksum "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b094df03ccebe7142e9755a0422b43454cdb76fb"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b094df03ccebe7142e9755a0422b43454cdb76fb", @"/Views/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52cebd563a2b98582a8cbd9866c8e8212ef4c809", @"/Views/_ViewImports.cshtml")]
    public class Views_Pages_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo-3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "pages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "about", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("theme-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "aboutus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("item.Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginWriteAttribute("style", " style=\"", 76, "\"", 140, 3);
            WriteAttributeValue("", 84, "background-image:url(/images/", 84, 29, true);
#nullable restore
#line 3 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b094df03ccebe7142e9755a0422b43454cdb76fb7663", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b094df03ccebe7142e9755a0422b43454cdb76fb9644", async() => {
                WriteLiteral("More About Us");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                    <div class=""grid"">
                        <div class=""icon"">
                            <i class=""fi flaticon-money-bag""></i>
                        </div>
                        <h3>Make a Claim</h3>
                  ");
            WriteLiteral(@"      <p>You can claim you money</p>
                    </div>
                    <div class=""grid"">
                        <div class=""icon"">
                            <i class=""fi flaticon-agent""></i>
                        </div>
                        <h3>Find an Agent</h3>
                        <p>Want an agent?</p>
                    </div>
                    <div class=""grid"">
                        <div class=""icon"">
                            <i class=""fi flaticon-cost""></i>
                        </div>
                        <h3>Pay Premium</h3>
                        <p>Pay your premium now</p>
                    </div>
                </div>
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
   ");
            WriteLiteral(@"                 <div class=""fun-fact-grids clearfix"">
                        <div class=""grid"">
                            <div class=""info"">
                                <h3><span class=""odometer"" data-count=""10,50,000"">00</span>+</h3>
                                <p>Insurance Policies Issued</p>
                                <p>A collection of textile samples lay spread out on the table samsa was a travelling</p>
                                <a href=""#"" class=""theme-btn-s3"">Become a customer</a>
                            </div>
                        </div>
                        <div class=""grid"">
                            <div class=""info"">
                                <h3><span class=""odometer"" data-count=""98.75"">00</span>%</h3>
                                <p>Claims paid during FY</p>
                                <p>A collection of textile samples lay spread out on the table samsa was a travelling</p>
                                <a href=""#"" class=""theme-btn");
            WriteLiteral(@"-s3"">Make a claim</a>
                            </div>
                        </div>
                        <div class=""grid"">
                            <div class=""info"">
                                <h3><span class=""odometer"" data-count=""245"">00</span></h3>
                                <p>Offices arround the world</p>
                                <p>A collection of textile samples lay spread out on the table samsa was a travelling</p>
                                <a href=""#"" class=""theme-btn-s3"">Locate a branch</a>
                            </div>
                        </div>
                    </div>
                </div>

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
");
            WriteLiteral(@"                    <div class=""agents-grids clearfix"">
                        <div class=""grid"">
                            <div class=""section-title"">
                                <span>Agents</span>
                                <h2>Our Agents</h2>
                            </div>
                            <div class=""info"">
                                <h3>");
#nullable restore
#line 123 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                               Write(Model.Settings.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <h4>");
#nullable restore
#line 124 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                               Write(Model.Settings.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b094df03ccebe7142e9755a0422b43454cdb76fb16396", async() => {
                WriteLiteral("More About Us");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 128 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                         foreach (var item in Model.Agents)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"grid\">\r\n                                <div class=\"img-holder\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b094df03ccebe7142e9755a0422b43454cdb76fb18356", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6351, "~/uploads/", 6351, 10, true);
#nullable restore
#line 132 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
AddHtmlAttributeValue("", 6361, item.Image, 6361, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"agent-info\">\r\n                                    <h4>");
#nullable restore
#line 135 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <p>");
#nullable restore
#line 136 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                                  Write(item.WorkExperience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 139 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
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
            WriteLiteral("er\">\r\n\r\n                    <div class=\"testimonials-slider-s2\">\r\n");
#nullable restore
#line 223 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                         foreach (var item in Model.Testimonials)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"testimonials-slider-item\">\r\n                                <div class=\"grid\">\r\n                                    <p>");
#nullable restore
#line 227 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                                  Write(item.Review);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <div class=\"quoter\">\r\n                                        <h4>");
#nullable restore
#line 229 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        <span>");
#nullable restore
#line 230 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                                         Write(item.WorkExperience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 234 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"

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
#line 277 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                     foreach (var item in Model.Brands)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"grid\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b094df03ccebe7142e9755a0422b43454cdb76fb24711", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 14029, "~/images/partners/", 14029, 18, true);
#nullable restore
#line 280 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
AddHtmlAttributeValue("", 14047, item.Logo, 14047, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 282 "C:\Users\Admin\Desktop\Asp.net-core-Final\AspFinal\AspFinal\Views\Pages\About.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
