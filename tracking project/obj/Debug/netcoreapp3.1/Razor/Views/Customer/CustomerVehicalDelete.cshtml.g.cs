#pragma checksum "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a2e710b5752dba5e524988e259a940eaec5ca44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CustomerVehicalDelete), @"mvc.1.0.view", @"/Views/Customer/CustomerVehicalDelete.cshtml")]
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
#line 1 "D:\tracking project\tracking project\Views\_ViewImports.cshtml"
using tracking_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\tracking project\tracking project\Views\_ViewImports.cshtml"
using tracking_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a2e710b5752dba5e524988e259a940eaec5ca44", @"/Views/Customer/CustomerVehicalDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d08640f2ceeb54148f36356825127d4fa42990", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_CustomerVehicalDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<tracking_project.Models.CustomerVehicle>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CustomerVehicalDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
  
    ViewData["Title"] = "CustomerVehicalDelete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<h3>Are you sure you want to delete this?</h3>
<div>

    <hr />
    <h5 style=""font-family:'Times New Roman'"">Vehicle Info</h5>
    <table class=""table table-bordered"" style=""font-family:'Times New Roman'"">
        <dl>
        <tr>
            <th>
                ");
#nullable restore
#line 18 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
           Write(Html.DisplayNameFor(model => model.RegistrationNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
           Write(Html.DisplayNameFor(model => model.EngineNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
           Write(Html.DisplayNameFor(model => model.ChasisNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n\r\n                ");
#nullable restore
#line 31 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
           Write(Html.DisplayFor(model => model.RegistrationNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
           Write(Html.DisplayFor(model => model.EngineNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
           Write(Html.DisplayFor(model => model.ChasisNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n        </tr>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
           Write(Html.DisplayNameFor(model => model.MakeModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
           Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
           Write(Html.DisplayFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
           Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
           Write(Html.DisplayFor(model => model.MakeModel));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </td>
        </tr>
        <thead>
            </dl>
    </table>
    <br />
    <h5 style=""font-family:'Times New Roman'"">Payment info</h5>
    <table class=""table"">
        <thead>
            <tr style=""font-family: 'Times New Roman'; "">
                <th>
                    ");
#nullable restore
#line 74 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 77 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayNameFor(model => model.Net));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 80 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayNameFor(model => model.ReceiveAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th> ");
#nullable restore
#line 82 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
                Write(Html.DisplayNameFor(model => model.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n\r\n            </tr>\r\n            <tr style=\"font-family: \'Times New Roman\';\">\r\n                <td>\r\n                    ");
#nullable restore
#line 88 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 91 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayFor(model => model.Net));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 94 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayFor(model => model.ReceiveAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 96 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayFor(model => model.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n            <tr style=\"font-family: \'Times New Roman\';\">\r\n                <th>");
#nullable restore
#line 100 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayNameFor(model => model.Deduction));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th> ");
#nullable restore
#line 101 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
                Write(Html.DisplayNameFor(model => model.PaymentMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>\r\n                    ");
#nullable restore
#line 103 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayNameFor(model => model.ExtraCharges));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 106 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayNameFor(model => model.UnitCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n            <tr style=\"font-family: \'Times New Roman\';\">\r\n                <td>");
#nullable restore
#line 110 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayFor(model => model.Deduction));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 111 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayFor(model => model.PaymentMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 112 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
                Write(Html.DisplayFor(model => model.ExtraCharges));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 114 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayFor(model => model.UnitCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr style=\"font-family: \'Times New Roman\'\">\r\n                <th>\r\n                    ");
#nullable restore
#line 119 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayNameFor(model => model.ServiceTax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 122 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayNameFor(model => model.TaxDeduction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n");
            WriteLiteral("                <th>\r\n                    ");
#nullable restore
#line 128 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayNameFor(model => model.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n            <tr style=\"font-family: \'Times New Roman\'\">\r\n                <td>\r\n                    ");
#nullable restore
#line 133 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayFor(model => model.ServiceTax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 136 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayFor(model => model.TaxDeduction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 142 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayFor(model => model.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </td>
            </tr>

            </tbody>
    </table>




    <br />
    <h5 style=""font-family:'Times New Roman';"">Extra Info</h5>
    <table class=""table "">
        <thead>
            <tr style=""font-family: 'Times New Roman';"">
                <th>
                    ");
#nullable restore
#line 158 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayNameFor(model => model.GeoFences));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 161 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayNameFor(model => model.Source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 164 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayNameFor(model => model.PaymentRemarkes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n            <tr style=\"font-family: \'Times New Roman\'; \">\r\n                <td>\r\n                    ");
#nullable restore
#line 173 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayFor(model => model.GeoFences));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 176 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayFor(model => model.Source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 179 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayFor(model => model.PaymentRemarkes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n            <tr style=\"font-family:\'Times New Roman\';\">\r\n                <th> ");
#nullable restore
#line 184 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
                Write(Html.DisplayNameFor(model => model.PaymentAlert));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 185 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayNameFor(model => model.SpacialRemarkes));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n            <tr style=\"font-family:\'Times New Roman\';\">\r\n                <td>");
#nullable restore
#line 188 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayFor(model => model.PaymentAlert));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 189 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
               Write(Html.DisplayFor(model => model.SpacialRemarkes));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n        </tbody>\r\n    </table>\r\n    <table class=\"table \">\r\n        <tbody>\r\n\r\n    </table>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a2e710b5752dba5e524988e259a940eaec5ca4420660", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a2e710b5752dba5e524988e259a940eaec5ca4420927", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 200 "D:\tracking project\tracking project\Views\Customer\CustomerVehicalDelete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.VehicalId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a2e710b5752dba5e524988e259a940eaec5ca4422723", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tracking_project.Models.CustomerVehicle> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
