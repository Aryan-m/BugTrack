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
#nullable restore
#line 1 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
           [Microsoft.AspNetCore.Components.RouteAttribute(href)]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class BugsView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
       
    private const string href = Classes.Bugs.URL_VIEW;
    private string searchString1 = "";
    private string searchString2 = "";
    private BugModel selectedItem1 = null;
    private BugModel selectedItem2 = null;
    private List<BugModel> selectedItems = new List<BugModel>();
    private bool filterBugs1(BugModel element) => filterBugs(element, searchString1);
    private bool filterBugs2(BugModel element) => filterBugs(element, searchString2);
    private List<BugModel> Bugs = new List<BugModel>();

    private async Task refreshBugList() {
        Bugs = (await bugsDB.View(null)).ToList();
    }

    private async Task deleteBug(long BugID) {
        await bugsDB.Delete(BugID);
        await refreshBugList();
    }

    private void launchDeleteBugDialog(long BugID, string BugTitle)
    {
        var parameters = new DialogParameters();
        parameters.Add("ContentCallback", (Func<Task>)(async () => await deleteBug(BugID)));
        parameters.Add("ContentText", $"Are you sure you want to delete \"{ BugTitle }\"?");
        parameters.Add("ButtonText", "Delete");
        parameters.Add("Color", Color.Error);

        var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

        DialogService.Show<ConfirmDialog>("Delete", parameters, options);
    }

    // open dialog for add new
    private async Task launchAddNewBugDialog()
    {

        var dialog = DialogService.Show<BugAddForm>("Add New Bug");
        var result = await dialog.Result;

        if (!result.Cancelled)
        {
            await refreshBugList();
        }
    }

    // open dialog for edit
    private async Task launchEditBugDialog(long BugID)
    {
        var dialog = DialogService.Show<BugAddForm>("Edit Bug", new DialogParameters { ["BugID"] = BugID });
        var result = await dialog.Result;

        if (!result.Cancelled)
        {
            await refreshBugList();
        }
    }

    // filtering for bug table (used in search bar)
    private bool filterBugs(BugModel element, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.Title.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }

    protected override async Task OnInitializedAsync()
    {
        await refreshBugList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBugsData bugsDB { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
