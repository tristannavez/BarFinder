#pragma checksum "C:\coursProjet\projetPoin\projet-poin\Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7c42e01b2c3223e9661b87e1c09ca6e65b44344"
// <auto-generated/>
#pragma warning disable 1591
namespace POIN.Client
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#line 1 "C:\coursProjet\projetPoin\projet-poin\Client\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(4);
                __builder2.AddAttribute(5, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#line 3 "C:\coursProjet\projetPoin\projet-poin\Client\App.razor"
                                        routeData

#line default
#line hidden
                ));
                __builder2.AddAttribute(6, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#line 3 "C:\coursProjet\projetPoin\projet-poin\Client\App.razor"
                                                                   typeof(MainLayout)

#line default
#line hidden
                ));
                __builder2.AddAttribute(7, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n                ");
                    __builder3.AddMarkupContent(9, "<h1>Navré</h1>\r\n                ");
                    __builder3.AddMarkupContent(10, "<p>Il n\'y a aucune bière pour vous ici</p>\r\n            ");
                }
                ));
                __builder2.AddAttribute(11, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(12, "\r\n                ");
                    __builder3.AddMarkupContent(13, "<h1>Authentification en cours</h1>\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n    ");
            }
            ));
            __builder.AddAttribute(15, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(17);
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(19, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(20);
                    __builder3.AddAttribute(21, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#line 15 "C:\coursProjet\projetPoin\projet-poin\Client\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(23, "\r\n                ");
                        __builder4.AddMarkupContent(24, "<h1>Navré</h1>\r\n                ");
                        __builder4.AddMarkupContent(25, "<p>Il n\'y a aucune bière pour vous ici</p>\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
