#pragma checksum "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da820b6459b0a2d36950878d41bdc000cdf51c5a"
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
#line 1 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
using PFG_BlazorServer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
using PFG_BlazorServer.Services;

#line default
#line hidden
#nullable disable
    public partial class EmpresaParameter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                  empresa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                           CreateEmpresa

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n                ");
                __builder2.OpenElement(6, "table");
                __builder2.AddAttribute(7, "class", "table");
                __builder2.OpenElement(8, "tr");
                __builder2.AddMarkupContent(9, "<td>NOMBRE</td>\r\n                        ");
                __builder2.OpenElement(10, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "class", "form-control col-sm-5");
                __builder2.AddAttribute(13, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                                                   empresa.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => empresa.Name = __value, empresa.Name))));
                __builder2.AddAttribute(15, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => empresa.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n                        &nbsp;");
                __Blazor.PFG_BlazorServer.Pages.EmpresaParameter.TypeInference.CreateValidationMessage_0(__builder2, 17, 18, 
#nullable restore
#line 12 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                        () => empresa.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.OpenElement(20, "tr");
                __builder2.AddMarkupContent(21, "<td>INDUSTRIA</td>\r\n                        ");
                __builder2.OpenElement(22, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control col-sm-5");
                __builder2.AddAttribute(25, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                                                   empresa.Industry

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => empresa.Industry = __value, empresa.Industry))));
                __builder2.AddAttribute(27, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => empresa.Industry));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                        &nbsp;");
                __Blazor.PFG_BlazorServer.Pages.EmpresaParameter.TypeInference.CreateValidationMessage_1(__builder2, 29, 30, 
#nullable restore
#line 17 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                        () => empresa.Industry

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.OpenElement(32, "tr");
                __builder2.AddMarkupContent(33, "<td>EMAIL</td>\r\n                        ");
                __builder2.OpenElement(34, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "class", "form-control col-sm-5");
                __builder2.AddAttribute(37, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                                                   empresa.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => empresa.Email = __value, empresa.Email))));
                __builder2.AddAttribute(39, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => empresa.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                        &nbsp;");
                __Blazor.PFG_BlazorServer.Pages.EmpresaParameter.TypeInference.CreateValidationMessage_2(__builder2, 41, 42, 
#nullable restore
#line 22 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                        () => empresa.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                    ");
                __builder2.OpenElement(44, "tr");
                __builder2.AddMarkupContent(45, "<td>TELEFONO</td>\r\n                        ");
                __builder2.OpenElement(46, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "class", "form-control col-sm-5");
                __builder2.AddAttribute(49, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                                                   empresa.Telefono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => empresa.Telefono = __value, empresa.Telefono))));
                __builder2.AddAttribute(51, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => empresa.Telefono));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                        &nbsp;");
                __Blazor.PFG_BlazorServer.Pages.EmpresaParameter.TypeInference.CreateValidationMessage_3(__builder2, 53, 54, 
#nullable restore
#line 27 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                        () => empresa.Telefono

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __builder2.OpenElement(56, "tr");
                __builder2.AddMarkupContent(57, "<td>DESCRIPTION</td>\r\n                        ");
                __builder2.OpenElement(58, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(59);
                __builder2.AddAttribute(60, "class", "form-control col-sm-5");
                __builder2.AddAttribute(61, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                                                       empresa.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => empresa.Descripcion = __value, empresa.Descripcion))));
                __builder2.AddAttribute(63, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => empresa.Descripcion));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                        &nbsp;");
                __Blazor.PFG_BlazorServer.Pages.EmpresaParameter.TypeInference.CreateValidationMessage_4(__builder2, 65, 66, 
#nullable restore
#line 32 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                        () => empresa.Descripcion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                    ");
                __builder2.OpenElement(68, "tr");
                __builder2.AddMarkupContent(69, "<td>PAIS</td>\r\n                        ");
                __builder2.OpenElement(70, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(71);
                __builder2.AddAttribute(72, "class", "form-control col-sm-5");
                __builder2.AddAttribute(73, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                                                   empresa.Pais

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => empresa.Pais = __value, empresa.Pais))));
                __builder2.AddAttribute(75, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => empresa.Pais));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                        &nbsp;");
                __Blazor.PFG_BlazorServer.Pages.EmpresaParameter.TypeInference.CreateValidationMessage_5(__builder2, 77, 78, 
#nullable restore
#line 37 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                        () => empresa.Pais

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                    ");
                __builder2.OpenElement(80, "tr");
                __builder2.AddMarkupContent(81, "<td>CIUDAD</td>\r\n                        ");
                __builder2.OpenElement(82, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(83);
                __builder2.AddAttribute(84, "class", "form-control col-sm-5");
                __builder2.AddAttribute(85, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                                                   empresa.Ciudad

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => empresa.Ciudad = __value, empresa.Ciudad))));
                __builder2.AddAttribute(87, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => empresa.Ciudad));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                        &nbsp;");
                __Blazor.PFG_BlazorServer.Pages.EmpresaParameter.TypeInference.CreateValidationMessage_6(__builder2, 89, 90, 
#nullable restore
#line 42 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                        () => empresa.Ciudad

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                    ");
                __builder2.OpenElement(92, "tr");
                __builder2.AddMarkupContent(93, "<td>CALLE</td>\r\n                        ");
                __builder2.OpenElement(94, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(95);
                __builder2.AddAttribute(96, "class", "form-control col-sm-5");
                __builder2.AddAttribute(97, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                                                   empresa.Calle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => empresa.Calle = __value, empresa.Calle))));
                __builder2.AddAttribute(99, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => empresa.Calle));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                        &nbsp;");
                __Blazor.PFG_BlazorServer.Pages.EmpresaParameter.TypeInference.CreateValidationMessage_7(__builder2, 101, 102, 
#nullable restore
#line 47 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                        () => empresa.Calle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                    ");
                __builder2.OpenElement(104, "tr");
                __builder2.AddMarkupContent(105, "<td>CODIGO POSTAL</td>\r\n                        ");
                __builder2.OpenElement(106, "td");
                __Blazor.PFG_BlazorServer.Pages.EmpresaParameter.TypeInference.CreateInputNumber_8(__builder2, 107, 108, "form-control col-sm-5", 109, 
#nullable restore
#line 51 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                                                     empresa.CodigoPostal

#line default
#line hidden
#nullable disable
                , 110, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => empresa.CodigoPostal = __value, empresa.CodigoPostal)), 111, () => empresa.CodigoPostal);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                        &nbsp;");
                __Blazor.PFG_BlazorServer.Pages.EmpresaParameter.TypeInference.CreateValidationMessage_9(__builder2, 113, 114, 
#nullable restore
#line 52 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
                                                        () => empresa.CodigoPostal

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n\r\n                ");
                __builder2.AddMarkupContent(116, "<div class=\"col-12 row\"><span class=\"col-12\"></span>\r\n                    <input type=\"submit\" class=\"form-control col-6 btn btn-primary\" value=\"Save\"></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\guill\Desktop\PFG\BlazorServer\PFG_BlazorServer\PFG_BlazorServer\Pages\EmpresaParameter.razor"
       

    public Empresa empresa { get; set; }

    protected override void OnInitialized()
    {
        empresa = new Empresa ();
    }

    private async Task CreateEmpresa ()
    {
        //empresa.Email = "g@gmail.com";
        if (await EmpresaService.InsertEmpresa(empresa))
            NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmpresaService EmpresaService { get; set; }
    }
}
namespace __Blazor.PFG_BlazorServer.Pages.EmpresaParameter
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
