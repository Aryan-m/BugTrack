#pragma checksum "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13a50c89ce01aa6e2043a233c6198af6dbcf18ee"
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
#line 24 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
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
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 23 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                  editModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 23 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
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
                        __builder4.OpenElement(11, "ul");
                        __builder4.AddAttribute(12, "class", "app-error-list ml-3 mb-3");
                        __builder4.AddMarkupContent(13, "\r\n");
#nullable restore
#line 27 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                 foreach (var error in errors)
                {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(14, "                    ");
                        __builder4.OpenElement(15, "li");
#nullable restore
#line 29 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
__builder4.AddContent(16, error);

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(17, "\r\n");
#nullable restore
#line 30 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                }

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(18, "            ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(19, "\r\n            ");
                        __Blazor.BugTrackBlazorServerUI.Pages.ProfileEdit.TypeInference.CreateMudTextField_0(__builder4, 20, 21, "Display name", 22, 
#nullable restore
#line 33 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                                                                     () => editModel.DisplayName

#line default
#line hidden
#nullable disable
                        , 23, 
#nullable restore
#line 33 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                                       editModel.DisplayName

#line default
#line hidden
#nullable disable
                        , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editModel.DisplayName = __value, editModel.DisplayName)));
                        __builder4.AddMarkupContent(25, "\r\n            ");
                        __builder4.AddMarkupContent(26, "<label class=\"mud-input-label\r\n                          mud-input-label-animated\r\n                          mud-input-label-text\r\n                          mt-2\">\r\n                Profile picture:\r\n            </label>\r\n            ");
                        __builder4.OpenElement(27, "div");
                        __builder4.AddMarkupContent(28, "\r\n");
#nullable restore
#line 41 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                 if (!String.IsNullOrEmpty(editModel.ImgDataBase64))
                {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(29, "                    ");
                        __builder4.OpenElement(30, "button");
                        __builder4.AddAttribute(31, "type", "button");
                        __builder4.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                                                    launchEditProfileImgDialog

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddMarkupContent(33, "\r\n                        ");
                        __builder4.OpenElement(34, "img");
                        __builder4.AddAttribute(35, "src", 
#nullable restore
#line 44 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                                   editModel.ImgDataBase64

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(36, "class", "rounded-circle");
                        __builder4.AddAttribute(37, "width", "50");
                        __builder4.AddAttribute(38, "height", "50");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(39, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(40, "\r\n");
#nullable restore
#line 49 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                }

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(41, "                ");
                        __builder4.OpenComponent<BlazorInputFile.InputFile>(42);
                        __builder4.AddAttribute(43, "id", "profileImg");
                        __builder4.AddAttribute(44, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 50 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                                                     OnInputFileChanged

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(45, "class", "mud-file-input");
                        __builder4.AddAttribute(46, "accept", ".jpg, .jpeg, .png");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(47, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudIconButton>(48);
                        __builder4.AddAttribute(49, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                                      Icons.Filled.CloudUpload

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(50, "Style", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                                        $"color:{Colors.Indigo.Darken2};"

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(51, "ButtonType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 53 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                                           ButtonType.Button

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(52, "Class", "ml-auto");
                        __builder4.AddAttribute(53, "HtmlTag", "label");
                        __builder4.AddAttribute(54, "for", "profileImg");
                        __builder4.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(56, "\r\n                    Upload Picture\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(57, "\r\n            ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(58, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudCardActions>(60);
                    __builder3.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(62, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudIconButton>(63);
                        __builder4.AddAttribute(64, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                                  Icons.Filled.Save

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(65, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 63 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                                                             Color.Dark

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(66, "ButtonType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 63 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
                                                                                     ButtonType.Submit

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(67, "Class", "ml-auto");
                        __builder4.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(69, "Register");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(70, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(71, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\ProfileEdit.razor"
       
    private class EditModel
    {
        [Required]
        public string DisplayName { get; set; }
        public byte[] ImgDataBytes { get; set; }
        public string ImgDataBase64 { get; set; }
    }

    private ApplicationUser user { get; set; }
    private AuthenticationState authState { get; set; }
    private EditModel editModel { get; set; } = new EditModel();
    private List<string> errors { get; set; } = new List<string>();

    // event callback sent to fileUploadSingle component to save uploaded files
    protected void saveUploadedFile(ImageFileModel imgFile)
    {
        editModel.ImgDataBytes = imgFile.ImgDataBytes;
        editModel.ImgDataBase64 = imgFile.ImgDataBase64;
    }

    private async Task OnInputFileChanged(IFileListEntry[] files)
    {
        var fileName = files.FirstOrDefault().Name;

        using (var ms = new MemoryStream())
        {

            await files[0].Data.CopyToAsync(ms);

            // invoke eventCallback
            saveUploadedFile(new ImageFileModel(
                                0
                            , fileName
                            , ms.ToArray()
                            , "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray())
                        ));
        }
    }

    private async Task launchEditProfileImgDialog()
    {
        var dialog = Dialog.Show<ProfileImgEdit>("Profile Picture"
                                  , new DialogParameters { ["ImgSrc"] = editModel.ImgDataBase64 }
                                  , new DialogOptions() { DisableBackdropClick = true }
                                  );

        var result = await dialog.Result;

        if (!result.Cancelled)
        {
            editModel.ImgDataBase64 = null;
            editModel.ImgDataBytes = null;
        }
    }

    public async Task OnValidSubmit()
    {
        errors.Clear();

        // update user info
        user.DisplayName = editModel.DisplayName;
        user.ImgDataBytes = editModel.ImgDataBytes;
        user.ImgDataBase64 = editModel.ImgDataBase64;

        List<ApplicationUser> usersWithSameDisplayName = _context.Users.Where(user => user.DisplayName == editModel.DisplayName).ToList();
        if (usersWithSameDisplayName.Count >= 2
            ||
            (usersWithSameDisplayName.Count == 1
            && usersWithSameDisplayName.First().Email != user.Email)
        )
        {

            errors.Add("Display name taken! Please choose a different name.");
            return;
        }

        var result = await _userManager.UpdateAsync(user);

        // However, it always succeeds inspite of not updating the database
        if (!result.Succeeded)
        {
            // error case
            return;
        }

        await _context.SaveChangesAsync();

        NavManager.NavigateTo("/", forceLoad: true);
    }

    protected override async Task OnInitializedAsync()
    {
        authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        user = await _userManager.GetUserAsync(authState.User);
        editModel = new EditModel
        {
            DisplayName = user.DisplayName
        ,
            ImgDataBytes = user.ImgDataBytes
        ,
            ImgDataBase64 = user.ImgDataBase64
        };
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService Dialog { get; set; }
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
