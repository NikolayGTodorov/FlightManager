#pragma checksum "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a2d6220e625b7c8f8bf84818933780914a77543"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flights_Index), @"mvc.1.0.view", @"/Views/Flights/Index.cshtml")]
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
#line 1 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a2d6220e625b7c8f8bf84818933780914a77543", @"/Views/Flights/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15f339ab26e1f7c427971d34ecda8fd273fe3c5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Flights_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcMovie.Models.Flights>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:normal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script type=\"text/javascript\" src=\"https://cdn.datatables.net/1.10.2/js/jquery.dataTables.min.js\"></script>\n    <script>\n        $(document).ready(function () {\n            $(\'#indexTable\').DataTable();\n        });\n    </script>\n");
            }
            );
            WriteLiteral("<h1 class=\"display-3 text-center\">Flights List</h1>\n\n<p style=\"text-align:center;\">\n");
#nullable restore
#line 18 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a2d6220e625b7c8f8bf84818933780914a775436670", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <!--<button type=\"button\" onclick=\"location.href=\'");
#nullable restore
#line 21 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
                                                     Write(Url.Action("Create", "Flights"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\" />-->\n");
#nullable restore
#line 22 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>\n<div class=\"table-responsive\">\n    <table id=\"indexTable\" class=\"table table-hover\">\n        <thead class=\"text-center\">\n            <tr>\n                <th>\n                    ");
#nullable restore
#line 30 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.LocationFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 33 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.LocationTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 36 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DepartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 39 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ArrivalTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 42 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PlaneType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 45 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PilotName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 48 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PlaneCapacityNormal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 51 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PlaneCapacityBusiness));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 54 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.AlreadyReserved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th></th>\n            </tr>\n        </thead>\n        <tbody class=\"text-center\">\n");
#nullable restore
#line 60 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 64 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LocationFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 67 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LocationTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 70 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DepartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 73 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ArrivalTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 76 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PlaneType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 79 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PilotName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 82 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PlaneCapacityNormal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 85 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PlaneCapacityBusiness));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 88 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AlreadyReserved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n");
#nullable restore
#line 91 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {
                            if (User.IsInRole("Admin") || User.IsInRole("Worker"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""btn-group dropright"">
                                    <button type=""button"" class=""btn btn-danger dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">Menu</button>
                                    <div class=""dropdown-menu"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a2d6220e625b7c8f8bf84818933780914a7754316180", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
                                                                                     WriteLiteral(item.PlaneId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a2d6220e625b7c8f8bf84818933780914a7754318505", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
                                                                                        WriteLiteral(item.PlaneId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a2d6220e625b7c8f8bf84818933780914a7754320836", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
                                                                                       WriteLiteral(item.PlaneId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </div>\n                                </div>\n");
#nullable restore
#line 103 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""btn-group dropright"">
                                <button type=""button"" class=""btn btn-danger dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">Menu</button>
                                <div class=""dropdown-menu"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a2d6220e625b7c8f8bf84818933780914a7754323865", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
                                                                                    WriteLiteral(item.PlaneId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </div>\n                            </div>\n");
#nullable restore
#line 113 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                </tr>\n");
#nullable restore
#line 116 "C:\Users\nik21\Downloads\FlightsManager (3)\FlightManager\Views\Flights\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcMovie.Models.Flights>> Html { get; private set; }
    }
}
#pragma warning restore 1591
