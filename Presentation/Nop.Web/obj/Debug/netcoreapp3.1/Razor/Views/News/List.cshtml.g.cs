#pragma checksum "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07a49fc52c2c26531c4a13e3645f9091d2fc5c8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_List), @"mvc.1.0.view", @"/Views/News/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 8 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Boards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Checkout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Newsletter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.PrivateMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Vendors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07a49fc52c2c26531c4a13e3645f9091d2fc5c8b", @"/Views/News/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7654b745a4afa95f40d704ba2b1e9f7718148f30", @"/Views/_ViewImports.cshtml")]
    public class Views_News_List : Nop.Web.Framework.Mvc.Razor.NopRazorPage<NewsItemListModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
  
    Layout = "_ColumnsTwo";

    //title
    Html.AddTitleParts(T("PageTitle.NewsArchive").Text);
    //page class
    Html.AppendPageCssClassParts("html-news-list-page");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"page news-list-page\">\r\n    <div class=\"page-title\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 286, "\"", 363, 1);
#nullable restore
#line 12 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
WriteAttributeValue("", 293, Url.RouteUrl("NewsRSS", new { languageId = Model.WorkingLanguageId }), 293, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"link-rss\"");
            BeginWriteAttribute("title", " title=\"", 381, "\"", 408, 1);
#nullable restore
#line 12 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
WriteAttributeValue("", 389, T("News.RSS.Hint"), 389, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
                                                                                                                                 Write(T("News.RSS"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <h1>");
#nullable restore
#line 13 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
       Write(T("News"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"page-body\">\r\n        ");
#nullable restore
#line 16 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
   Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.NewsListPageBeforeItems }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"news-items\">\r\n");
#nullable restore
#line 18 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
             foreach (var item in Model.NewsItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"news-item\">\r\n                    <div class=\"news-head\">\r\n                        <a class=\"news-title\"");
            BeginWriteAttribute("href", " href=\"", 844, "\"", 906, 1);
#nullable restore
#line 22 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
WriteAttributeValue("", 851, Url.RouteUrl("NewsItem", new { SeName = item.SeName }), 851, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
                                                                                                        Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <span class=\"news-date\">-");
#nullable restore
#line 23 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
                                            Write(item.CreatedOn.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"news-body\">\r\n                        ");
#nullable restore
#line 26 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
                   Write(Html.Raw(item.Short));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"buttons\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1229, "\"", 1291, 1);
#nullable restore
#line 29 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
WriteAttributeValue("", 1236, Url.RouteUrl("NewsItem", new { SeName = item.SeName }), 1236, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"read-more\">");
#nullable restore
#line 29 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
                                                                                                       Write(T("News.MoreInfo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </div>\r\n                    ");
#nullable restore
#line 31 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
               Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.NewsListPageInsideItem, additionalData = item }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 33 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 35 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
          
            var pager = Html.Pager(Model.PagingFilteringContext).QueryParam("pagenumber");
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
         if (!pager.IsEmpty())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"pager\">\r\n                ");
#nullable restore
#line 41 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
           Write(pager);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 43 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
#nullable restore
#line 44 "D:\Thuong_Mai_Dien_Tu\Presentation\Nop.Web\Views\News\List.cshtml"
   Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.NewsListPageAfterItems }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsItemListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
