#pragma checksum "C:\coursProjet\projetPoin\projet-poin\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91ecec52ac45cbc48852c783d01397355246dd42"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\FetchData.razor"
using POIN.Shared;

#line default
#line hidden
#line 2 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\FetchData.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Roles", "Admin");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n");
                __builder2.AddMarkupContent(4, "<h1>Weather forecast</h1>\r\n\r\n");
                __builder2.AddMarkupContent(5, "<p>This component demonstrates fetching data from the server.</p>\r\n\r\n\r\n");
#line 12 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
                __builder2.AddContent(6, "    ");
                __builder2.AddMarkupContent(7, "<p><em>Loading...</em></p>\r\n");
#line 15 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\FetchData.razor"
    
}


else
{

#line default
#line hidden
                __builder2.AddContent(8, "    ");
                __builder2.OpenElement(9, "table");
                __builder2.AddAttribute(10, "class", "table");
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.AddMarkupContent(12, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
                __builder2.OpenElement(13, "tbody");
                __builder2.AddMarkupContent(14, "\r\n");
#line 31 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
                __builder2.AddContent(15, "                ");
                __builder2.OpenElement(16, "tr");
                __builder2.AddMarkupContent(17, "\r\n                    ");
                __builder2.OpenElement(18, "td");
                __builder2.AddContent(19, 
#line 34 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.OpenElement(21, "td");
                __builder2.AddContent(22, 
#line 35 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.OpenElement(24, "td");
                __builder2.AddContent(25, 
#line 36 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                    ");
                __builder2.OpenElement(27, "td");
                __builder2.AddContent(28, 
#line 37 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n");
#line 39 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\FetchData.razor"
            }

#line default
#line hidden
                __builder2.AddContent(31, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n");
#line 42 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\FetchData.razor"
}

#line default
#line hidden
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 44 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
