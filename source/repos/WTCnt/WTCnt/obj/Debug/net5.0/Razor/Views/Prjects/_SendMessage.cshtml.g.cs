#pragma checksum "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\Prjects\_SendMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd2d3e5c7e4a17024af2c1f5ffef3a0bfdb413a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prjects__SendMessage), @"mvc.1.0.view", @"/Views/Prjects/_SendMessage.cshtml")]
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
#line 1 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\_ViewImports.cshtml"
using WTCnt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\_ViewImports.cshtml"
using WTCnt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd2d3e5c7e4a17024af2c1f5ffef3a0bfdb413a3", @"/Views/Prjects/_SendMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"558f2fa77e088ad55925468765466d4e9d4eb3dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Prjects__SendMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WTCnt.Models.ProjectsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/chat.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd2d3e5c7e4a17024af2c1f5ffef3a0bfdb413a34093", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dd2d3e5c7e4a17024af2c1f5ffef3a0bfdb413a34355", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd2d3e5c7e4a17024af2c1f5ffef3a0bfdb413a36241", async() => {
                WriteLiteral("\r\n    <div class=\"chat\">\r\n        <h1 class=\"chat__header\">Chat</h1>\r\n        <div class=\"chat__content\">\r\n");
#nullable restore
#line 12 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\Prjects\_SendMessage.cshtml"
             foreach (var item in Model.messages)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\Prjects\_SendMessage.cshtml"
                 if (int.Parse(User.Identities.ToList()[0].Name) == item.User_ID)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"chat__item\">\r\n                        ");
#nullable restore
#line 17 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\Prjects\_SendMessage.cshtml"
                   Write(Html.Raw("<img style='width:50px; height:50px;' alt='photo' class='chat__person - avatar' src=\"data:image/jpeg;base64,"
                                                + Convert.ToBase64String(Model.Users.ToList().Find(u => u.ID == item.User_ID).Photo) + "\" />"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"chat__messages\">\r\n                            <div class=\"chat__message\">\r\n                                <div class=\"chat__message-time\">\r\n                                    ");
#nullable restore
#line 22 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\Prjects\_SendMessage.cshtml"
                               Write(item.TimeSend.ToString("U"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"chat__message-content\">\r\n                                    ");
#nullable restore
#line 25 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\Prjects\_SendMessage.cshtml"
                               Write(item.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 30 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\Prjects\_SendMessage.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"chat__item chat__item--responder\">\r\n                        ");
#nullable restore
#line 34 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\Prjects\_SendMessage.cshtml"
                   Write(Html.Raw("<img style='width:50px; height:50px;' alt='photo' class='chat__person - avatar' src=\"data:image/jpeg;base64,"
                                        + Convert.ToBase64String(Model.Users.ToList().Find(u => u.ID == item.User_ID).Photo) + "\" />"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"chat__messages\">\r\n                            <div class=\"chat__message\">\r\n                                <div class=\"chat__message-time\">\r\n                                    ");
#nullable restore
#line 39 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\Prjects\_SendMessage.cshtml"
                               Write(item.TimeSend.ToString("U"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"chat__message-content\">\r\n                                    ");
#nullable restore
#line 42 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\Prjects\_SendMessage.cshtml"
                               Write(item.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 47 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\Prjects\_SendMessage.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\Prjects\_SendMessage.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WTCnt.Models.ProjectsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
