#pragma checksum "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4f749c55f4fe87ee803cb5e60c233a22cfd139e"
// <auto-generated/>
#pragma warning disable 1591
namespace H6_Site.Shared
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
#line 5 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
using static GlobalObjects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
using H6_Site.Models;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-ilobn9eqz4");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-ilobn9eqz4>MaxiToys</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-ilobn9eqz4");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-ilobn9eqz4></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 15 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-ilobn9eqz4");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-ilobn9eqz4");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-ilobn9eqz4");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 18 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-ilobn9eqz4></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
         if (userState.UserLoggedIn)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "li");
            __builder.AddAttribute(27, "class", "nav-item px-3");
            __builder.AddAttribute(28, "b-ilobn9eqz4");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "class", "nav-link");
            __builder.AddAttribute(31, "href", "/Profile");
            __builder.AddAttribute(32, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 26 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
                                                                 NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "<span class=\"oi oi-person\" aria-hidden=\"true\" b-ilobn9eqz4></span> Profile\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
         if (userState.UserLoggedIn)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "nav-item px-3");
            __builder.AddAttribute(37, "style", "display:" + (
#nullable restore
#line 33 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
                                                      userState.PanelProp

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddAttribute(38, "b-ilobn9eqz4");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "class", "nav-link");
            __builder.AddAttribute(41, "href", "/SysInfo");
            __builder.AddAttribute(42, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 34 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
                                                                 NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(44, "<span class=\"oi oi-bar-chart\" aria-hidden=\"true\" b-ilobn9eqz4></span> System Info\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class", "nav-item px-3");
            __builder.AddAttribute(48, "style", "display:" + (
#nullable restore
#line 38 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
                                                      userState.PanelProp

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddAttribute(49, "b-ilobn9eqz4");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(50);
            __builder.AddAttribute(51, "class", "nav-link");
            __builder.AddAttribute(52, "href", "/Logs");
            __builder.AddAttribute(53, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 39 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
                                                              NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(55, "<span class=\"oi oi-list\" aria-hidden=\"true\" b-ilobn9eqz4></span> Logs\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "li");
            __builder.AddAttribute(57, "class", "nav-item px-3");
            __builder.AddAttribute(58, "b-ilobn9eqz4");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(59);
            __builder.AddAttribute(60, "class", "nav-link");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
                                                async e => await Login_OnClick(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "style", "cursor:pointer;");
            __builder.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(64, "span");
                __builder2.AddAttribute(65, "class", 
#nullable restore
#line 46 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
                              userState.LoginIcon

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(66, "aria-hidden", "true");
                __builder2.AddAttribute(67, "b-ilobn9eqz4");
                __builder2.CloseElement();
                __builder2.AddContent(68, " ");
                __builder2.AddContent(69, 
#nullable restore
#line 46 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
                                                                               LoginTxt

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\abp\source\repos\H6_Site\Shared\NavMenu.razor"
       
    public string LoginTxt => userState.UserLoggedIn ? "Logout" : "Login";

    private bool collapseNavMenu = true;
    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    protected override async Task OnInitializedAsync()
    {
        await InvokeAsync(() =>
        {
            userState.OnUserChange += StateHasChanged;
        });
    }

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    private async Task Login_OnClick(MouseEventArgs e)
    {
        await InvokeAsync(StateHasChanged);
        if (userState.UserLoggedIn)
        {
            userState.SetUser(new UserModel());
            await InvokeAsync(StateHasChanged);
            await InvokeAsync(() => Nav.NavigateTo(""));
        }
        else
        {
            await InvokeAsync(() => Nav.NavigateTo("Login"));
        }
    }

    public async ValueTask DisposeAsync()
    {
        await InvokeAsync(() =>
        {
            userState.OnUserChange -= StateHasChanged;
        });
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserStateContainer userState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
    }
}
#pragma warning restore 1591
