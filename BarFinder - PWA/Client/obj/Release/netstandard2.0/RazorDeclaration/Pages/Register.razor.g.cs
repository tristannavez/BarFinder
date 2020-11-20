#pragma checksum "C:\coursProjet\projetPoin\projet-poin\Client\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e76364d72c3054936fc771b2c35bcc382aa7f79"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace POIN.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\coursProjet\projetPoin\projet-poin\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\coursProjet\projetPoin\projet-poin\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\coursProjet\projetPoin\projet-poin\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\coursProjet\projetPoin\projet-poin\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\coursProjet\projetPoin\projet-poin\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\coursProjet\projetPoin\projet-poin\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\coursProjet\projetPoin\projet-poin\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\coursProjet\projetPoin\projet-poin\Client\_Imports.razor"
using POIN.Shared;

#line default
#line hidden
#line 10 "C:\coursProjet\projetPoin\projet-poin\Client\_Imports.razor"
using POIN.Client;

#line default
#line hidden
#line 11 "C:\coursProjet\projetPoin\projet-poin\Client\_Imports.razor"
using POIN.Client.Shared;

#line default
#line hidden
#line 12 "C:\coursProjet\projetPoin\projet-poin\Client\_Imports.razor"
using POIN.Client.Services;

#line default
#line hidden
#line 14 "C:\coursProjet\projetPoin\projet-poin\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#line 4 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\Register.razor"
using POIN.Shared.Models;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 44 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\Register.razor"
       

    private RegisterModel RegisterModel = new RegisterModel();
    private bool ShowErrors;
    private IEnumerable<string> Errors;

    private async Task HandleRegistration()
    {
        ShowErrors = false;

        var result = await AuthService.Register(RegisterModel);

        if (result.Successful)
        {
            NavigationManager.NavigateTo("/login");
        }
        else
        {
            Errors = result.Errors;
            ShowErrors = true;
        }
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private POIN.Client.Services.IAuthService AuthService { get; set; }
    }
}
#pragma warning restore 1591
