#pragma checksum "C:\projects2\TheCause\Views\Shared\_SignPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6119e53d80cb22313fdc488bf7565323a8532ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SignPartial), @"mvc.1.0.view", @"/Views/Shared/_SignPartial.cshtml")]
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
#line 1 "C:\projects2\TheCause\Views\_ViewImports.cshtml"
using TheCause;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects2\TheCause\Views\_ViewImports.cshtml"
using TheCause.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6119e53d80cb22313fdc488bf7565323a8532ed", @"/Views/Shared/_SignPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a760dfa3e8df292019821c903be54a252c8448", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__SignPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TheCause.Models.Sign>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\projects2\TheCause\Views\Shared\_SignPartial.cshtml"
   foreach (var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"bg-light m-4 p-2\">\r\n        <h6> ");
#nullable restore
#line 9 "C:\projects2\TheCause\Views\Shared\_SignPartial.cshtml"
        Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n            </div>\r\n");
#nullable restore
#line 12 "C:\projects2\TheCause\Views\Shared\_SignPartial.cshtml"

 }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TheCause.Models.Sign>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
