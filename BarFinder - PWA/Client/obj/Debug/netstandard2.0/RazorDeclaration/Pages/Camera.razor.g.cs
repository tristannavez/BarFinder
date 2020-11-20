#pragma checksum "C:\coursProjet\projetPoin\projet-poin\Client\Pages\Camera.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f5ab6a016583c9caec2afa86c1b4c0ecb9785ff"
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
#line 8 "C:\coursProjet\projetPoin\projet-poin\Client\_Imports.razor"
using POIN.Shared;

#line default
#line hidden
#line 9 "C:\coursProjet\projetPoin\projet-poin\Client\_Imports.razor"
using POIN.Shared.Models;

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
#line 1 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\Camera.razor"
using Microsoft.AspNetCore.Blazor.Services;

#line default
#line hidden
#line 2 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\Camera.razor"
using Services;

#line default
#line hidden
#line 3 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\Camera.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#line 4 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\Camera.razor"
using Microsoft.JSInterop;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/camera")]
    public partial class Camera : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 30 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\Camera.razor"
       

    private ElementReference canvasElement;
    private ElementReference videoElement;
    private ElementReference outputElement;


    public bool showCanvas { get; set; } = true;
    public string Message { get; set; }


    public string logStatus { get; set; }

    private async Task TakeScan()
    {
        showCanvas = false;
        await JSRuntime.InvokeAsync<string>("runQrScanner", canvasElement, videoElement, outputElement, DotNetObjectReference.Create(this));
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
