#pragma checksum "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8d540c7079c2192c11bdf00aca2b3706e75c692"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication10.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\_Imports.razor"
using WebApplication10;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\_Imports.razor"
using WebApplication10.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fizzBuzz")]
    public partial class FizzBuzz : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>FizzBuzz</h3>\r\n");
            __builder.AddMarkupContent(1, "<p>Write a program</p>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<div class=\"col-3\">FizzValue:</div>\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "number");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                                  FizzValue

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FizzValue = __value, FizzValue, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\"\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row");
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.AddMarkupContent(17, "<div class=\"col-3\">BuzzValue:</div>\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "number");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                                  BuzzValue

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => BuzzValue = __value, BuzzValue, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\"\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "row");
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-");
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-primary");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                                  FizzBuzzIt

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "FizzBuzz It");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 22 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
 if (buzzItems.Count() > 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row pt-5");
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "table-responsive");
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "table");
            __builder.AddAttribute(47, "class", "table table-striped table-bordered table-hover table-sm");
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.AddMarkupContent(49, "<thead class=\"thead-dark\">\r\n                    <tr><th colspan=\"10\">Results for FizzBuzz</th></tr>\r\n                </thead>\r\n                ");
            __builder.OpenElement(50, "tbody");
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 31 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                     for (var i = 0; i < 100; i += 10)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "                        ");
            __builder.OpenElement(53, "tr");
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.OpenElement(55, "td");
            __builder.AddAttribute(56, "class", 
#nullable restore
#line 34 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                        buzzItems[i].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, 
#nullable restore
#line 34 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                                                 buzzItems[i].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                            ");
            __builder.OpenElement(59, "td");
            __builder.AddAttribute(60, "class", 
#nullable restore
#line 35 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                        buzzItems[i+1].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(61, 
#nullable restore
#line 35 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                                                   buzzItems[i + 1].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                            ");
            __builder.OpenElement(63, "td");
            __builder.AddAttribute(64, "class", 
#nullable restore
#line 36 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                        buzzItems[i+2].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(65, 
#nullable restore
#line 36 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                                                   buzzItems[i + 2].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                            ");
            __builder.OpenElement(67, "td");
            __builder.AddAttribute(68, "class", 
#nullable restore
#line 37 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                        buzzItems[i+3].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(69, 
#nullable restore
#line 37 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                                                   buzzItems[i + 3].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                            ");
            __builder.OpenElement(71, "td");
            __builder.AddAttribute(72, "class", 
#nullable restore
#line 38 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                        buzzItems[i+4].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(73, 
#nullable restore
#line 38 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                                                   buzzItems[i + 4].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                            ");
            __builder.OpenElement(75, "td");
            __builder.AddAttribute(76, "class", 
#nullable restore
#line 39 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                        buzzItems[i+5].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(77, 
#nullable restore
#line 39 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                                                   buzzItems[i + 5].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                            ");
            __builder.OpenElement(79, "td");
            __builder.AddAttribute(80, "class", 
#nullable restore
#line 40 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                        buzzItems[i+6].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(81, 
#nullable restore
#line 40 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                                                   buzzItems[i + 6].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                            ");
            __builder.OpenElement(83, "td");
            __builder.AddAttribute(84, "class", 
#nullable restore
#line 41 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                        buzzItems[i+7].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(85, 
#nullable restore
#line 41 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                                                   buzzItems[i + 7].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                            ");
            __builder.OpenElement(87, "td");
            __builder.AddAttribute(88, "class", 
#nullable restore
#line 42 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                        buzzItems[i+8].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(89, 
#nullable restore
#line 42 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                                                   buzzItems[i + 8].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                            ");
            __builder.OpenElement(91, "td");
            __builder.AddAttribute(92, "class", 
#nullable restore
#line 43 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                        buzzItems[i+9].ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(93, 
#nullable restore
#line 43 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                                                                   buzzItems[i + 9].Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 45 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
#nullable restore
#line 51 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\winya\source\repos\WebApplication10\WebApplication10\Pages\FizzBuzz.razor"
       

    List<BuzzItem> buzzItems = new List<BuzzItem>();
    private int FizzValue = 3;
    private int BuzzValue = 5;

    bool Fizz = false;
    bool Buzz = false;

    void FizzBuzzIt()
    {
        if (buzzItems.Count > 0)
        {
            buzzItems.Clear();
        }
        for (var i = 1; i <= 100; i++)
        {
            Fizz = (i % FizzValue == 0);
            Buzz = (i % BuzzValue == 0);

            if (Fizz & Buzz)
            {
                buzzItems.Add(new BuzzItem { Value = "FizzBuzz", ClassName = "fizzBuzz" });
            }
            else if (Fizz)
            {
                buzzItems.Add(new BuzzItem { Value = "Fizz", ClassName = "fizz" });
            }
            else if (Buzz)
            {
                buzzItems.Add(new BuzzItem { Value = "Buzz", ClassName = "buzz" });
            }
            else
            {
                buzzItems.Add(new BuzzItem { Value = i.ToString(), ClassName = "fizzBuzz" });
            }
        }
    }
    class BuzzItem
    {
        
        
        public string Value { get; set; }
        public string ClassName { get; set; }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
