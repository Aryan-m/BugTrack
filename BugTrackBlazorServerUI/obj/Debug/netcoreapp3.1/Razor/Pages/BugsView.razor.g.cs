#pragma checksum "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0571c87f6b094b7abe00c4f3781deb494b1bf20"
// <auto-generated/>
#pragma warning disable 1591
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
            __Blazor.BugTrackBlazorServerUI.Pages.BugsView.TypeInference.CreateMudTable_0(__builder, 0, 1, 
#nullable restore
#line 7 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                  Bugs

#line default
#line hidden
#nullable disable
            , 2, 
#nullable restore
#line 7 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                               true

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 7 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                            true

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 7 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                                            false

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 7 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                                                            true

#line default
#line hidden
#nullable disable
            , 6, "Sort By", 7, 
#nullable restore
#line 8 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                      new Func<BugModel,bool>(filterBugs1)

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 9 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                       true

#line default
#line hidden
#nullable disable
            , 9, "true", 10, 
#nullable restore
#line 8 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                                                                                selectedItem1

#line default
#line hidden
#nullable disable
            , 11, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 12, (__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n\r\n\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudIconButton>(14);
                __builder2.AddAttribute(15, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 14 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                             Size.Large

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                              Icons.Material.Filled.Refresh

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Style", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                $"color:{Colors.Green.Accent4};"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Edge", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 17 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                             Edge.Start

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                  async (e) => await refreshBugList()

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudIconButton>(21);
                __builder2.AddAttribute(22, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 21 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                             Size.Large

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                              Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "Style", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                $"color:{Colors.Indigo.Accent2};"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Edge", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 24 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                             Edge.Start

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                  (e) => launchAddNewBugDialog()

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n\r\n\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "mt-0 w-50 ml-auto");
                __builder2.AddMarkupContent(30, "\r\n            ");
                __Blazor.BugTrackBlazorServerUI.Pages.BugsView.TypeInference.CreateMudTextField_1(__builder2, 31, 32, "Search", 33, 
#nullable restore
#line 31 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                     Adornment.Start

#line default
#line hidden
#nullable disable
                , 34, 
#nullable restore
#line 31 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                                                      Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 35, 
#nullable restore
#line 32 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                    Size.Medium

#line default
#line hidden
#nullable disable
                , 36, 
#nullable restore
#line 32 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                                            false

#line default
#line hidden
#nullable disable
                , 37, 
#nullable restore
#line 32 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                                                              true

#line default
#line hidden
#nullable disable
                , 38, 
#nullable restore
#line 30 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                       searchString1

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString1 = __value, searchString1)));
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\r\n    ");
            }
            , 42, (__builder2) => {
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(44);
                __builder2.AddAttribute(45, "style", "width: 20vw;");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(47);
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(49, "\r\n            ");
                    __Blazor.BugTrackBlazorServerUI.Pages.BugsView.TypeInference.CreateMudTableSortLabel_2(__builder3, 50, 51, 
#nullable restore
#line 40 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                                 SortDirection.Ascending

#line default
#line hidden
#nullable disable
                    , 52, 
#nullable restore
#line 40 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                                                                  new Func<BugModel, object>(x => x.Title)

#line default
#line hidden
#nullable disable
                    , 53, (__builder4) => {
                        __builder4.AddMarkupContent(54, "\r\n                ");
                        __builder4.AddMarkupContent(55, "<strong>Title</strong>\r\n            ");
                    }
                    );
                    __builder3.AddMarkupContent(56, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(58);
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(60, "<strong>Description</strong>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n    ");
            }
            , 62, (context) => (__builder2) => {
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(64);
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(66, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(67);
                    __builder3.AddAttribute(68, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                  Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(69, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 49 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                 Size.Medium

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "Title", "Delete");
                    __builder3.AddAttribute(71, "Style", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                    $"color:{Colors.Red.Accent4};"

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(72, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                      () => launchDeleteBugDialog(context.ID, context.Title)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(73, "Class", "ma-2");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(75);
                    __builder3.AddAttribute(76, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                  Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(77, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 56 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                 Size.Medium

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(78, "Title", "Edit");
                    __builder3.AddAttribute(79, "Style", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                    $"color:{Colors.Orange.Accent4};"

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(80, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
                                       (x) => launchEditBugDialog(context.ID)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(81, "Class", "ma-2");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(82, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(84);
                __builder2.AddAttribute(85, "DataLabel", "Title");
                __builder2.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 63 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
__builder3.AddContent(87, context.Title);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(89);
                __builder2.AddAttribute(90, "DataLabel", "Description");
                __builder2.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 64 "C:\Users\kasra\OneDrive\Desktop\Software\Personal Projects\Bug Track\BugTrackBlazorServerUI\Pages\BugsView.razor"
__builder3.AddContent(92, context.Description);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n    ");
            }
            , 94, (__builder2) => {
                __builder2.AddMarkupContent(95, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTablePager>(96);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(97, "\r\n    ");
            }
            );
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
namespace __Blazor.BugTrackBlazorServerUI.Pages.BugsView
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Func<T, global::System.Boolean> __arg6, int __seq7, global::System.Boolean __arg7, int __seq8, System.Object __arg8, int __seq9, T __arg9, int __seq10, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg10, int __seq11, global::Microsoft.AspNetCore.Components.RenderFragment __arg11, int __seq12, global::Microsoft.AspNetCore.Components.RenderFragment __arg12, int __seq13, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg13, int __seq14, global::Microsoft.AspNetCore.Components.RenderFragment __arg14)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Dense", __arg1);
        __builder.AddAttribute(__seq2, "Hover", __arg2);
        __builder.AddAttribute(__seq3, "Bordered", __arg3);
        __builder.AddAttribute(__seq4, "Striped", __arg4);
        __builder.AddAttribute(__seq5, "SortLabel", __arg5);
        __builder.AddAttribute(__seq6, "Filter", __arg6);
        __builder.AddAttribute(__seq7, "FixedHeader", __arg7);
        __builder.AddAttribute(__seq8, "Loading", __arg8);
        __builder.AddAttribute(__seq9, "SelectedItem", __arg9);
        __builder.AddAttribute(__seq10, "SelectedItemChanged", __arg10);
        __builder.AddAttribute(__seq11, "ToolBarContent", __arg11);
        __builder.AddAttribute(__seq12, "HeaderContent", __arg12);
        __builder.AddAttribute(__seq13, "RowTemplate", __arg13);
        __builder.AddAttribute(__seq14, "PagerContent", __arg14);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Adornment __arg1, int __seq2, global::System.String __arg2, int __seq3, global::MudBlazor.Size __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, T __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg7)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Adornment", __arg1);
        __builder.AddAttribute(__seq2, "AdornmentIcon", __arg2);
        __builder.AddAttribute(__seq3, "IconSize", __arg3);
        __builder.AddAttribute(__seq4, "FullWidth", __arg4);
        __builder.AddAttribute(__seq5, "Immediate", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateMudTableSortLabel_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.SortDirection __arg0, int __seq1, global::System.Func<T, global::System.Object> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::MudBlazor.MudTableSortLabel<T>>(seq);
        __builder.AddAttribute(__seq0, "InitialDirection", __arg0);
        __builder.AddAttribute(__seq1, "SortBy", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
