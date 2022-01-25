#pragma checksum "C:\Users\Euheni\Advanced\Blazor\TableTemplate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecb26fd3188cf3d726b25ee3d1f689694b38fa03"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class TableTemplate<RowType> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\Euheni\Advanced\Blazor\TableTemplate.razor"
       
    [Parameter]
    public RenderFragment Header { get; set; }
    [Parameter]
    public RenderFragment<RowType> RowTemplate { get; set; }
    [Parameter]
    public IEnumerable<RowType> RowData { get; set; }
    [Parameter]
    public Func<RowType, string> Highlight { get; set; }
    public IEnumerable<string> HighlightChoices() =>
    RowData.Select(item => Highlight(item)).Distinct();
    public string HighlightSelection { get; set; }
    public string IsHighlighted(RowType item) =>
    Highlight(item) == HighlightSelection ? "bg-dark text-white" : "";
    [Parameter]
    public Func<RowType, string> SortDirection { get; set; }
    public string[] SortDirectionChoices =
    new string[] { "Ascending", "Descending" };
    public string SortDirectionSelection { get; set; } = "Ascending";
    public IEnumerable<RowType> SortedData() =>
        SortDirectionSelection == "Ascending"
            ? RowData.OrderBy(SortDirection)
            : RowData.OrderByDescending(SortDirection);

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
