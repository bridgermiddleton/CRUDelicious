#pragma checksum "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/CRUDelicious/Views/Home/IndividualDishPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8712e6f516c93a65773247e7eda1189cf62fe3fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndividualDishPage), @"mvc.1.0.view", @"/Views/Home/IndividualDishPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/IndividualDishPage.cshtml", typeof(AspNetCore.Views_Home_IndividualDishPage))]
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
#line 1 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8712e6f516c93a65773247e7eda1189cf62fe3fe", @"/Views/Home/IndividualDishPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndividualDishPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dishes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(15, 87, true);
            WriteLiteral("<div class=\"container\">\n    <a href=\"/\">Home</a>\n    <h1 class=\"display-2 text-center\">");
            EndContext();
            BeginContext(103, 10, false);
#line 4 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/CRUDelicious/Views/Home/IndividualDishPage.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(113, 33, true);
            WriteLiteral("</h1>\n    <p class=\"text-center\">");
            EndContext();
            BeginContext(147, 10, false);
#line 5 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/CRUDelicious/Views/Home/IndividualDishPage.cshtml"
                      Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(157, 41, true);
            WriteLiteral("</p>\n    <hr>\n    <p class=\"text-center\">");
            EndContext();
            BeginContext(199, 17, false);
#line 7 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/CRUDelicious/Views/Home/IndividualDishPage.cshtml"
                      Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(216, 39, true);
            WriteLiteral("</p>\n    <p><strong>Calories:</strong> ");
            EndContext();
            BeginContext(256, 14, false);
#line 8 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/CRUDelicious/Views/Home/IndividualDishPage.cshtml"
                             Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(270, 40, true);
            WriteLiteral("</p>\n    <p><strong>Tastiness:</strong> ");
            EndContext();
            BeginContext(311, 15, false);
#line 9 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/CRUDelicious/Views/Home/IndividualDishPage.cshtml"
                              Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(326, 51, true);
            WriteLiteral("</p>\n    <div class=\"btn-group align-top\">\n        ");
            EndContext();
            BeginContext(377, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8712e6f516c93a65773247e7eda1189cf62fe3fe6185", async() => {
                BeginContext(454, 82, true);
                WriteLiteral("\n            <button class=\"btn btn-danger\" type=\"submit\">Delete</button>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 410, "/ProcessDelete/", 410, 15, true);
#line 11 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/CRUDelicious/Views/Home/IndividualDishPage.cshtml"
AddHtmlAttributeValue("", 425, Model.DishId, 425, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(543, 39, true);
            WriteLiteral("\n    </div>\n    <a class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 582, "\"", 608, 2);
            WriteAttributeValue("", 589, "/edit/", 589, 6, true);
#line 15 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/CRUDelicious/Views/Home/IndividualDishPage.cshtml"
WriteAttributeValue("", 595, Model.DishId, 595, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(609, 17, true);
            WriteLiteral(">Edit</a>\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dishes> Html { get; private set; }
    }
}
#pragma warning restore 1591
