#pragma checksum "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\CarWeb\WebCar.UI\Views\Shared\Filter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e1f68fd5f9c5b0df3fe3ca9e2960fd214ddc85f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Filter), @"mvc.1.0.view", @"/Views/Shared/Filter.cshtml")]
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
#line 1 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\CarWeb\WebCar.UI\Views\_ViewImports.cshtml"
using WebCar.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\CarWeb\WebCar.UI\Views\_ViewImports.cshtml"
using WebCar.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\CarWeb\WebCar.UI\Views\_ViewImports.cshtml"
using EntityLayer.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e1f68fd5f9c5b0df3fe3ca9e2960fd214ddc85f", @"/Views/Shared/Filter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e04c462fa0dcca8dce68ed01244004d993dd640", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Filter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/NiceAdmin/js/jquery-1.8.3.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\CarWeb\WebCar.UI\Views\Shared\Filter.cshtml"
   var x = new Advert();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-8\">\r\n    <br />\r\n    FİLTRELEME\r\n");
#nullable restore
#line 7 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\CarWeb\WebCar.UI\Views\Shared\Filter.cshtml"
     using (Html.BeginForm("Filtre", "Home", FormMethod.Get, new { @class = "row" }))
    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row mb-3"">
            <label for=""inputEmail3"" class=""col-sm-4 col-form-label"">En Az</label>
            <div class=""col-sm-8"">
                <input type=""text"" class=""form-control"" name=""min"" placeholder=""En Az(Fiyat)"">
            </div>
        </div>
        <div class=""row mb-3"">
            <label for=""inputEmail3"" class=""col-sm-4 col-form-label"">En Çok</label>
            <div class=""col-sm-8"">
                <input type=""text"" class=""form-control"" name=""max"" placeholder=""En Çok(Fiyat)"">
            </div>
        </div>
        <div class=""row mb-3"">
            <label for=""inputEmail3"" class=""col-sm-4 col-form-label"">Şehir</label>
            <div class=""col-sm-8"">



                ");
#nullable restore
#line 28 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\CarWeb\WebCar.UI\Views\Shared\Filter.cshtml"
           Write(Html.DropDownListFor(item => x.CityId, (IEnumerable<SelectListItem>)ViewBag.cities, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"row mb-3\">\r\n            <label for=\"inputEmail3\" class=\"col-sm-4 col-form-label\">Durum</label>\r\n            <div class=\"col-sm-8\">\r\n\r\n\r\n                ");
#nullable restore
#line 38 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\CarWeb\WebCar.UI\Views\Shared\Filter.cshtml"
           Write(Html.DropDownListFor(item => x.StateId, (IEnumerable<SelectListItem>)ViewBag.states, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"row mb-3\">\r\n            <label for=\"inputEmail3\" class=\"col-sm-4 col-form-label\">Marka</label>\r\n            <div class=\"col-sm-8\">\r\n\r\n\r\n                ");
#nullable restore
#line 47 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\CarWeb\WebCar.UI\Views\Shared\Filter.cshtml"
           Write(Html.DropDownListFor(item => x.BrandId, (IEnumerable<SelectListItem>)ViewBag.brand, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"row mb-3\">\r\n            <label for=\"inputEmail3\" class=\"col-sm-4 col-form-label\">Model</label>\r\n            <div class=\"col-sm-8\">\r\n\r\n\r\n                ");
#nullable restore
#line 57 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\CarWeb\WebCar.UI\Views\Shared\Filter.cshtml"
           Write(Html.DropDownListFor(item => x.ModelId, new SelectList(""), "Model Seç", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
        </div>
        <div class=""row mb-3"">
            <label for=""inputEmail3"" class=""col-sm-4 col-form-label""></label>
            <div class=""col-sm-8"">
                <button type=""submit"" class=""btn btn-outline-primary col-12""><i class=""bi bi-search""></i> FİLTRELE</button>
            </div>
        </div>
");
#nullable restore
#line 67 "C:\Users\gkykl\OneDrive\Masaüstü\ASP.NET CORE\CarWeb\WebCar.UI\Views\Shared\Filter.cshtml"



    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e1f68fd5f9c5b0df3fe3ca9e2960fd214ddc85f7792", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<script>
    $(document).ready(function () {
        $(""#BrandId"").change(function () {
            var markaid = $(this).val();
            debugger
            $.ajax({
                Type: ""Post"",
                url: ""/Home/ModelGet?BrandId="" + markaid,
                contentType: ""html"",
                success: function (response) {
                    debugger
                    $(""#ModelId"").empty();
                    $(""#ModelId"").append(response);
                }
            })
        })
    })
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591