#pragma checksum "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28e72e38bb9bb16379eb6fb8a1cff09a816dd0df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Details), @"mvc.1.0.view", @"/Views/Person/Details.cshtml")]
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
#line 1 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\_ViewImports.cshtml"
using Person.Domain.Domains;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\_ViewImports.cshtml"
using Person.Domain.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\_ViewImports.cshtml"
using Person.WebClient.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\_ViewImports.cshtml"
using Person.WebClient.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28e72e38bb9bb16379eb6fb8a1cff09a816dd0df", @"/Views/Person/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82c397680f0e5b0a74bf131b4ae29a2119945e92", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Person", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePerson", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
  
    ViewBag.Title = "Details";
    var photoPath = "/images/" + (Model.PhotoPath ?? "noimage.PNG");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"row justify-content-center m-3\">\r\n    <div class=\"col-sm-8\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                <h1>");
#nullable restore
#line 13 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
               Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n\r\n            <div class=\"card-body text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28e72e38bb9bb16379eb6fb8a1cff09a816dd0df8212", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                                   WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                <h4>Employee ID : ");
#nullable restore
#line 19 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                             Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4>LastName : ");
#nullable restore
#line 20 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                          Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4>BirthDate : ");
#nullable restore
#line 21 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                           Write(Model.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4>City : ");
#nullable restore
#line 22 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                      Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4>Gender : ");
#nullable restore
#line 23 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                        Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4>PrivateNumber : ");
#nullable restore
#line 24 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                               Write(Model.PrivateNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 25 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                 if (Model.PhoneNumbers != null && Model.PhoneNumbers.Count != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4>\r\n                        PhoneNumbers : ");
#nullable restore
#line 28 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                                        foreach (var number in Model.PhoneNumbers)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> ");
#nullable restore
#line 29 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                           Write(number.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 29 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                                            Write(number.NumberType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>");
#nullable restore
#line 29 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </h4>\r\n");
#nullable restore
#line 31 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                 if (Model.RelatedTo != null && Model.RelatedTo.Count != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4>\r\n                        Relations : ");
#nullable restore
#line 36 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                                     foreach (var relation in Model.RelatedTo)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> ");
#nullable restore
#line 37 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                           Write(service.Fetch(relation.ToId).LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 37 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                                                                    Write(relation.RelationType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>");
#nullable restore
#line 37 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                                                                                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </h4>\r\n");
#nullable restore
#line 39 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            <div class=\"card-footer text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28e72e38bb9bb16379eb6fb8a1cff09a816dd0df16301", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28e72e38bb9bb16379eb6fb8a1cff09a816dd0df16580", async() => {
                    WriteLiteral("Back");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28e72e38bb9bb16379eb6fb8a1cff09a816dd0df18119", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                                                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n                    <span");
                BeginWriteAttribute("id", " id=\"", 1934, "\"", 1966, 2);
                WriteAttributeValue("", 1939, "confirmDeleteSpan_", 1939, 18, true);
#nullable restore
#line 47 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
WriteAttributeValue("", 1957, Model.Id, 1957, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display:none\">\r\n                        <span>Delete?</span>\r\n\r\n                        <button type=\"submit\" class=\"btn btn-danger\" style=\"width:30px\">Y</button>\r\n                        <a href=\"#\" class=\"btn btn-primary\" style=\"width:30px\"");
                BeginWriteAttribute("onclick", "\r\n                           onclick=\"", 2217, "\"", 2288, 4);
                WriteAttributeValue("", 2255, "confirmDelete(\'", 2255, 15, true);
#nullable restore
#line 52 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
WriteAttributeValue("", 2270, Model.Id, 2270, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2279, "\',", 2279, 2, true);
                WriteAttributeValue(" ", 2281, "false)", 2282, 7, true);
                EndWriteAttribute();
                WriteLiteral(">N</a>\r\n                    </span>\r\n\r\n                    <span");
                BeginWriteAttribute("id", " id=\"", 2353, "\"", 2378, 2);
                WriteAttributeValue("", 2358, "deleteSpan_", 2358, 11, true);
#nullable restore
#line 55 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
WriteAttributeValue("", 2369, Model.Id, 2369, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <a href=\"#\" class=\"btn btn-danger\"");
                BeginWriteAttribute("onclick", "\r\n                           onclick=\"", 2440, "\"", 2510, 4);
                WriteAttributeValue("", 2478, "confirmDelete(\'", 2478, 15, true);
#nullable restore
#line 57 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
WriteAttributeValue("", 2493, Model.Id, 2493, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2502, "\',", 2502, 2, true);
                WriteAttributeValue(" ", 2504, "true)", 2505, 6, true);
                EndWriteAttribute();
                WriteLiteral(">Delete</a>\r\n                    </span>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\user\Desktop\PersonManagment\PersonManagment\PersonManagment\Person.WebClient\Views\Person\Details.cshtml"
                                                                WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28e72e38bb9bb16379eb6fb8a1cff09a816dd0df26124", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPersonService service { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
