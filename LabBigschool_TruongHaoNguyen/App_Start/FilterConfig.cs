using System.Web;
using System.Web.Mvc;

namespace LabBigschool_TruongHaoNguyen
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
