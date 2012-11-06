using System.Web;
using System.Web.Mvc;

namespace Dev10_Net40_Mvc4_WebAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}