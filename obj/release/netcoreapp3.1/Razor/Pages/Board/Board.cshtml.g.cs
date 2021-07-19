#pragma checksum "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a652a4d48a0ca5a1a2ef409358aee70bb38ef882"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AgileGame.Pages.Board.Pages_Board_Board), @"mvc.1.0.razor-page", @"/Pages/Board/Board.cshtml")]
namespace AgileGame.Pages.Board
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
#line 1 "/Users/pc/Projects/AgileGame/Pages/_ViewImports.cshtml"
using AgileGame;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a652a4d48a0ca5a1a2ef409358aee70bb38ef882", @"/Pages/Board/Board.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4312fa55e4a574e125b36989d88afc10b6d8854", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Board_Board : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Board/Card/AddCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wave-effect waves-light btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml"
  
    ViewData["Title"] = "Tablero";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script type=\"text/javascript\" src=\"https://code.jquery.com/ui/1.12.1/jquery-ui.js\"></script>\"\n");
            }
            );
            WriteLiteral(@"
<script>

    jQuery(document).ready( 
    jQuery(function () {
        jQuery("".draggable"").draggable({
            revert: ""invalid""
        });

        $('.column').droppable({
            accept: '.draggable',
            drop: function (event, ui) {
                var dropped = ui.draggable;
                var droppedOn = $(this);
                
                $(dropped).detach().css({ top: 0, left: 0 }).appendTo(droppedOn);
                    console.log(dropped[0].id, droppedOn[0].id);
                    $.ajax({
                        type: ""POST"",
                        dataType: ""json"",
                        contentType: ""application/json"",
                        url: ""/api/Tarjeta/movertarjeta"",
                        beforeSend: function (request) {
                            request.setRequestHeader(""RequestVerificationToken"", $('#RequestVerificationToken').val());
                        },
                        data: JSON.stringify({ cardId: parseInt( dropped[0].id), columnaId");
            WriteLiteral(": parseInt(droppedOn[0].id) }),\n                });\n                \n            }\n        });\n        \n\n         \n    }));\n</script>\n\n\n<div class=\"container\">\n    <div class=\"row\">\n        <h3 >Tablero: ");
#nullable restore
#line 51 "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml"
                 Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 51 "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml"
                             Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("    </h3>\n    </div>\n\n    <div class=\"row\">\n        <div class=\"col s10\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a652a4d48a0ca5a1a2ef409358aee70bb38ef8825717", async() => {
                WriteLiteral("\n                Agregar Tarjeta\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml"
                                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml"
                                                                        WriteLiteral(Model.Nombre);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"row\">\n");
#nullable restore
#line 62 "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml"
         foreach (var column in Model.Columnas)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col m4\">\n                <h3 style=\"text-align:center\">");
#nullable restore
#line 65 "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml"
                                         Write(column.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 65 "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml"
                                                        Write(column.Limite);

#line default
#line hidden
#nullable disable
            WriteLiteral(") </h3> \n                <hr/>\n\n                <div class=\"column\" style=\"min-height: 600px\"");
            BeginWriteAttribute("id", " id=\"", 2008, "\"", 2023, 1);
#nullable restore
#line 68 "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml"
WriteAttributeValue("", 2013, column.Id, 2013, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    \n");
#nullable restore
#line 70 "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml"
                     foreach (var card in column.Cards)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card draggable blue-grey darken-1 \"");
            BeginWriteAttribute("id", " id=\"", 2196, "\"", 2209, 1);
#nullable restore
#line 72 "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml"
WriteAttributeValue("", 2201, card.Id, 2201, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <div class=\"card-content white-text\">\n                                <p>");
#nullable restore
#line 74 "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml"
                              Write(card.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                               \n                                \n                                    <div class=\"col m12\"> € ");
#nullable restore
#line 77 "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml"
                                                       Write(card.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                                    <div class=\"col m12\"> Hs:  ");
#nullable restore
#line 78 "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml"
                                                          Write(card.Restantes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 78 "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml"
                                                                            Write(card.Horas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                                \n                            </div> \n\n                        </div>\n");
#nullable restore
#line 83 "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n");
#nullable restore
#line 86 "/Users/pc/Projects/AgileGame/Pages/Board/Board.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BoardModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BoardModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BoardModel>)PageContext?.ViewData;
        public BoardModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
