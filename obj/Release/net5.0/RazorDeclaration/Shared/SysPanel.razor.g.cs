// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 5 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
using static GlobalObjects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
using AbpLib.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
using AbpLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
using Blazor.Extensions.Canvas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
using Blazor.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
using Blazor.Extensions.Canvas.Canvas2D;

#line default
#line hidden
#nullable disable
    public partial class SysPanel : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
       

    BECanvasComponent CanvasTotalTimePct { get; set; }
    BECanvasComponent CanvasTodayTimePct { get; set; }

    Canvas2DContext context1 { get; set; }
    Canvas2DContext context2 { get; set; }

    protected override void OnInitialized()
    {
        iupdate.OnInfoChangeAsync += Refresh;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            try
            {
                watch.Start();
                context1 = await CanvasTotalTimePct.CreateCanvas2DAsync();
                context2 = await CanvasTodayTimePct.CreateCanvas2DAsync();
                await context1.SetFillStyleAsync(COLOR.Black);
                await context1.SetFontAsync("10pt consolas");

                await context2.SetFillStyleAsync(COLOR.Black);
                await context2.SetFontAsync("10pt consolas");

                await CreateGraphPctTodayTime();
                await CreateGraphPctTotalTime();
                await watch.LogTime("SysInfo", "OnAfterRenderAsync", userState.CurrentUser.PropertyView("ProfilePicture"));
            }
            catch (Exception err)
            {
                await err.LogErrors("SysInfo", "OnAfterRenderAsync");
            }
        }
    }

    protected async Task CreateGraphPctTotalTime()
    {
        await context1.BeginPathAsync();
        await context1.MoveToAsync(spaceX, spaceX);

        await context1.LineToAsync(spaceX, chartHeightPct - spaceY);
        await context1.SetFillStyleAsync(COLOR.Black);
        await context1.FillTextAsync("CPU, Memory, Disk % (All date times)", 45, 15);
        await context1.FillTextAsync("CPU", 50, chartHeightPct - 5);
        await context1.FillTextAsync("RAM", 130, chartHeightPct - 5);
        await context1.FillTextAsync("DISK", 210, chartHeightPct - 5);
        await context1.FillTextAsync("Avg/Max", 270, chartHeightPct - 5);

        for (int i = 0; i < maxDataValPct + 1; i += 10)
        {
            await context1.FillTextAsync(i.ToString(), 0, (chartHeightPct - spaceY) - (i * 2));
        }

        //X-Axis
        await context1.LineToAsync(CanvasTodayTimePct.Width - 40, chartHeightPct - spaceY);

        await context1.DrawBarsPctGraphs(iupdate.AllValues);
    }

    protected async Task CreateGraphPctTodayTime()
    {
        await context2.BeginPathAsync();
        await context2.MoveToAsync(spaceX, spaceX);

        await context2.LineToAsync(spaceX, chartHeightPct - spaceY);
        await context2.SetFillStyleAsync(COLOR.Black);
        await context2.FillTextAsync("CPU, Memory, Disk % (Today)", 45, 15);
        await context2.FillTextAsync("CPU", 50, chartHeightPct - 5);
        await context2.FillTextAsync("RAM", 130, chartHeightPct - 5);
        await context2.FillTextAsync("DISK", 210, chartHeightPct - 5);
        await context2.FillTextAsync("Avg/Max", 270, chartHeightPct - 5);

        for (int i = 0; i < maxDataValPct + 1; i += 10)
        {
            await context2.FillTextAsync(i.ToString(), 0, (chartHeightPct - spaceY) - (i * 2));
        }

        //X-Axis
        await context2.LineToAsync(CanvasTodayTimePct.Width - 40, chartHeightPct - spaceY);
        await context2.DrawBarsPctGraphs(iupdate.TodayValues);
    }

    private async Task Refresh()
    {
        await InvokeAsync(StateHasChanged);
    }

    public async ValueTask DisposeAsync()
    {
        await InvokeAsync(() =>
        {
            iupdate.OnInfoChangeAsync -= Refresh;
            if (context1 != null)
            {
                context1.Dispose();
                context2.Dispose();
                CanvasTodayTimePct = null;
                CanvasTotalTimePct = null;
            }
        });
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserStateContainer userState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private System.Diagnostics.Stopwatch watch { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UpdateInfo iupdate { get; set; }
    }
}
#pragma warning restore 1591
