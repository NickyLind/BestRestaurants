#pragma checksum "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Review/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "542f3f86f4751be84d1d596b680732ed884cb7f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Review_Details), @"mvc.1.0.view", @"/Views/Review/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"542f3f86f4751be84d1d596b680732ed884cb7f8", @"/Views/Review/Details.cshtml")]
    public class Views_Review_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurants.Models.Review>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Review/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Review Details</h2>\n<hr />\n<h3>");
#nullable restore
#line 9 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Review/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Review/Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n<h3>");
#nullable restore
#line 10 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Review/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 10 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Review/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n<p>");
#nullable restore
#line 11 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Review/Details.cshtml"
Write(Html.ActionLink("Back to restaurant list", "Index", "Restaurants"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 12 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Review/Details.cshtml"
Write(Html.ActionLink("Edit Review", "Edit", new { id = Model.ReviewId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 13 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Review/Details.cshtml"
Write(Html.ActionLink("Delete Review", "Delete", new{ id = Model.ReviewId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurants.Models.Review> Html { get; private set; }
    }
}
#pragma warning restore 1591