#pragma checksum "C:\Users\MR.Z\source\repos\WebCore2\WebCore\Pages\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b201eda3cafff2e4edb1feccb213e3d9ff43aee5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebCore.Pages.Pages_Test), @"mvc.1.0.razor-page", @"/Pages/Test.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Test.cshtml", typeof(WebCore.Pages.Pages_Test), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b201eda3cafff2e4edb1feccb213e3d9ff43aee5", @"/Pages/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5123c2fd7f4c65ab918803232fbc907481ddd091", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Test : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 3862, true);
            WriteLiteral(@"
<div>
    <a id=""clickTest"" onclick=""getList()"">获取列表</a>
    <a id=""clickTest2"" onclick=""postObject()"">提交对象</a>
    <a id=""clickTest3"" onclick=""postObject2()"">提交对象2</a>
    <a id=""clickTest3"" onclick=""clickHandle4()"">获取服务器表单数据</a>
    <a id=""clickTest4"" onclick=""uploadFile()"">上传</a>
    <input id=""fileInput"" name=""file"" type=""file"" multiple=""multiple"" accept=""image/png,image/gif,image/jpeg"" onchange=""uploadFile()"" />
    <input id=""fileInput2"" name=""file"" type=""file"" multiple=""multiple"" accept=""image/png,image/gif,image/jpeg"" onchange=""uploadFile2()"" />
    <a id=""clickTest5"" onclick=""GetImg()"">获取图片流</a>
    <a id=""clickTest5"" onclick=""downloadFile()"">下载图片</a>
    <img src=""api/Download/GetImg"" alt=""Alternate Text"" />
    <img src=""api/Download/GetImg/a.jpg"" alt=""Alternate Text"" />
    <img src=""staticfiles/a.jpg"" alt=""Alternate Text"" />
</div>

<script>
    function getList() {
        axios.get('api/GetMsg/GetProductList')
            .then(function (response) {
                console.");
            WriteLiteral(@"log(response);
            })
            .catch(function (error) {
                console.log(response);
            });
    }

    function postObject() {
        axios.post('api/GetMsg/Send_LX', {
            PhoneNum: 'Fred',
            Msg: 'Flintstone',
            Id: 1,
            cookie: ''
        })
            .then(function (response) {
                console.log(response);
            })
            .catch(function (error) {
                console.log(response);
            });
    }

    function postObject2() {
        axios.post('api/GetMsg/Send_MI', {
            PhoneNum: 'Fred',
            Msg: 'Flintstone',
            Id: 1,
            cookie: ''
        })
            .then(function (response) {
                console.log(response);
            })
            .catch(function (error) {
                console.log(response);
            });
    }

    function clickHandle4() {
        axios.get('api/GetMsg/GetFormData')
            .then(func");
            WriteLiteral(@"tion (response) {
                console.log(response);
            })
            .catch(function (error) {
                console.log(response);
            });
    }

    function uploadFile() {
        let files = document.getElementById(""fileInput"").files;
        let formdata1 = new FormData();// 创建form对象
        formdata1.append('file001', files[0]);
        formdata1.append('msg', ""hello"");
        formdata1.append('file002', files[1]);
        axios.post('api/Upload/UploadFile', formdata1, {
            headers: { 'Content-Type': 'multipart/form-data' }
        })
            .then(function (response) {
                console.log(response);
            })
            .catch(function (error) {
                alert(response);
            });
    }

    function uploadFile2() {
        let files = document.getElementById(""fileInput2"").files;
        let formdata1 = new FormData();// 创建form对象
        formdata1.append('file001', files[0]);
        formdata1.append('msg', """);
            WriteLiteral(@"hello"");
        formdata1.append('file002', files[1]);
        axios.post('api/Upload/UploadFile2', formdata1, {
            headers: { 'Content-Type': 'multipart/form-data' }
        })
            .then(function (response) {
                console.log(response);
            })
            .catch(function (error) {
                alert(response);
            });
    }

    function GetImg() {
        axios.get('api/Download/GetImg')
            .then(function (response) {
                console.log(response);
            })
            .catch(function (error) {
                console.log(response);
            });
    }

    function downloadFile() {
        this.location.href = `${this.location.origin}/api/Download/downloadFile`;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestModel>)PageContext?.ViewData;
        public TestModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
