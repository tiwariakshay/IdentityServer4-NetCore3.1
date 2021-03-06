#pragma checksum "C:\Users\akshayt\source\repos\IdentityServer\IdentityServer\Views\Diagnostics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc1d8c6e41fbb198a787c767f0e5c5eb291fd67e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Diagnostics_Index), @"mvc.1.0.view", @"/Views/Diagnostics/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Diagnostics/Index.cshtml", typeof(AspNetCore.Views_Diagnostics_Index))]
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
#line 1 "C:\Users\akshayt\source\repos\IdentityServer\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServerHost.Quickstart.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc1d8c6e41fbb198a787c767f0e5c5eb291fd67e", @"/Views/Diagnostics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bec599faa2156b5976535a194fedf34093459faa", @"/Views/_ViewImports.cshtml")]
    public class Views_Diagnostics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DiagnosticsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 351, true);
            WriteLiteral(@"
<div class=""diagnostics-page"">
    <div class=""lead"">
        <h1>Authentication Cookie</h1>
    </div>

    <div class=""row"">
        <div class=""col"">
            <div class=""card"">
                <div class=""card-header"">
                    <h2>Claims</h2>
                </div>
                <div class=""card-body"">
                    <dl>
");
            EndContext();
#line 16 "C:\Users\akshayt\source\repos\IdentityServer\IdentityServer\Views\Diagnostics\Index.cshtml"
                         foreach (var claim in Model.AuthenticateResult.Principal.Claims)
                        {

#line default
#line hidden
            BeginContext(495, 32, true);
            WriteLiteral("                            <dt>");
            EndContext();
            BeginContext(528, 10, false);
#line 18 "C:\Users\akshayt\source\repos\IdentityServer\IdentityServer\Views\Diagnostics\Index.cshtml"
                           Write(claim.Type);

#line default
#line hidden
            EndContext();
            BeginContext(538, 38, true);
            WriteLiteral("</dt>\n                            <dd>");
            EndContext();
            BeginContext(577, 11, false);
#line 19 "C:\Users\akshayt\source\repos\IdentityServer\IdentityServer\Views\Diagnostics\Index.cshtml"
                           Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(588, 6, true);
            WriteLiteral("</dd>\n");
            EndContext();
#line 20 "C:\Users\akshayt\source\repos\IdentityServer\IdentityServer\Views\Diagnostics\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(620, 319, true);
            WriteLiteral(@"                    </dl>
                </div>
            </div>
        </div>
        
        <div class=""col"">
            <div class=""card"">
                <div class=""card-header"">
                    <h2>Properties</h2>
                </div>
                <div class=""card-body"">
                    <dl>
");
            EndContext();
#line 33 "C:\Users\akshayt\source\repos\IdentityServer\IdentityServer\Views\Diagnostics\Index.cshtml"
                         foreach (var prop in Model.AuthenticateResult.Properties.Items)
                        {

#line default
#line hidden
            BeginContext(1054, 32, true);
            WriteLiteral("                            <dt>");
            EndContext();
            BeginContext(1087, 8, false);
#line 35 "C:\Users\akshayt\source\repos\IdentityServer\IdentityServer\Views\Diagnostics\Index.cshtml"
                           Write(prop.Key);

#line default
#line hidden
            EndContext();
            BeginContext(1095, 38, true);
            WriteLiteral("</dt>\n                            <dd>");
            EndContext();
            BeginContext(1134, 10, false);
#line 36 "C:\Users\akshayt\source\repos\IdentityServer\IdentityServer\Views\Diagnostics\Index.cshtml"
                           Write(prop.Value);

#line default
#line hidden
            EndContext();
            BeginContext(1144, 6, true);
            WriteLiteral("</dd>\n");
            EndContext();
#line 37 "C:\Users\akshayt\source\repos\IdentityServer\IdentityServer\Views\Diagnostics\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1176, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 38 "C:\Users\akshayt\source\repos\IdentityServer\IdentityServer\Views\Diagnostics\Index.cshtml"
                         if (Model.Clients.Any())
                        {

#line default
#line hidden
            BeginContext(1252, 78, true);
            WriteLiteral("                            <dt>Clients</dt>\n                            <dd>\n");
            EndContext();
#line 42 "C:\Users\akshayt\source\repos\IdentityServer\IdentityServer\Views\Diagnostics\Index.cshtml"
                              
                                var clients = Model.Clients.ToArray();
                                for(var i = 0; i < clients.Length; i++)
                                {
                                    

#line default
#line hidden
            BeginContext(1581, 10, false);
#line 46 "C:\Users\akshayt\source\repos\IdentityServer\IdentityServer\Views\Diagnostics\Index.cshtml"
                                     Write(clients[i]);

#line default
#line hidden
            EndContext();
#line 46 "C:\Users\akshayt\source\repos\IdentityServer\IdentityServer\Views\Diagnostics\Index.cshtml"
                                                            
                                    if (i < clients.Length - 1)
                                    {
                                        

#line default
#line hidden
            BeginContext(1747, 2, true);
            WriteLiteral(", ");
            EndContext();
#line 49 "C:\Users\akshayt\source\repos\IdentityServer\IdentityServer\Views\Diagnostics\Index.cshtml"
                                                       
                                    }
                                }
                            

#line default
#line hidden
            BeginContext(1859, 34, true);
            WriteLiteral("                            </dd>\n");
            EndContext();
#line 54 "C:\Users\akshayt\source\repos\IdentityServer\IdentityServer\Views\Diagnostics\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1919, 105, true);
            WriteLiteral("                    </dl>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DiagnosticsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
