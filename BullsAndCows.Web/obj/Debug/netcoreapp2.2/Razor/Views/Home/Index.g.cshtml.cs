#pragma checksum "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "479525588f1a177baaca9c89c4895e9abc6db5e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\_ViewImports.cshtml"
using BullsAndCows;

#line default
#line hidden
#line 2 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\_ViewImports.cshtml"
using BullsAndCows.Models;

#line default
#line hidden
#line 3 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\_ViewImports.cshtml"
using BullsAndCows.Web;

#line default
#line hidden
#line 1 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Index.cshtml"
using BullsAndCows.Data.Models;

#line default
#line hidden
#line 2 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"479525588f1a177baaca9c89c4895e9abc6db5e5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9dd9cbfcd9924ba8f870196adc3fc1b74e4522d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-primary px-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(181, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(228, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
            BeginContext(271, 116, true);
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1 class=\"display-4 mb-3\">\r\n            Welcome, <span class=\"text-primary\">");
            EndContext();
            BeginContext(388, 18, false);
#line 15 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Index.cshtml"
                                           Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(406, 113, true);
            WriteLiteral("</span>!\r\n        </h1>\r\n        <p class=\"lead font-italic\" style=\"font-size: 2rem;\">Want to play?</p>\r\n        ");
            EndContext();
            BeginContext(519, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "479525588f1a177baaca9c89c4895e9abc6db5e56013", async() => {
                BeginContext(590, 12, true);
                WriteLiteral("Start a game");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(606, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 20 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(632, 229, true);
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1 class=\"display-4 mb-5\">\r\n            Welcome!\r\n        </h1>\r\n        <p class=\"lead font-italic\" style=\"font-size: 2rem;\">Create an account, in order to play the game.</p>\r\n    </div>\r\n");
            EndContext();
#line 29 "C:\Users\volenpopov\Desktop\Project\ASP.NET-BullsAndCows\BullsAndCows.Web\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(864, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<BullsAndCowsUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<BullsAndCowsUser> SignInManager { get; private set; }
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
