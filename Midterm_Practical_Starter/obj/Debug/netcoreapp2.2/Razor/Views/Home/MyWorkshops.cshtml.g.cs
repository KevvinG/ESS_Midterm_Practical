#pragma checksum "C:\Users\Kevin\Desktop\Midterm_Practical_Starter\Midterm_Practical_Starter\Views\Home\MyWorkshops.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d76c7bfff31123e8b85f160ea25f911086a3ed9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MyWorkshops), @"mvc.1.0.view", @"/Views/Home/MyWorkshops.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MyWorkshops.cshtml", typeof(AspNetCore.Views_Home_MyWorkshops))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d76c7bfff31123e8b85f160ea25f911086a3ed9", @"/Views/Home/MyWorkshops.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MyWorkshops : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Midterm_Practical_Starter.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Kevin\Desktop\Midterm_Practical_Starter\Midterm_Practical_Starter\Views\Home\MyWorkshops.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(202, 241, true);
            WriteLiteral("\r\n<div id=\"jumbo\" class=\"jumbotron\">\r\n    <h1 class=\"text-center\">My Workshops Page</h1>\r\n    <p class=\"text-center\">Below is a sample bootstrap table to change before submission (time allowing)</p>\r\n    <p class=\"text-center\">Welcome user: ");
            EndContext();
            BeginContext(444, 11, false);
#line 12 "C:\Users\Kevin\Desktop\Midterm_Practical_Starter\Midterm_Practical_Starter\Views\Home\MyWorkshops.cshtml"
                                    Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(455, 790, true);
            WriteLiteral(@"</p>
</div>

<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">First</th>
            <th scope=""col"">Last</th>
            <th scope=""col"">Handle</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope=""row"">1</th>
            <td>Mark</td>
            <td>Otto</td>
            <td>mdo</td>
        </tr>
        <tr>
            <th scope=""row"">2</th>
            <td>Jacob</td>
            <td>Thornton</td>
            <td>fat</td>
        </tr>
        <tr>
            <th scope=""row"">3</th>
            <td>Larry</td>
            <td>the Bird</td>
            <td>twitter</td>
        </tr>
    </tbody>
    <button>Drop All Workshops</button>
</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Midterm_Practical_Starter.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
