#pragma checksum "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\SeresProducoes\SeresProducoes\Views\Gallery\Gallery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77054a11a48a922539476cf70bb8c3beef9522ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_Gallery), @"mvc.1.0.view", @"/Views/Gallery/Gallery.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gallery/Gallery.cshtml", typeof(AspNetCore.Views_Gallery_Gallery))]
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
#line 1 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\SeresProducoes\SeresProducoes\Views\_ViewImports.cshtml"
using SeresProducoes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77054a11a48a922539476cf70bb8c3beef9522ed", @"/Views/Gallery/Gallery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05a7cda0f0998f3a456757346bb5f13661fb68e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Gallery_Gallery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Image>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\SeresProducoes\SeresProducoes\Views\Gallery\Gallery.cshtml"
  
    ViewData["Title"] = "Gallery";

#line default
#line hidden
            BeginContext(70, 266, true);
            WriteLiteral(@"<!-- DONE -->
<div style=""background-image: url('../images/clubConcert_.jpg');"">

    <div class=""container pb-3"">
        <div class=""text-center"">
            <h1 class=""display-4 text-primary"">Gallery</h1>
        </div>


        <div class=""gallery"">
");
            EndContext();
#line 15 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\SeresProducoes\SeresProducoes\Views\Gallery\Gallery.cshtml"
             foreach (Image image in Model)
            {

#line default
#line hidden
            BeginContext(396, 20, true);
            WriteLiteral("                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 416, "\"", 438, 1);
#line 17 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\SeresProducoes\SeresProducoes\Views\Gallery\Gallery.cshtml"
WriteAttributeValue("", 422, image.ImagePath, 422, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(439, 25, true);
            WriteLiteral(" width=\"200\" height=\"200\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 464, "\"", 479, 1);
#line 17 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\SeresProducoes\SeresProducoes\Views\Gallery\Gallery.cshtml"
WriteAttributeValue("", 470, image.Id, 470, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(480, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 18 "C:\Users\KKW MOKHETHI\Documents\Code\Projects\ASP.NET Core\Seres Produções\SeresProducoes\SeresProducoes\Views\Gallery\Gallery.cshtml"
            }

#line default
#line hidden
            BeginContext(498, 1695, true);
            WriteLiteral(@"        </div>

        <hr class=""bg-warning"" />

        <h5>Official music videos</h5>
        <div class=""row"">
            <div class=""col"">
                <iframe style=""width:100%; height: 100%;"" src=""https://www.youtube.com/embed/UE3G-9CDCI4"" frameborder=""0"" allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
            </div>
            <!-- width=""560"" height=""315""-->
            <div class=""col"">
                <iframe style=""width:100%; height: 100%;"" src=""https://www.youtube.com/embed/D16zXiGEJi8"" frameborder=""0"" allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen>
                </iframe>
            </div>
        </div>

        <h5>More videos</h5>
        <div class=""row"">
            <div class=""col"">
                <iframe style=""width:100%; height: 100%;"" src=""https://www.youtube.com/embed/t_LQg5nVAd0"" frameborder=""0"" allow=""accelerometer; autoplay; encrypted-media; g");
            WriteLiteral(@"yroscope; picture-in-picture"" allowfullscreen></iframe>
            </div>
            <div class=""col"">
                <iframe style=""width:100%; height: 100%;"" src=""https://www.youtube.com/embed/dgE5biv2M1I"" frameborder=""0"" allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
            </div>
            <div class=""col"">
                <iframe style=""width:100%; height: 100%;"" src=""https://www.youtube.com/embed/jivAL2kF0ws"" frameborder=""0"" allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Image>> Html { get; private set; }
    }
}
#pragma warning restore 1591