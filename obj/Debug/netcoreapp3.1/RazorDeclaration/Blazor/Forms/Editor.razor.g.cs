#pragma checksum "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71ff7441882f536a47350ddb3dbeb4fa525fbe03"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Advanced.Blazor.Forms
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/forms/edit/{id:long}")]
    public partial class Editor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Euheni\Advanced\Blazor\Forms\Editor.razor"
 
        [Inject]
        public NavigationManager NavManager { get; set; }
        [Inject]
        DataContext Context { get; set; }
        [Parameter]
        public long Id { get; set; }
    public Person PersonData { get; set; } = new Person();
    public IDictionary<string, long> Departments { get; set; }
        = new Dictionary<string, long>();
    public IDictionary<string, long> Locations { get; set; }
        = new Dictionary<string, long>();
    protected async override Task OnParametersSetAsync()
    {
        PersonData = await Context.People.FindAsync(Id);
        Departments = await Context.Departments
        .ToDictionaryAsync(d => d.Name, d => d.Departmentid);
        Locations = await Context.Locations
        .ToDictionaryAsync(l => $"{l.City}, {l.State}", l => l.LocationId);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
