using System.Web;
using System.Web.Optimization;

namespace Policy.Web
{
    public class BundleConfig
    {
        // 有关 Bundling 的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;
            #region "使用twitter出品的Bootstrap框架加载的css和js"
            bundles.Add(new StyleBundle("~/bootstrap/css/css").Include("~/bootstrap/css/bootstrap-responsive.css",
                "~/bootstrap/css/bootstrap.css",
                "~/bootstrap/css/datetimepicker.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/bootstrap/jquery/jquery-1.7.1.js", "~/bootstrap/jquery/jquery.widget.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jslogic").IncludeDirectory("~/bootstrap/jslogic/", "*.js"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include("~/bootstrap/js/bootstrap.js",
                //"~/bootstrap/js/bootstrap-datetimepicker.js",
                //"~/bootstrap/js/dateFormat.js",
                "~/bootstrap/js/respond.js"));
            #endregion

        }
    }
}