#pragma checksum "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e7988b605d7d654835621c6c32599197cbe9424"
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
#nullable restore
#line 6 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
using static H6_Site.GlobalObjects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
using AbpLib.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
using H6_Site.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Logs")]
    public partial class Logs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "padding-bottom:15px;");
            __builder.OpenElement(2, "span");
            __builder.AddAttribute(3, "style", "display: inline-block;");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "id", "Textbox1");
            __builder.AddAttribute(6, "class", "DefaultTextbox");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
                                                                          async e => await KeyDown(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(9, "onkeyup", 
#nullable restore
#line 12 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
                                                                                                                                true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "placeholder", "Search");
            __builder.AddAttribute(11, "tabindex", "0");
            __builder.AddElementReferenceCapture(12, (__value) => {
#nullable restore
#line 12 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
                                                                                                                                                                 TxtArea = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "table");
            __builder.OpenElement(15, "tr");
            __builder.OpenElement(16, "td");
            __builder.OpenElement(17, "div");
#nullable restore
#line 20 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
                 if (RecordSet?.Count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
                     foreach (var n in RecordSet)
                    {
                        Dictionary<string, object>[] records = n.Value;
                        string[] columns = records?.FirstOrDefault()?.Select(x => x.Key)?.ToArray();
                        if (columns?.Length > 0)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "style", "font-family:Arial; font-weight:bold; font-size:16px; padding-bottom:10px; ");
            __builder.AddContent(20, 
#nullable restore
#line 29 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
                                 n.Key

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                            ");
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table table-bordered");
            __builder.AddAttribute(24, "style", "font-family:Arial; font-size:11px;");
            __builder.OpenElement(25, "thead");
            __builder.OpenElement(26, "tr");
#nullable restore
#line 34 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
                                         for (int i = 0; i < columns.Length; i++)
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "th");
            __builder.AddAttribute(28, "scope", "col");
            __builder.AddContent(29, 
#nullable restore
#line 36 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
                                                             columns[i]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                                ");
            __builder.OpenElement(31, "tbody");
#nullable restore
#line 42 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
                                     foreach (var n2 in records)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "tr");
            __builder.AddAttribute(33, "style", "cursor:text;");
#nullable restore
#line 45 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
                                             foreach (var n3 in n2)
                                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "td");
            __builder.AddAttribute(35, "style", "max-width:300px; text-overflow: ellipsis; overflow:hidden;");
            __builder.AddContent(36, 
#nullable restore
#line 47 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
                                                                                                                        n3.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\abp\source\repos\H6_Site\Pages\Logs.razor"
       

    Dictionary<string, Dictionary<string, object>[]> RecordSet;
    ElementReference TxtArea;

    protected override async Task OnInitializedAsync()
    {
        if (!userState.CurrentUser.Admin)
        {
            await InvokeAsync(() => nav.NavigateTo(""));
        }
    }

    protected async Task KeyDown(KeyboardEventArgs e)
    {
        bool isEnter = e.Key == "Enter";
        if (isEnter)
        {

            try
            {
                watch.Start();
                if(RecordSet == null) RecordSet = new Dictionary<string, Dictionary<string, object>[]>(StringComparer.OrdinalIgnoreCase);

                string search = await JS.InvokeAsync<string>("GetControlValue", "Textbox1");
                string logFields = typeof(LogModel).GetSqlFields();
                string queryLogFields = typeof(XEventModel).GetSqlFields();
                string sysEventLogFields = typeof(SysEventLogModel).GetSqlFields();

                DataModel[] dataModels = new DataModel[]
                {             
                    new DataModel() { Fields = sysEventLogFields, SearchStmt = sysEventLogFields.GetSearchStmt(search), Table = "SysEventLog", OrderStmt = new KeyValuePair<string, string>("TimeGenerated","desc"), Limit = 1000 },
                    new DataModel() { Fields = logFields, SearchStmt = logFields.GetSearchStmt(search), Table = "Log", OrderStmt = new KeyValuePair<string, string>("CreatedDateTime","desc"), Limit = 1000 },
                    new DataModel() { Fields = queryLogFields, SearchStmt = queryLogFields.GetSearchStmt(search), Table = "QueryLog",OrderStmt = new KeyValuePair<string, string>("TimeStamp","desc"), Limit = 1000 }
                };

                for (int i = 0; i < dataModels.Length; i++)
                {
                    DataModel m = dataModels[i];
                    using HttpResponseMessage msg = await client.PostAsync("Data/GetData", m.SERIALIZE_CONTENT());
                    Dictionary<string, object>[] records = await msg.DeserializeStream<Dictionary<string, object>>();

                    RecordSet.AddData(m.Table, records);
                    await InvokeAsync(StateHasChanged);
                }

                watch.Stop();
                await watch.LogTime("Logs", "KeyDown");
                watch.Reset();
            }
            catch (Exception err)
            {
                await err.LogErrors("Logs", "KeyDown");
            }
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JS.InvokeVoidAsync("Focus", "Textbox1");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private System.Diagnostics.Stopwatch watch { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserStateContainer userState { get; set; }
    }
}
#pragma warning restore 1591
