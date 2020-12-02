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
#line 4 "C:\Users\abp\source\repos\H6_Site\Pages\Index.razor"
using static H6_Site.GlobalObjects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abp\source\repos\H6_Site\Pages\Index.razor"
using AbpLib.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\abp\source\repos\H6_Site\Pages\Index.razor"
 
    List<ItemModel> Items;

    protected override async Task OnInitializedAsync()
    {
        string result = await client.GetStringAsync("Data/GetItems");
        Items = result.DESERIALIZE<List<ItemModel>>();
    }

    protected async Task On_Btn1Click(object sender, MouseEventArgs e)
    {
        ItemModel m = (ItemModel)sender;
        await client.PostAsync("Validation/RemoveItem", m.SERIALIZE_CONTENT());

        string result = await client.GetStringAsync("Data/GetItems");
        Items = result.DESERIALIZE<List<ItemModel>>();
        await InvokeAsync(StateHasChanged);
    }

    protected async Task On_BasketAdd(object sender, MouseEventArgs e)
    {
        ItemModel m = (ItemModel)sender;
        userState.BasketList.Add(m);
        userState.SetUser(userState.CurrentUser);
        await InvokeAsync(StateHasChanged);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserStateContainer userState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
    }
}
#pragma warning restore 1591