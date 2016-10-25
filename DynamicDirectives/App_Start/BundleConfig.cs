using System.Web;
using System.Web.Optimization;

namespace DynamicDirectives
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/library").Include(
                        "~/Scripts/jquery-1.10.2.min.js",
                        "~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/application").Include(
                        "~/Scripts/Application/Modules/application.js",
                        "~/Scripts/Application/Controllers/clientCtrl.js",
                        "~/Scripts/Application/Services/clientService.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
