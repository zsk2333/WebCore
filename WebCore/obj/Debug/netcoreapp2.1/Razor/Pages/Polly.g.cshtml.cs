#pragma checksum "C:\Users\MR.Z\source\repos\WebCore2\WebCore\Pages\Polly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a4c6ee4f84d7988caa05dada87a37e92544d6cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebCore.Pages.Pages_Polly), @"mvc.1.0.razor-page", @"/Pages/Polly.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Polly.cshtml", typeof(WebCore.Pages.Pages_Polly), null)]
namespace WebCore.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\MR.Z\source\repos\WebCore2\WebCore\Pages\_ViewImports.cshtml"
using WebCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a4c6ee4f84d7988caa05dada87a37e92544d6cb", @"/Pages/Polly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5123c2fd7f4c65ab918803232fbc907481ddd091", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Polly : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\MR.Z\source\repos\WebCore2\WebCore\Pages\Polly.cshtml"
  
    ViewData["Title"] = "Polly";

#line default
#line hidden
            BeginContext(81, 350, true);
            WriteLiteral(@"
<h2>Polly</h2>

<button onclick=""Throw()"">测试熔断</button>


<script>
    function Throw() {
        axios.post(""TestPolly/TestRetry"")
            .then(function (res) {
                console.log(res);
            })
            .catch(function (error) {
                console.log(error);
            });
    }


</script>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebCore.Pages.PollyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebCore.Pages.PollyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebCore.Pages.PollyModel>)PageContext?.ViewData;
        public WebCore.Pages.PollyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
