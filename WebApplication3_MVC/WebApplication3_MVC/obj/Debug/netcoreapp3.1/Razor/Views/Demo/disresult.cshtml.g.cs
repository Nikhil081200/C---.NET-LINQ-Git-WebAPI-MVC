#pragma checksum "C:\Users\Nilesh H. Prasad\source\repos\WebApplication3_MVC\WebApplication3_MVC\Views\Demo\disresult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89c91eb55b44440d141af9442e067db801774311"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_disresult), @"mvc.1.0.view", @"/Views/Demo/disresult.cshtml")]
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
#line 1 "C:\Users\Nilesh H. Prasad\source\repos\WebApplication3_MVC\WebApplication3_MVC\Views\_ViewImports.cshtml"
using WebApplication3_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nilesh H. Prasad\source\repos\WebApplication3_MVC\WebApplication3_MVC\Views\_ViewImports.cshtml"
using WebApplication3_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89c91eb55b44440d141af9442e067db801774311", @"/Views/Demo/disresult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"252178764b989a4ac130b585dab16fe88144f76f", @"/Views/_ViewImports.cshtml")]
    public class Views_Demo_disresult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication3_MVC.ViewModel.Final>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Student Details</h2>\r\n\r\n<table border=\"3px\" style=\"background-color:aqua;\" cellpadding=\"15px\">\r\n    <tr>\r\n        <td colspan=\"2\">Student Details</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Registration Number:</td>\r\n        <td>");
#nullable restore
#line 11 "C:\Users\Nilesh H. Prasad\source\repos\WebApplication3_MVC\WebApplication3_MVC\Views\Demo\disresult.cshtml"
       Write(Model.stuobj.regno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>student Nam:</td>\r\n        <td>");
#nullable restore
#line 15 "C:\Users\Nilesh H. Prasad\source\repos\WebApplication3_MVC\WebApplication3_MVC\Views\Demo\disresult.cshtml"
       Write(Model.stuobj.stname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Student Mail ID:</td>\r\n        <td>");
#nullable restore
#line 19 "C:\Users\Nilesh H. Prasad\source\repos\WebApplication3_MVC\WebApplication3_MVC\Views\Demo\disresult.cshtml"
       Write(Model.stuobj.smailid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Total Marks:</td>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\Nilesh H. Prasad\source\repos\WebApplication3_MVC\WebApplication3_MVC\Views\Demo\disresult.cshtml"
       Write(Model.msobj.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Percentage:</td>\r\n        <td>");
#nullable restore
#line 27 "C:\Users\Nilesh H. Prasad\source\repos\WebApplication3_MVC\WebApplication3_MVC\Views\Demo\disresult.cshtml"
       Write(Model.msobj.percentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Grade:</td>\r\n        <td>");
#nullable restore
#line 31 "C:\Users\Nilesh H. Prasad\source\repos\WebApplication3_MVC\WebApplication3_MVC\Views\Demo\disresult.cshtml"
       Write(Model.msobj.grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication3_MVC.ViewModel.Final> Html { get; private set; }
    }
}
#pragma warning restore 1591
