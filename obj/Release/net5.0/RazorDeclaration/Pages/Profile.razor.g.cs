// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace H6_Site.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\abp\source\repos\H6_Site\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abp\source\repos\H6_Site\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abp\source\repos\H6_Site\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abp\source\repos\H6_Site\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abp\source\repos\H6_Site\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\abp\source\repos\H6_Site\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\abp\source\repos\H6_Site\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\abp\source\repos\H6_Site\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\abp\source\repos\H6_Site\_Imports.razor"
using H6_Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\abp\source\repos\H6_Site\_Imports.razor"
using H6_Site.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\abp\source\repos\H6_Site\Pages\Profile.razor"
using AbpLib.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\abp\source\repos\H6_Site\Pages\Profile.razor"
using AbpLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\abp\source\repos\H6_Site\Pages\Profile.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\abp\source\repos\H6_Site\Pages\Profile.razor"
using static GlobalObjects;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Profile")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\abp\source\repos\H6_Site\Pages\Profile.razor"
       

    string newPicture => userState.CurrentUser.Admin ? "Upload Item" : "Request Item";
    string PauseBtn_Txt => LoggingIsPaused ? "Resume" : "Pause";

    protected override async Task OnInitializedAsync()
    {
        try
        {
            if (!userState.UserLoggedIn)
            {
                await InvokeAsync(() => nav.NavigateTo(""));
            }
        }
        catch (Exception err)
        {
            await err.LogErrors("Profile", "OnInitializedAsync");
        }
    }

    protected async Task On_Btn1Click(MouseEventArgs e)
    {
        try
        {
            watch.Start();
            await client.PostAsync("Data/UserUpdate", userState.CurrentUser.SERIALIZE_CONTENT());

            await watch.LogTime("Profile", "On_Btn1Click");

            JS.InfoMsg("ProfileInfo", "User information has been updated");
        }
        catch (Exception err)
        {
            JS.InfoMsg("ProfileInfo", err.Message);
            await err.LogErrors("Profile", "On_Btn1Click");
        }
    }

    protected async Task On_Btn2Click(MouseEventArgs e)
    {
        LoggingIsPaused = !LoggingIsPaused;
        LocalSVCRunning = await "pause_logging".ContactLocalSVC(LoggingIsPaused.ToString());
    }

    protected async Task On_KeyUp(KeyboardEventArgs e)
    {
        string time_value = await JS.InvokeAsync<string>("GetControlValue", "Interval_TB");
        if (int.TryParse(time_value, out int val) && val >= 100)
        {
            LocalSVCRunning = await "set_interval".ContactLocalSVC(val.ToString());
            LocalSVC_Interval = val;
        }
    }

    private async Task OnInput_ProfilePicture(InputFileChangeEventArgs e)
    {
        try
        {
            watch.Start();
            using Stream s = e.File.OpenReadStream();
            byte[] bytes = await s.GetBytes();

            if (bytes.Length > 0)
            {
                await client.PostAsync($"Data/UploadFile/{e.File.Name}/{userState.CurrentUser.UserName}/Profile_Picture", new ByteArrayContent(bytes));
                userState.CurrentUser.ProfilePicture = Convert.ToBase64String(bytes);
                JS.InfoMsg("ProfileInfo", $"Profile picture has been updated with: {e.File.Name}");
            }

            await watch.LogTime("Profile", "OnInput_FileUpload", userState.CurrentUser.PropertyView("ProfilePicture"));
        }
        catch (Exception err)
        {
            await err.LogErrors("Profile", "OnInputFileChange");
        }
    }

    private async Task OnInput_FileUpload(InputFileChangeEventArgs e)
    {
        try
        {
            watch.Start();
            using Stream s = e.File.OpenReadStream();
            byte[] bytes = await s.GetBytes();

            if (bytes.Length > 0 && !string.IsNullOrEmpty(item.ItemName) && item.Price != 0)
            {
                HttpResponseMessage msg = await client.PostAsync($"Data/UploadFile/{e.File.Name}/{userState.CurrentUser.UserName}/New_Picture", new ByteArrayContent(bytes));

                if (int.TryParse(await msg.Content.ReadAsStringAsync(), out int fileId))
                {

                    if (fileId > 0)
                    {
                        msg = await client.PostAsync($"Data/UpdateItemDetails/{fileId}", item.SERIALIZE_CONTENT());
                        JS.InfoMsg("ProfileInfo", $"{e.File.Name} has been uploaded with the price of {item.Price} DKK");
                    }
                    else
                    {

                        switch(fileId)
                        {
                            case -1:
                                JS.InfoMsg("ProfileInfo", "Profile picture was updated");
                                break;
                            case -2:
                                JS.InfoMsg("ProfileInfo", "File already exists");
                                break;
                        }
                    }
                }
            }
            else
            {
                JS.InfoMsg("ProfileInfo", "Upload Failed, check price and name input");
            }

            await watch.LogTime("Profile", "OnInput_FileUpload");
        }
        catch (Exception err)
        {
            await err.LogErrors("Profile", "OnInputFileChange");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ItemModel item { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserStateContainer userState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private System.Diagnostics.Stopwatch watch { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
    }
}
#pragma warning restore 1591
