#pragma checksum "C:\Users\abp\source\repos\H6_Site\Pages\SysInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d0d70f02257f83424a793b623e148544b8bfefc"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/SysInfo")]
    public partial class SysInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\abp\source\repos\H6_Site\Pages\SysInfo.razor"
 if (userState.CurrentUser.Admin && userState.UserLoggedIn)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.OpenComponent<H6_Site.Shared.SysPanel>(1);
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\abp\source\repos\H6_Site\Pages\SysInfo.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<h3>Unauthorized</h3>");
#nullable restore
#line 13 "C:\Users\abp\source\repos\H6_Site\Pages\SysInfo.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\abp\source\repos\H6_Site\Pages\SysInfo.razor"
 
    protected override async Task OnInitializedAsync()
    {
        if (!userState.CurrentUser.Admin)
        {
            await InvokeAsync(() => nav.NavigateTo(""));
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserStateContainer userState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private System.Diagnostics.Stopwatch watch { get; set; }
    }
}
#pragma warning restore 1591
