// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorForm.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using BlazorForm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/_Imports.razor"
using BlazorForm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/Index.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "/Users/sebastianpoot/VSCodeProjects/BlazorForm/Pages/Index.razor"
      
    
    List<Patient> Patients = new List<Patient>();
    protected override async Task OnInitializedAsync()
    {
        await LoadPatients();
    }
    private async Task LoadPatients()
    {
        Patients = await service.GetPatientAsync();
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PatientServices service { get; set; }
    }
}
#pragma warning restore 1591