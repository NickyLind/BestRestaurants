#pragma checksum "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/AddCuisine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a414cee4ae01d03596adabb5b7259a155f4b07a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_AddCuisine), @"mvc.1.0.view", @"/Views/Restaurants/AddCuisine.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a414cee4ae01d03596adabb5b7259a155f4b07a1", @"/Views/Restaurants/AddCuisine.cshtml")]
    public class Views_Restaurants_AddCuisine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurants.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/AddCuisine.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("<h2>Add a cuisine</h2>\n<h4>Add a cuisine to this restaurant: ");
#nullable restore
#line 7 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/AddCuisine.cshtml"
                                 Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
#nullable restore
#line 8 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/AddCuisine.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/AddCuisine.cshtml"
Write(Html.HiddenFor(model => model.RestaurantId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/AddCuisine.cshtml"
Write(Html.Label("Select Cuisine"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/AddCuisine.cshtml"
Write(Html.DropDownList("CuisineId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\n");
#nullable restore
#line 14 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/AddCuisine.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 15 "/Users/Nick/Desktop/Epicodus/CSE-week-10/BestRestaurants.Solution/BestRestaurants/Views/Restaurants/AddCuisine.cshtml"
Write(Html.ActionLink("Back to restaurant list", "Index"));

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
