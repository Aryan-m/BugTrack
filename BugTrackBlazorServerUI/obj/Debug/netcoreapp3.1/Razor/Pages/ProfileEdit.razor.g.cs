#pragma checksum "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a1f23a4fbda69f284437d0f45e945c89ee9ecb9"
// <auto-generated/>
#pragma warning disable 1591
namespace BugTrackBlazorServerUI.Pages
{
    #line hidden
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
#line 3 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
using BugTrackBlazorServerUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using DataAccess.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
using BugTrackBlazorServerUI.Areas.Identity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
using BugTrackBlazorServerUI.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProfileEdit")]
    public partial class ProfileEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                  editModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 21 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                                            OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCard>(5);
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(7, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudCardContent>(8);
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(10, "\r\n            ");
                        __Blazor.BugTrackBlazorServerUI.Pages.ProfileEdit.TypeInference.CreateMudTextField_0(__builder4, 11, 12, "Display name", 13, 
#nullable restore
#line 25 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                                                                       () => editModel.DisplayName

#line default
#line hidden
#nullable disable
                        , 14, 
#nullable restore
#line 25 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                                         editModel.DisplayName

#line default
#line hidden
#nullable disable
                        , 15, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editModel.DisplayName = __value, editModel.DisplayName)));
                        __builder4.AddMarkupContent(16, "                    \r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudCardActions>(18);
                    __builder3.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(20, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudButton>(21);
                        __builder4.AddAttribute(22, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 28 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                                   ButtonType.Submit

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(23, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 28 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                                                               Variant.Filled

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(24, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 28 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                                                                                      Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "Class", "ml-auto");
                        __builder4.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(27, "Register");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(28, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
       
    private class EditModel
    {
        [Required]
        public string DisplayName { get; set; }
    }

    private ApplicationUser user { get; set; }
    private AuthenticationState authState { get; set; }
    private EditModel editModel { get; set; } = new EditModel();

    //private async Task LoadAsync(ApplicationUser user)
    //{
    //    var userName = await _userManager.GetUserNameAsync(user);
    //    var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
    //}

    //public async Task<IActionResult> OnGetAsync()
    //{
    //    var user = await _userManager.GetUserAsync(User);
    //    if (user == null)
    //    {
    //        return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
    //    }

    //    await LoadAsync(user);
    //    return Page();
    //}

    public async Task OnValidSubmit()
    {
        
        // update user info
        user.DisplayName = editModel.DisplayName;

        // This is the part that doesn't work
        var result = await _userManager.UpdateAsync(user);

        // However, it always succeeds inspite of not updating the database
        if (!result.Succeeded)
        {
            // error case
            return;
        }

        await _context.SaveChangesAsync();

        await _signInManager.RefreshSignInAsync(user);

        NavManager.NavigateTo("/");
    }

    protected override async Task OnInitializedAsync()
    {
        authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        user = await _userManager.GetUserAsync(authState.User);
        editModel = new EditModel { DisplayName = user.DisplayName };
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BugTrackBlazorServerUIContext _context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<ApplicationUser> _signInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
    }
}
namespace __Blazor.BugTrackBlazorServerUI.Pages.ProfileEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591