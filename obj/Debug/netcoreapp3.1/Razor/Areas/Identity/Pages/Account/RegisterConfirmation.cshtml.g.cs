#pragma checksum "C:\projects2\TheCause\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21af10a37694f63b40c4d902c5fbaac43a479b50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "C:\projects2\TheCause\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects2\TheCause\Areas\Identity\Pages\_ViewImports.cshtml"
using TheCause.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projects2\TheCause\Areas\Identity\Pages\_ViewImports.cshtml"
using TheCause.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\projects2\TheCause\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using TheCause.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21af10a37694f63b40c4d902c5fbaac43a479b50", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e1b8bb3f5a240e8b271987e7d6cbcc993c07520", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c8b0882063dc3b4898ed28bfdfad485144dfcb0", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\projects2\TheCause\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Register confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <div class=\"container\" style=\"margin-top:150px\">\r\n\r\n<h1 class=\"clearfix mt-5\">");
#nullable restore
#line 11 "C:\projects2\TheCause\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 12 "C:\projects2\TheCause\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    This app does not currently have a real email sender registered, see <a href=\"https://aka.ms/aspaccountconf\">these docs</a> for how to configure a real email sender.\r\n    Normally this would be emailed: <a id=\"confirm-link\"");
            BeginWriteAttribute("href", " href=\"", 497, "\"", 531, 1);
#nullable restore
#line 17 "C:\projects2\TheCause\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
WriteAttributeValue("", 504, Model.EmailConfirmationUrl, 504, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Click here to confirm your account</a>\r\n</p>\r\n");
#nullable restore
#line 19 "C:\projects2\TheCause\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n        Please check your email to confirm your account.\r\n</p>\r\n");
#nullable restore
#line 25 "C:\projects2\TheCause\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
