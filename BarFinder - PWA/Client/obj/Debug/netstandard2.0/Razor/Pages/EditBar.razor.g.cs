#pragma checksum "C:\coursProjet\projetPoin\projet-poin\Client\Pages\EditBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c876ab2d40adf58675db3a44d53d355dbcd85b6c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/editbar")]
    public partial class EditBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.AddMarkupContent(3, "<h5 class=\"card-title\">Modifier le bar</h5>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 8 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\EditBar.razor"
                          _fillBar

#line default
#line hidden
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 8 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\EditBar.razor"
                                                   HandleValidSubmit

#line default
#line hidden
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n\r\n            ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.AddMarkupContent(18, "\r\n                ");
                __builder2.OpenElement(19, "p");
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.OpenElement(21, "label");
                __builder2.AddMarkupContent(22, "\r\n                        Nom du bar :\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 16 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\EditBar.razor"
                                                                      _fillBar.Identifier

#line default
#line hidden
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _fillBar.Identifier = __value, _fillBar.Identifier))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _fillBar.Identifier));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n\r\n            ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenElement(35, "p");
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __builder2.OpenElement(37, "label");
                __builder2.AddMarkupContent(38, "\r\n                        Description :\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(39);
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 25 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\EditBar.razor"
                                                                          _fillBar.Description

#line default
#line hidden
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _fillBar.Description = __value, _fillBar.Description))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _fillBar.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n            ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group");
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.OpenElement(51, "p");
                __builder2.AddMarkupContent(52, "\r\n                    ");
                __builder2.OpenElement(53, "label");
                __builder2.AddMarkupContent(54, "\r\n                        Type de bar:\r\n                        ");
                __Blazor.POIN.Client.Pages.EditBar.TypeInference.CreateInputSelect_0(__builder2, 55, 56, "form-control", 57, 
#line 34 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\EditBar.razor"
                                                                        _fillBar.Classification

#line default
#line hidden
                , 58, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _fillBar.Classification = __value, _fillBar.Classification)), 59, () => _fillBar.Classification, 60, (__builder3) => {
                    __builder3.AddMarkupContent(61, "\r\n                            ");
                    __builder3.AddMarkupContent(62, "<option value>Classique</option>\r\n                            ");
                    __builder3.AddMarkupContent(63, "<option value=\"Ambiance\">Ambiance</option>\r\n                            ");
                    __builder3.AddMarkupContent(64, "<option value=\"Restaurant\">Restaurant</option>\r\n                        ");
                }
                );
                __builder2.AddMarkupContent(65, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n\r\n            ");
                __builder2.AddMarkupContent(69, @"<div class=""form-group"">
                <form enctype=""multipart/form-data"" method=""post"">
                    <dl>
                        <dt>
                            <label asp-for=""FileUpload.FormFile""></label>
                        </dt>
                        <dd>
                            <input asp-for=""FileUpload.FormFile"" type=""file"">
                        </dd>
                    </dl>
                    <input asp-page-handler=""Upload"" class=""btn btn-primary"" type=""submit"" value=""Charger l'image"">
                </form>
            </div>

            ");
                __builder2.AddMarkupContent(70, "<button type=\"submit\" class=\"btn btn-success\">Enregistrer</button>\r\n\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 63 "C:\coursProjet\projetPoin\projet-poin\Client\Pages\EditBar.razor"
       
    private fillBarModel _fillBar = new fillBarModel();

    private void HandleValidSubmit()
    {
        Console.WriteLine("OnValidSubmit");
    }

#line default
#line hidden
    }
}
namespace __Blazor.POIN.Client.Pages.EditBar
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591