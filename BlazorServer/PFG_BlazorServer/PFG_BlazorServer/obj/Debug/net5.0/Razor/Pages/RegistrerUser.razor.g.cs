#pragma checksum "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\RegistrerUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45adeefde26d027e07151a5f075be77e30692e62"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\RegistrerUser.razor"
using PFG_BlazorServer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\RegistrerUser.razor"
using PFG_BlazorServer.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/registerUser")]
    public partial class RegistrerUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Roles", "Admin, Empresa");
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((ContextEmpresa) => (__builder2) => {
                __builder2.OpenElement(3, "p");
                __builder2.AddContent(4, "HELLO ");
#nullable restore
#line 9 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\RegistrerUser.razor"
__builder2.AddContent(5, ContextEmpresa.User.Identity.Name);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<PFG_BlazorServer.Pages.EmpresaParameter>(7);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(9);
            __builder.AddAttribute(10, "Roles", "Admin, Estudiante");
            __builder.AddAttribute(11, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((contextEstudiante) => (__builder2) => {
                __builder2.OpenElement(12, "p");
                __builder2.AddContent(13, "HELLO ");
#nullable restore
#line 16 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\RegistrerUser.razor"
__builder2.AddContent(14, contextEstudiante.User.Identity.Name);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenComponent<PFG_BlazorServer.Pages.EstudianteParameter>(16);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591