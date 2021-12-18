// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BugTrackBlazorServerUI.Pages
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
#line 13 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\_Imports.razor"
using System.Linq;

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
    public partial class BugAddForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugAddForm.razor"
       
    [CascadingParameter]
    MudDialogInstance MudDialog { get; set; }

    [Parameter]
    public long? BugID { get; set; }

    private BugModel newBug = new BugModel();
    private List<ImageFileModel> imageFiles = new List<ImageFileModel>();

    private void Cancel()
    {
        MudDialog.Cancel();
    }

    // indicate save was successful
    private void indicateSuccess()
    {
        Snackbar.Add("Bug Saved", Severity.Success);
        MudDialog.Close(DialogResult.Ok(newBug.ID));
    }

    // indicate something went wrong
    private void indicateError(string errMsg)
    {
        Snackbar.Add(errMsg, Severity.Error);
    }

    private async Task saveBug()
    {
        try {
            // Add New
            if (newBug.ID == 0) {
                await bugsDB.Insert(newBug, imageFiles);
            } 
            // Edit
            else
            {
                await bugsDB.Update(newBug, imageFiles);
            }
            indicateSuccess();
        } catch(Exception ex) {
            indicateError("Error");
        }
    }

    // event callback sent to fileUpload component to save uploaded files
    protected void saveUploadedFiles(List<ImageFileModel> imgFiles)
    {
        imageFiles = imgFiles;
    }

    protected override async Task OnInitializedAsync()
    {
        // if edit mode, load bug and related files
        if (BugID != null)
        {
            newBug = (await bugsDB.View(BugID)).ToList().FirstOrDefault();

            if (newBug.ID == 0) MudDialog.Cancel();

            imageFiles = (await imageFilesDB.View(null, newBug.ID)).ToList();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IImageFilesData imageFilesDB { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBugsData bugsDB { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
