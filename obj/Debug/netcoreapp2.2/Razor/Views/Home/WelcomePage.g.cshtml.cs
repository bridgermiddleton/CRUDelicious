#pragma checksum "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/CRUDelicious/Views/Home/WelcomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a0a03ca98f90a85d5b9ba5f45aa1d5d763d47f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WelcomePage), @"mvc.1.0.view", @"/Views/Home/WelcomePage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/WelcomePage.cshtml", typeof(AspNetCore.Views_Home_WelcomePage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a0a03ca98f90a85d5b9ba5f45aa1d5d763d47f7", @"/Views/Home/WelcomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WelcomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dishes>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 195, true);
            WriteLiteral("<div class=\"container\">\n    <h1 class=\"display-2\">Welcome to CRUDelicious</h1>\n    <div class=\"row\">\n        <div class=\"col\">\n            <h5>Check out some recent dishes!</h5>\n            <hr>\n");
            EndContext();
#line 8 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/CRUDelicious/Views/Home/WelcomePage.cshtml"
             foreach (Dishes dish in @Model)
            {

#line default
#line hidden
            BeginContext(275, 21, true);
            WriteLiteral("                <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 296, "\"", 316, 2);
            WriteAttributeValue("", 303, "/", 303, 1, true);
#line 10 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/CRUDelicious/Views/Home/WelcomePage.cshtml"
WriteAttributeValue("", 304, dish.DishId, 304, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(317, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(319, 9, false);
#line 10 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/CRUDelicious/Views/Home/WelcomePage.cshtml"
                                      Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(328, 8, true);
            WriteLiteral("</a> by ");
            EndContext();
            BeginContext(337, 9, false);
#line 10 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/CRUDelicious/Views/Home/WelcomePage.cshtml"
                                                        Write(dish.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(346, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 11 "/Users/bridgermiddleton/Desktop/coding_dojo/C#/ORMs/Projects/CRUDelicious/Views/Home/WelcomePage.cshtml"
            }

#line default
#line hidden
            BeginContext(365, 128, true);
            WriteLiteral("            \n        </div>\n        <div class=\"col\">\n            <a href=\"/new\">Add a Dish</a>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dishes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
