﻿using System.Web;
using System.Web.Mvc;

namespace Task_2308
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new MyException());
        }
    }
}
