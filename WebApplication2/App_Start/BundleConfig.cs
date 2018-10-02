using System.Web;
using System.Web.Optimization;

namespace WebApplication2
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/login/css").Include(
                     "~/AdminLTE-master/bower_components/bootstrap/dist/css/bootstrap.min.css",
                     "~/AdminLTE-master/dist/css/AdminLTE.min.css",
                     "~/AdminLTE-master/plugins/iCheck/square/blue.css",
                     "~/cloudflare/font-awesome.min.css",
                     "~/cloudflare/ionicons.min.css"));

            bundles.Add(new ScriptBundle("~/login/js").Include(
                     "~/AdminLTE-master/bower_components/jquery/dist/jquery.min.js",
                     "~/AdminLTE-master/bower_components/bootstrap/dist/js/bootstrap.min.js",
                     "~/AdminLTE-master/plugins/iCheck/icheck.min.js"));
        }
    }
}
