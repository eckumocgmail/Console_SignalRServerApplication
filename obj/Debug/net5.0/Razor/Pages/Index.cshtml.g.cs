#pragma checksum "D:\Projects\Console_SignalRServerApplication\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a98d18fcf640c213be14104793bc01584c1c200f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Console_SignalRServerApplication.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Console_SignalRServerApplication.Pages
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
#line 1 "D:\Projects\Console_SignalRServerApplication\Pages\_ViewImports.cshtml"
using Console_SignalRServerApplication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a98d18fcf640c213be14104793bc01584c1c200f", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7492662aa926765d7d8def7994d81a067b3eb13a", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("ctrl.progress()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Projects\Console_SignalRServerApplication\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    function $( id ){
        return document.getElementById(id);
    }
    const ctrl = {
        progress: function(){
            $('view').innerHTML = `
            <div class=""spinner-border"" role=""status"">
              <span class=""visually-hidden"">Loading...</span>
            </div>`;

        }
    }

</script>
<style>
    *{
        margin: 0px;
        padding: 0px;
    }
    html,body{
        width: 100%; height: 100%;
        position: fixed;
        margin: auto;
    }
</style>
<div style=""width: 100%; height: 100%; position: fixed; display: flex; flex-direction: column; flex-wrap: nowrap;"">
    <div style=""width: 100%;"">
        <div style=""width: 100%;"">

            <button style=""width: 100%;""></button>

        </div>
    </div>
    <div style=""width: 100%; height: 100%; display: flex; flex-direction: row; flex-wrap: nowrap;"">
        <div style=""height: 100%;"">

            <h2 class=""text-center display-4""> ???????????????????? </h2>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a98d18fcf640c213be14104793bc01584c1c200f4684", async() => {
                WriteLiteral(@"
                <div class=""input-group"">
                  <span class=""input-group-text"" style=""width: 100px;""> URL </span>
                  <input type=""url"" value=""https://localhost:5001/hubs/server"" class=""form-control"" 
                         oninput=""validateUrl(event)"" />
                </div>
                <small id=""inputUrlError"" class=""text text-danger""></small>
                <div class=""input-group"">
                  <span class=""input-group-text"" style=""width: 100px;""> ?????? </span>
                  <input type=""text"" value=""admin"" class=""form-control"" 
                         oninput=""validateUsername(event)"" />
                </div>
                <small id=""inputUsernameError"" class=""text text-danger""></small>
                <div class=""input-group"">
                  <span class=""input-group-text"" style=""width: 100px;""> ???????????? </span>
                  <input type=""password"" value=""p@ssword"" class=""form-control"" 
                         oninput=""validatePassword");
                WriteLiteral(@"(event)"" />
                </div>
                <small id=""inputPasswordError"" class=""text text-danger""></small>
                <div class=""w-100"" align=""right"">
                    <button class=""btn btn-primary btn-sm m-1""> ???????????????????????? </button>
                </div>                
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"  

        </div>
        <div style=""height: 100%; width: 100%;"" id=""view"">

    
                <button style=""width: 100%; height: 100%;"">wait</button>

           

        </div>
        <div style=""height: 100%;"">

            <button style=""height: 100%;"">right</button>

        </div>

    </div>
    <div style=""width: 100%;"">
        <div style=""width: 100%;"">

                <button style=""width: 100%;""></button>
        </div>
    </div>
</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
