#pragma checksum "C:\Users\User\Desktop\Pustoknew\Pustok\Views\Shared\_BasketPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aebab12f38bbe0dd31d5a9156d829fee9bbe7de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BasketPartial), @"mvc.1.0.view", @"/Views/Shared/_BasketPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\User\Desktop\Pustoknew\Pustok\Views\_ViewImports.cshtml"
using Pustok.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Pustoknew\Pustok\Views\_ViewImports.cshtml"
using Pustok.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Pustoknew\Pustok\Views\_ViewImports.cshtml"
using Pustok.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Pustoknew\Pustok\Views\_ViewImports.cshtml"
using Pustok.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Pustoknew\Pustok\Views\_ViewImports.cshtml"
using Pustok.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aebab12f38bbe0dd31d5a9156d829fee9bbe7de", @"/Views/Shared/_BasketPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f86939d6056b69a82cf94bef96cff384d2a792d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BasketPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/product-details.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/checkout.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn--primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"cart-total\">\r\n                                            <span class=\"text-number\">\r\n                                                ");
#nullable restore
#line 4 "C:\Users\User\Desktop\Pustoknew\Pustok\Views\Shared\_BasketPartial.cshtml"
                                           Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </span>
                                            <span class=""text-item"">
                                                Shopping Cart
                                            </span>
                                            <span class=""price"">
");
#nullable restore
#line 10 "C:\Users\User\Desktop\Pustoknew\Pustok\Views\Shared\_BasketPartial.cshtml"
                                                  
                                                    double total = 0;

                                                    foreach (BasketVM basketVM in Model)
                                                    {
                                                        total += (basketVM.Count * basketVM.Price);
                                                    }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                £");
#nullable restore
#line 19 "C:\Users\User\Desktop\Pustoknew\Pustok\Views\Shared\_BasketPartial.cshtml"
                                            Write(total.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                <i class=""fas fa-chevron-down""></i>
                                            </span>
                                        </div>
                                        <div class=""cart-dropdown-block"">
");
#nullable restore
#line 24 "C:\Users\User\Desktop\Pustoknew\Pustok\Views\Shared\_BasketPartial.cshtml"
                                             foreach (BasketVM basketVM in Model)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\" single-cart-block \">\r\n                                                <div class=\"cart-product\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aebab12f38bbe0dd31d5a9156d829fee9bbe7de8961", async() => {
                WriteLiteral("\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9aebab12f38bbe0dd31d5a9156d829fee9bbe7de9272", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1756, "~/image/products/", 1756, 17, true);
#nullable restore
#line 29 "C:\Users\User\Desktop\Pustoknew\Pustok\Views\Shared\_BasketPartial.cshtml"
AddHtmlAttributeValue("", 1773, basketVM.MainImage, 1773, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    <div class=\"content\">\r\n                                                        <h3 class=\"title\">\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aebab12f38bbe0dd31d5a9156d829fee9bbe7de12086", async() => {
                WriteLiteral("\r\n                                                                ");
#nullable restore
#line 34 "C:\Users\User\Desktop\Pustoknew\Pustok\Views\Shared\_BasketPartial.cshtml"
                                                           Write(basketVM.GenreName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\User\Desktop\Pustoknew\Pustok\Views\Shared\_BasketPartial.cshtml"
                                                                               Write(basketVM.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        </h3>\r\n                                                        <p class=\"price\"><span class=\"qty\">");
#nullable restore
#line 37 "C:\Users\User\Desktop\Pustoknew\Pustok\Views\Shared\_BasketPartial.cshtml"
                                                                                      Write(basketVM.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ×</span> £");
#nullable restore
#line 37 "C:\Users\User\Desktop\Pustoknew\Pustok\Views\Shared\_BasketPartial.cshtml"
                                                                                                                Write(basketVM.Price.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                        <button class=""cross-btn""><i class=""fas fa-times""></i></button>
                                                    </div>
                                                </div>
                                            </div>
");
#nullable restore
#line 42 "C:\Users\User\Desktop\Pustoknew\Pustok\Views\Shared\_BasketPartial.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\" single-cart-block \">\r\n                                                <div class=\"btn-block\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aebab12f38bbe0dd31d5a9156d829fee9bbe7de15408", async() => {
                WriteLiteral("\r\n                                                        View Cart <i class=\"fas fa-chevron-right\"></i>\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aebab12f38bbe0dd31d5a9156d829fee9bbe7de17063", async() => {
                WriteLiteral("\r\n                                                        Check Out <i class=\"fas fa-chevron-right\"></i>\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
