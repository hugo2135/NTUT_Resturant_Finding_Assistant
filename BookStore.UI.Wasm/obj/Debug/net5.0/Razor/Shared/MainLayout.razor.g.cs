#pragma checksum "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9109e0f86d7b2134556a97a06d4197630b9c7401"
// <auto-generated/>
#pragma warning disable 1591
namespace BookStore.UI.Wasm.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using BookStore.UI.Wasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using BookStore.UI.Wasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using BookStore.UI.Wasm.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using BookStore.UI.Wasm.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using BookStore.UI.Wasm.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using BookStore.UI.Wasm.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\Shared\MainLayout.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "sidebar");
            __builder.AddMarkupContent(4, "\n    ");
            __builder.OpenComponent<BookStore.UI.Wasm.Shared.NavMenu>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddMarkupContent(10, "\n    ");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\">\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\n    </div>\n\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddMarkupContent(14, "\n        ");
#nullable restore
#line 16 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\Shared\MainLayout.razor"
__builder.AddContent(15, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, " \n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
