#pragma checksum "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c454fde933393e3d87459e9ca310d4eb4caa3f80"
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
#nullable restore
#line 12 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
 if (iupdate.AllValues != null && iupdate.TodayValues != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "table");
            __builder.OpenElement(1, "tr");
            __builder.OpenElement(2, "td");
            __builder.OpenElement(3, "div");
            __builder.OpenElement(4, "span");
            __builder.AddAttribute(5, "style", "display:inline-block;");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(6);
            __builder.AddAttribute(7, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 19 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
                                         320

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 19 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
                                                      250

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(9, (__value) => {
#nullable restore
#line 19 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
                                                                 CanvasTotalTimePct = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "span");
            __builder.AddAttribute(12, "style", "display:inline-block; padding-left:100px;");
            __builder.OpenComponent<Blazor.Extensions.Canvas.BECanvas>(13);
            __builder.AddAttribute(14, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 22 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
                                         320

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 22 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
                                                      250

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(16, (__value) => {
#nullable restore
#line 22 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
                                                                 CanvasTodayTimePct = (Blazor.Extensions.Canvas.BECanvas)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(17, "div");
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table table-borderless");
            __builder.OpenElement(20, "tr");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "div");
            __builder.AddContent(23, "Avg/Current Measure interval: ");
            __builder.AddContent(24, 
#nullable restore
#line 33 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
                                                        iupdate.AllValues.AvgInterval

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, "/");
            __builder.AddContent(26, 
#nullable restore
#line 33 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
                                                                                       LocalSVC_Interval

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "tr");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "ItemColumns");
            __builder.OpenElement(32, "ul");
            __builder.AddAttribute(33, "class", "MeasureList");
            __builder.AddMarkupContent(34, "<li class=\"header\">API</li>\r\n                            ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "grey");
            __builder.AddContent(37, 
#nullable restore
#line 41 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
                                              iupdate.AllValues.APICalls

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(38, " Calls in total");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                            ");
            __builder.OpenElement(40, "li");
            __builder.AddAttribute(41, "class", "grey");
            __builder.AddContent(42, 
#nullable restore
#line 42 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
                                              iupdate.TodayValues.APICalls

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(43, " Calls today");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n                    ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "ItemColumns");
            __builder.OpenElement(47, "ul");
            __builder.AddAttribute(48, "class", "MeasureList");
            __builder.AddMarkupContent(49, "<li class=\"header\">Network</li>\r\n                            ");
            __builder.OpenElement(50, "li");
            __builder.AddAttribute(51, "class", "grey");
            __builder.AddContent(52, 
#nullable restore
#line 49 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
                                              iupdate.AllValues.AvgNetworkUsage

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(53, " Average KB/Measure");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.OpenElement(55, "li");
            __builder.AddAttribute(56, "class", "grey");
            __builder.AddContent(57, 
#nullable restore
#line 50 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
                                              iupdate.AllValues.HighestNetUsage

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(58, " Highest KB/Measure");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenElement(60, "tr");
            __builder.OpenElement(61, "td");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "ItemColumns");
            __builder.OpenElement(64, "ul");
            __builder.AddAttribute(65, "class", "MeasureList");
            __builder.AddMarkupContent(66, "<li class=\"header\">Disk</li>\r\n                            ");
            __builder.OpenElement(67, "li");
            __builder.AddAttribute(68, "class", "grey");
            __builder.AddContent(69, 
#nullable restore
#line 61 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
                                              iupdate.AllValues.AvgKBPerDisk

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(70, " Average KB/Measure");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                            ");
            __builder.OpenElement(72, "li");
            __builder.AddAttribute(73, "class", "grey");
            __builder.AddContent(74, 
#nullable restore
#line 62 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
                                              iupdate.AllValues.HighestKBPerDisk

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(75, " Highest KB/Measure");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "ItemColumns");
            __builder.OpenElement(79, "ul");
            __builder.AddAttribute(80, "class", "MeasureList");
            __builder.AddMarkupContent(81, "<li class=\"header\">Database</li>\r\n                            ");
            __builder.OpenElement(82, "li");
            __builder.AddAttribute(83, "class", "grey");
            __builder.AddContent(84, "Longest query time: ");
            __builder.AddContent(85, 
#nullable restore
#line 68 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
                                                                  iupdate.AllValues.LongestQuery

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(86, " ms");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                            ");
            __builder.OpenElement(88, "li");
            __builder.AddAttribute(89, "class", "grey");
            __builder.AddContent(90, "Average query time: ");
            __builder.AddContent(91, 
#nullable restore
#line 69 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
                                                                  iupdate.AllValues.AvgQueryLength

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(92, " ms");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\abp\source\repos\H6_Site\Shared\SysPanel.razor"
}

#line default
#line hidden
#nullable disable
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
