using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
namespace WebApplication2
{
    public class BundelConfig
    {
        public static void RegisterBundles(BundleCollection bundles) {

            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Content/css/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Content/css/mdb.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include("~/img/mdb-favicon.ico", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/style/css").Include("~/Content/index.css", new CssRewriteUrlTransform()));






            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include("~/Scripts/js/mdb.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/slick/js").Include("~/Scripts/js/slick.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/script/js").Include("~/Scripts/js/script.js"));
        }
    }
}