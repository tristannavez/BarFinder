#pragma checksum "C:\coursProjet\projetPoin\projet-poin\Client\Component\QRCodeFromFile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc6fe582c42a55b99098baa28111845ad1f065f8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace POIN.Client.Component
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
#line 1 "C:\coursProjet\projetPoin\projet-poin\Client\Component\QRCodeFromFile.razor"
using Microsoft.JSInterop;

#line default
#line hidden
    public partial class QRCodeFromFile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 29 "C:\coursProjet\projetPoin\projet-poin\Client\Component\QRCodeFromFile.razor"
       

    private ElementReference canvasElement;
    private ElementReference buttonOpenSourceFileElement;
    private ElementReference buttonOpenTargetFileElement;

    private string resultScan { get; set; } = string.Empty;


    protected void AddClickEvent()
    {
        JSRuntime.InvokeVoidAsync("addClickEvent", buttonOpenTargetFileElement);

    }


    [JSInvokable("HaveScanResultForFile")]
    public void HaveScanResultForFile(string data)
    {

        NavigationManager.NavigateTo("/participants/" + data);

    }

    [JSInvokable("DontHaveScanResultForFile")]
    public void DontHaveScanResultForFile()
    {

        Console.WriteLine("error read");
        resultScan = "Can not read the QR code, please get closer and retry";
        base.StateHasChanged();
    }

    public async Task HandleFileSelected()
    {
        await JSRuntime.InvokeVoidAsync("runQrScannerFromFile", canvasElement, buttonOpenTargetFileElement, DotNetObjectReference.Create(this));
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
