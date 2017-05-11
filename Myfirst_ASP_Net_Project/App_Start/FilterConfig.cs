using System.Web;
using System.Web.Mvc;

namespace Myfirst_ASP_Net_Project
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
