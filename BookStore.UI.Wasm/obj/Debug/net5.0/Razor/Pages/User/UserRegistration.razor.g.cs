#pragma checksum "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\Pages\User\UserRegistration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0456925816504362189eb224a505e72d2176fb5e"
// <auto-generated/>
#pragma warning disable 1591
namespace BookStore.UI.Wasm.Pages.User
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/registration")]
    public partial class UserRegistration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Registration</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\n\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
