// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookStore.UI.Wasm.Pages.Resturants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using BookStore.UI.Wasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using BookStore.UI.Wasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using BookStore.UI.Wasm.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using BookStore.UI.Wasm.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using BookStore.UI.Wasm.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using BookStore.UI.Wasm.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/resturants")]
    public partial class AuthorList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\Pages\Resturants\AuthorList.razor"
       
    private IList<Author> authors;
    private IList<Resturant> resturants;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        authors = await _repo.GetAll(Endpoints.AuthorsEndpoint);
        StateHasChanged();
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "c:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\Pages\Resturants\AuthorList.razor"
        

    private async Task HandleSearch(string search)
    {
        authors = await _repo.GetBySearch(Endpoints.AuthorsEndpoint, search);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorRepository _repo { get; set; }
    }
}
#pragma warning restore 1591
