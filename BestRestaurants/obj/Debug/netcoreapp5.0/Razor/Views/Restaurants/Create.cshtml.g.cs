#pragma checksum "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c8743441469b67c7968fa8a7aa6c03d284f29ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Create), @"mvc.1.0.view", @"/Views/Restaurants/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c8743441469b67c7968fa8a7aa6c03d284f29ab", @"/Views/Restaurants/Create.cshtml")]
    public class Views_Restaurants_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurants.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h4>Add a new Restaurant</h4>\n");
#nullable restore
#line 8 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.LabelFor(model => model.Address));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.TextBoxFor(model => model.Address));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.LabelFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.TextBoxFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.Label("Select cuisine"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.DropDownList("CuisineId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Add new restaurant\" class=\"btn btn-danger\" />\n");
#nullable restore
#line 21 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 22 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/Create.cshtml"
Write(Html.ActionLink("Show all restaurants", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurants.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
