#pragma checksum "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f73af826ea34b12008e448844609433a42d7e6eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jobs_Index), @"mvc.1.0.view", @"/Views/Jobs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Jobs/Index.cshtml", typeof(AspNetCore.Views_Jobs_Index))]
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
#line 10 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml"
using JobBoard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f73af826ea34b12008e448844609433a42d7e6eb", @"/Views/Jobs/Index.cshtml")]
    public class Views_Jobs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(23, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f73af826ea34b12008e448844609433a42d7e6eb2966", async() => {
                BeginContext(29, 196, true);
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <title>Add a Job Opening</title>\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n");
                EndContext();
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
            EndContext();
            BeginContext(232, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(233, 491, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f73af826ea34b12008e448844609433a42d7e6eb4333", async() => {
                BeginContext(239, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(268, 9, true);
                WriteLiteral("    <ul>\n");
                EndContext();
#line 12 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml"
     foreach (JobOpening jobOpening in Model)
    {

#line default
#line hidden
                BeginContext(329, 19, true);
                WriteLiteral("        <li>Title: ");
                EndContext();
                BeginContext(349, 21, false);
#line 14 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml"
              Write(jobOpening.GetTitle());

#line default
#line hidden
                EndContext();
                BeginContext(370, 31, true);
                WriteLiteral("</li>\n        <li>Description: ");
                EndContext();
                BeginContext(402, 27, false);
#line 15 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml"
                    Write(jobOpening.GetDescription());

#line default
#line hidden
                EndContext();
                BeginContext(429, 26, true);
                WriteLiteral("</li>\n        <li>Salary: ");
                EndContext();
                BeginContext(456, 19, false);
#line 16 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml"
               Write(jobOpening.GetPay());

#line default
#line hidden
                EndContext();
                BeginContext(475, 6, true);
                WriteLiteral("</li>\n");
                EndContext();
#line 18 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml"
         foreach(KeyValuePair<string, string> entry in @jobOpening.GetContactInfo())
        {

#line default
#line hidden
                BeginContext(577, 16, true);
                WriteLiteral("            <li>");
                EndContext();
                BeginContext(594, 9, false);
#line 20 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml"
           Write(entry.Key);

#line default
#line hidden
                EndContext();
                BeginContext(603, 2, true);
                WriteLiteral(": ");
                EndContext();
                BeginContext(606, 11, false);
#line 20 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml"
                       Write(entry.Value);

#line default
#line hidden
                EndContext();
                BeginContext(617, 6, true);
                WriteLiteral("</li>\n");
                EndContext();
#line 21 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml"
        }

#line default
#line hidden
                BeginContext(633, 16, true);
                WriteLiteral("        <p></p>\n");
                EndContext();
#line 23 "/Users/Guest/Desktop/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml"
    }

#line default
#line hidden
                BeginContext(655, 62, true);
                WriteLiteral("\n\n    </ul>\n    <a href=\"/jobs/new\">Add a new Job Opening</a>\n");
                EndContext();
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
            EndContext();
            BeginContext(724, 102, true);
            WriteLiteral("\n</html>\n\n\n<!-- string title, string description, int pay, string name, string email, string phone -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591