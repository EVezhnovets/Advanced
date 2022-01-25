#pragma checksum "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fb4c3768179714e833c970b2ede2fda6392144f"
// <auto-generated/>
#pragma warning disable 1591
namespace Advanced.Blazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Euheni\Advanced\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Euheni\Advanced\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Euheni\Advanced\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Euheni\Advanced\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Euheni\Advanced\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Euheni\Advanced\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Euheni\Advanced\_Imports.razor"
using Advanced.Models;

#line default
#line hidden
#nullable disable
    public partial class NavLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-3");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 5 "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor"
             foreach (string key in NavLinks.Keys)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "                ");
            __builder.OpenComponent<Advanced.Blazor.MultiNavLink>(10);
            __builder.AddAttribute(11, "class", "btn btn-outline-primary btn-block");
            __builder.AddAttribute(12, "href", 
#nullable restore
#line 8 "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor"
                                     NavLinks[key]

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(14, "DisabledClasses", "btn btn-dark text-light btn-block disabled");
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n                    ");
                __builder2.AddContent(17, 
#nullable restore
#line 11 "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor"
                     key

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(18, "\r\n                ");
            }
            ));
            __builder.AddComponentReferenceCapture(19, (__value) => {
#nullable restore
#line 10 "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor"
                                    Refs[key] = (Advanced.Blazor.MultiNavLink)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 13 "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "            ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-secondary btn-block mt-5 ");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor"
                                                                        ToggleLinks

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "\r\n                Toggle Links\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.AddContent(31, 
#nullable restore
#line 19 "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Euheni\Advanced\Blazor\NavLayout.razor"
       
    public Dictionary<string, string[]> NavLinks
    = new Dictionary<string, string[]> {
        {"People", new string[] {"/people", "/" } },
        {"Departments", new string[] {"/depts", "/departments" } },
        {"Details", new string[] { "/person" } }
    };
    public Dictionary<string, MultiNavLink> Refs
        = new Dictionary<string, MultiNavLink>();
    private bool LinksEnabled = true;
    public void ToggleLinks()
    {
        LinksEnabled = !LinksEnabled;
        foreach (MultiNavLink link in Refs.Values)
        {
            link.SetEnabled(LinksEnabled);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
