#pragma checksum "C:\Users\win10pro\source\repos\ASP_Net_CoreMVC\ASP_Net_CoreMVC\Views\Product\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72f0345d5b04955324ee062d7faea2cd6a8c3f12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Update), @"mvc.1.0.view", @"/Views/Product/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Update.cshtml", typeof(AspNetCore.Views_Product_Update))]
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
#line 1 "C:\Users\win10pro\source\repos\ASP_Net_CoreMVC\ASP_Net_CoreMVC\Views\_ViewImports.cshtml"
using ASP_Net_CoreMVC;

#line default
#line hidden
#line 2 "C:\Users\win10pro\source\repos\ASP_Net_CoreMVC\ASP_Net_CoreMVC\Views\_ViewImports.cshtml"
using ASP_Net_CoreMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72f0345d5b04955324ee062d7faea2cd6a8c3f12", @"/Views/Product/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"480594ff11529ebaadaf379775af4b5e041b908b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("SaveUpdate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\win10pro\source\repos\ASP_Net_CoreMVC\ASP_Net_CoreMVC\Views\Product\Update.cshtml"
  
    ViewData["Title"] = "Update";

#line default
#line hidden
            BeginContext(60, 30, true);
            WriteLiteral("\r\n<h2>Update</h2>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(90, 316, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4830735c871f4983b64ca2fe3759d492", async() => {
                BeginContext(130, 40, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 170, "\"", 187, 1);
#line 10 "C:\Users\win10pro\source\repos\ASP_Net_CoreMVC\ASP_Net_CoreMVC\Views\Product\Update.cshtml"
WriteAttributeValue("", 178, Model.Id, 178, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(188, 43, true);
                WriteLiteral(" />\r\n        <input type=\"text\" name=\"Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 231, "\"", 250, 1);
#line 11 "C:\Users\win10pro\source\repos\ASP_Net_CoreMVC\ASP_Net_CoreMVC\Views\Product\Update.cshtml"
WriteAttributeValue("", 239, Model.Name, 239, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(251, 65, true);
                WriteLiteral(" placeholder=\"Name\" />\r\n        <input type=\"number\" name=\"Price\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 316, "\"", 336, 1);
#line 12 "C:\Users\win10pro\source\repos\ASP_Net_CoreMVC\ASP_Net_CoreMVC\Views\Product\Update.cshtml"
WriteAttributeValue("", 324, Model.Price, 324, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(337, 62, true);
                WriteLiteral(" placeholder=\"Price\" />\r\n        <input type=\"submit\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(406, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
