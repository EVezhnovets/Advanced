#pragma checksum "C:\Users\Euheni\Advanced\Blazor\PersonDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ef8e76efa38d757d6cb1a4d51bbfa1c88764d38"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/person")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/person/{id:long}")]
    public partial class PersonDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\Euheni\Advanced\Blazor\PersonDisplay.razor"
       

    [Inject]
    public DataContext Context { get; set; }
    [Inject]
    public NavigationManager NavManager { get; set; }

    [Parameter]
    public long Id { get; set; }

    public Person Person { get; set; }

    protected async override Task OnParametersSetAsync()
    {
        await Task.Delay(200);
        Person = await Context.People
        .FirstOrDefaultAsync(p => p.PersonId == Id) ?? new Person();
    }
    public void HandleClick(bool increment)
    {
        Person = null;
        NavManager.NavigateTo($"/person/{(increment ? Id + 1 : Id - 1)}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
