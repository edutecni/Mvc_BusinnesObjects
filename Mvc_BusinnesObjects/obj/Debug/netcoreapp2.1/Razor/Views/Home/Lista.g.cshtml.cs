#pragma checksum "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\Home\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76932c3657632525e3d91c48eec094a9706676e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Lista), @"mvc.1.0.view", @"/Views/Home/Lista.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Lista.cshtml", typeof(AspNetCore.Views_Home_Lista))]
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
#line 1 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\_ViewImports.cshtml"
using Mvc_BusinnesObjects;

#line default
#line hidden
#line 2 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\_ViewImports.cshtml"
using Mvc_BusinnesObjects.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76932c3657632525e3d91c48eec094a9706676e4", @"/Views/Home/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a656bc9568623b099ad3ee356472f5b66e3fe5cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mvc_BusinnesObjects.Models.Aluno>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\Home\Lista.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(83, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(112, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f96a3666ded94ed7b5668b6df04fcb05", async() => {
                BeginContext(118, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Lista</title>\r\n");
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
            BeginContext(212, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(214, 1561, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb7682fe4e3043af9bc0a3c72702b384", async() => {
                BeginContext(220, 11, true);
                WriteLiteral("\r\n<p>\r\n    ");
                EndContext();
                BeginContext(231, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1bd11428f104574b6b208cfbe7aee02", async() => {
                    BeginContext(254, 10, true);
                    WriteLiteral("Create New");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(268, 103, true);
                WriteLiteral("\r\n</p>\r\n<table class=\"table\" border=\"1\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(372, 43, false);
#line 22 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\Home\Lista.cshtml"
           Write(Html.DisplayNameFor(model => model.AlunoId));

#line default
#line hidden
                EndContext();
                BeginContext(415, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(471, 40, false);
#line 25 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\Home\Lista.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(511, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(567, 40, false);
#line 28 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\Home\Lista.cshtml"
           Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
                EndContext();
                BeginContext(607, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(663, 41, false);
#line 31 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\Home\Lista.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(704, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(760, 46, false);
#line 34 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\Home\Lista.cshtml"
           Write(Html.DisplayNameFor(model => model.Nascimento));

#line default
#line hidden
                EndContext();
                BeginContext(806, 86, true);
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
                EndContext();
#line 40 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\Home\Lista.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
                BeginContext(924, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(973, 42, false);
#line 43 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\Home\Lista.cshtml"
           Write(Html.DisplayFor(modelItem => item.AlunoId));

#line default
#line hidden
                EndContext();
                BeginContext(1015, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1071, 39, false);
#line 46 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\Home\Lista.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(1110, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1166, 39, false);
#line 49 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\Home\Lista.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sexo));

#line default
#line hidden
                EndContext();
                BeginContext(1205, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1261, 40, false);
#line 52 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\Home\Lista.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1301, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1357, 45, false);
#line 55 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\Home\Lista.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nascimento));

#line default
#line hidden
                EndContext();
                BeginContext(1402, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1458, 65, false);
#line 58 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\Home\Lista.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(1523, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(1544, 71, false);
#line 59 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\Home\Lista.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(1615, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(1636, 69, false);
#line 60 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\Home\Lista.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(1705, 36, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 63 "D:\Projetos\Angular\Mvc_BusinnesObjects\Mvc_BusinnesObjects\Views\Home\Lista.cshtml"
}

#line default
#line hidden
                BeginContext(1744, 24, true);
                WriteLiteral("    </tbody>\r\n</table>\r\n");
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
            BeginContext(1775, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mvc_BusinnesObjects.Models.Aluno>> Html { get; private set; }
    }
}
#pragma warning restore 1591
