﻿using System.Web;
using System.Web.Mvc;

namespace Taller1_DSE_MM160953
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
