#pragma checksum "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\ProjectPerTasks\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f5ac6a5126dba1a10e05611bd2c39518298f245"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProjectPerTasks_Create), @"mvc.1.0.view", @"/Views/ProjectPerTasks/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f5ac6a5126dba1a10e05611bd2c39518298f245", @"/Views/ProjectPerTasks/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"558f2fa77e088ad55925468765466d4e9d4eb3dd", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjectPerTasks_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WTCnt.Models.PpUViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f5ac6a5126dba1a10e05611bd2c39518298f2453950", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f5ac6a5126dba1a10e05611bd2c39518298f2454920", async() => {
                WriteLiteral("\r\n    <h1>Добавление задачи в проект</h1>\r\n\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f5ac6a5126dba1a10e05611bd2c39518298f2455314", async() => {
                    WriteLiteral("\r\n                <input type=\"hidden\" id=\"projectID\" name=\"projectID\"");
                    BeginWriteAttribute("value", " value=\"", 281, "\"", 305, 1);
#nullable restore
#line 13 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\ProjectPerTasks\Create.cshtml"
WriteAttributeValue("", 289, Model.ProjectID, 289, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />
                <div class=""form-group"" style=""text-align:left"">
                    <label class=""control-label"">Задача:</label>
                    <input id=""comment"" name=""comment"" class=""form-control"" />
                </div>
                <div class=""form-group"" style=""text-align:left"">
                    <label class=""control-label"">Сотрудник:</label>
                    <select id=""user"" name=""user"" class=""form-control"">
");
#nullable restore
#line 21 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\ProjectPerTasks\Create.cshtml"
                         foreach (var item in Model.Users)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f5ac6a5126dba1a10e05611bd2c39518298f2456824", async() => {
#nullable restore
#line 23 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\ProjectPerTasks\Create.cshtml"
                                                Write(item.Name);

#line default
#line hidden
#nullable disable
                        WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\ProjectPerTasks\Create.cshtml"
                                                           Write(item.Surname);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\ProjectPerTasks\Create.cshtml"
                               WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\ProjectPerTasks\Create.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                    </select>
                </div>
                <div class=""form-group"">
                    <input type=""submit"" value=""Добавить"" class=""btn btn-primary"" style=""background-color: #5a3c8d""/>
                </div>
                <div>
                    <button type=""button"" class=""btn btn-danger"" style="" margin: 0px 5px 5px 0px""");
                    BeginWriteAttribute("onclick", " onclick=\"", 1317, "\"", 1374, 3);
                    WriteAttributeValue("", 1327, "location.href=\'", 1327, 15, true);
#nullable restore
#line 31 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\ProjectPerTasks\Create.cshtml"
WriteAttributeValue("", 1342, Url.Action("Index", "Prjects"), 1342, 31, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 1373, "\'", 1373, 1, true);
                    EndWriteAttribute();
                    WriteLiteral(">Завершить</button>\r\n                </div>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\alexb\source\repos\WTCnt\WTCnt\Views\ProjectPerTasks\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WTCnt.Models.PpUViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591