#pragma checksum "C:\Projetos\ControleCondominal\ControleCondominal\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dca82f97704f104220025951f8115996950144df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Index.cshtml", typeof(AspNetCore.Views_Login_Index))]
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
#line 1 "C:\Projetos\ControleCondominal\ControleCondominal\Views\_ViewImports.cshtml"
using ControleCondominal;

#line default
#line hidden
#line 2 "C:\Projetos\ControleCondominal\ControleCondominal\Views\_ViewImports.cshtml"
using ControleCondominal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dca82f97704f104220025951f8115996950144df", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec3f43568dc33ffeacde8859686c4c8ba776392", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Ícone de Usuário"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 150px; height: 150px; margin-bottom: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projetos\ControleCondominal\ControleCondominal\Views\Login\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(52, 1134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "415b82431db044bbb591a10d8b3e0612", async() => {
                BeginContext(58, 1121, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <!-- Adicione aqui os links para seus estilos CSS, se aplicável -->
    <style>
        body {
            background-color: rgb(70, 67, 203, 255);
            display: flex;
            align-items: center;
            justify-content: center;
            height: 100vh; /* 100% da altura da viewport */
            margin: 0; /* Remover margens padrão do body */
        }

        section {
            background-color: aliceblue;
            border-radius: 10px;
            padding: 15px;
            width: 500px;
            margin: auto;
            box-shadow: 5px 5px 10px rgba(0, 0, 0, 0.363);
            text-align: center;
        }

        .log {
            color: rgb(104, 85, 224);
            background-color: rgba(255, 255, 255, 1);
            border: 1px solid rgba(104, 85, 224, 1);
        }

            .log:hover {
                color: white;
                box-shadow: 0 0 20px rgba(104, 85, 224,");
                WriteLiteral(" 0.6);\r\n                background-color: rgba(104, 85, 224, 1);\r\n            }\r\n\r\n    </style>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1186, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1188, 954, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30afc65595f247d4aef75d23c3c6c0d1", async() => {
                BeginContext(1194, 25, true);
                WriteLiteral("\r\n    <section>\r\n        ");
                EndContext();
                BeginContext(1219, 112, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "83817433954b49d4af4c0ba756c44ec1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1331, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 47 "C:\Projetos\ControleCondominal\ControleCondominal\Views\Login\Index.cshtml"
         using (Html.BeginForm("Index", "Login", FormMethod.Post))
        {
            

#line default
#line hidden
                BeginContext(1427, 23, false);
#line 49 "C:\Projetos\ControleCondominal\ControleCondominal\Views\Login\Index.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(1454, 242, true);
                WriteLiteral("            <div style=\"margin-bottom: 10px; margin-right: 50px;\">\r\n                <label for=\"username\">Usuário:</label>\r\n                <input type=\"text\" id=\"username\" name=\"username\" required style=\"width: 150px;\">\r\n            </div>\r\n");
                EndContext();
                BeginContext(1698, 244, true);
                WriteLiteral("            <div style=\"margin-bottom: 10px; margin-right: 40px;\">\r\n                <label for=\"password\">Senha:</label>\r\n                <input type=\"password\" id=\"password\" name=\"password\" required style=\"width: 150px;\">\r\n            </div>\r\n");
                EndContext();
                BeginContext(1944, 94, true);
                WriteLiteral("            <button type=\"submit\" id=\"log\" class=\"log\" onclick=\"fazerLogin()\">Login</button>\r\n");
                EndContext();
#line 62 "C:\Projetos\ControleCondominal\ControleCondominal\Views\Login\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(2049, 86, true);
                WriteLiteral("    </section>\r\n\r\n    <!-- Adicione aqui qualquer mensagem de erro, se aplicável -->\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2142, 741, true);
            WriteLiteral(@"
</html>


<script>
    function chamarHttpPost() {
        $.ajax({
            url: '/Login/Index', // Substitua por seu caminho real
            type: 'POST',
            data: {
                username: $('#username').val(), // Substitua pelo ID real do campo de usuário
                password: $('#password').val()  // Substitua pelo ID real do campo de senha
            },
            success: function (response) {
                // Lida com a resposta do servidor (se necessário)
                console.log(response);
            },
            error: function (error) {
                // Lida com erros (se necessário)
                console.error(error);
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591