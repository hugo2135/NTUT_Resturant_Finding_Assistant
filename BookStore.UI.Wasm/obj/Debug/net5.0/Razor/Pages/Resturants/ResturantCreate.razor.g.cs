#pragma checksum "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\Pages\Resturants\ResturantCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e2a53ed3fa2fb845251756a805475cc321ce02f"
// <auto-generated/>
#pragma warning disable 1591
namespace BookStore.UI.Wasm.Pages.Resturants
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/resturants/create/")]
    public partial class ResturantCreate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create A Resturant</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\Pages\Resturants\ResturantCreate.razor"
                 Model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\Pages\Resturants\ResturantCreate.razor"
                                       CreateResturant

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\n    \n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n            \n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\n    \n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "\n        ");
                __builder2.AddMarkupContent(13, "<label for=\"Name\">Name</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "id", "Name");
                __builder2.AddAttribute(17, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\Pages\Resturants\ResturantCreate.razor"
                                 Model.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Name = __value, Model.Name))));
                __builder2.AddAttribute(19, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Model.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n    ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "\n        ");
                __builder2.AddMarkupContent(25, "<label for=\"Style\">Style</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "id", "Style");
                __builder2.AddAttribute(29, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\Pages\Resturants\ResturantCreate.razor"
                                 Model.Style

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Style = __value, Model.Style))));
                __builder2.AddAttribute(31, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Model.Style));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\n    ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group");
                __builder2.AddMarkupContent(36, "\n        ");
                __builder2.AddMarkupContent(37, "<label for=\"PriceClass\">PriceClass</label>\n        ");
                __Blazor.BookStore.UI.Wasm.Pages.Resturants.ResturantCreate.TypeInference.CreateInputNumber_0(__builder2, 38, 39, "form-control", 40, "PriceClass", 41, 
#nullable restore
#line 26 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\Pages\Resturants\ResturantCreate.razor"
                                   Model.PriceClass

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.PriceClass = __value, Model.PriceClass)), 43, () => Model.PriceClass);
                __builder2.AddMarkupContent(44, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\n    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group");
                __builder2.AddMarkupContent(48, "\n        ");
                __builder2.AddMarkupContent(49, "<label for=\"Distance\">Distance</label>\n        ");
                __Blazor.BookStore.UI.Wasm.Pages.Resturants.ResturantCreate.TypeInference.CreateInputNumber_1(__builder2, 50, 51, "form-control", 52, "Distance", 53, 
#nullable restore
#line 30 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\Pages\Resturants\ResturantCreate.razor"
                                   Model.Distance

#line default
#line hidden
#nullable disable
                , 54, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Distance = __value, Model.Distance)), 55, () => Model.Distance);
                __builder2.AddMarkupContent(56, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\n    ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.AddMarkupContent(60, "\n        ");
                __builder2.AddMarkupContent(61, "<label for=\"Address\">Address</label>\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(62);
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "id", "Address");
                __builder2.AddAttribute(65, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\Pages\Resturants\ResturantCreate.razor"
                                     Model.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Address = __value, Model.Address))));
                __builder2.AddAttribute(67, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Model.Address));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\n    ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group");
                __builder2.AddMarkupContent(72, "\n        ");
                __builder2.AddMarkupContent(73, "<label for=\"Rating\">Rating</label>\n        ");
                __Blazor.BookStore.UI.Wasm.Pages.Resturants.ResturantCreate.TypeInference.CreateInputNumber_2(__builder2, 74, 75, "form-control", 76, "Rating", 77, 
#nullable restore
#line 38 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\Pages\Resturants\ResturantCreate.razor"
                                   Model.Rating

#line default
#line hidden
#nullable disable
                , 78, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Model.Rating = __value, Model.Rating)), 79, () => Model.Rating);
                __builder2.AddMarkupContent(80, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\n\n\n\n    ");
                __builder2.AddMarkupContent(82, "<button class=\"btn btn-primary\" type=\"submit\">\n        <span class=\"oi oi-pencil\"></span>\n        Submit Resturant\n    </button>\n\n    ");
                __builder2.OpenElement(83, "button");
                __builder2.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\Pages\Resturants\ResturantCreate.razor"
                      BackToList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "class", "btn btn-warning");
                __builder2.AddMarkupContent(86, "\n        <span class=\"oi oi-media-skip-backward\"></span>\n        Back to List\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\WilliamLiu\Desktop\Resturant_manager\src\BookStore.UI.Wasm\Pages\Resturants\ResturantCreate.razor"
       
    private Resturant Model = new Resturant();

    private async Task CreateResturant()
    {
        var response = await _repo.Create(Endpoints.ResturantsEndpoint, Model);
        if (response != null)
        {
            _taostService.ShowSuccess("Resturant created successfully");
            BackToList();
        }
    }

    private void BackToList()
    {
        _navManager.NavigateTo("/resturants/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService _taostService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IResturantRepository _repo { get; set; }
    }
}
namespace __Blazor.BookStore.UI.Wasm.Pages.Resturants.ResturantCreate
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
