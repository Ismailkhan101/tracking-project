#pragma checksum "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "accf673edb8311eb53f1add5ff027740caa6344d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ApplicationForm), @"mvc.1.0.view", @"/Views/Customer/ApplicationForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"accf673edb8311eb53f1add5ff027740caa6344d", @"/Views/Customer/ApplicationForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d08640f2ceeb54148f36356825127d4fa42990", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_ApplicationForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<tracking_project.Models.Customer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/content/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
  
    ViewData["Title"] = "ApplicationForm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "accf673edb8311eb53f1add5ff027740caa6344d4501", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"container-fluid\" style=\"padding:0px;\">\r\n    <div class=\"card\">\r\n        <div class=\"card-header\" style=\"padding-bottom: 0px;\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-2 logo\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "accf673edb8311eb53f1add5ff027740caa6344d5875", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""col-md-7"">
                    <h2 class=""text-center"" style=""padding-top:30px; padding-left: 47px; font-family:'Segoe UI'"">
                        Customer Application Form
                    </h2>
                </div>
            </div>
       
           
        </div>
       
        <div class=""card-body"">

            <div class=""row"">

                <div class=""col-md-12"">
                    <div class=""card-header bg-gray"">
                        <p class=""subHeading"">Customer Information</p>
                    </div>
                    <div class=""row "">
                        <table class=""table table-bordered"">
                            <thead class=""text-center"">
                                <tr>
                                    <th>
                                        Name
                                    </th>
                                    <th>
                                        ");
            WriteLiteral(@"Company Name
                                    </th>
                                    <th>
                                        Email
                                    </th>
                                    <th>
                                        CNIC
                                    </th>
                                    <th>
                                        Office Contact
                                    </th>


                                    
                                
                                </tr>
                            </thead>
                            <tbody class=""text-center"">


                                <tr>
                                    <td>

                                        ");
#nullable restore
#line 65 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
                                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 69 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
                                   Write(Html.DisplayFor(model => model.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 72 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
                                   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 75 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
                                   Write(Html.DisplayFor(model => model.CNIC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 78 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
                                   Write(Html.DisplayFor(model => model.OfficePhone));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </td>
                                    
                                  
                                </tr>
                            </tbody>
                        </table>
                    </div>

                </div>

            </div>

");
#nullable restore
#line 91 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
             if (Model.Vehicles.Count() > 0)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""card-header bg-gray"">
                            <p class=""subHeading"">Vehicle Information</p>
                        </div>
                    </div>


                    <div class=""col-md-12"">

                        <div class=""row "">
                            <table class=""table table-bordered"">
                                <thead class=""text-center"">
                                    <tr>
                                        <th>
                                            Reg No
                                        </th>
                                        <th>
                                           Make/Model
                                        </th>
                                        <th>
                                            Engine Number
                                        </th>
                                        <");
            WriteLiteral(@"th>
                                            Chasis Number
                                        </th>
                                         <th>
                                            Year
                                        </th>
                                         <th>
                                            Color
                                        </th>
                                         <th>
                                            Decided AMF
                                        </th>
                                       
                                    </tr>
                                </thead>
                                <tbody class=""text-center"">
");
#nullable restore
#line 140 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
                                     foreach (var item in Model.Vehicles)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n\r\n                                            ");
#nullable restore
#line 145 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
                                       Write(Html.DisplayFor(model => item.RegistrationNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                        </td>\r\n                                        <td>\r\n\r\n                                            ");
#nullable restore
#line 150 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
                                       Write(Html.DisplayFor(model => item.MakeModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                        </td>\r\n                                        <td>\r\n\r\n                                            ");
#nullable restore
#line 155 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
                                       Write(Html.DisplayFor(model => item.EngineNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 159 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
                                       Write(Html.DisplayFor(model => item.ChasisNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 162 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
                                       Write(Html.DisplayFor(model => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 165 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
                                       Write(Html.DisplayFor(model => item.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 168 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
                                       Write(Html.DisplayFor(model => item.DecidedAMF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 171 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
                                       Write(Html.DisplayFor(model => item.UnitVehicle.InstallationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                       \r\n                                    </tr>\r\n");
#nullable restore
#line 175 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 183 "D:\tracking project\tracking project\Views\Customer\ApplicationForm.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
          
            <div class=""row"">

                <div class=""col-md-12"">
                    <div class=""card-header bg-gray"">
                        <p class=""subHeading"">Confedential Information</p>
                    </div>
                    <div class=""row "">
                        <table class=""table table-bordered"">
                            <thead class=""text-center"">
                                <tr>
                                    <th>
                                        Normal Code
                                    </th>
                                    <th>
                                        Emergency Code
                                    </th>
                                    <th>
                                        Name (Secondary User)
                                    </th>
                                    <th>
                                        Primary Phone (Secondary User)
                                    </t");
            WriteLiteral("h>\r\n                                   \r\n\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody class=\"text-center\">\r\n                                <tr>\r\n                                    \r\n");
            WriteLiteral("                                </tr>\r\n\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tracking_project.Models.Customer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
