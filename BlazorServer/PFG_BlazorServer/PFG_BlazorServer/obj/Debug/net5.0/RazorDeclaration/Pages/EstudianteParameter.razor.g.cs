// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PFG_BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using PFG_BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using PFG_BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EstudianteParameter.razor"
using PFG_BlazorServer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EstudianteParameter.razor"
using PFG_BlazorServer.Services;

#line default
#line hidden
#nullable disable
    public partial class EstudianteParameter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EstudianteParameter.razor"
       

    public Estudiante estudiante = new();

    protected override void OnInitialized()
    {
        estudiante = new Estudiante ();
    }

    private async Task CreateEstudiante ()
    {
        if (await EstudianteService.InsertEstudiante(estudiante))
            NavigationManager.NavigateTo("/");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEstudianteService EstudianteService { get; set; }
    }
}
#pragma warning restore 1591
