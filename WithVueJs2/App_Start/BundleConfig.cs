using System.Web;
using System.Web.Optimization;

namespace WithVueJs2
{
  public class BundleConfig
  {
    // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new StyleBundle("~/bundles/appStyle").Include(
                "~/Scripts/app/dist/css/*.css"
                ));

      bundles.Add(new ScriptBundle("~/bundles/appJs").Include(
                "~/Scripts/app/dist/js/*.js"
                ));
    }
  }
}
