#pragma checksum "E:\Projects VS\GraceArtAuction2\Views\Artists\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ff6bb6c1264ac94df3607d4c42e3173d178cd93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artists_Index), @"mvc.1.0.view", @"/Views/Artists/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Artists/Index.cshtml", typeof(AspNetCore.Views_Artists_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ff6bb6c1264ac94df3607d4c42e3173d178cd93", @"/Views/Artists/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Artists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ArtAuction.Models.Artist>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Artists", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddArtist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block my-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ArtistView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "E:\Projects VS\GraceArtAuction2\Views\Artists\Index.cshtml"
  
    ViewData["Title"] = "Artists";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(107, 218, true);
            WriteLiteral("<main role=\"main\">\r\n\r\n    <section class=\"jumbotron text-center artistsTab\">\r\n        <div class=\"container\">\r\n            <h1 class=\"jumbotron-heading\">WE COOPERATE WITH MANY FANTASTIC ARTISTS!</h1>\r\n            <p>\r\n");
            EndContext();
#line 12 "E:\Projects VS\GraceArtAuction2\Views\Artists\Index.cshtml"
                 if (User.IsInRole("Administrator"))
                {

#line default
#line hidden
            BeginContext(398, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(418, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ff6bb6c1264ac94df3607d4c42e3173d178cd934884", async() => {
                BeginContext(508, 16, true);
                WriteLiteral("Add a new artist");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(528, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "E:\Projects VS\GraceArtAuction2\Views\Artists\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(549, 152, true);
            WriteLiteral("            </p>\r\n        </div>\r\n    </section>\r\n</main>\r\n<div class=\"album py-5 bg-light\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n\r\n");
            EndContext();
#line 24 "E:\Projects VS\GraceArtAuction2\Views\Artists\Index.cshtml"
             foreach (var artist in Model)
            {

#line default
#line hidden
            BeginContext(760, 93, true);
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <h3 class=\"text-center font-weight-bold\">");
            EndContext();
            BeginContext(853, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ff6bb6c1264ac94df3607d4c42e3173d178cd937309", async() => {
                BeginContext(932, 11, false);
#line 27 "E:\Projects VS\GraceArtAuction2\Views\Artists\Index.cshtml"
                                                                                                                                  Write(artist.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "E:\Projects VS\GraceArtAuction2\Views\Artists\Index.cshtml"
                                                                                                               WriteLiteral(artist.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(947, 118, true);
            WriteLiteral("</h3>\r\n                <p class=\"text-center font-weight-normal\"><span class=\"font-weight-bold\">Date of birth:</span> ");
            EndContext();
            BeginContext(1066, 35, false);
#line 28 "E:\Projects VS\GraceArtAuction2\Views\Artists\Index.cshtml"
                                                                                                          Write(artist.BirthDate.Date.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 118, true);
            WriteLiteral("</p>\r\n                <p class=\"text-center font-weight-normal\"><span class=\"font-weight-bold\">Place of birth:</span> ");
            EndContext();
            BeginContext(1220, 17, false);
#line 29 "E:\Projects VS\GraceArtAuction2\Views\Artists\Index.cshtml"
                                                                                                           Write(artist.BirthPlace);

#line default
#line hidden
            EndContext();
            BeginContext(1237, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 30 "E:\Projects VS\GraceArtAuction2\Views\Artists\Index.cshtml"
                 if (artist.DeathDate != null && artist.DeathPlace != null)
                {

#line default
#line hidden
            BeginContext(1339, 115, true);
            WriteLiteral("                    <p class=\"text-center font-weight-normal\"><span class=\"font-weight-bold\">Date of death:</span> ");
            EndContext();
            BeginContext(1455, 35, false);
#line 32 "E:\Projects VS\GraceArtAuction2\Views\Artists\Index.cshtml"
                                                                                                              Write(artist.DeathDate.Date.ToString("d"));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 122, true);
            WriteLiteral("</p>\r\n                    <p class=\"text-center font-weight-normal\"><span class=\"font-weight-bold\">Place of death:</span> ");
            EndContext();
            BeginContext(1613, 17, false);
#line 33 "E:\Projects VS\GraceArtAuction2\Views\Artists\Index.cshtml"
                                                                                                               Write(artist.DeathPlace);

#line default
#line hidden
            EndContext();
            BeginContext(1630, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 34 "E:\Projects VS\GraceArtAuction2\Views\Artists\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1655, 114, true);
            WriteLiteral("                <p class=\"text-center font-weight-normal\"><span class=\"font-weight-bold\">Styles\\movements:</span> ");
            EndContext();
            BeginContext(1770, 13, false);
#line 35 "E:\Projects VS\GraceArtAuction2\Views\Artists\Index.cshtml"
                                                                                                             Write(artist.Styles);

#line default
#line hidden
            EndContext();
            BeginContext(1783, 26, true);
            WriteLiteral("</p>\r\n            </div>\r\n");
            EndContext();
#line 37 "E:\Projects VS\GraceArtAuction2\Views\Artists\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(1826, 38, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ArtAuction.Models.Artist>> Html { get; private set; }
    }
}
#pragma warning restore 1591