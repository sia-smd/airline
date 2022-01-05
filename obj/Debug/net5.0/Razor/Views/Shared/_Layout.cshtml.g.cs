#pragma checksum "E:\work\airline\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f67fcba0a9843faf440f1547bf2b043c3df8b0a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "E:\work\airline\Views\_ViewImports.cshtml"
using airline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\work\airline\Views\_ViewImports.cshtml"
using airline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f67fcba0a9843faf440f1547bf2b043c3df8b0a3", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0171f88d7e102ccbf1d6d96a8718b43396fca6b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("direction: rtl; font-family: iransans;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html >\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f67fcba0a9843faf440f1547bf2b043c3df8b0a33513", async() => {
                WriteLiteral(@"
<!-- basic -->
<meta charset=""utf-8"">
<meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<!-- mobile metas -->
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<meta name=""viewport"" content=""initial-scale=1, maximum-scale=1"">
<!-- site metas -->
<title>Airline</title>
<meta name=""keywords""");
                BeginWriteAttribute("content", " content=\"", 425, "\"", 435, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n<meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 463, "\"", 473, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n<meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 496, "\"", 506, 0);
                EndWriteAttribute();
                WriteLiteral(@">	
<!-- bootstrap css -->
<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.7.2/font/bootstrap-icons.css"">
<link rel=""stylesheet"" type=""text/css"" href=""/css/bootstrap.min.css"">
<!-- style css -->
<link rel=""stylesheet"" type=""text/css"" href=""/css/style.css"">
<!-- Responsive-->
<link rel=""stylesheet"" href=""/css/responsive.css"">
<!-- fevicon -->
<link rel=""icon"" href=""images/fevicon.png"" type=""image/gif"" />
<!-- Scrollbar Custom CSS -->
<link rel=""stylesheet"" href=""css/jquery.mCustomScrollbar.min.css"">
<!-- Tweaks for older IEs-->
<link rel=""stylesheet"" href=""https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css"">
<!-- owl stylesheets --> 

<link rel=""stylesheet"" href=""css/owl.carousel.min.css"">
<link rel=""stylesheet"" href=""css/owl.theme.default.min.css"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.css"" media=""screen"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f67fcba0a9843faf440f1547bf2b043c3df8b0a36415", async() => {
                WriteLiteral(@"
	<!-- header section start -->
	<div class=""header_section"">
		<div class=""container"">
			<div class=""row"">
				<div class=""col-sm-12 col-lg-3"">
					<div class=""logo""><a href=""index.html""><img src=""images/logo.png""></a></div>
				</div>
				<div class=""col-sm-6"">
					<nav class=""navbar navbar-expand-lg navbar-light bg-light"">
                        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNavAltMarkup"" aria-controls=""navbarNavAltMarkup"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                        </button>
                    <div class=""collapse navbar-collapse"" id=""navbarNavAltMarkup"">
                        <div class=""navbar-nav"">
                           <a class=""nav-item nav-link"" href=""index.html"">Home</a>
                           <a class=""nav-item nav-link"" href=""browse ads.html"">Browse ads</a>
                           <a class=""nav-item nav-li");
                WriteLiteral(@"nk"" href=""about.html"">About</a>
                           <a class=""nav-item nav-link"" href=""clients.html"">Clients</a>
                           <a class=""nav-item nav-link"" href=""contact.html"">Contact</a>
                        </div>
                    </div>
                    </nav>
				</div>
				<div class=""col-sm-6 col-lg-3"">
					<div class=""search_main"">
                    <button class=""submit_bt""><a href=""#""><span class=""doctor""><img src=""images/doctor-icon.png""></span>Submit ads</a></button>
				    </div>
				</div>
			</div>
		</div>
	</div>
	<!-- header section end -->
    ");
#nullable restore
#line 69 "E:\work\airline\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
    <!-- footer section start -->
	<div class=""layout_padding footer_section"">
		<div class=""container"">
			<div class=""row"">
				<div class=""col-sm-6 col-md-6 col-lg-3"">
					<div><img src=""images/footer-logo.png""></div>
					<p class=""dolor_text"">dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et sdolor sit amet,</p>
				</div>
				<div class=""col-sm-6 col-md-6 col-lg-3"">
					<h1 class=""quick_text"">Quick links</h1>
					<div class=""chevron_arrow""><img src=""images/chevron-arrow.png""><span class=""padding-left"">Join Us</span></div>
					<div class=""chevron_arrow""><img src=""images/chevron-arrow.png""><span class=""padding-left"">Maintenance</span></div>
					<div class=""chevron_arrow""><img src=""images/chevron-arrow.png""><span class=""padding-left"">Language Packs</span></div>
					<div class=""chevron_arrow""><img src=""images/chevron-arrow.png""><span class=""padding-left"">LearnPress</span></div>
					<div class=""chevron_arrow""><img src=""images/chevron-arrow.png""");
                WriteLiteral(@"><span class=""padding-left"">Release Status</span></div>
				</div>
				<div class=""col-sm-6 col-md-6 col-lg-3"">
					<h1 class=""subscribe_text"">Subcribe email</h1>
					<p class=""ipsum_text"">Lorem ipsum dolor sit amet, consectetur adipiscing elit,</p>
					<input type=""text"" class=""email_text"" placeholder=""Your Email"" name=""Name"">
					<button class=""submit_text"">Submit</button>
				</div>
				<div class=""col-sm-6 col-md-6 col-lg-3"">
					<h1 class=""quick_text"">Contact Us</h1>
					<div class=""map_flag""><img src=""images/map-flag.png""><span class=""padding-left"">London 145 United Kingdom</span></div>
					<div class=""dolor_text""><img src=""images/email-icon.png""><span class=""padding-left"">adsiter@gmail.com</span></div>
					<div class=""dolor_text""><img src=""images/phone-icon.png""><span class=""padding-left"">+12586954775</span></div>
				</div>
			</div>
		</div>
	</div>
	<!-- footer section end -->
	<!-- copyright section start -->
    <div class=""copyright"">
    	<p class=""copyright_text"">201");
                WriteLiteral(@"9 All Rights Reserved. Design By <a href=""https://html.design""> Free Html Templates</p>
    </div>
	<!-- copyright section end -->
      <!-- Javascript files-->
      <script src=""js/jquery.min.js""></script>
      <script src=""js/popper.min.js""></script>
      <script src=""js/bootstrap.bundle.min.js""></script>
      <script src=""js/jquery-3.0.0.min.js""></script>
      <script src=""js/plugin.js""></script>
      <!-- sidebar -->
      <script src=""js/jquery.mCustomScrollbar.concat.min.js""></script>
      <script src=""js/custom.js""></script>
      <!-- javascript --> 
      <script src=""js/owl.carousel.js""></script>
      <script src=""https:cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.js""></script>
      <script>
         $(document).ready(function(){
         $("".fancybox"").fancybox({
         openEffect: ""none"",
         closeEffect: ""none""
         });
         
         $("".zoom"").hover(function(){
         
         $(this).addClass('transition');
         }, f");
                WriteLiteral("unction(){\r\n         \r\n         $(this).removeClass(\'transition\');\r\n         });\r\n         });\r\n         \r\n      </script> \r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
