#pragma checksum "C:\Users\1\source\repos\AppVueTest\AppVueTest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e93901a12cf473b90d16a779d1cc83a3fef4d8b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\1\source\repos\AppVueTest\AppVueTest\Views\_ViewImports.cshtml"
using AppVueTest;

#line default
#line hidden
#line 2 "C:\Users\1\source\repos\AppVueTest\AppVueTest\Views\_ViewImports.cshtml"
using AppVueTest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e93901a12cf473b90d16a779d1cc83a3fef4d8b2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a2393f795c2eecaf5650de312ad0ef034525ad6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\1\source\repos\AppVueTest\AppVueTest\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 9869, true);
            WriteLiteral(@"
    <div id=""app"">
        <f7-app :params=""f7params"">
            <!-- Statusbar -->
            <f7-statusbar></f7-statusbar>

            <!-- Left Panel -->
            <f7-panel left reveal theme-dark>
                <f7-view id=""left-panel-view"">
                    <f7-page>
                        <f7-navbar title=""Left Panel""></f7-navbar>
                        <f7-block strong>
                            <p>Left panel content goes here</p>
                        </f7-block>
                        <f7-block-title>Load page in panel</f7-block-title>
                        <f7-list>
                            <f7-list-item link=""/about/"" title=""About""></f7-list-item>
                            <f7-list-item link=""/form/"" title=""Form""></f7-list-item>
                        </f7-list>
                        <f7-block-title>Load page in main view</f7-block-title>
                        <f7-list>
                            <f7-list-item link=""/about/"" title=""About"" view=""#");
            WriteLiteral(@"main-view""
                                          panel-close></f7-list-item>
                            <f7-list-item link=""/form/"" title=""Form"" view=""#main-view""
                                          panel-close></f7-list-item>
                        </f7-list>
                    </f7-page>
                </f7-view>
            </f7-panel>

            <!-- Right Panel -->
            <f7-panel right cover theme-dark>
                <f7-view id=""right-panel-view"">
                    <f7-page>
                        <f7-navbar title=""Right Panel"" sliding></f7-navbar>
                        <f7-block>
                            <p>Right panel content goes here</p>
                        </f7-block>
                        <f7-block-title>Load page in panel</f7-block-title>
                        <f7-list>
                            <f7-list-item link=""/about/"" title=""About""></f7-list-item>
                            <f7-list-item link=""/form/"" title=""Form""></f7-list-ite");
            WriteLiteral(@"m>
                        </f7-list>
                        <f7-block-title>Load page in main view</f7-block-title>
                        <f7-list>
                            <f7-list-item link=""/about/"" title=""About"" view=""#main-view""
                                          panel-close></f7-list-item>
                            <f7-list-item link=""/form/"" title=""Form"" view=""#main-view""
                                          panel-close></f7-list-item>
                        </f7-list>
                    </f7-page>
                </f7-view>
            </f7-panel>

            <!-- Main View -->
            <f7-view id=""main-view"" main class=""safe-areas"">
                <f7-page>
                    <f7-navbar>
                        <f7-nav-left>
                            <f7-link icon-if-ios=""f7:menu"" icon-if-md=""material:menu""
                                     panel-open=""left""></f7-link>
                        </f7-nav-left>
                        <f7-nav-title>");
            WriteLiteral(@"My App</f7-nav-title>
                        <f7-nav-right>
                            <f7-link icon-if-ios=""f7:menu"" icon-if-md=""material:menu""
                                     panel-open=""right""></f7-link>
                        </f7-nav-right>
                    </f7-navbar>
                    <f7-toolbar bottom>
                        <f7-link>Left Link</f7-link>
                        <f7-link>Right Link</f7-link>
                    </f7-toolbar>
                    <f7-block strong>
                        <p>Here is your blank Framework7 app. Let's see what we have here.</p>
                    </f7-block>
                    <f7-block-title>Navigation</f7-block-title>
                    <f7-list>
                        <f7-list-item link=""/about/"" title=""About""></f7-list-item>
                        <f7-list-item link=""/form/"" title=""Form""></f7-list-item>
                    </f7-list>
                    <f7-block-title>Modals</f7-block-title>
                    <f7");
            WriteLiteral(@"-block strong>
                        <f7-row>
                            <f7-col width=""50"">
                                <f7-button fill raised popup-open=""#popup"">Popup</f7-button>
                            </f7-col>
                            <f7-col width=""50"">
                                <f7-button fill raised login-screen-open=""#login-screen"">Login Screen</f7-button>
                            </f7-col>
                        </f7-row>
                    </f7-block>
                    <f7-block-title>Panels</f7-block-title>
                    <f7-block strong>
                        <f7-row>
                            <f7-col width=""50"">
                                <f7-button fill raised panel-open=""left"">Left Panel</f7-button>
                            </f7-col>
                            <f7-col width=""50"">
                                <f7-button fill raised panel-open=""right"">Right Panel</f7-button>
                            </f7-col>
               ");
            WriteLiteral(@"         </f7-row>
                    </f7-block>
                    <f7-list>
                        <f7-list-item link=""/dynamic-route/blog/45/post/125/?foo=bar#about"" title=""Dynamic Route""></f7-list-item>
                        <f7-list-item link=""/load-something-that-doesnt-exist/"" title=""Default Route (404)""></f7-list-item>
                    </f7-list>
                </f7-page>
            </f7-view>

            <!-- Popup -->
            <f7-popup id=""popup"">
                <f7-view>
                    <f7-page>
                        <f7-navbar title=""Popup"">
                            <f7-nav-right>
                                <f7-link popup-close>Close</f7-link>
                            </f7-nav-right>
                        </f7-navbar>
                        <f7-block>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Neque, architecto. Cupiditate laudantium rem nesciunt numquam, ipsam. Voluptates omnis, a inventore atque ratione aliquam. Omnis iusto ne");
            WriteLiteral(@"mo quos ullam obcaecati, quod.</f7-block>
                    </f7-page>
                </f7-view>
            </f7-popup>

            <!-- Login Screen -->
            <f7-login-screen id=""login-screen"">
                <f7-view>
                    <f7-page login-screen>
                        <f7-login-screen-title>Login</f7-login-screen-title>
                        <f7-list form>
                            <f7-list-input label=""Username""
                                           name=""username""
                                           placeholder=""Username""
                                           type=""text""></f7-list-input>
                            <f7-list-input label=""Password""
                                           name=""password""
                                           type=""password""
                                           placeholder=""Password""></f7-list-input>
                        </f7-list>
                        <f7-list>
                        ");
            WriteLiteral(@"    <f7-list-button title=""Sign In"" login-screen-close></f7-list-button>
                            <f7-block-footer>
                                <p>Click Sign In to close Login Screen</p>
                            </f7-block-footer>
                        </f7-list>
                    </f7-page>
                </f7-view>
            </f7-login-screen>
        </f7-app>
    </div>

    <!-- About Page Template -->
    <template id=""page-about"">
        <f7-page>
            <f7-navbar title=""About"" back-link=""Back""></f7-navbar>
            <f7-block-title>About My App</f7-block-title>
            <f7-block strong>
                <p>Here is About page!</p>
                <p>You can go <f7-link back>back</f7-link>.</p>
                <p>Mauris posuere sit amet metus id venenatis. Ut ante dolor, tempor nec commodo rutrum, varius at sem. Nullam ac nisi non neque ornare pretium. Nulla mauris mauris, consequat et elementum sit amet, egestas sed orci. In hac habitasse platea dictumst.");
            WriteLiteral(@"</p>
                <p>Fusce eros lectus, accumsan eget mi vel, iaculis tincidunt felis. Nulla tincidunt pharetra sagittis. Fusce in felis eros. Nulla sit amet aliquam lorem, et gravida ipsum. Mauris consectetur nisl non sollicitudin tristique. Praesent vitae metus ac quam rhoncus mattis vel et nisi. Aenean aliquet, felis quis dignissim iaculis, lectus quam tincidunt ligula, et venenatis turpis risus sed lorem. Morbi eu metus elit. Ut vel diam dolor.</p>
            </f7-block>
        </f7-page>
    </template>

    <!-- Form Page Template -->
    <template id=""page-form"">
        <f7-page>
            <f7-navbar title=""Form"" back-link=""Back""></f7-navbar>
            <f7-block-title>Form Example</f7-block-title>
            <f7-list form>
                <f7-list-input label=""Name""
                               type=""text""
                               placeholder=""Name""></f7-list-input>
                <f7-list-input label=""E-mail""
                               type=""email""
            ");
            WriteLiteral(@"                   placeholder=""E-mail""></f7-list-input>
                <f7-list-input label=""URL""
                               type=""url""
                               placeholder=""URL""></f7-list-input>
                <f7-list-input label=""Password""
                               type=""password""
                               placeholder=""Password""></f7-list-input>
                <f7-list-input label=""Phone""
                               type=""tel""
                               placeholder=""Phone""></f7-list-input>
                <f7-list-input label=""Gender""
                               type=""select"">
                    ");
            EndContext();
            BeginContext(9914, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e93901a12cf473b90d16a779d1cc83a3fef4d8b213625", async() => {
                BeginContext(9931, 4, true);
                WriteLiteral("Male");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9944, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(9966, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e93901a12cf473b90d16a779d1cc83a3fef4d8b215131", async() => {
                BeginContext(9974, 6, true);
                WriteLiteral("Female");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9989, 4596, true);
            WriteLiteral(@"
                    </f7-list-item>
                    <f7-list-input label=""Birth date""
                                   type=""date""
                                   placeholder=""Birth date"" value=""2014-04-30""></f7-list-input>
                    <f7-list-item title=""Toggle"">
                        <f7-toggle slot=""after""></f7-toggle>
                    </f7-list-item>
                    <f7-list-input label=""Slider""
                                   :input=""false"">
                        <f7-range slot=""input"" min=""0"" max=""100"" value=""50"" step=""1"" :label=""true""></f7-range>
                    </f7-list-input>
                    <f7-list-input label=""Textarea""
                                   type=""textarea""
                                   placeholder=""Bio""></f7-list-input>
                    <f7-list-input label=""Resizable""
                                   type=""textarea""
                                   placeholder=""Bio""
                                   resizable><");
            WriteLiteral(@"/f7-list-input>
            </f7-list>

            <f7-block-title>Checkbox group</f7-block-title>
            <f7-list form>
                <f7-list-item v-for=""n in 3"" :key=""n"" checkbox name=""my-checkbox"" :value=""n"" :title=""'Checkbox ' + n""></f7-list-item>
            </f7-list>

            <f7-block-title>Radio buttons group</f7-block-title>
            <f7-list form>
                <f7-list-item v-for=""n in 3"" :key=""n"" radio name=""my-radio"" :checked=""n === 1"" :value=""n"" :title=""'Radio ' + n""></f7-list-item>
            </f7-list>

            <f7-block-title>Buttons</f7-block-title>
            <f7-block strong>
                <f7-row tag=""p"">
                    <f7-button class=""col"">Button</f7-button>
                    <f7-button class=""col"" fill>Fill</f7-button>
                </f7-row>
                <f7-row tag=""p"">
                    <f7-button class=""col"" raised>Raised</f7-button>
                    <f7-button class=""col"" raised fill>Raised Fill</f7-button>
       ");
            WriteLiteral(@"         </f7-row>
                <f7-row tag=""p"">
                    <f7-button class=""col"" round>Round</f7-button>
                    <f7-button class=""col"" round fill>Round Fill</f7-button>
                </f7-row>
                <f7-row tag=""p"">
                    <f7-button class=""col"" outline>Outline</f7-button>
                    <f7-button class=""col"" round outline>Outline Round</f7-button>
                </f7-row>
                <f7-row tag=""p"">
                    <f7-button class=""col"" small outline>Small</f7-button>
                    <f7-button class=""col"" small round outline>Small Round</f7-button>
                </f7-row>
                <f7-row tag=""p"">
                    <f7-button class=""col"" small fill>Small</f7-button>
                    <f7-button class=""col"" small round fill>Small Round</f7-button>
                </f7-row>
                <f7-row tag=""p"">
                    <f7-button class=""col"" large raised>Large</f7-button>
                    <f7-but");
            WriteLiteral(@"ton class=""col"" large fill raised>Large Fill</f7-button>
                </f7-row>
                <f7-row tag=""p"">
                    <f7-button class=""col"" large fill raised color=""red"">Large Red</f7-button>
                    <f7-button class=""col"" large fill raised color=""green"">Large Green</f7-button>
                </f7-row>
            </f7-block>
        </f7-page>
    </template>

    <!-- Dynamic Routing Page Template -->
    <template id=""page-dynamic-routing"">
        <f7-page>
            <f7-navbar title=""Dynamic Route"" back-link=""Back""></f7-navbar>
            <f7-block strong>
                <ul>
                    <li><b>Url:</b> {{$f7route.url}}</li>
                    <li><b>Path:</b> {{$f7route.path}}</li>
                    <li><b>Hash:</b> {{$f7route.hash}}</li>
                    <li>
                        <b>Params:</b>
                        <ul>
                            <li v-for=""(value, key) in $f7route.params"" :key=""key""><b>{{key}}:</b> {{value}");
            WriteLiteral(@"}</li>
                        </ul>
                    </li>
                    <li>
                        <b>Query:</b>
                        <ul>
                            <li v-for=""(value, key) in $f7route.query"" :key=""key""><b>{{key}}:</b> {{value}}</li>
                        </ul>
                    </li>
                    <li><b>Route:</b> {{$f7route.route}}</li>
                </ul>
            </f7-block>
            <f7-block strong>
                <f7-link ");
            EndContext();
            BeginContext(14586, 467, true);
            WriteLiteral(@"@click=""$f7router.back()"">Go back via Router API</f7-link>
            </f7-block>
        </f7-page>
    </template>

    <!-- Page Not Found Template -->
    <template id=""page-not-found"">
        <f7-page>
            <f7-navbar title=""Not found"" back-link=""Back""></f7-navbar>
            <f7-block strong>
                <p>Sorry</p>
                <p>Requested content not found.</p>
            </f7-block>
        </f7-page>
    </template>

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
