using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace K_POP.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Main Style
            bundles.Add(new StyleBundle("~/bundles/main/css").Include(
                "~/Content/freelancer.min.css", new CssRewriteUrlTransform()));

            //BootStrap Style
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));

            //Font-Awesome Style
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include(
                "~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));

            //Magnific-Popup
            bundles.Add(new StyleBundle("~/bundles/magnific-popup/css").Include(
                "~/Content/magnific-popup.css", new CssRewriteUrlTransform()));

            //Bootstrap 
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                "~/Scripts/bootstrap.min.js"));

            //jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
                "~/Scripts/jquery-3.3.1.min.js"));

            //jQuery-Easing
            bundles.Add(new ScriptBundle("~/bundles/jquery-easing/js").Include(
                "~/Scripts/jquery.easing.1.3.js"));

            //Magnific-Popup
            bundles.Add(new ScriptBundle("~/bundles/magnific-popup/js").Include(
                "~/Scripts/jquery.magnific-popup.min.js"));

            //Main JS
            bundles.Add(new ScriptBundle("~/bundles/main/js").Include(
                "~/Scripts/freelancer.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqValidation/js").Include(
                "~/Scripts/jqBootstrapValidation.min.js"));
        }
    }
}