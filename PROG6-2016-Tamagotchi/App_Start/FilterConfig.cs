using System.Web;
using System.Web.Mvc;

namespace PROG6_2016_Tamagotchi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
