﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    
    #line 2 "..\..\Pages\LayoutPage.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 3 "..\..\Pages\LayoutPage.cshtml"
    using System.Diagnostics;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Pages\LayoutPage.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 5 "..\..\Pages\LayoutPage.cshtml"
    using HangFire.Storage;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Pages\LayoutPage.cshtml"
    using Storage.Monitoring;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class LayoutPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\n");







WriteLiteral("<!DOCTYPE html>\n\n<html lang=\"ru\">\n<head>\n    <title>");


            
            #line 12 "..\..\Pages\LayoutPage.cshtml"
      Write(Title);

            
            #line default
            #line hidden
WriteLiteral(" - HangFire</title>\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" conten" +
"t=\"width=device-width, initial-scale=1.0\">\n    <link rel=\"stylesheet\" href=\"");


            
            #line 15 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/css/styles.css"));

            
            #line default
            #line hidden
WriteLiteral(@""" />
</head>
    <body>
        <!-- Wrap all page content here -->
        <div id=""wrap"">

            <!-- Fixed navbar -->
            <div class=""navbar navbar-default navbar-static-top"">
                <div class=""container"">
                    <div class=""navbar-header"">
                        <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                            <span class=""icon-bar""></span>
                            <span class=""icon-bar""></span>
                            <span class=""icon-bar""></span>
                        </button>
                        <a class=""navbar-brand"" href=""");


            
            #line 30 "..\..\Pages\LayoutPage.cshtml"
                                                 Write(Request.LinkTo("/"));

            
            #line default
            #line hidden
WriteLiteral(@""">HangFire Monitor</a>
                    </div>
                    <div class=""collapse navbar-collapse"">
                        <ul class=""nav navbar-nav navbar-right"">
                            <li>
                                <a href=""/"">
                                    <span class=""glyphicon glyphicon-log-out""></span>
                                    Back to site
                                </a>
                            </li>
                        </ul>
                    </div>
                    <!--/.nav-collapse -->
                </div>
            </div>

            <!-- Begin page content -->

            <div class=""container"">
                <div class=""col-md-3"">
");


            
            #line 50 "..\..\Pages\LayoutPage.cshtml"
                      
                        var monitor = JobStorage.Current.GetMonitoringApi();
                        StatisticsDto statistics = monitor.GetStatistics();
                    

            
            #line default
            #line hidden
WriteLiteral("\n                    <div id=\"stats\" class=\"list-group\">\n                        " +
"<a class=\"list-group-item ");


            
            #line 56 "..\..\Pages\LayoutPage.cshtml"
                                              Write(Request.PathInfo.Equals("/") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\"\n                           href=\"");


            
            #line 57 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/"));

            
            #line default
            #line hidden
WriteLiteral("\">\n                            <span class=\"glyphicon glyphicon-dashboard\"></span" +
">\n                            Dashboard\n                        </a>\n\n          " +
"              <a class=\"list-group-item ");


            
            #line 62 "..\..\Pages\LayoutPage.cshtml"
                                              Write(Request.PathInfo.Equals("/servers") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\"\n                           href=\"");


            
            #line 63 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/servers"));

            
            #line default
            #line hidden
WriteLiteral("\">\n                            <span class=\"label label-default pull-right\">");


            
            #line 64 "..\..\Pages\LayoutPage.cshtml"
                                                                    Write(statistics.Servers);

            
            #line default
            #line hidden
WriteLiteral("</span>\n                            <span class=\"glyphicon glyphicon-hdd\"></span>" +
"\n                            Active Servers\n                        </a>\n\n      " +
"                  <a class=\"list-group-item ");


            
            #line 69 "..\..\Pages\LayoutPage.cshtml"
                                              Write(Request.PathInfo.StartsWith("/queues") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \n                           href=\"");


            
            #line 70 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/queues"));

            
            #line default
            #line hidden
WriteLiteral("\">\n                            <span class=\"label label-default pull-right\">\n    " +
"                            <span id=\"stats-enqueued\" title=\"Enqueued jobs count" +
"\">\n                                    ");


            
            #line 73 "..\..\Pages\LayoutPage.cshtml"
                               Write(statistics.Enqueued);

            
            #line default
            #line hidden
WriteLiteral("\n                                </span>\n                                / \n     " +
"                           <span id=\"stats-queues\" title=\"Queues count\">\n       " +
"                             ");


            
            #line 77 "..\..\Pages\LayoutPage.cshtml"
                               Write(statistics.Queues);

            
            #line default
            #line hidden
WriteLiteral(@"
                                </span>
                            </span>
                            <span class=""glyphicon glyphicon-inbox""></span>
                            Jobs & Queues
                        </a>
                        <a class=""list-group-item stats-indent ");


            
            #line 83 "..\..\Pages\LayoutPage.cshtml"
                                                           Write(Request.PathInfo.Equals("/scheduled") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \n                           href=\"");


            
            #line 84 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/scheduled"));

            
            #line default
            #line hidden
WriteLiteral("\">\n                            <span id=\"stats-scheduled\" class=\"label label-info" +
" pull-right\">\n                                ");


            
            #line 86 "..\..\Pages\LayoutPage.cshtml"
                           Write(statistics.Scheduled);

            
            #line default
            #line hidden
WriteLiteral("\n                            </span>\n                            Scheduled\n      " +
"                  </a>\n                        <a class=\"list-group-item stats-i" +
"ndent ");


            
            #line 90 "..\..\Pages\LayoutPage.cshtml"
                                                           Write(Request.PathInfo.Equals("/processing") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \n                           href=\"");


            
            #line 91 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/processing"));

            
            #line default
            #line hidden
WriteLiteral("\">\n                            <span id=\"stats-processing\" class=\"label label-war" +
"ning pull-right\">\n                                ");


            
            #line 93 "..\..\Pages\LayoutPage.cshtml"
                           Write(statistics.Processing);

            
            #line default
            #line hidden
WriteLiteral("\n                            </span>\n                            Processing\n     " +
"                   </a>\n                        <a class=\"list-group-item stats-" +
"indent ");


            
            #line 97 "..\..\Pages\LayoutPage.cshtml"
                                                           Write(Request.PathInfo.Equals("/succeeded") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \n                           href=\"");


            
            #line 98 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/succeeded"));

            
            #line default
            #line hidden
WriteLiteral("\">\n                            <span id=\"stats-succeeded\" class=\"label label-succ" +
"ess pull-right\">\n                                ");


            
            #line 100 "..\..\Pages\LayoutPage.cshtml"
                           Write(statistics.Succeeded);

            
            #line default
            #line hidden
WriteLiteral("\n                            </span>\n                            Succeeded\n      " +
"                  </a>\n                        <a class=\"list-group-item stats-i" +
"ndent ");


            
            #line 104 "..\..\Pages\LayoutPage.cshtml"
                                                           Write(Request.PathInfo.Equals("/failed") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\" \n                           href=\"");


            
            #line 105 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/failed"));

            
            #line default
            #line hidden
WriteLiteral("\">\n                            <span id=\"stats-failed\" class=\"label label-danger " +
"pull-right\">\n                                ");


            
            #line 107 "..\..\Pages\LayoutPage.cshtml"
                           Write(statistics.Failed);

            
            #line default
            #line hidden
WriteLiteral("\n                            </span>\n                            Failed\n         " +
"               </a>\n                        <a class=\"list-group-item stats-inde" +
"nt ");


            
            #line 111 "..\..\Pages\LayoutPage.cshtml"
                                                           Write(Request.PathInfo.Equals("/deleted") ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\"\n                           href=\"");


            
            #line 112 "..\..\Pages\LayoutPage.cshtml"
                            Write(Request.LinkTo("/deleted"));

            
            #line default
            #line hidden
WriteLiteral("\">\n                            <span id=\"stats-deleted\" class=\"label label-defaul" +
"t pull-right\">\n                                ");


            
            #line 114 "..\..\Pages\LayoutPage.cshtml"
                           Write(statistics.Deleted);

            
            #line default
            #line hidden
WriteLiteral("\n                            </span>\n                            Deleted\n        " +
"                </a>\n                    </div>\n                </div>\n         " +
"       <div class=\"col-md-9\">\n");


            
            #line 121 "..\..\Pages\LayoutPage.cshtml"
                     if (Breadcrumbs != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <ol class=\"breadcrumb\">\n                            <li><" +
"a href=\"");


            
            #line 124 "..\..\Pages\LayoutPage.cshtml"
                                    Write(Request.LinkTo("/"));

            
            #line default
            #line hidden
WriteLiteral("\"><span class=\"glyphicon glyphicon-home\"></span></a></li>\n");


            
            #line 125 "..\..\Pages\LayoutPage.cshtml"
                             foreach (var breadcrumb in Breadcrumbs)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li><a href=\"");


            
            #line 127 "..\..\Pages\LayoutPage.cshtml"
                                        Write(breadcrumb.Value);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 127 "..\..\Pages\LayoutPage.cshtml"
                                                           Write(breadcrumb.Key);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\n");


            
            #line 128 "..\..\Pages\LayoutPage.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            <li class=\"active\">");


            
            #line 129 "..\..\Pages\LayoutPage.cshtml"
                                           Write(BreadcrumbsTitle ?? Title);

            
            #line default
            #line hidden
WriteLiteral("</li>\n                        </ol>\n");


            
            #line 131 "..\..\Pages\LayoutPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\n                    <h1 class=\"page-header\">\n                        ");


            
            #line 134 "..\..\Pages\LayoutPage.cshtml"
                   Write(Title);

            
            #line default
            #line hidden
WriteLiteral("\n");


            
            #line 135 "..\..\Pages\LayoutPage.cshtml"
                         if (!String.IsNullOrEmpty(Subtitle))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <small>");


            
            #line 137 "..\..\Pages\LayoutPage.cshtml"
                              Write(Subtitle);

            
            #line default
            #line hidden
WriteLiteral("</small>\n");


            
            #line 138 "..\..\Pages\LayoutPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </h1>\n                    ");


            
            #line 140 "..\..\Pages\LayoutPage.cshtml"
               Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral(@"
                </div>
            </div>
        </div>

        <div id=""footer"">
            <div class=""container"">
                <ul class=""list-inline credit"">
                    <li>
                        <a href=""http://hangfire.io/"" target=""_blank"">HangFire 
                            ");


            
            #line 150 "..\..\Pages\LayoutPage.cshtml"
                       Write(FileVersionInfo.GetVersionInfo(GetType().Assembly.Location).ProductVersion);

            
            #line default
            #line hidden
WriteLiteral("\n                        </a>\n                    </li>\n                    <li>");


            
            #line 153 "..\..\Pages\LayoutPage.cshtml"
                   Write(JobStorage.Current);

            
            #line default
            #line hidden
WriteLiteral("</li>\n                    <li>Time: ");


            
            #line 154 "..\..\Pages\LayoutPage.cshtml"
                         Write(DateTime.UtcNow);

            
            #line default
            #line hidden
WriteLiteral(" GMT\n                    </li>\n                    <li>Generated in [");


            
            #line 156 "..\..\Pages\LayoutPage.cshtml"
                                  Write((DateTime.UtcNow - (DateTime)Context.Items["GenerationStartedAt"]).Milliseconds);

            
            #line default
            #line hidden
WriteLiteral(" ms]\n                    </li>\n                </ul>\n            </div>\n        <" +
"/div>\n        \n        <script>\n            (function (hangFire) {\n             " +
"   hangFire.config = {\n                    pollInterval: 2000,\n                 " +
"   pollUrl: \'");


            
            #line 166 "..\..\Pages\LayoutPage.cshtml"
                          Write(Request.LinkTo("/stats"));

            
            #line default
            #line hidden
WriteLiteral("\'\n                };\n            })(window.HangFire = window.HangFire || {});\n   " +
"     </script>\n        <script src=\"");


            
            #line 170 "..\..\Pages\LayoutPage.cshtml"
                Write(Request.LinkTo("/js/scripts.js"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\n    </body>\n</html>\n");


        }
    }
}
#pragma warning restore 1591
