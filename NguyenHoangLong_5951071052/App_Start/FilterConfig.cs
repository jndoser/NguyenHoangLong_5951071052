using System.Web;
using System.Web.Mvc;

namespace NguyenHoangLong_5951071052
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
