#pragma checksum "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Components\UnauthorizedLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "952c67c8cfbf946a666bc4658118484908f23581"
// <auto-generated/>
#pragma warning disable 1591
namespace BugTrackBlazorServerUI.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using BugTrackBlazorServerUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using BugTrackBlazorServerUI.Classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using BugTrackBlazorServerUI.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using DataAccess.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    public partial class UnauthorizedLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(2);
            __builder.AddAttribute(3, "FullWidth", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 4 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Components\UnauthorizedLayout.razor"
                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "MaxWidth", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth?>(
#nullable restore
#line 5 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Components\UnauthorizedLayout.razor"
                             MaxWidth.Large

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(8);
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudContainer>(14);
                    __builder3.AddAttribute(15, "MaxWidth", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 10 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Components\UnauthorizedLayout.razor"
                                MaxWidth.Large

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "Class", "glassy-container");
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(18, "\r\n            ");
#nullable restore
#line 11 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Components\UnauthorizedLayout.razor"
__builder4.AddContent(19, Body);

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(20, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
